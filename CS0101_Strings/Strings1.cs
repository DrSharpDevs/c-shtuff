using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS0101_Strings
{
    internal partial class Program
    {
        private static void Strings1()
        {
            // This line writes output to the console.
            // TASK #1 : Replace "Hello, World!" with your name.
            Console.WriteLine("Hello, World!");


            // A string is a sequence of characters
            // We can store a strings in a variable, then print that
            // TASK #2 : Change myString to something else
            string myString = "Hello, World!";
            Console.WriteLine(myString);


            // We can also concatenate (join) strings by adding them together
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            // Even better, we can use string interpolation to insert variables into a string
            // Note how we don't have to 'declare' the fullName variable again
            fullName = $"{firstName} {lastName}";
            Console.WriteLine(fullName);

            // TASK #3 : Use one of the above techniques to complete the JoinStrings method below
            Console.WriteLine(JoinStrings(firstName, lastName));
        }

        #region JoinStrings Method
        /// Take two strings and join them together with a space in between
        /// </summary>
        /// <param name="string1">First string</param>
        /// <param name="string2">Second string</param>
        /// <returns>Joined strings</returns>
        static string JoinStrings(string string1, string string2)
        {
            // Task #3 : YOUR CODE HERE


            return "";
            // Task #3 : END
        }
        #endregion
    }
}
