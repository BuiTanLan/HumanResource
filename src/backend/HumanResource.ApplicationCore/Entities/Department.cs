using System.Collections.Generic;

namespace HumanResource.ApplicationCore.Entities
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public ICollection<Employee> Employees { get; set; }
        
    }
}