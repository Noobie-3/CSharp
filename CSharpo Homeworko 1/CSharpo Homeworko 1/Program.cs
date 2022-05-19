using System;

namespace CSharpo_Homeworko_1
{
    class Program {
        static void Main(string[] args) {    

            //takes in a number
            Console.WriteLine("Please enter a Number that will be worked with\t");
            string Number = Console.ReadLine();
            int numconverted = Int32.Parse(Number);
            
            //Writed the new numbers 
            Console.WriteLine("Number Squared: " + (numconverted * numconverted));
            Console.WriteLine("Number devided by 2: " + (numconverted / 2));
            Console.WriteLine("Number minis 100: " + (numconverted - 100));
        }
    }
}
