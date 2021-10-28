using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Product :Stock, IProductFirstStock
    {
        public string NameFirstStock { get; set; }
        public string NameSeconStock { get; set; }
    }
}
