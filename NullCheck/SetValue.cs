using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullCheck
{
    public class SetValue
    {
        public SetValue(string val)
        {
            Val = val;
        }

        public string? Val { get; set; }

        public void AppendString(string appendString)
        {
            Console.WriteLine(Val + appendString);
        }
    }
}
