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
       

            Console.Write("Nama driver : ");
            taxi.DriverName = Console.ReadLine();

            Console.Write("On Duty? [YES or NO] : ");
            taxi.OnDuty = Console.ReadLine().ToLower() == "yes" ? true : false;

            if (taxi.OnDuty) 
            {
                Console.Write("Number of Passenger : ");
                taxi.NumPassenger = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                taxi.TaxiInfo();
                taxi.PickUpPassenger();
                taxi.DropOffPassenger();

            }
            else
            {
                Console.WriteLine();
                taxi.PickUpPassenger();
                taxi.DropOffPassenger();
            }




            Console.ReadKey();
        }
    }
}
