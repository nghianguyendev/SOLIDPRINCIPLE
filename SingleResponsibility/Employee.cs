using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// A class should have one and only one reason to change, meaning that a class should have only one job.
/// </summary>
namespace solid
{
    /// <summary>
    /// Employee and EmployeeOutput should be saparated 
    /// When we want more output then just modify EmployeeOutout class.
    /// </summary>

    public class Employee
    {
        public int Salary { get; set; }
        public Employee(int salary)
        {
            Salary = salary;
        }

        public int GetSalary()
        {
            return Salary;
        }
    }

    public class EmployeeOutput
    {
        public Employee employee { get; set; }
        public EmployeeOutput(Employee employee)
        {
            this.employee = employee;
        }
        public void PrintSalary()
        {
            Console.WriteLine("Salary is " + employee.Salary);
        }

        public void PrintSalaryAsHtml()
        {
            Console.WriteLine("<b>Salary is " + employee.Salary + "</b>");
        }

    }
}
