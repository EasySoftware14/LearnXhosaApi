using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnXhosa.Implementation.Entities;
using LearnXhosa.Repository.InterfaceContracts;
using NHibernate;

namespace LearnXhosa.Repository.PhraseRepository
{
    public class EnglishPhrasesRepository : Repository<PhraseTranslation>, IEnglishPhraseRepository
    {
        private readonly NhibernateHelper _nhibernateHelper;
        public ISession Session { get; set; }

        public EnglishPhrasesRepository()
        {
            _nhibernateHelper = new NhibernateHelper();
            Session = _nhibernateHelper.OpenSession();
        }
    }
}
