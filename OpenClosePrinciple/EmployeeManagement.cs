using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Objects or entities should be open for extension, but closed for modification.
/// </summary>
namespace OpenClosePrinciple
{
    /// <summary>
    /// PrintIntroduces will not change if we add more employee type for example Senior Developer,
    /// Just create new class and implement IEmployee.
    /// </summary>

    public class EmployeeManagement
    {
        List<IEmployee> Employees { get; set; }
        public EmployeeManagement(List<IEmployee> employees)
        {
            this.Employees = employees;
        }

        public void PrintIntroduces()
        {
            foreach (var employee in this.Employees)
            {
                employee.DoSomeThing();
            }
            Console.ReadLine();
        }
    }
}
