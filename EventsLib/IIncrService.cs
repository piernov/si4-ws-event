//  Listing of ICalcService.cs
using System;
using System.Text;
using System.ServiceModel;
namespace EventsLib
{
    [ServiceContract(CallbackContract = typeof(IIncrServiceEvents))]
    public interface IIncrService
    {
        [OperationContract]
        void Incr();

        [OperationContract]
        void Decr();

        [OperationContract]
        void SubscribeUpdatedEvent();
    }
}