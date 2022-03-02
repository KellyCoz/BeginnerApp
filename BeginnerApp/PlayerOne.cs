using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerApp
{
   public class PlayerOne : Player
    {   
        public PlayerOne(string name, int total, int score, string marker="x") : base(name, total, score, marker)
        {  
        }
        public static void AssignXValues(string userInput, ref string a1, ref string a2, ref string a3, ref string b1, ref string b2, 
            ref string b3, ref string c1, ref string c2, ref string c3)
        {
            
            switch (userInput)
            {
                case "A1":
                    a1 = "X";
                    break;
                case "A2":
                    a2 = "X";
                    break;
                case "A3":
                    a3 = "X";
                    break;
                case "B1":
                    b1 = "X";
                    break;
                case "B2":
                    b2 = "X";
                    break;
                case "B3":
                    b3 = "X";
                    break;
                case "C1":
                    c1 = "X";
                    break;
                case "C2":
                    c2 = "X";
                    break;
                case "C3":
                    c3 = "X";
                    break;
            }
        }
    }
}
