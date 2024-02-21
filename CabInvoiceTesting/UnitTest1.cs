using CabInvoice;

namespace CabInvoiceTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           double costPerKM = 10;
            double costPerMin = 10;
            double MinFare = 5;

            double distance = 2.0;
            int time = 5;
            double totval = (distance * costPerKM) + (time * costPerMin);
           
            CabInvoiceMain ob = new CabInvoiceMain();
             double expected = ob.TotalFare(distance, time); 
            Assert.AreEqual(expected, totval);
        }
    }
}