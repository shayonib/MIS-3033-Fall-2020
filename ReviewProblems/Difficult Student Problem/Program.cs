using System;

namespace Difficult_Student_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student(5, "Shayoni", "Banerjee", 40000);
            Console.WriteLine(myStudent);

            myStudent.MakePayment(500);
            Console.WriteLine(myStudent);

            myStudent.MakePayment(500);
            Console.WriteLine(myStudent);

            try
            {
                myStudent.MakePayment(-500);
                Console.WriteLine(myStudent);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

        }
    }
}
