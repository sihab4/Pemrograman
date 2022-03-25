using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace membuatTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat object dari class Taxi
            Taxi taxi = new Taxi();


            //pengesetan nilai properties
            bool OnDuty = true;
            int NumPassenger = 10;
            taxi.DriverName = "Muhammad Qurais Sihab";
            taxi.OnDuty = "Yes"; Convert.ToString(OnDuty);
            taxi.NumPassenger = Convert.ToString(NumPassenger);

            //pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
