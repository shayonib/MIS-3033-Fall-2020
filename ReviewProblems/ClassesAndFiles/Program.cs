using System;
using System.Collections.Generic;

namespace ClassesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Student stud1 = new Student();
            stud1.name = "Lauren";
            stud1.id = 2;
            students.Add(stud1);

            Student stud2 = new Student("Shayoni", 1);
            students.Add(stud2);

            foreach (var stud in students)
            {
                Console.WriteLine(stud);
               // Console.WriteLine(stud.name + " has an ID of " + stud.id);          
            }
            //Console.WriteLine(stud1.name + " has an id of " + stud1.id);
            //Console.WriteLine(stud2.name + " has an id of " + stud2.id);

        }
    }
}
