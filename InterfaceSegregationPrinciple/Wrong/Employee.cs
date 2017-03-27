using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Wrong
{
    public interface IEmployee
    {
        void DoManagement();
        void DoDevelop();
    }

    /// <summary>
    /// Developer do not do management so implement DoManagement() is not necessary
    /// </summary>
    public class Developer : IEmployee
    {
        public void DoDevelop()
        {
            throw new NotImplementedException();
        }

        public void DoManagement()
        {
            throw new NotImplementedException();
        }
    }
}
