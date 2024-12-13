using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add(1);
            array.Add("two");
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);

            LinqEx linq = new LinqEx();
            linq.printDistinct();
            linq.printSum();
            linq.printSort();

            LinqModel lm = new LinqModel();
            lm.empDetails();

            RefOutKeyword refKeyword = new RefOutKeyword();
            int amount;
           
           
            Console.WriteLine("Enter price amount");
            int price=Convert.ToInt32(Console.ReadLine());
            refKeyword.newYrCalc(ref price,15, out amount);
            Console.WriteLine($"Amount :{amount}");

            ConstNdReadOnly cr = new ConstNdReadOnly(10);
            cr.DisplayMax_MinValue();

            Delegateprinter sc = new Delegateprinter(Delegate.SoftCopy);
            sc("Print as soft copy");
            Delegateprinter hc = new Delegateprinter(Delegate.HardCopy);
            sc("Print as Hard copy");
            Console.ReadKey();
        }
       
    }
}
