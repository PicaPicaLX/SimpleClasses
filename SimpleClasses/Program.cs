using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar1 = new Car();
            myCar1.Make = "Oldsmobile";
            myCar1.Model = "Cutlas Supreme";
            myCar1.Year = 1986;
            myCar1.Color = "Silver";

            Car myCar2 = new Car();
            myCar2.Make = "New";
            myCar2.Model = "Buick";
            myCar2.Year = 1999;
            myCar2.Color = "Black";

            Console.WriteLine("{0} {1} {2} {3}", 
                myCar1.Make, 
                myCar1.Model, 
                myCar1.Year, 
                myCar1.Color);
            Console.ReadLine();
        }
    }


    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }
}
