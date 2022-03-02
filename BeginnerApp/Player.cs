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
        public double winPercentage;
        public int totalGames;
        public string playerMarker;
        
        public Player(string name, int total, int score, string marker)
        {
            firstName = name;
            sessionScore = score;
            totalGames = total;
            playerMarker = marker;
        }
        public double CalculateGameStats
        {
            get
            {
                winPercentage = sessionScore/totalGames*100;
                return winPercentage;
            }
        }
        public static void PrintStats()
        {
            Console.WriteLine("{firstName} scored {sessionScore} points!");
        }
    }
}
