using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Taxi
    {
        //properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumOfPassanger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);

            if (OnDuty)
                Console.WriteLine("On Duty : Yes");
            else
                Console.WriteLine("On Duty : No");

            Console.WriteLine("Number of Passanger : {0}", NumOfPassanger);
            Console.WriteLine();
        }

        public void PickUpPassanger()
        {
            Console.WriteLine("{0} sedang menjemput panumpang", DriverName);
        }

        public void DropOfPassanger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    }
}
