using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    class Compare
    {
        public Compare()
        {
            Console.WriteLine("A new Compare Instance created");
        }
        public bool ComapreString(string s1, string s2)
        {
            return s1.Equals(s2);
        }
    }
}
