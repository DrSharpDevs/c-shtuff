using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS0101_Strings
{
    internal partial class Program
    {
        private static void Strings2()
        {
            // The Console.ReadLine() method reads input from the console.
            // It will wait for the user to type something and press Enter.
            // You can store the input in a string variable.
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            // TASK #4 : Now make it print out a greeting with the name
            // YOUR CODE HERE

            // If we want to make a really long string we can keep adding to it
            string longString = "This is a really long string. ";
            longString = longString + "Or at least it will be when we 're done with it. ";
            longString += "The += operator is a shorthand way of writing longString = longString + \"Some text\". ";
            longString += "That's probably enough for now.";

            // TASK #5 : Use the += operator to add to the longString variable
            // YOUR CODE HERE
            
            // TASK #6 : Write the longString variable to the console
            // YOUR CODE HERE

        }

    }
}
