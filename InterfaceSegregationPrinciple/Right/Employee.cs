using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// A client should never be forced to implement an interface that it doesn’t use or clients shouldn’t be forced to depend on methods they do not use.
/// </summary>
namespace InterfaceSegregationPrinciple.Right
{
    public interface IDeveloper
    {
        void DoDevelop();
    }

    public interface IManager
    {
        void DoManagement();
    }
    /// <summary>
    /// Developer do develop, Manager do management
    /// </summary>
    public class Developer : IDeveloper
    {
        public void DoDevelop()
        {
            throw new NotImplementedException();
        }
    }
    public class Manager : IManager
    {
        public void DoManagement()
        {
            throw new NotImplementedException();
        }
    }
}
