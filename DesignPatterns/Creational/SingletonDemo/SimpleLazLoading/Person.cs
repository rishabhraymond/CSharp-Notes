using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLazyLoading
{
    public sealed class Person
    {
        private int count = 0;
        private Person()
        {
            count++;
            Console.WriteLine("Person class Initialized");
        }

        private static readonly Lazy<Person> person = new Lazy<Person>(() => new Person());

        public static Person GetInstance
        {
            get
            {
                return person.Value;
            }
        }

        public void PrintPerson(string msg)
        {
            Console.WriteLine($"Count:{count}");
            Console.WriteLine(msg);
        }
    }
}
