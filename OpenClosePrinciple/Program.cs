using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManagement management = new EmployeeManagement(new List<IEmployee> {
                new Developer(),
                new ProjectManager()
            });

            management.PrintIntroduces();
        }
    }
}
