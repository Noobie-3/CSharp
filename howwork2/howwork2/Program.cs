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
            string quit = "no";
            while (quit == "no") { 

                //gets the numbers to use
                Console.WriteLine("Please input the first number that you will be working with: ");
                int num = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please input the second number that you will be working with: ");
                int amount = Int32.Parse(Console.ReadLine());

                //gets what they wanna do with numbers
                Console.WriteLine("Please input the what you would like to do with these numbers");
                string choice = Console.ReadLine();

                //input validation for choice
                while (choice != "Add" && choice != "add" && choice != "Subtract" && choice != "subtract" && choice != "Multiply" && choice != "multiply" && choice != "Divide" && choice != "divide" && choice != "End" && choice != "end") {

                    Console.WriteLine("Not a valid Input, Please Try again: ");
                    choice = Console.ReadLine();

                }
                    //if input valid do the equation
                    switch (choice) {
                        case "Add" or "add":
                            addition(num, amount);
                            break;
                        case "Subtract" or "subtract":
                            Subtraction(num, amount);
                            break;
                        case "Multiply" or "multiply":
                            Multi(num, amount);
                            break;
                        case "Divide" or "divide":
                            divide(num, amount);
                            break;
                        case "End" or "end":
                            Environment.Exit(1);
                            break;
                    }
            }

        }
    }
}
