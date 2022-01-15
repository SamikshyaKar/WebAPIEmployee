using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIEmployeeFull.Models
{
    public class Employee
    {

        [Key]
        public int EmpID { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        public int EmpSalary { get; set; }

        public string EmpCity { get; set; }

        public DateTime EmpDateofBirth { get; set; }

        public Gender EmpGender { get; set; }

        public Department EmpdepartmentID { get; set; }
        public int DepartmentId { get; set; }
        public string PhotoPath { get; set; }

        public string Email { get; set; }



    }

}
