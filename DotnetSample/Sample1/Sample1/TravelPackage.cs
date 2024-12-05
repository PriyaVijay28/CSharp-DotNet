using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    internal abstract class TravelPackage
    {
        int noOfPersons;
        string modeOfTravel;
        int noOfDays;

        public TravelPackage(int noOfPersons,String modeOfTravel, int noOfDays)
        {
            this.noOfPersons = noOfPersons;
            this.modeOfTravel = modeOfTravel;
            this.noOfDays = noOfDays;   
        }

        protected TravelPackage(int noOfPersons, string modeOfTravel)
        {
            this.noOfPersons = noOfPersons;
            this.modeOfTravel = modeOfTravel;
        }

        public abstract void packageDetails(int noOfPersons, String modeOfTravel);
        public abstract void packageDetails(int noOfPersons, String modeOfTravel,int days);
        public abstract int totalAmount(int noOfPersons);
    }
}
