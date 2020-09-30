using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Models
{
    class Person : Employee
    {
        private string name;
        private DateTime birthDate;
        private Gender gender;

        public Person(int salary, string profession, string name, DateTime birthDate, Gender gender) : base(salary, profession)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.gender = gender;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }
    }
}
