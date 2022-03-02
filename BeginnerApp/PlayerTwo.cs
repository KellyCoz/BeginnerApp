using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerApp
{
    class PlayerTwo : Player
    {
        public PlayerTwo(string name, int total, int score, string marker = "y") : base(name, total, score, marker)
        {
        }
        public static void AssignYValues(string userInput, ref string a1, ref string a2, ref string a3, ref string b1, ref string b2,
            ref string b3, ref string c1, ref string c2, ref string c3)
        {

            switch (userInput)
            {
                case "A1":
                    a1 = "Y";
                    break;
                case "A2":
                    a2 = "Y";
                    break;
                case "A3":
                    a3 = "Y";
                    break;
                case "B1":
                    b1 = "Y";
                    break;
                case "B2":
                    b2 = "Y";
                    break;
                case "B3":
                    b3 = "Y";
                    break;
                case "C1":
                    c1 = "Y";
                    break;
                case "C2":
                    c2 = "Y";
                    break;
                case "C3":
                    c3 = "Y";
                    break;
            }
        }
    }
}
