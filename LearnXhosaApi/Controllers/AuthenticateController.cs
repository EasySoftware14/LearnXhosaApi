using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LearnXhosa.Implementation.Entities;
using LearnXhosa.Services.Contracts;
using LearnXhosa.Services.Services;
using Newtonsoft.Json;

namespace LearnXhosaApi.Controllers
{
    [RoutePrefix("api/authenticate")]
    public class AuthenticateController : ApiController
    {
        private readonly IUserService _userService;

        public AuthenticateController()
        {
            _userService = new UserService();
        }

        [Route("authenticateUser/{email}/{password}")]
        [HttpGet]
        public string AuthenticateUser(string email, string password)
        {
            var stringed = string.Empty;

            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                var user = _userService.GetUserByEmail(email);

                if (user != null && user.Password == password)
                {
                    stringed = JsonConvert.SerializeObject(user);
                }
                else
                {
                    stringed = "Authorization failed";
                }
                   
            }

            return stringed;
        }
    }
}
