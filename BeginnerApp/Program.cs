using System;

namespace BeginnerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1 = " ", a2 = " ", a3 = " ", b1 = " ", b2 = " ", b3 = " ", c1 = " ", c2 = " ", c3 = " ";
            string userInput="";
            bool gameOver;
            string endOfGame = "";
            int turnCount;
            
            do
            {
                turnCount = 0;
                gameOver = false;
                PrintBoard(a1, a2, a3, b1, b2, b3, c1, c2, c3);

                while (!gameOver && userInput != "Q")
                {


                    Console.WriteLine("Player One, please enter a coordinate. Type 'Q' to quit the game");
                    userInput = Console.ReadLine().ToUpper();

                    bool repeatedValue = true;


                    while ((repeatedValue || !CheckForValidUserInput(userInput)) && userInput != "Q")
                    {
                        while (!CheckForValidUserInput(userInput))
                        {
                            Console.WriteLine("Invalid entry. Please try again. Enter a valid coordinate.");
                            userInput = Console.ReadLine().ToUpper();
                        }
                        while (repeatedValue)
                        {
                            if (userInput == "A1" && a1 == " ") { a1 = "X"; repeatedValue = false; }
                            if (userInput == "B1" && b1 == " ") { b1 = "X"; repeatedValue = false; }
                            if (userInput == "C1" && c1 == " ") { c1 = "X"; repeatedValue = false; }
                            if (userInput == "A2" && a2 == " ") { a2 = "X"; repeatedValue = false; }
                            if (userInput == "B2" && b2 == " ") { b2 = "X"; repeatedValue = false; }
                            if (userInput == "C2" && c2 == " ") { c2 = "X"; repeatedValue = false; }
                            if (userInput == "A3" && a3 == " ") { a3 = "X"; repeatedValue = false; }
                            if (userInput == "B3" && b3 == " ") { b3 = "X"; repeatedValue = false; }
                            if (userInput == "C3" && c3 == " ") { c3 = "X"; repeatedValue = false; }
                            if (repeatedValue == true)
                            {
                                Console.WriteLine("That space is already taken. Please try again.");
                                userInput = Console.ReadLine().ToUpper();
                            }
                        }

                    }

                    PrintBoard(a1, a2, a3, b1, b2, b3, c1, c2, c3);
                    gameOver = CheckForWin(a1, a2, a3, b1, b2, b3, c1, c2, c3);

                    Console.WriteLine("Player Two, please enter a coordinate. Type 'Q' to quit the game");
                    userInput = Console.ReadLine().ToUpper();

                    repeatedValue = true;


                    while ((repeatedValue || !CheckForValidUserInput(userInput))&& userInput!="Q") { 
                        while (!CheckForValidUserInput(userInput))
                        {
                            Console.WriteLine("Invalid entry. Please try again. Enter a valid coordinate.");
                            userInput = Console.ReadLine().ToUpper(); 
                        }
                        while (repeatedValue)
                        {
                            if (userInput == "A1" && a1 == " ") { a1 = "O"; repeatedValue = false; }
                            if (userInput == "B1" && b1 == " ") { b1 = "O"; repeatedValue = false; }
                            if (userInput == "C1" && c1 == " ") { c1 = "O"; repeatedValue = false; }
                            if (userInput == "A2" && a2 == " ") { a2 = "O"; repeatedValue = false; }
                            if (userInput == "B2" && b2 == " ") { b2 = "O"; repeatedValue = false; }
                            if (userInput == "C2" && c2 == " ") { c2 = "O"; repeatedValue = false; }
                            if (userInput == "A3" && a3 == " ") { a3 = "O"; repeatedValue = false; }
                            if (userInput == "B3" && b3 == " ") { b3 = "O"; repeatedValue = false; }
                            if (userInput == "C3" && c3 == " ") { c3 = "O"; repeatedValue = false; }
                            if (repeatedValue == true)
                            {
                                Console.WriteLine("That space is already taken. Please try again.");
                                userInput = Console.ReadLine().ToUpper();
                            }
                        }

                    } 

                    PrintBoard(a1, a2, a3, b1, b2, b3, c1, c2, c3);
                    gameOver = CheckForWin(a1, a2, a3, b1, b2, b3, c1, c2, c3);

                    turnCount++;

                    if(turnCount==9)
                    {
                        Console.WriteLine("It's a tie!!!");
                        Console.WriteLine("Game Over.");
                        userInput = "Q";
                    }
                }

                Console.WriteLine("This round is over! Play again? (Y/N)");
                endOfGame = Console.ReadLine().ToUpper();
                a1 = " "; a2 = " "; a3 = " "; b1 = " "; b2 = " "; b3 = " "; c1 = " "; c2 = " "; c3 = " ";
            } while (endOfGame != "N");
        }
        static void PrintBoard(string a1, string a2, string a3, string b1, string b2, string b3, string c1, string c2, string c3)
        {
            Console.WriteLine(" |--A--|--B--|--C--|");
            Console.WriteLine(" ___________________");
            Console.WriteLine(" |     |     |     |");
            Console.WriteLine("1| " + a1 + "   |  " + b1 + "  |  " + c1 + "  |");
            Console.WriteLine(" |     |     |     |");
            Console.WriteLine(" ___________________");
            Console.WriteLine(" |     |     |     |");
            Console.WriteLine("2| " + a2 + "   |  " + b2 + "  |  " + c2 + "  |");
            Console.WriteLine(" |     |     |     |");
            Console.WriteLine(" ___________________");
            Console.WriteLine(" |     |     |     |");
            Console.WriteLine("3| " + a3 + "   |  " + b3 + "  |  " + c3 + "  |");
            Console.WriteLine(" |     |     |     |");
        }
        static bool CheckForWin(string a1, string a2, string a3, string b1, string b2, string b3, string c1, string c2, string c3)
        {
            bool gameOver = false;
            string xORo = "";
            if (a1 == a2 && a2 == a3 && a1 != " ")
            {
                xORo = a1;
                gameOver = true;
            }
            if (b1 == b2 && b2 == b3 && b1 != " ")
            {
                xORo = b1;
                gameOver = true;
            }
            if (c1 == c2 && c2 == c3 && c1 != " ")
            {
                xORo = c1;
                gameOver = true;
            }
            if (a1 == b1 && b1 == c1 && c1 != " ")
            {
                xORo = a1;
                gameOver = true;
            }
            if (a2 == b2 && b2 == c2 && c2 != " ")
            {
                xORo = a2;
                gameOver = true;
            }
            if (a3 == b3 && b3 == c3 && c3 != " ")
            {
                xORo = a3;
                gameOver = true;
            }
            if (a1 == b2 && b2 == c3 && c3 != " ")
            {
                xORo = a1;
                gameOver = true;
            }
            if (c1 == b2 && b2 == a3 && a3 != " ")
            {
                xORo = c1;
                gameOver = true;
            }
            if(gameOver==true && xORo == "X")
            {
                Console.WriteLine("Player One Wins!!!");
            }
            if(gameOver==true && xORo== "O")
            {
                Console.WriteLine("Player Two Wins!!!");
            }
            return gameOver;
        }
        static bool CheckForValidUserInput(string userInput)
        {
            bool validUserInput = false;
            string values = "A1 A2 A3 B1 B2 B3 C1 C2 C3 Q";
            if (values.Contains(userInput))
            {
                validUserInput = true;
            }
            
            return validUserInput;
        }
    }
}
