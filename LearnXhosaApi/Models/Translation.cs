using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LearnXhosaApi.Models
{
    [DataContract]
    public class Translation
    {
        [DataMember]
        public string EnglishPhrase { get; set; }
        [DataMember]
        public Phrase XhosaPhrase { get; set; }
        [DataMember]
        public DateTime DateAdded { get; set; }
    }
}