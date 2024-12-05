using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    internal class Munnar : TravelPackage
    {
        public Munnar(int noOfPersons, string modeOfTravel,int noOfDays) : base(noOfPersons, modeOfTravel,noOfDays)
        {
        }

        public override void packageDetails(int noOfPersons,String modeOfTravel )
        {
            int amount = this.totalAmount(noOfPersons);
            Console.WriteLine($"Total no. of Persons {noOfPersons}. Your mode of travel will be {modeOfTravel}. Amount to be paid will be {amount}");
        }

        public override void packageDetails(int noOfPersons, string modeOfTravel, int days)
        {
            int amount = this.totalAmount(noOfPersons);
            Console.WriteLine($"Total no. of Persons {noOfPersons}. Your mode of travel will be {modeOfTravel}. Amount to be paid will be {amount}. Duration will be {days} days");
        }

        public override int totalAmount(int noOfPersons)
        {
            return noOfPersons * 5000;
        }
    }
}
