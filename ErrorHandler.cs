using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace GroceryStore2
{
    internal class ErrorHandler
    {

        public static bool checkIfInt(string userInput)
        {
            try
            {
                Convert.ToInt32(userInput);
                return true;
            } 
            catch(Exception ex) {
                return false;
            }
        }

        

    }
}
