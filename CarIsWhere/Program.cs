using System;

namespace CarIsWhere
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Machine = new Car("Ford","Focus","FFFF12","Blue");
            Machine.Printinfo();
            Machine.DrivesLap();
            Machine.Printinfo();
            Machine.DriveuntilEmpty();
            Machine.Printinfo();



        }
    }
}
