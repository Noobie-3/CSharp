using System;
using System.Collections.Generic;
using System.Text;

namespace Module_4_Project {
    class Apple : Fruit {


        private bool hasWorms;
        
        public bool HasWorms{
            get { return hasWorms; }
            set { hasWorms = value; }


        }
        private int amountOfSeeds;

        public int AmountOfSeeds {
            get {
                return amountOfSeeds;
            }
            set {
                amountOfSeeds = value;
            }
        }


    }
}
