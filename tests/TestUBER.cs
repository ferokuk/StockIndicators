using NUnit.Framework;
using Skender.Stock.Indicators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIndicators.tests
{
    internal class TestUBER
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
                var UBERLength = conn.UBER.ToArray().Length;
                Assert.Greater(UBERLength, 10, "Not enough UBER stocks to calculate BOP!");
            }
        }
        [Test]
        public void TestExistingOnSpecificDate()
        {
            using (DBConnection conn = new DBConnection())
            {
                var UBERStock = conn.UBER.FirstOrDefault(x => x.Date == new DateTime(2020, 6, 1).ToUniversalTime());
                Assert.AreNotEqual(UBERStock, null, "One or few rows of UBER's stock is missing");

            }
        }
        [Test]
        public void TestStockIndicatorsDema()
        {
            using (DBConnection conn = new DBConnection())
            {
                var UBERStock = conn.UBER.Take(1).ToList().GetDema(1);
                Assert.AreEqual(UBERStock, 41.57, "Expected and received DEMA values ​​of UBER's stock are different");

            }
        }
    }
}
