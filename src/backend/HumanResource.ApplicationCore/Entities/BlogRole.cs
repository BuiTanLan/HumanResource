using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResource.ApplicationCore.Entities
{
    public class BlogRole
    {
        public int RoleId { set; get; }
        public int BlogId { set; get; }
        public virtual Blog Blog { set; get; }
        public virtual Role Role { set; get; }
    }
}
