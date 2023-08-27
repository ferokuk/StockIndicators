using Skender.Stock.Indicators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIndicators
{
    public class MSFT : IQuote
    {
        [Key]
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public decimal AdjClose { get; set; }
        public decimal Volume { get; set; }
    }
    public class TSLA : IQuote
    {
        [Key]
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public decimal AdjClose { get; set; }
        public decimal Volume { get; set; }
    }

    public class AAPL : IQuote
    {
        [Key]
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public decimal AdjClose { get; set; }
        public decimal Volume { get; set; }
    }

    public class UBER : IQuote
    {
        [Key]
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public decimal AdjClose { get; set; }
        public decimal Volume { get; set; }
    }

    public class GOOGL : IQuote
    {
        [Key]
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public decimal AdjClose { get; set; }
        public decimal Volume { get; set; }
    }
}
