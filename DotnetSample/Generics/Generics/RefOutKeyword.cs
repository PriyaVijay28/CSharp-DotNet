using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class RefOutKeyword
    {
        int newYrDiscPercent = 15;
        int cristmasDiscPercent = 10;
        

        public void newYrCalc(ref int price, int newYrDiscPercent,out int amount)
        {
            amount = price-(price * newYrDiscPercent / 100);
            
        }

        public void cristmasCalc(ref int price, int cristmasDiscPercent, out int amount)
        {
            amount = price-(price * cristmasDiscPercent / 100);
            
        }
    }
}
