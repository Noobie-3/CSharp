using System;
using System.Collections.Generic;
using System.Linq;//"Had no e .. added an e"
using System.Text;
using System.Threading.Tasks;
namespace Module1 {
    class Program {//Formatted Entire thing with correct bracket use also added abracket here
        public static/*added a t to static*/ int GetBirthYear(int Age) /*"Removed ; from end*/{
            return (Age /*removed the quotes from Age*/- DateTime.Now.Year); //added ; to end
        }


       /*tabbed over for formatting corectly*/ static void Main(string[] args) {
            Console.Write(/*add quotes */"Please input your age: "); int Age = int.Parse(Console.ReadLine());
          /*added o  to console*/  Console.Write("Your approximate birth year is: " + GetBirthYear(Age));
        }
    }
}