using System;
using System.Text.RegularExpressions;

namespace BeginnerApp
{
    public class Validations
    {
        public static bool CheckForWin(string a1, string a2, string a3, string b1, string b2, string b3, string c1, string c2, string c3, ref bool gameOver)
        {
            //bool gameOver = false;
            string xORo = "";
            if (a1 == a2 && a2 == a3 && a1 != " ")
            {
                xORo = a1;
                gameOver = true;
            }
            else if (b1 == b2 && b2 == b3 && b1 != " ")
            {
                xORo = b1;
                gameOver = true;
            }
            else if (c1 == c2 && c2 == c3 && c1 != " ")
            {
                xORo = c1;
                gameOver = true;
            }
            else if (a1 == b1 && b1 == c1 && c1 != " ")
            {
                xORo = a1;
                gameOver = true;
            }
            else if (a2 == b2 && b2 == c2 && c2 != " ")
            {
                xORo = a2;
                gameOver = true;
            }
            else if (a3 == b3 && b3 == c3 && c3 != " ")
            {
                xORo = a3;
                gameOver = true;
            }
            else if (a1 == b2 && b2 == c3 && c3 != " ")
            {
                xORo = a1;
                gameOver = true;
            }
            else if (c1 == b2 && b2 == a3 && a3 != " ")
            {
                xORo = c1;
                gameOver = true;
            }
            if (gameOver == true && xORo == "X")
            {
                Console.WriteLine("Player One Wins!!!");
            }
            else if (gameOver == true && xORo == "O")
            {
                Console.WriteLine("Player Two Wins!!!");
            }
            return gameOver;
        }
        public static bool CheckForValidUserInput(string userInput)
        {
            string pattern = @"(A|B|C)(1|2|3)";
            Regex regex = new(pattern);
            return regex.IsMatch(userInput);

        }
    }
}
