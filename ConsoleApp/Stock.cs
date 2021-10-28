using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Stock : IStockFirst
    {
        public string NameMainStock { get; set; }
        string IStockFirst.NameFirstStock { get; set; }

        public void AddFirstStock()
        {
            Console.WriteLine("First Stock Added");
        }
    }
}
