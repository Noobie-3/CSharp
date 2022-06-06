using System;

namespace test_ {
    class Program {
        //Adittion function
        static void addition(int num, int amount) {
            Console.WriteLine("The Answer is: " + (num + amount));
        }

        //Subtraction Function
        static void Subtraction(int num, int amount) {
            Console.WriteLine("The Answer is: " + (num - amount));
        }
        //Multi function
        static void Multi(int num, int amount) {
            Console.WriteLine("The Answer is: " + (num * amount));
        }
        //devide function
        static void divide(int num, int amount) {
            Console.WriteLine("The Answer is: " + (num / amount));
        }
        static void Main(string[] args) {
            string quit = "quit";
            while (quit == "quit")

                //gets the numbers to use
                Console.WriteLine("Please input the first number that you will be working with: ");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please input the second number that you will be working with: ");
            int amount = Int32.Parse(Console.ReadLine());

            //gets what they wanna do with numbers
            string choice = Console.ReadLine();

            //input validation for choice
            while (choice != "Add" && choice != "1" && choice != "Subtract" && choice != "2" && choice != "Multiply" && choice != "3" && choice != "Divide" && choice != "4") {

                Console.WriteLine("Not a valid Input, Please Try again: ");
                choice = Console.ReadLine();
            }

            //if input valid do the equation
            switch (choice) {
                case "Add" or "1":
                    addition(num, amount);
                    break;
                case "Subtract" or "2":
                    Subtraction(num, amount);
                    break;
                case "Multiply" or "3":
                    Multi(num, amount);
                    break;
                case "Divide" or "4":
                    divide(num, amount);
                    break;
            }

        }
    }
}
