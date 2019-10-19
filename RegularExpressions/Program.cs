using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        #region 1
        static bool IsEmail(string email)
        {
            string[] parts = email.Split('@');
            if(parts.Length != 2)
            {
                return false;
            }

            if(IsAlphaNumeric(parts[0]) == false)
            {
                return false;
            }

            parts = parts[1].Split('.');
            if(parts.Length == 1)
            {
                return false;
            }

            foreach(string part in parts)
            {
                if(IsAlphaNumeric(part) == false)
                {
                    return false;
                }
            }

            return true;
        }

        static bool IsAlphaNumeric(string text)
        {
            foreach(char ch in text)
            {
                if(char.IsLetterOrDigit(ch) == false)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region 2

        static bool IsEmail2(string email)
        {
            Regex regex = 
                new Regex(@"^(([0-9a-zA-Z]+)@([a-zA-z]+)(\.[a-zA-z]+)){1,}$");

            return regex.IsMatch(email);
        }

        #endregion

        static void Main(string[] args)
        {
            //
            string email = "test@test.com";
            Console.WriteLine(IsEmail2(email));

            string txt = "Hello, World! Welcome to my world!";

            Regex regex = new Regex("world", RegexOptions.IgnoreCase);
            string result = regex.Replace(txt, funcMatch);

            Console.WriteLine(result);
            //

            Regex rx = new Regex(@"\b(?<ttt>\w+)\s+(\k<ttt>)\b",
  RegexOptions.Compiled | RegexOptions.IgnoreCase);

            // Define a test string.        
            string text = "The the quick brown fox  fox jumps over the lazy dog dog epe epe.";

            // Find matches.
            MatchCollection matches = rx.Matches(text);

            // Report the number of matches found.
            Console.WriteLine("{0} matches found in:\n   {1}",
                              matches.Count,
                              text);

            // Report on each match.
            foreach (Match match in matches)
            {
                GroupCollection groups = match.Groups;
                Console.WriteLine("'{0}' repeated at positions {1} and {2}",
                                  groups["ttt"].Value,
                                  groups[0].Index,
                                  groups[1].Index);
            }
        }

        static string funcMatch(Match match)
        {
            return "Universe";
        }
    }
}
