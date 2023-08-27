using NUnit.Framework;
using Skender.Stock.Indicators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIndicators.tests
{
    internal class TestGOOGL
    {
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void TestAmountIsEnough()
        {
            using (DBConnection conn = new DBConnection())
            {
                var GOOGLLength = conn.GOOGL.ToArray().Length;
                Assert.Greater(GOOGLLength, 10, "Not enough GOOGL stocks to calculate BOP!");
            }
        }
        [Test]
        public void TestExistingOnSpecificDate()
        {
            using (DBConnection conn = new DBConnection())
            {
                var GOOGLStock = conn.GOOGL.FirstOrDefault(x => x.Date == new DateTime(2010, 11, 10).ToUniversalTime());
                Assert.AreNotEqual(GOOGLStock, null, "One or few rows of GOOGL's stock is missing");

            }
        }
        [Test]
        public void TestStockIndicatorsDema()
        {
            using (DBConnection conn = new DBConnection())
            {
                var GOOGLStock = conn.GOOGL.Take(1).ToList().GetDema(1);
                Assert.AreEqual(GOOGLStock, 50.220219, "Expected and received DEMA values ​​of GOOGL's stock are different");

            }
        }
    }
}
