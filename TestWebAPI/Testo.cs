using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebAPI
{
    public class Testo
    {

        public string SourceSystem { get; set; }

        public string SourceOrderNumber { get; set; }

        public string TransactionId { get; set; }

        public string QuoteHeaderData { get; set; }

        public string ItemData { get; set; }
    }
}