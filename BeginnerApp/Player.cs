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
        public string playerMarker;
        
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
        public static void PrintStats()
        {
            Console.WriteLine("{firstName} scored {sessionScore} points!");
        }
    }
}
