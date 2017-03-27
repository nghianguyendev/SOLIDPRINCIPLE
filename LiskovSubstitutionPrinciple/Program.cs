using LiskovSubstitutionPrinciple.Wrong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Wrong
            ///Employee but out put "i am do nothing", this is not corrected, must be "i am coding".
            ///ProjectManager is not able to substitute for Employee.
            Employee employee = new ProjectManager();
            Outputer outputer = new Outputer(employee);
            outputer.Print();

            ///Right
            ///Employee output "i am coding", this is corrected.
            Right.Employee rightEmployee = new Right.Employee();
            Right.Outputer rightOutputer = new Right.Outputer(rightEmployee);
            rightOutputer.Print();

            Console.Read();


        }
    }
}
