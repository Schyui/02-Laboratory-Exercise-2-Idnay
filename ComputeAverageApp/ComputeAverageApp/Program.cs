using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeAverageApp
{
    internal class ComputerAverageProgram

    {
        //static variables so i can use them inside the methods and within the static main

        //double variables for the 5 grades
        static double g1, g2, g3, g4, g5;

        //variable for the average so i can store the formula
        static double avg;

        //just an additional stuff for the name :)
        static string name;

        //variables for the two boolean in order to make a condition for the loop
        static bool hasValue = false;
        static bool isTrue = false;


        static void Main(string[] args)
        {
            //loop, if the input has no value, if it has one, it proceeds to the next flow
            while (!hasValue)
            {
                //input for the name
                Console.Write("Please Enter your name first: ");
                name = Console.ReadLine();

                //if the name contains 1 or more than character, it will stop the loop by turning the hasValue into true, then it will proceed to the next flow
                if (name.Length > 0)
                {
                    hasValue = true;
                   
                    Console.WriteLine("Hello "+name+"!");
                }
                //if the name contains 0 character, it will continue looping
                else
                {
                    Console.WriteLine("No input, please try again");
                    continue;
                }

            }

            //another loop, but with exception in it, it will display a message that shows the problem, like invalid format, i only used Exception for the parameter bc i already did the FormatException on the last activity
            while (!isTrue)
            {
                try
                {
                    GetGrades();
                    CalcAverage();

                    //limits the grades up to 100 only
                    if (avg <= 100)
                    {
                        WriteOutput();
                    }
                    else {
                        Console.WriteLine("Grades are only up to 100, Please try again.");
                        continue;
                    }
                    //it will turn true to stop looping if it meets the correct input
                    isTrue = true;
                }
                //this will loop if there are problems 
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }
                       
        }
        //method for the inputs, i also took your advice from the previous activity, we need to be specific when it comes to naming :)
        static void GetGrades()
        {
            Console.WriteLine("Enter 5 grades separated by new line: ");
            g1 = Convert.ToInt32(Console.ReadLine());
            g2 = Convert.ToInt32(Console.ReadLine());
            g3 = Convert.ToInt32(Console.ReadLine());
            g4 = Convert.ToInt32(Console.ReadLine());
            g5 = Convert.ToInt32(Console.ReadLine());
        }
        //method for the output with some conditions i added, if the average is 90-100, 80-89, 75-79, and below 75, each of them will print out a compliment :)
        static void WriteOutput()
        {
            string comp = "";
            if (avg >= 90 && avg <= 100)
            {
                comp = "Good Job, ";
            }
            else if (avg >= 80 && avg <= 89)
            {
                comp = "Nice Work, ";
            }
            else if (avg >= 75 && avg <= 79)
            {
                comp = "Keep it up, ";
            }
            else {
                comp = "You can do better, ";
            }

                Console.WriteLine(comp + name+"! Your average is " + avg + " and round off to " + Math.Round(avg));
        }
        //formula for the average
        static void CalcAverage() {
            avg = (g1 + g2 + g3 + g4 + g5) / 5;
        }

    }
}
