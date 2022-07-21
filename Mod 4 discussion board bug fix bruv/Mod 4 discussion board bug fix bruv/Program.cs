using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Module4 {


    class Class1 {
        int students { get; set; }
        string ClassName { get; set; }
        string[,] studentNames;
        public Class1() { studentNames = new string[25, 2]; }
        public string GetStudentNames(int index) { return studentNames[index, 0] + " " + studentNames[index, 5]; }
        public void ClearStudentsNames() { studentNames = new string[25, 2]; }
        public void SetStudentNames(string[,] arrIn) { studentNames = arrIn; }


        static void Main(string[] args)  
        {  
        //do somthing ig I wonder who wrote these odd bug fixes
        }



    }
}





