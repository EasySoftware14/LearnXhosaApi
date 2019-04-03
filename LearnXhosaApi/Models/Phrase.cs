using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Learn = LearnXhosa.Implementation.Entities;

namespace LearnXhosaApi.Models
{
    [DataContract]
    public class Phrase
    {
        [DataMember]
        public string XhosaPhrase { get; set; }

        [DataMember]
        public DateTime DateAdded { get; set; }

        [DataMember]
        public IList<string> Translation { get; set; }

        public Phrase(Learn.Phrase phrase)
        {
            XhosaPhrase = phrase.XhosaPhrase;
            DateAdded = phrase.CreatedAt;
            Translation = phrase.Translation.Select(x => x.EnglishTranslation).ToList();
        }

    }
}