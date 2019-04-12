using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using LearnXhosa.Implementation.Entities;

namespace LearnXhosa.Implementation.Mapping
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("User");
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            Map(x => x.Email).Column("email");
            Map(x => x.Password).Column("password");
            Map(x => x.Name).Column("name");
            Map(x => x.Surname).Column("surname");
            Map(x => x.ContactNumber).Column("contact_number");
            Map(x => x.UserType).Column("user_type").CustomType<UserType>();
            Map(x => x.CreatedAt).Column("created_at");
            Map(x => x.ModifiedAt).Column("modified_at");
            HasMany(x => x.Phrases).Cascade.AllDeleteOrphan().Fetch.Join().Inverse().KeyColumn("added_by");
        }
    }
}
