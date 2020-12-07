using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResource.ApplicationCore.Entities
{
    public class Role
    {
        public int RoleId { set; get; }
        public string RoleName { set; get; }
        public bool Status { set; get; }

        public virtual ICollection<Employee> Employees { set; get; }
        public virtual ICollection<BlogRole> BlogRoles { set; get; }
    }
}
