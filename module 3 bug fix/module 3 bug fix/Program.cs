using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Module3 {
    class Program {
        static void Main(string[] args) {
            int[] arr = new int[25];
            Random rand = new Random();
            for(int c = 0; c < arr.Length; c++) {
                arr[c] = rand.Next(0, 900);

            }

        }

        static int Find(int[] arrIn, int numToFind) {
            for(int c = 0; c < arrIn.Length; c++) {
                if(arrIn[c] == numToFind) {
                    return c;
                }
            }
            return -1;
        }

        //who writes these things it does jack cruuuuuuuaaaaap


        static int Find(int[] arrIn, int minNum, int maxNum) {
            for(int c = 0; c < arrIn.Length; c++) {
                if(arrIn[c] > minNum && arrIn[c] < maxNum) { return c; }
                else {
                    
                }
            }
            return -1;
        }
    }
}