using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace GroceryStore2
{
    internal class InputValidator
    {
        public static bool checkIfEmpty(string? userInput)
        {
            if (userInput == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool checkIfEmpty(int? userInput)
        {
            if (userInput == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ContainsDigits(string input)
        {
            bool isMatch = Regex.IsMatch(input, @"\d");
            if ( isMatch)
            {
                return true;
            } else
            {
                MessageBox.Show("Please enter a valid input for price!");
                return false;
            }
        }

    }
}
