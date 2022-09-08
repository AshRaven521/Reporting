using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICSBEL.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string JobTitle { get; set; }
        public DateTime BirthDate { get; set; }
        public double Salary { get; set; }
        public Employee(string name, string surname, string job, DateTime dateBitrth, double salary)
        {
            Name = name;
            Surname = surname;
            JobTitle = job;
            BirthDate = dateBitrth;
            Salary = salary;
        }
    }
}
