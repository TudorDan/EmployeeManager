using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Models
{
    class Employee
    {
        protected int salary;
        protected string profession;

        public Employee(int salary, string profession)
        {
            this.salary = salary;
            this.profession = profession;
        }

        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
