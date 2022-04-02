using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace membuatTaxi
{
    public class Taxi

    {   //properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }


        //method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);

        }

        public void PickUpPassenger()
        {
            if (OnDuty == true)
            {
                Console.WriteLine("Onduty = Yes");
                Console.WriteLine("Number of Passenger {0}", NumPassenger);
            }
            else
            {
             
                Console.WriteLine("{0} tidak sedang menjemput penumpang", DriverName);
            }
            
        }
        public void DropOffPassenger()
        {
            if(NumPassenger != 0)
            {
                Console.WriteLine();
                Console.WriteLine("{0} sedang menngantar penumpang", DriverName);
            }
        }
    }
}
