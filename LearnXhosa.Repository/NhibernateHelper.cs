using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using LearnXhosa.Implementation.Mapping;
using NHibernate;

namespace LearnXhosa.Repository
{
    public class NhibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    InitializeSessionFactory();
                }

                return _sessionFactory;
            }
        }

        private static void InitializeSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                    .ConnectionString(c => c.FromAppSetting("connection_string"))
                    .ShowSql())
                .Mappings(m => m.FluentMappings
                    .AddFromAssemblyOf<UserMap>())
                .BuildSessionFactory();
        }

        public ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
