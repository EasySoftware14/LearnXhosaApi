using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LearnXhosaApi.Models
{
    [DataContract]
    public class User
    {
        [DataMember]
        public string Email { get; set; }
      
    }
}