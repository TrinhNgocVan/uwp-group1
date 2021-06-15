using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinhNgocVan.Models
{
       public class Employee
        {
            public String name { get; set; }
            public string role { get; set; }
            public string birthYear { get; set; }
        }
        public class EmployeeData
        {
            
            public List<Employee> data { get; set; }
        }
    
}
