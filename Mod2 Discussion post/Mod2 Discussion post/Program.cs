using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace CsharpTesting

{

    class Program/*Decalares the class for the program*/ {
        static void Main(string[] args)/*Main function where all the code that will run is located(functions will be somwhere else and just ran in here)*/{
            int Age;//declares an int names Age
            Console.Out.WriteLine("Please input your age: ");//writes "Please input your age: " to the console
            Age = int.Parse(Console.ReadLine());//gets a string inpuyt from the user and turns it into an int.

            while (Age < 0) {//begining of a while loop
                Console.Out.WriteLine("You can not have an age lower than 0");//writes to the console "You can not have an age lower than 0"
                Console.Out.WriteLine("Please input your age: ");//Writes to the console " Please input your age: 
                Age = Console.Read();//takes in age 
            }

            Console.Out.WriteLine("You were approximatley born in the year " + GetBirthYear(Age) + ".");// Writes to the console you were approximatly born in the year    then it runs the GetBirthyear function that is declared later and then adds a period at the end"
            Console.Out.WriteLine("\nPress any key to continue...");//writes to the console a new line then " Press any key to continue..."
            Console.ReadLine();//takes in a key press of anysort
        }
        static int GetBirthYear(int Age) {/*this whole block is a function that takes age away from 2017 but this program seems to be outdated so 2022 would need to be put here to make it correct*/
            return 2017 - Age;
        }

    }

}