using System;
using System.Collections.Generic;
using System.Text;

namespace Module_4_Project {
    class Banana : Fruit {
        private bool isGirthy;
        public bool IsGirthy {
            get {
                return isGirthy;
            }
            set {
                this.isGirthy = value;
            }


        }
        public bool isStillGreen;
        private bool IsStillGreen {
            get {
                return isStillGreen;
            }
            set {
                this.isStillGreen = value;
            }
        }


    }
}
