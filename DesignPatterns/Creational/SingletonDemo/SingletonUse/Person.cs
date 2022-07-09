using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonUse
{
    public sealed class Person
    {
        private static int count = 0;
        private static Person? instance = null;
        public static Person GetInstance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Person();
                }
                return instance;
            }
        }
        private Person()
        {
            count++;
            Console.WriteLine(@"No of times object created: {0}", count);
        }

        public void PrintPerson(string message)
        {
            Console.WriteLine(@"Person created with message {0}", message);
        }
    }
}
