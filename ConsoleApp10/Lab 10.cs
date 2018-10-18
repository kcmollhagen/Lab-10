using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            Console.WriteLine("Welcome to the Circle Tester...a place where all your geometric dreams come true!");
            List<Circle> Circles = new List<Circle>();
            do
            {
                Console.WriteLine("Enter a radius:");
                string response = Console.ReadLine();
                // this line to begins my validation
                double radius;
                bool success = double.TryParse(response, out radius);
                //if statement to make sure it is positive and greater than 0
                if (!success || radius <=0)
                {
                    Console.WriteLine("I'm sorry, that is not a valid number. Please enter a number greater than 0.");
                    continue;
                }

                    Circle c = new Circle(radius);
                    // keeps track of how many circles are made
                    Circles.Add(c);
                    Console.WriteLine("Circumference = {0:F2}", c.CalculateFormattedCircumference());
                    Console.WriteLine("\nArea of circle: " + c.CalculateFormattedArea());
                    Console.WriteLine("Would you like to continue?  y/n ");
                    string answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        Console.WriteLine("Hot Diggity Dog!!");
                    }
                    else if (answer == "n")
                    {
                        Console.WriteLine("You are the weakest link. GOODBYE!");
                        loop = false;
                    }

                } while (loop) ;
                Console.WriteLine("You created " + Circles.Count + " circle(s)");
                Console.ReadKey();
        }
    }
}

