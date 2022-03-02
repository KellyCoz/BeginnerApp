using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerApp
{
    public class Player
    {

        public string firstName;
        public int sessionScore;
        public int currentScore;
        string playerMarker;
        
        public Player(string name, int total, int score, string marker)
        {
            firstName = name;
            sessionScore = total;
            currentScore = score;
            playerMarker = marker;
        }
        public int CalculateSessionScore
        {
            get
            {
                sessionScore += currentScore;
                return sessionScore;
            }
        }

        public static bool CheckForRepeat(string userInput, string a1, string a2, string a3, string b1, string b2, string b3, string c1, string c2, string c3)
        {
            bool repeat = true;

            if ((userInput == "A1" && a1 == " ") || (userInput == "B1" && b1 == " ") || (userInput == "C1" && c1 == " ")
                || (userInput == "A2" && a2 == " ") || (userInput == "B2" && b2 == " ") || (userInput == "C2" && c2 == " ")
                || (userInput == "A3" && a3 == " ") || (userInput == "B3" && b3 == " ") || (userInput == "C3" && c3 == " "))
            {
                repeat = false;
            }
            return repeat;
        }
        public static void PrintStats()
        {
            Console.WriteLine("{firstName} scored {sessionScore} points!");
        }
    }
}
