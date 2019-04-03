using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnXhosa.Implementation.Entities
{
    public class Entity
    {
        public virtual long Id { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        public virtual DateTime ModifiedAt { get; set; }
    }
}
