using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Wrong
{
    public class Employee
    {
        public virtual void  DoSomeThing()
        {
            Console.WriteLine("I AM CODING");
        }
    }

    public class ProjectManager : Employee
    {
        public override void DoSomeThing()
        {
            Console.WriteLine("I AM DO NOTHING");
        }
    }

    public class Outputer
    {
        public Employee employee { get; set; }

        public Outputer( Employee employee)
        {
            this.employee = employee;
        }

        public void Print()
        {
            employee.DoSomeThing();
        }
    }
}
