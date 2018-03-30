using System;
using System.Text;
using System.ServiceModel;
namespace EventsLib
{
    public interface IIncrServiceEvents
    {
        [OperationContract(IsOneWay = true)]
        void Updated(int counter);
    }
}