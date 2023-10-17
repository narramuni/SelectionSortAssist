using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSortAssist
{
    public class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        static void runApp()
        {
            string[] students = new string[5];

            students[0] = "SaiPavan";
            students[1] = "Bhanu";
            students[2] = "Adhithya";
            students[3] = "Varun";
            students[4] = "Guru";

            SelectionSort selectionSort = new SelectionSort();
            selectionSort.Sort(students);


            Console.WriteLine("Sorted List of Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student}");
                Console.ReadLine(); 
            }
        }
    }
}
