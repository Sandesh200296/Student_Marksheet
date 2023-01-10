using System;

namespace Marksheet
{
    public class studentDetails
    {

        public static void Main(String[] args)
        {
            int id, marks1, marks2, marks3, total;
            string name;
            float percentage;

            //Enter Roll Number
            Console.WriteLine("Kindly enter Student Roll number:");
            id = Convert.ToInt32(Console.ReadLine());

            //Enter Name
            Console.WriteLine("Kindly enter Student Name: ");
            name = Console.ReadLine();
            
            // Enter marks1
            Console.WriteLine("Kindly enter marks1: ");
            marks1= Convert.ToInt32(Console.ReadLine());

            // Enter marks2
            Console.WriteLine("Kindly enter marks2: ");
            marks2 = Convert.ToInt32(Console.ReadLine());

            // enter marks3
            Console.WriteLine("Kindly enter marks3: ");
            marks3= Convert.ToInt32(Console.ReadLine());

            // total marks
            total = marks1 + marks2 + marks3;

            // percentage
            percentage = total / 3.0f;

            // Display
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student id: " + id);
            Console.WriteLine("Total Marks: " + total);
            Console.WriteLine("Percentage is: "+percentage);

            // grade
            if (percentage <= 35)
            { Console.WriteLine("Grade is F"); }
            else if (percentage >= 35 && percentage <= 49)
            { Console.WriteLine("Grade is D"); }
            else if (percentage >= 50 && percentage <= 59)
            { Console.WriteLine("Grade is C"); }
            else if (percentage >= 60 && percentage <= 69)
            { Console.WriteLine("Grade is B"); }
            else if (percentage >= 70 && percentage <= 79)
            { Console.WriteLine("Grade is B+"); }
            else if (percentage >= 80 && percentage <= 90)
            { Console.WriteLine("Grade is A"); }
            else if (percentage >= 91)
            { Console.WriteLine("Grade is A+"); }
        }
   }
}