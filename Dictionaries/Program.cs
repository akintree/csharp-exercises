using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> students =
                new Dictionary<int, string>();
            int studentID;
            bool success;

            Console.WriteLine("Enter a student (or ENTER to finish):");
            do
            {
                Console.WriteLine("Student ID: ");
                success = int.TryParse(Console.ReadLine(), out studentID);
                if (success)
                {
                    // Get the student's name
                    Console.Write("Name: ");
                    string studentName = Console.ReadLine();

                    students.Add(studentID, studentName);
                }
            }
            while (success);

            // Print roster
            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + " - " + student.Value);
            }

            //double sum = students.Values.Sum();
            //double avg = sum / students.Count;
            //Console.WriteLine("Average grade: " + avg);

            Console.ReadLine();
        }
    }
}