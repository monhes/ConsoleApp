using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp
{
    delegate int Calculator(int n);
    class Person : IEnumerable<Job>
    {
        public List<Address> addresses;

        public List<Job> jobs;
        public Person()
        {
            System.Console.WriteLine("job class in person class");
            jobs = new List<Job>(){
            new Job { Money = 200 ,Level = "1"},
            new Job { Money = 2200 ,Level ="7"},
            new Job { Money = 20450 ,Level = "8"},
            new Job { Money = 757800 ,Level ="5" },
            new Job { Money = 80680 ,Level ="4"},
            };
        }
        public string Name { get; set; }
        public string Email { get; set; }

        public IEnumerator<Job> GetEnumerator()
        {
            return jobs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
        public static int Add(int n)
        {
            return n + n;
        }
        public void Cal()
        {
            Calculator c = new Calculator(Add);
            c(20);
            System.Console.WriteLine(c(20));
        }
    }
}
