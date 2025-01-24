using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv1
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  int Age { get; set; }
        public double Salary { get; set; }


       
        public static bool operator ==(Employee left , Employee right)
        {
            return left.Id == right.Id && left.Name == right.Name && left.Age == right.Age && left.Salary == right.Salary;
        }
        public static bool operator !=(Employee left, Employee right)
        {
            return left.Id != right.Id && left.Name != right.Name && left.Age != right.Age && left.Salary != right.Salary;
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Age}, {Salary}";
        }
    }
}
