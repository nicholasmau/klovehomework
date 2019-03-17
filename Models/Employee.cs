using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLoveHomework.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime StartDate { get; set; }
        public int DepartmentID { get; set; }

        //public ICollection<Department> Departments { get; set; }
        public virtual Department Departments { get; set; }
    }
}