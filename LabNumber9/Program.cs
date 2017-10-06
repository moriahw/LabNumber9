using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius of the circle.");
            double radius = ReadValidInteger();
                

            Circle CircleInfo = new Circle(); //creating the object of the class

            CircleInfo.Radius = radius; // assigning user value to class property

            Console.WriteLine(CircleInfo.GetCircumference());

            Console.WriteLine(CircleInfo.GetArea());

        }

        //method for validation of user input
        public static double ReadValidInteger()
        {

            double Input = 0;

            while (! double.TryParse(Console.ReadLine(), out Input)) //converts string to a number as long as the number is valid. returns true or false.
            {
                Console.WriteLine("Please enter a number!");
            }
            return Input;

        }

    }
}
