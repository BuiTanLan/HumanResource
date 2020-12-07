using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResource.ApplicationCore.Entities
{
    public class Tag
    {
        public int TagId { set; get; }
        public string TagName { set; get; }
        public bool Status { set; get; }
        public virtual ICollection<BlogTag> BlogTags { set; get; }
    }
}
