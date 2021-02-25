using System;
using System.Collections.Generic;
using System.Text;

namespace CarIsWhere
{
    class Car
    {//Create a class Car
     //The car has a mark name(string), model name(string), registration number(string, no longer than six characters), color(string), odometer(int) and fuel tank(int)
     //The odometer value equals 0 by default.
     //The fuel tank value by default is 60.
        private string markname;
        private string modelname;
        private string regristatsionnr;
        private string color;
        private int odometer = 0;
        private int fueltank = 60;

        //No car characteristics can be changed after the car object has been created.*
        //All the car characteristics can be accessed using ‘.’ (E.g.newCar.Model);
        public Car(string MarkName, string ModelName, string RegNumer, string Color)
        {
            markname = MarkName;
            modelname = ModelName;
            if (RegNumer.Length <= 6)
            {
                regristatsionnr = RegNumer;
            }
            else { throw new ArgumentOutOfRangeException("RegNumber cannot be longer than 6 charakters"); }
            color = Color;
        }
        public string Markname { get { return markname;} }
        public string Modelname { get { return modelname; } }
        public string regnumber { get { return regristatsionnr; } }
        public string COLOR { get { return color; } }
        public int OdoMeter { get { return odometer; } }
        public int fuelTank { get { return fueltank; } }
        //The car can drive.Every lap the car passes increases the value of the odometer by 100 and decreases the value of the fuel tank by 5 .
        public void DrivesLap() 
        {
            Console.WriteLine("The car goes wroom");
            odometer += 100;
            fueltank -= 5;
        }
        //Write a program that allows you to create a car object and makes the car drive until the fuel tank is empty (equals 0). When the fuel tank value reaches 0, the car stops.
        public void DriveuntilEmpty()
        {
            while (fueltank != 0)
            {
                odometer += 100;
                fueltank -= 5;

            }
        }
        //Write a method to display all the car properties(characteristics).
        public void Printinfo()
        {
            Console.WriteLine($"Mark:{markname}, Model {modelname}, RegNr {regnumber}, Color {color}, Odometer {odometer}, fueltank {fueltank}");
        }


    }
}
