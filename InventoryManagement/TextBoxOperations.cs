using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InventoryManagement
{
    internal class TextBoxOperations
    {
        public static string AdjustTextBoxNameValue(string str)
        {
            string result = string.Empty;
            bool newWord = true;

            for(int i = 0; i < str.Length; i++) 
            {
                if(newWord) 
                {
                    result += Char.ToUpper(str[i]);
                    newWord = false;
                }
                else
                {
                    result += Char.ToLower(str[i]);
                }
                if (str[i] == ' ') 
                {
                    newWord = true;
                }
                 
            }

            // Replace multiple spaces with a single space
            result = Regex.Replace(result, @"\s+", " ");
            return result;
        }
    }
}
