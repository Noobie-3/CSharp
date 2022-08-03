using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_final {
    class Student {

        private int studentId;
        private string fname;
        private string lname;
        private double gpa;
        private const double LOWEST_GPA = 0.0;
        private const double HIGHEST_GPA = 4.0;


        public int StudentId {
            get { return studentId; }
            set { studentId = value; }
        }

        public string Fname {
            get { return fname; }
            set { fname = value; }
        }

        public string Lname {
            get { return lname; }
            set { lname = value; }
        }

        public double GPA {
            get { return gpa; }
            set { gpa = value; 
                if(this.gpa < LOWEST_GPA || this.gpa > HIGHEST_GPA) {
                this.gpa = 0.0;//show zack i didint have to use value there and qlote as he reads this ehehehhehehehehh
                }  
            }
        }

         public Student(int ID, string Fname, string Lname, double GPA ) {
            this.StudentId = ID;
            this.Fname = Fname;
            this.Lname = Lname;
            this.GPA = GPA;
        }
    }

}
