using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResource.ApplicationCore.Entities
{
    public class FormVersion
    {
        public int FormVersionId { get; set; }
        public string VersionName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool Status { get; set; }
        public int FormId { get; set; }
    }
}
