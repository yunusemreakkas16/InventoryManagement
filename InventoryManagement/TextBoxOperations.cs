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
            // check null!
            if (str == null)
            {
                return null;
            }

            // Check if the length of the input string is greater than 50
            if (str.Length > 50)
            {
                // If it is, limit the string to 50 characters
                str = str.Substring(0, 50);
            }

            string result = string.Empty;
            bool newWord = true;

            for (int i = 0; i < str.Length; i++)
            {
                if (newWord)
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
        public static string AdjustTextBoxCharacterLimit(string str) 
        {
            if (str == null)
            {
                return null;
            }

            if (str.Length > 50)
            {
                // If it is, limit the string to 50 characters
                str = str.Substring(0, 50);
            }
            return str;
        }
        public static string AdjustTextBoxUpperCaseFirstCharacter(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }
            else
            {
                str = str.Substring(0, 1).ToUpper() + str.Substring(1);
                return str;
            }
        }
    }
}
