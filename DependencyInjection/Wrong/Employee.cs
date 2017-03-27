using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Wrong
{
    public class Employee
    {
        public void DoDevelop()
        {
            Console.WriteLine("I am coding");
        }
    }

    /// <summary>
    /// EmployeeOutputer depend on concretion class Employee
    /// It is not able to extend for example Print another kind of employee like Manager.
    /// </summary>
    public class EmployeeOutputer
    {
        public Employee employee { get; set; }
        public EmployeeOutputer(Employee employee)
        {
            this.employee = employee;
        }

        public void Print()
        {
            employee.DoDevelop();
        }
    }
}
