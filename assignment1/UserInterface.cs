using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {
        //No variables
        //No properties
        //No constructors

        //********
        //Methods
        //********

        public static int GetUserInput()
        {
            PrintMenu();

            String input = Console.ReadLine();

            while (input != "1" && input != "2")
            {
                PrintErrorMessage();

                PrintMenu();

                input = Console.ReadLine();

            }

            return Int32.Parse(input);
        }

        public static void PrintMenu()
        {
            Console.WriteLine("What would you like to do? ");
            Console.WriteLine("1. View all wine items");
            Console.WriteLine("2. Search by wine item number and print");
        }

        private static void PrintErrorMessage()
        {
            Console.WriteLine("That i not a valid entry");
            Console.WriteLine("Please make a valid choice");
        }
        
    }   

}
