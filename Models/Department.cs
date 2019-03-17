using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLoveHomework.Models
{
    public class Department
    {
        [Key]
        [ForeignKey("DepartmentID")]
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        public Employee Employee { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}
