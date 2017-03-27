using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The Liskov Substitution Principle says that the object of a derived class should be able to replace an object of the base class without bringing any errors in the system or modifying the behavior of the base class.
/// </summary>
namespace LiskovSubstitutionPrinciple.Right
{
    public interface IWorker
    {
        void DoSomeThing();
    }
    public class Employee:IWorker
    {
        public void  DoSomeThing()
        {
            Console.WriteLine("I AM CODING");
        }
    }

    public class ProjectManager : IWorker
    {
        public void DoSomeThing()
        {
            Console.WriteLine("I AM DO NOTHING");
        }
    }

    public class Outputer
    {
        public IWorker worker { get; set; }

        public Outputer( Employee worker)
        {
            this.worker = worker;
        }

        public void Print()
        {
            worker.DoSomeThing();
        }
    }
}
