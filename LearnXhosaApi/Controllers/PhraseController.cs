using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using LearnXhosa.Implementation.Entities;
using LearnXhosa.Services.Contracts;
using LearnXhosa.Services.Services;
using LearnXhosaApi.Models;
using Newtonsoft.Json;
using Phrase = LearnXhosaApi.Models.Phrase;

namespace LearnXhosaApi.Controllers
{
    [RoutePrefix("api/phrase")]
    public class PhraseController : ApiController
    {
        private readonly IXhosaPhraseService _xhosaPhraseService;
        private readonly IEnglishPhraseService _englishPhraseService;
        private readonly IUserService _userService;

        public PhraseController()
        {
            _xhosaPhraseService = new XhosaPhraseService();
            _englishPhraseService = new EnglishPhraseService();
            _userService = new UserService();
        }

        [Route("GetPhrases")]
        [HttpGet]
        public string GetPhrases()
        {
            var xhosaPhrases = _xhosaPhraseService.GetAll().ToList();
            var phrases = new List<Phrase>();
            var buildPhrases = string.Empty;

            foreach (var xhosaPhrase in xhosaPhrases)
            {
                var phrase = new Phrase(xhosaPhrase);
                phrases.Add(phrase);
            }

            buildPhrases = JsonConvert.SerializeObject(phrases);

            return buildPhrases;
        }
        [Route("GetPhrase")]
        [HttpGet]
        public string GetPhrase(long id)
        {
            var phrase = _xhosaPhraseService.Get(id);
            var buildPhrases = string.Empty;

            if (phrase != null)
                buildPhrases = JsonConvert.SerializeObject(phrase);

            return buildPhrases;
        }
        [Route("EditPhrase")]
        [HttpPost]
        public IHttpActionResult EditPhrase([FromBody]PhraseModel model)
        {
            var phrase = _xhosaPhraseService.Get(model.Id);
            _xhosaPhraseService.Update(phrase);

            return Ok();
        }
        [Route("deletePhrase")]
        [HttpPost]
        public IHttpActionResult DeletePhrase([FromBody]PhraseModel model)
        {
            var phrase = _xhosaPhraseService.Get(model.Id);
            _xhosaPhraseService.Delete(phrase);

            return Ok();
        }
        [Route("SavePhrase")]
        [HttpPost]
        public IHttpActionResult SavePhrase([FromBody]PhraseModel model)
        {
            var todaysDate = DateTime.Now;
            var phase = GetPhaseLevel(model.PhraseLevel);

            var phrase = new LearnXhosa.Implementation.Entities.Phrase
            {
                CreatedAt = todaysDate,
                ModifiedAt = todaysDate,
                XhosaPhrase = model.XhosaPhrase,
                PhraseLevel = phase,
                AddedBy = model.User
            };

            var id = _xhosaPhraseService.Save(phrase);

            var translation = new PhraseTranslation
            {
                PhraseToTranslate = phrase,
                CreatedAt = todaysDate,
                ModifiedAt = todaysDate,
                EnglishTranslation = model.Translation.EnglishTranslation,
                TranslatedBy = model.User
            };

            _englishPhraseService.Save(translation);
            phrase.Translation = new List<PhraseTranslation> { new PhraseTranslation(translation) };

            _xhosaPhraseService.Update(phrase);

            return Ok();
        }

        private PhraseLevel GetPhaseLevel(int phaseLevel)
        {
            var test = Enum.GetName(typeof(PhraseLevel), phaseLevel);

            return PhraseLevel.Advance;
        }
    }
}
