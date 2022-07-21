using System;

namespace Module_4_Project {
    class Program {
        static void Main(string[] args) {

            Apple apple = new Apple();

            apple.Size = 12;
            apple.HasWorms = false;
            apple.AmountOfSeeds = 5;
            apple.color = "yellow";
            apple.weight = 19;
            Console.Write("Apple stuff ------\t" + apple.Size +"\t" + apple.HasWorms + "\t" + apple.AmountOfSeeds + apple.Size + "\t" + apple.color + "\t" + apple.weight);


            Orange orange = new Orange();
            orange.Roundness = 4;
            orange.IsSpoiled = false;
            orange.Size = 11;
            orange.color = "brown";
            orange.weight = 12;
            Console.WriteLine("\nOrange stuff ------" +  orange.Roundness + "\t" + orange.IsSpoiled + "\t" + orange.Size + "\t" + orange.color + "\t" + orange.weight);

            Banana banana = new Banana();
            banana.isStillGreen = false;
            banana.IsGirthy = true;
            banana.Size = 999;
            banana.color = "pink";
            banana.weight = 999;

            Console.WriteLine("\nBannannananana stuff ------" + banana.IsGirthy + "\t" + banana.isStillGreen + "\t" + banana.Size + "\t" + banana.color + "\t" + banana.weight);




        }
    }
}
  