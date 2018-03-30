using EventsClient.IncrServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsClient
{
    class Program
    {
        IncrServiceClient objClient;

        Program()
        {
            IncrServiceCallbackSink objsink = new IncrServiceCallbackSink();
            InstanceContext iCntxt = new InstanceContext(objsink);
            objClient = new IncrServiceClient(iCntxt);
        }

        void RandomIncr()
        {
            Random rand = new Random();
            while (true)
            {
                //objClient.Incr();
                Thread.Sleep(rand.Next() % 10000); // 10 secs max
            }
        }

        void RandomDecr()
        {
            Random rand = new Random();
            while (true)
            {
                objClient.Decr();
                Thread.Sleep(1); // 10 secs max
                Console.WriteLine("miaou");

            }
        }

        void Run()
        {
            objClient.SubscribeUpdatedEvent();
            objClient.Decr();

            Thread threadIncr = new Thread(RandomIncr);
            Thread threadDecr = new Thread(RandomDecr);
            threadIncr.Start();
            threadDecr.Start();

            Console.ReadLine();

            threadIncr.Abort();
            threadDecr.Abort();
        }

        static void Main(string[] args)
        {
            (new Program()).Run();
        }
    }
}
