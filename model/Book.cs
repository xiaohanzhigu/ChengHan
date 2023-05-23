using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChengHan.model
{
    internal class Book
    {
        public string code { get; set; }
        public string bookName { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public string pubDate { get; set; }
        public double price { get; set; }
        public string ISBN { get; set; }
    }
}
