using EventsClient.CalcServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsClient
{
    class CalcServiceCallbackSink : ICalcServiceCallback
    {
        public void Calculated(int nOp, double dblNum1, double dblNum2, double dblResult)
        {
            Console.WriteLine("nOp: " + nOp + " dblNum1: " + dblNum1 + " dblNum2: " + dblNum2 + " dblResult: " + dblResult);
        }

        public void CalculationFinished()
        {
            Console.WriteLine("CalculationFinished");
        }
    }
}
