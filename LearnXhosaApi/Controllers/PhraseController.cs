using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.Http;
using LearnXhosa.Services.Contracts;
using LearnXhosa.Services.Services;
using LearnXhosaApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LearnXhosaApi.Controllers
{
    [RoutePrefix("api/phrase")]
    public class PhraseController : ApiController
    {
        private readonly IXhosaPhraseService _xhosaPhraseService;

        public PhraseController()
        {
            _xhosaPhraseService = new XhosaPhraseService();
        }

        [Route("GetPhrases")]
        [HttpGet]
        public IEnumerable<Phrase> GetPhrases()
        {
            var xhosaPhrases = _xhosaPhraseService.GetAll().ToList();
            var phrases=  new List<Phrase>();

            foreach (var xhosaPhrase in xhosaPhrases)
            {
               var phrase = new Phrase(xhosaPhrase);
                phrases.Add(phrase);
            }

            return phrases;
        }
    }
}
