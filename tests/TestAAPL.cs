using NUnit.Framework;
using Skender.Stock.Indicators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIndicators.tests
{
    internal class TestAAPL
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
                var AAPLLength = conn.AAPL.ToArray().Length;
                Assert.Greater(AAPLLength, 10, "Not enough AAPL stocks to calculate BOP!");
            }
        }
        [Test]
        public void TestExistingOnSpecificDate()
        {
            using (DBConnection conn = new DBConnection())
            {
                var AAPLStock = conn.AAPL.FirstOrDefault(x => x.Date == new DateTime(2021, 5, 18).ToUniversalTime());
                Assert.AreNotEqual(AAPLStock, null, "One or many rows of AAPL's stock is missing");

            }
        }
        [Test]
        public void TestStockIndicatorsDema()
        {
            using (DBConnection conn = new DBConnection())
            {
                var AAPLStock = conn.AAPL.Take(1).ToList().GetDema(1);
                Assert.AreEqual(AAPLStock, 0.128348, "Expected and received DEMA values ​​of AAPL's stock are different");

            }
        }
    }
}
