using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string GetNamePropertyName()
        {
            return "Name";
        }
    }
}
