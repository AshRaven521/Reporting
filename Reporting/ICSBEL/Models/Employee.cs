using System;

namespace ICSBEL.Models
{
    public class Employee
    {
        public string Name { get; }
        public string Surname { get; }
        public string JobTitle { get; }
        public DateTime BirthDate { get; }
        public double Salary { get; }
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
