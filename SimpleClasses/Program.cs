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
            Car myCar = new Car("Oldsmobile", "Cutlas Supreme", 1986, "Silver");  //creating an instance "myCar" of the Car class
            //myCar.Make = "Oldsmobile";        // Video put constructore in Main
            //myCar.Model = "Cutlas Supreme";
            //myCar.Year = 1986;
            //myCar.Color = "Silver";

            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color );

            decimal value = myCar.DetermineMarketValue();
            Console.WriteLine("{0:C}", value);

            //Console.ReadKey();

            //Console.WriteLine("{0:C}", myCar.DetermineMarketValue());


        }
        /*private static decimal DetermineMarketValue(Car car)  // Helper method not needed
        {
            decimal carValue = 100.0M;

            //Someday I might look up the value of the car...
            return carValue;
        }
        */
    }
}
