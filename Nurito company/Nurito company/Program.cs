using System;

namespace Nurito_company {
    class Program {
        static void Main(string[] args) {
            //declares the prices
            float BeefPrice = 2.50f;
            float BeanPrice = 1.75f;
            float SupremePrice = 3.25f;

            //Beef input and cauluation
            Console.WriteLine("How many Beef buritos would you like? ");
            string BeefAmount = Console.ReadLine();
            int BeefIntAmount = Int32.Parse(BeefAmount);
            float BeefSold = BeefIntAmount * BeefPrice;
            Console.WriteLine(BeefSold);

            //Bean input and calculation
            Console.WriteLine("How many Beef buritos would you like? ");
            string BeanAmount = Console.ReadLine();
            int BeanIntAmount = Int32.Parse(BeanAmount);
            float BeanSold = BeanIntAmount * BeanPrice;
            Console.WriteLine(BeanSold);

            //Supreme input and Calculation
            Console.WriteLine("How many Beef buritos would you like? ");
            string SupremeAmount = Console.ReadLine();
            int SupremeIntAmount = Int32.Parse(BeefAmount);
            float SupremeSold = SupremeIntAmount * SupremePrice;
            Console.WriteLine(SupremeSold);



            //receipt


            Console.WriteLine("\t\t\t\t\t|||||||Your Receipt|||||||");
            
        }
    }
}
