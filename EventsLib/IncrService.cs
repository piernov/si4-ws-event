//  Listing of CalcService.cs

using System;
using System.Text;
using System.ServiceModel;

namespace EventsLib
{
    public class IncrService : IIncrService
    {
        static int counter = 0;
        static Action<int> m_Event1 = delegate { };

        public void SubscribeUpdatedEvent()
        {
            IIncrServiceEvents subscriber =
            OperationContext.Current.GetCallbackChannel<IIncrServiceEvents>();
            m_Event1 += subscriber.Updated;
        }

        public void Incr()
        {
            counter++;
            m_Event1(counter);
        }

        public void Decr()
        {
            counter--;
            m_Event1(counter);
        }
    }
}