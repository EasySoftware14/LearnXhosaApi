using System.Collections.Generic;

namespace LearnXhosa.Implementation.Entities
{
    public class User : Entity
    {
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public virtual string ContactNumber { get; set; }
        public virtual UserType UserType { get; set; }

    }
}
