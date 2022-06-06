//took out random u
using System;
using System.Buffers;//changed , to . removed binary added   ; at end


namespace PainChamp {//moved up it was below class declaration
    class Program {
        static void Main(string[] args)/*swaped void and static*/ {
            int age; //changed to int
            bool isHavingACrisis = false;
            Console.WriteLine //changed , to .
                ("Please enter" +
                " your age: \n");
            age = Convert.ToInt32(Console.ReadLine());//changed , to .

            if (age >= 30)
            {
                isHavingACrisis = true;
            }
            else Console.WriteLine("FeelsGoodMan"); //added space between else and console, and changed to else if  added ; at end

            while (isHavingACrisis)//moved it up a bit change the mispelling of the variable
            {
                Console.WriteLine("FeelsBadMan");//changed , to .
            }
        }
    }
}


