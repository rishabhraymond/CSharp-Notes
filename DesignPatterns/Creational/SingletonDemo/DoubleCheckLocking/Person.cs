using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleCheckLocking
{
    public sealed class Person
    {
        private static int count = 0;
        private static Person? instance = null;
        private static readonly object obj = new(); //This will be used to lock the object
        
        public static Person GetInstance
        {
            get
            {
                if (instance == null) //This is done to avoid unecessary lock 
                {
                    lock (obj)
                    {
                        if (instance == null)
                        {
                            instance = new Person();
                        }
                    }
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
