using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5___Decision_Structures
{
    internal class Program //Maxym F.
    {
        static void Main(string[] args)
        {
            int grade, guess, radius, number;

            
          

            Console.WriteLine("Whats your grade? (from 0 to 100)");

            if (Int32.TryParse(Console.ReadLine(), out grade))
            {
                if (grade >= 80)
                {
                    Console.WriteLine("Good Job");
                }

                else if (grade <= 79)
                {
                    Console.WriteLine("Study Harder.");
                }
            }

            else 
            {
                Console.WriteLine("You used a letter. use NUMBERS");
            }

                Console.WriteLine("Guess the number!");

            if (Int32.TryParse(Console.ReadLine(), out guess))
            {
                if (guess == 12)
                {
                    Console.WriteLine("You guessed it! The numbers 12.");
                }


                else
                {
                    Console.WriteLine("Nope!");
                }
            }

            else 
            {
                Console.WriteLine("cant use letters. USE NUMBERS!!!");
            }

                Console.WriteLine("Whats the radius of your circle?");

            if (Int32.TryParse(Console.ReadLine(), out radius))
            {
                if (radius < 0)
                {
                    Console.WriteLine("Negative radii are illegal!");
                }

                else if (radius > 1)
                {
                    Console.WriteLine($"The Diameter is {radius}");
                }

                else if (radius == 1)
                {
                    Console.WriteLine("You have a dot.");
                }

            }

            else 
            {
                Console.WriteLine("A radius cant be made with letters, big guy");
            }

                Console.WriteLine("Give me a number-ill tell you if its in the range of 5 to 15 or not.");

            if (Int32.TryParse(Console.ReadLine(), out number))
            {
                if (number > 5 && number < 15)
                {
                    Console.WriteLine("Your number is between 5 and 15.");
                }

                else
                {
                    Console.WriteLine("Your number is not inbetween 5 and 15");
                }
            }

            else 
            {
                Console.WriteLine("Put in a number, big guy.");
            }


            int person1 = 15, person2 = 27, person3 = 15;

            if((person1==person3 && person1 !=person2) || (person1==person2 && person1 !=person3)) 
            {
                Console.WriteLine("2 people are the same age!");
            }
            
            














        }
    }
}
