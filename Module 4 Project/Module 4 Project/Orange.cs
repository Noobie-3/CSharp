using System;
using System.Collections.Generic;
using System.Text;

namespace Module_4_Project {
    class Orange : Fruit {

        private double roundness;
        public double Roundness {
            get {
                return roundness;
            }
            set {
                roundness = value;
            }


        }
        private bool isSpoiled;
         public bool IsSpoiled {
            get {
                return isSpoiled;
            }
            set {
                isSpoiled = value;
            }
        }


    }
}
