using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Entities must depend on abstractions not on concretions. 
/// It states that the high level module must not depend on the low level module, 
/// but they should depend on abstractions.
/// </summary>
namespace DependencyInjection.Right
{
    public interface IEmployee
    {
        void DoSomething();
    }
    public class Developer: IEmployee
    {
        public void DoSomething()
        {
            Console.WriteLine("I am coding");
        }
    }
    public class Manager : IEmployee
    {
        public void DoSomething()
        {
            Console.WriteLine("I am managing");
        }
    }
    /// <summary>
    /// EmployeeOutputer just depend abstration IEmployee
    /// It is easy to extend for example Print another kind of employee like Manager.
    /// </summary>
    public class EmployeeOutputer
    {
        public IEmployee employee { get; set; }
        public EmployeeOutputer(IEmployee employee)
        {
            this.employee = employee;
        }

        public void Print()
        {
            employee.DoSomething();
        }
    }
}
