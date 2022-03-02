using System;
using System.Text.RegularExpressions;

namespace BeginnerApp
{
    public class Validations
    {
        public static bool CheckForWin(string a1, string a2, string a3, string b1, string b2, string b3, string c1, string c2, string c3, ref bool gameOver)
        {
            if ((a1 == a2 && a2 == a3 && a1 != " ")|| (b1 == b2 && b2 == b3 && b1 != " ") || (c1 == c2 && c2 == c3 && c1 != " ")
                    || (a1 == b1 && b1 == c1 && c1 != " ") || (a2 == b2 && b2 == c2 && c2 != " ") || (a3 == b3 && b3 == c3 && c3 != " ") 
                    || (a1 == b2 && b2 == c3 && c3 != " ") || (c1 == b2 && b2 == a3 && a3 != " "))
          
            {
                gameOver = true;
            }
            
            return gameOver;
        }
        public static bool CheckForValidUserInput(string userInput)
        {
            string pattern = @"(A|B|C)(1|2|3)||Q";
            Regex regex = new(pattern);
           
            return regex.IsMatch(userInput);

        }
        public static bool CheckForRepeat(string userInput, string a1, string a2, string a3, string b1, string b2, string b3, string c1, string c2, string c3)
        {
            bool repeat = true;

            if ((userInput == "A1" && a1 == " ") || (userInput == "B1" && b1 == " ") || (userInput == "C1" && c1 == " ")
                || (userInput == "A2" && a2 == " ") || (userInput == "B2" && b2 == " ") || (userInput == "C2" && c2 == " ")
                || (userInput == "A3" && a3 == " ") || (userInput == "B3" && b3 == " ") || (userInput == "C3" && c3 == " ")||userInput=="Q")
            {
                repeat = false;
            }
            return repeat;
        }
    }
}
