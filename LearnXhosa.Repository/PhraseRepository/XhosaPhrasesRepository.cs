using System;
using System.Collections.Generic;
using LearnXhosa.Implementation.Entities;
using LearnXhosa.Repository.InterfaceContracts;
using NHibernate;

namespace LearnXhosa.Repository.PhraseRepository
{
    public class XhosaPhrasesRepository : Repository<Phrase>, IXhosaPhrasesRepository
    {
        private readonly NhibernateHelper _nhibernateHelper;
        public ISession Session { get; set; }

        public XhosaPhrasesRepository()
        {
            _nhibernateHelper = new NhibernateHelper();
            Session = _nhibernateHelper.OpenSession();
        }
        public List<Phrase> GetPhraseByLevel(PhraseLevel level)
        {
            throw new NotImplementedException();
        }
    }
}
