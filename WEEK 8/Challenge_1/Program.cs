using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MountainBike bike = new MountainBike(12,23,34,45);
            bike.SetGear(12);
            bike.SetSeatHeiht(23);
            bike.SetCadence(100);
            Console.WriteLine($"Cadence : {bike.GetCadence()}\tGear; {bike.GetGear()} ");
            Console.ReadLine();
        }
    }
}
