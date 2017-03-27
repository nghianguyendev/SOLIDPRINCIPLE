using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(15000000);
            EmployeeOutput output = new EmployeeOutput(employee);
            output.PrintSalaryAsHtml();
            Console.ReadLine();
        }
    }
}
