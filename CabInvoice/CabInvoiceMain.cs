using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoice
{
    public class CabInvoiceMain
    {
        static double costPerKM = 10;
        static double costPerMin = 10;
        static double MinFare = 5;
        public double TotalFare(double distance, int time)
        {
            
            double totval = (distance * costPerKM) + (time * costPerMin);
            if(totval <5) {
                return MinFare;
            }
            else
            {
                return totval;

            }
        }
        public static void Main()
        {

        }

    }
}
