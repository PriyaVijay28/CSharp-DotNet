using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
     
    internal class ConstNdReadOnly
    {
        public readonly int MinValue;
        public ConstNdReadOnly(int min ) { 
            this.MinValue = min;
        }
        public const int MaxValue = 500;
        public void DisplayMax_MinValue()
        {
            Console.WriteLine($"Max Value: {MaxValue}");
            Console.WriteLine($"Min Value: {MinValue}");
        }
    }
}
