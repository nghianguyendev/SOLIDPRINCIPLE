using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class Developer : IEmployee
    {
        public void DoSomeThing()
        {
            Console.WriteLine("I AM A DEVELOPER");
        }
    }
}
