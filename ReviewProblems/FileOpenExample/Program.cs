using System;
using System.IO;

namespace FileOpenExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C: \Users\shayo\Downloads\Pride and Prejudice by Jane Austen.txt";
            //put the @ sign so it doesn't show errors with the back slash (escape character sequences)

            string[] allLines = File.ReadAllLines(filePath);
            //string entireBook = File.ReadAllText(filePath);

            //Output 5 lines of the book at a time
            //for (int i = 0; i < allLines.Length; i++)
            //{
            //    if (i % 5 == 0 && i != 0)
            //    {
            //        Console.ReadKey();
            //    }
            //    Console.WriteLine(allLines[i]);
            //}
            //Console.WriteLine(entireBook);

            //Output a Chapter at a time
            foreach (var line in allLines)
            {
                if(line.Contains("Chapter") == true)
                {
                    Console.ReadKey();
                }
                Console.WriteLine(line);
            }

            //Console.WriteLine(allLines);
        }
    }
}
