using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    interface IProductFirstStock : IProductSeconStock
    {
        public string NameFirstStock { get; set; }
    }
}
