using System;

namespace Module_3_homework__Arrays_
{
    class Program
    {
        static void Main(string[] args)
        {
            int ArraySize = int.Parse(Console.ReadLine());


            double[] TestArray = new double[ArraySize];

            for(int i = 0; i < ArraySize; ++i) {
              TestArray[i] = double.Parse(Console.ReadLine());
            }

            Array.Sort(TestArray);
            Console.WriteLine("\n");
            for(int i = 0; i < ArraySize; ++i) {
                Console.WriteLine(TestArray[i]);
            }





            }
    }
}
