using System;
using System.Collections.Generic;
using System.Text;

namespace taksi
{
    class Objek
    {
        string nama;
        int nomor;
        int duty;

        public void DriverName()
        {
            Console.WriteLine("Driver Name : Samsul Huda");
        }

        public void OnDuty()
        {
            Console.WriteLine("On Duty : Yes");
        }

        public void NumberOfPpassenger()
        {
            Console.WriteLine("Number Of Passenger : 30");
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("Samsul Huda Sedang Menjemput Penumpang");
        }

        public void DropOffPasengger()
        {
            Console.WriteLine("Samsul Huda Sedang Mengantar Penumpang");
        }


    }
}
