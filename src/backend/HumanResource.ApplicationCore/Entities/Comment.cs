using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResource.ApplicationCore.Entities
{
    public class Comment
    {
        public int CommentId { set; get; }
        public string Content { set; get; }
        public DateTime DateComment { set; get; }
        public int? EmployeeId { set; get; } = null;
        public int? BlogId { set; get; } 
        public bool Status { set; get; }
        public virtual Employee Employee { set; get; }
        public virtual ICollection<ChildComment> ChildComments { set; get; }
    }
}
