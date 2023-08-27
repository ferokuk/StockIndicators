using NUnit.Framework;
using Skender.Stock.Indicators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIndicators.tests
{
    internal class TestTSLA
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
                var TSLALength = conn.TSLA.ToArray().Length;
                Assert.Greater(TSLALength, 10, "Not enough TSLA stocks to calculate BOP!");
            }
        }
        [Test]
        public void TestExistingOnSpecificDate()
        {
            using (DBConnection conn = new DBConnection())
            {
                var TSLAStock = conn.TSLA.FirstOrDefault(x => x.Date == DateTime.Parse("01.09.2020").ToUniversalTime());
                Assert.AreNotEqual(TSLAStock, null, "One or few rows of TSLA's stock is missing");
                
            }
        }
        [Test]
        public void TestStockIndicatorsDema()
        {
            using (DBConnection conn = new DBConnection())
            {
                var TSLAStock = conn.TSLA.Take(1).ToList().GetDema(1);
                Assert.AreEqual(TSLAStock, 4.778, "Expected and received DEMA values ​​of TSLA's stock are different");

            }
        }
    }
}
