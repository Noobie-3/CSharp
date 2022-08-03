using System;

namespace csharp_final {
    class Program {
        static void Main(string[] args) {
            Student RightStudent = new Student(5216, "Jed", "Stone", 3.1);
            Student WrongStudent = new Student(5217, "Anya", "Forger", 999999.9999);
            Console.WriteLine("Student ID\t Student First Name\t Student Last Name\t Student GPA");
            Console.WriteLine(RightStudent.StudentId + "\t\t\t" + RightStudent.Fname + "\t\t\t" + RightStudent.Lname + "\t\t\t" + RightStudent.GPA);
            Console.WriteLine(WrongStudent.StudentId + "\t\t\t" + WrongStudent.Fname + "\t\t\t" + WrongStudent.Lname + "\t\t\t" + WrongStudent.GPA);
        }
    }
}
