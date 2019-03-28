using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek taxi
            Taxi taxi = new Taxi();

            //pengesetan nilai properties
            taxi.DriverName = "Van";
            taxi.OnDuty = true;
            taxi.NumOfPassanger = 10;

            //pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassanger();
            taxi.DropOfPassanger();

            Console.ReadKey();
        }
    }
}
