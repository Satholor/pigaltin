using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2hw
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring our variables
            string first;      // First name before conversion
            string last;      // Last name before conversion
            string firstPig; // First name post conversion
            string lastPig; // Last name post conversion

            // Initializing Variables w/ user input
            Console.Write("Enter your first name: ");
            first = Console.ReadLine();
            Console.Write("Enter your last name: ");
            last = Console.ReadLine();

            // Converting the first and last name into Pig Latin
            // First we take the second letter of each name and use ToUpper to capitalize it, then we take the remainder of the name and concatenate it to the first letter.
            // We then take the first letter of each name, make it lowercase, then add it to the end of the string. We then add "ay" to the end of the string.
            firstPig = first[1].ToString().ToUpper() + first.Substring(2) + first[0].ToString().ToLower() + "ay";
            lastPig = last[1].ToString().ToUpper() + last.Substring(2) + last[0].ToString().ToLower() + "ay";

            Console.Write("{0} {1} -> {2} {3}", first, last, firstPig, lastPig);
        }
    }
}
