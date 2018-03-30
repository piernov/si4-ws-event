using EventsClient.IncrServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsClient
{
    class IncrServiceCallbackSink : IIncrServiceCallback
    {
        public void Updated(int counter)
        {
            Console.WriteLine("counter: " + counter);
        }
    }
}
