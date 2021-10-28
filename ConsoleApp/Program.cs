using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.NameMainStock = "0.1";
            product.NameFirstStock = "0.2";
            product.NameSeconStock = "0.3";

            IProductFirstStock productFirstStock = new Product();
            productFirstStock.NameFirstStock = "1.1";
            productFirstStock.NameSeconStock = "1.2";

            
            IProductSeconStock productSeconStock = new Product();
            productSeconStock.NameSeconStock = "2.1";
            //IProductFirstStock productFirstStock2 = new IProductFirstStock(); can not create instance of abstract

            Product addMainProduct()
            {
                var sum = new Product { NameMainStock = "" , NameFirstStock = "" , NameSeconStock = ""};
                return sum;
            }
            IProductFirstStock AddProductFirstStock()
            {
                var sum = new Product(){ NameMainStock = "AddProductFirstStock-NameMainStock", NameFirstStock = "AddProductFirstStock-NameFirstStock", NameSeconStock = "AddProductFirstStock-NameSeconStock" };
                return sum;
            }

            IProductSeconStock AddProductSecondStock()
            {
                var sum = new Product() { NameMainStock = "AddProductFirstStock-NameMainStock", NameFirstStock = "AddProductFirstStock-NameFirstStock", NameSeconStock = "AddProductFirstStock-NameSeconStock" };
                return sum;
            }

            IProductSeconStock displayReturn = AddProductSecondStock();
            Console.WriteLine(displayReturn.NameSeconStock);
            Console.WriteLine(displayReturn.GetType());
            ////////////////interface//////////////
            Console.WriteLine();
            Person per = new Person();

            foreach (Job job in per)
            {
                Console.WriteLine($"job {job.Money}");
            }

            List<Person> people = new List<Person>();
            List<Job> jobs = new List<Job>();

            Console.WriteLine();

            Func<string, string> name = var1 => $"some string+ {var1}";
            string myFullString = name("thud");
            Console.WriteLine(myFullString);

            Console.WriteLine();

            //var inc = GetAFunc();
            //int num = inc(1);
            //Console.WriteLine(num);
            //num = inc(1);
            //Console.WriteLine(num);
            //Console.WriteLine(inc(1));
            //Console.WriteLine(inc(1));


        }


        public static Func<int, int> GetAFunc()
        {
            var myVar = 1;
            Func<int, int> inc = delegate (int var1)
            {
                myVar = myVar + 1;
                return var1 + myVar;
            };
            return inc;
        }
    }
}
