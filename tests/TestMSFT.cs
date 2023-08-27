using NUnit.Framework;
using Skender.Stock.Indicators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIndicators.tests
{
    internal class TestMSFT
    {
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void TestMoreThanZero()
        {
            using (DBConnection conn = new DBConnection())
            {
                var MSFTLength = conn.MSFT.ToArray().Length;
                Assert.Greater(MSFTLength, 10, "Not enough MSFT stocks to calculate BOP!");
            }
        }
        [Test]
        public void TestExistingOnSpecificDate()
        {
            using (DBConnection conn = new DBConnection())
            {
                var MSFTStock = conn.MSFT.FirstOrDefault(x => x.Date == new DateTime(2014, 1, 2).ToUniversalTime());
                Assert.AreNotEqual(MSFTStock, null, "One or many rows of MSFT's stock is missing");

            }
        }
        [Test]
        public void TestStockIndicatorsDema()
        {
            using (DBConnection conn = new DBConnection())
            {
                var MSFTStock = conn.MSFT.Take(1).ToList().GetDema(1);
                Assert.AreEqual(MSFTStock, 0.097222, "Expected and received DEMA values ​​of MSFT's stock are different");

            }
        }
    }
}
