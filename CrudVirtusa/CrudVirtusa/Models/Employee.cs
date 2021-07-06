using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrudVirtusa.Models
{
    public class Employee
    {
         [Key]
         public int EmployeeId { get; set; }
         public string EmployeeName { get; set; }
         public double Salary { get; set; }
         public string EmployeeLName { get; set; }
         public int Age { get; set; }
    }
}