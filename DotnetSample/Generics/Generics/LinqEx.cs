using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class LinqEx
    {
        public void printList()
        {
            List<string> my_list = new List<string>()
        {
                "Apple","Mango","Tomato","Neem"
        };

            // Creating LINQ Query
            var res = from l in my_list
                      where l.Contains("a")
                      select l;

            // Executing LINQ Query
            foreach (var q in res)
            {
                Console.WriteLine(q);
            }
        }
        public void printDistinct()
        {
            List<int> intCollection = new List<int>() {1,2,3,2,4,4,5,6,1 };

            //Using Method syntax
            var dist = intCollection.Distinct();
            var max=intCollection.Max();
            var min=intCollection.Min();

            //Using Query
            var qs = (from num in intCollection select num).Distinct();
            foreach (var q in qs)
            {
                Console.Write(q+",");
            }
            //foreach (var d in dist)
            //{
            //    Console.Write("Method syntax" + d + ",");
            //}
        }
        public void printSum()
        {
            List<int> intCollection = new List<int>() { 10, 12, 3, 25, 40, 4, 51, 6, 1, 12, 14 };
            int res = intCollection.Where(x => x % 2 == 0).Distinct().Sum();
            Console.WriteLine();
            Console.WriteLine("Sum of even numbers : " + res);
        }
        public void printSort()
        {
            List<int> intCollection = new List<int>() { 10, 12, 3, 25, 40, 4, 51, 6, 1, 12, 14 };
            
            intCollection.Sort();
            foreach(var val in intCollection)
            {
                Console.Write(val + ", ");
            }
        }

    }
}
