using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Learn = LearnXhosa.Implementation.Entities;

namespace LearnXhosaApi.Models
{
    public class Phrase
    {
        public long Id { get; set; }    
        public string XhosaPhrase { get; set; }

        public DateTime DateAdded { get; set; }

        public IList<string> Translation { get; set; }

        public Phrase()
        {
            
        }
        public Phrase(Learn.Phrase phrase)
        {
            Id = phrase.Id;
            XhosaPhrase = phrase.XhosaPhrase;
            DateAdded = phrase.CreatedAt;
            Translation = phrase.Translation.Select(x => x.EnglishTranslation).ToList();
        }

    }
}