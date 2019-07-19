using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowersTableOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!\n");
            bool repeat = true;
            while (repeat)
            {
                int userNumber = ValidateIntegers("Please enter a number");
                //taking in ValidateIntegers, changing your strings to numbers
                //since string is an int and declaring userNumber, returning that method
                //putting userNumber in Display makes it work
                DisplayPowersTable(userNumber);


                string input = "";
                while (input != "y" && input != "n") //you can use relational and logical operators
                {
                    Console.WriteLine("Would you like to go again? Y/N");
                    input = Console.ReadLine().ToLower();
                }


                if (input != "y")
                {
                    Console.WriteLine("See you later, friend!");
                    repeat = false;
                }
                else
                {
                    repeat = true;
                }

            }


            Console.ReadKey();


        }
        public static void DisplayPowersTable(int numberPicked) //I want a method that displays everything I have done.
        {
            Console.WriteLine("\nNumber\tSquared\tCubed\t");// \t (tab) makes word into column
            Console.WriteLine("========================");
            for (int i = 1; i <= numberPicked; i++) //for loop all about start, stop, how you get there

            {

                Console.WriteLine($"{i}\t{Square(i)}\t{Cubed(i)}\t");

            }

        }

        public static int Square(int num) //I want to make a method for squared
        {
            return num * num; //equation for getting a square
        }

        public static int Cubed(int num) //I want to make method for cubed
        {
            return num * num * num; //equation for getting cubed
        }

        public static int ValidateIntegers(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            int number;
            if (int.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                return ValidateIntegers("Yikes, try again with a number!");
            }
        }
    }
}
