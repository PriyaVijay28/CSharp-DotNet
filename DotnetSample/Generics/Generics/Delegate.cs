using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
     delegate void Delegateprinter(string s);

    internal class Delegate
    {
        public static void HardCopy(string s)
        {
            Console.WriteLine(s);
        }
        public static void SoftCopy(string s)
        {
            Console.WriteLine(s);
        }
    }
}
