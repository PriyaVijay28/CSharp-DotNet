using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    internal class Program
    {
        enum trainees { Priya, Preethi, Gowtham, Lakshmi, Chandra };
        static void Main(string[] args)
        {


            //for(int i = 1; i <= 10; i++)
            //{
            //    if(i==3 || i == 9)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //for (int i = 1; i <= 6; i++)

            //{

            //    if (i == 2 || i == 5)

            //    {

            //        Console.Write(i * i+ ",");

            //        continue;

            //    }

            //    Console.Write(i + ",");

            //}

            String[,] travelPackage = { { "Ooty", "450km", "8000rs" }, { "Kodai", "550km", "9000rs" }, { "Munnar", "700km", "12000rs" } };
            for (int i = 0; i < travelPackage.GetLength(0); i++)
            {
               
                Console.WriteLine("Destination : " + travelPackage[i, 0] + ", Distance : " + travelPackage[i, 1] + ", Package : " + travelPackage[i, 2]);
                if (travelPackage[i, 0].Contains("Munnar"))
                {
                    Console.WriteLine("May include additional charges for Munnar");
                }
            }

            int[] list = { 3, 7, 5, 3, 10, 0, 6 };
            Array.Sort(list);
            Array.Reverse(list);
            foreach(int listNum in list)
            {
                Console.WriteLine(listNum);
            }

            int ft = (int)trainees.Preethi;
            int st = (int)trainees.Gowtham;
            Console.WriteLine($"{ft} and {st}");

            Console.WriteLine("Enter no of Persons");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter mode of travel");
            string mode = Console.ReadLine();
            Console.WriteLine("Enter no of days");
            int days = Convert.ToInt32(Console.ReadLine());
            Munnar munnar = new Munnar(n,mode,days);
            munnar.packageDetails(n,mode);
            munnar.packageDetails(n, mode,days);

            Generic<int> gen1 = new Generic<int>(50000);
            Generic<string> gen2 = new Generic<string>("I am a string");
             

            Console.ReadKey();
        }
    }
}
