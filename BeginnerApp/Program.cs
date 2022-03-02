using System;

namespace BeginnerApp
{
    class Program
    {
        static void Main()
        {
            string userInput="";
            bool gameOver;
            string endOfGame;
            int turnCount;
            string a1 = " ", a2 = " ", a3 = " ", b1 = " ", b2 = " ", b3 = " ", c1 = " ", c2 = " ", c3 = " ";
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("**************************");
            Console.WriteLine("*                        *");
            Console.WriteLine("* LET'S PLAY TIC TAC TOE *");
            Console.WriteLine("*                        *");
            Console.WriteLine("**************************");
            Console.ForegroundColor = ConsoleColor.White;
            
            do
            {
                turnCount = 0;
                gameOver = false;

                //PrintBoard(a1, a2, a3, b1, b2, b3, c1, c2, c3);
                while (!gameOver && userInput != "Q")
                {
                    bool playerOneTurn = true;
                    
                    Console.WriteLine("\nPlayer One, please enter a coordinate. \nType 'Q' to quit the game\n");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    PrintBoard(a1, a2, a3, b1, b2, b3, c1, c2, c3);
                    Console.ForegroundColor = ConsoleColor.White;
                    userInput = Console.ReadLine().ToUpper();

                    do
                    {
                        if (Validations.CheckForValidUserInput(userInput))
                        {
                            if (!Validations.CheckForRepeat(userInput, a1, a2, a3, b1, b2, b3, c1, c2, c3))
                            {
                                PlayerOne.AssignXValues(userInput, ref a1, ref a2, ref a3, ref b1, ref b2, ref b3, ref c1, ref c2, ref c3);
                                //Console.ForegroundColor = ConsoleColor.DarkRed;
                                //PrintBoard(a1, a2, a3, b1, b2, b3, c1, c2, c3);
                                Console.ForegroundColor = ConsoleColor.White;
                                if (!Validations.CheckForWin(a1, a2, a3, b1, b2, b3, c1, c2, c3, ref gameOver))
                                {
                                    gameOver = false;
                                    playerOneTurn = false;
                                }
                                else
                                {
                                    Console.WriteLine("Player One Wins!!!");
                                    gameOver = true;
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Player One, that space is already taken. Please try again.");
                                userInput = Console.ReadLine().ToUpper();
                            } 
                        }
                        else
                        {
                            Console.WriteLine("Player One, invalid entry. Please try again. Enter a valid coordinate.");
                            userInput = Console.ReadLine().ToUpper();
                        }
                    } while (playerOneTurn && userInput != "Q" && !gameOver) ;

                    turnCount++;

                    if (turnCount == 9 && !gameOver)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        PrintBoard(a1, a2, a3, b1, b2, b3, c1, c2, c3);
                        Console.WriteLine("It's a tie!!!");
                        Console.WriteLine("Game Over.");
                        a1 = " "; a2 = " "; a3 = " "; b1 = " "; b2 = " "; b3 = " "; c1 = " "; c2 = " "; c3 = " ";
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                    else if (userInput != "Q" && !gameOver)
                    {
                        Console.WriteLine("Player Two, please enter a coordinate. \nType 'Q' to quit the game\n");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        PrintBoard(a1, a2, a3, b1, b2, b3, c1, c2, c3);
                        Console.ForegroundColor = ConsoleColor.White;
                        userInput = Console.ReadLine().ToUpper();

                        do
                        {
                            if (Validations.CheckForValidUserInput(userInput))
                            {
                                if (!Validations.CheckForRepeat(userInput, a1, a2, a3, b1, b2, b3, c1, c2, c3))
                                {
                                    PlayerTwo.AssignYValues(userInput, ref a1, ref a2, ref a3, ref b1, ref b2, ref b3, ref c1, ref c2, ref c3);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    if (!Validations.CheckForWin(a1, a2, a3, b1, b2, b3, c1, c2, c3, ref gameOver))
                                    {
                                        gameOver = false;
                                        playerOneTurn = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Player Two Wins!!!");
                                        gameOver = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("PlayerTwo, that space is already taken. Please try again.");
                                    userInput = Console.ReadLine().ToUpper();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Player Two, invalid entry. Please try again. Enter a valid coordinate.");
                                userInput = Console.ReadLine().ToUpper();
                            }
                        } while (!playerOneTurn && userInput != "Q");

                        turnCount++;
                    }
                }
                if(userInput!="Q")
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    PrintBoard(a1, a2, a3, b1, b2, b3, c1, c2, c3);
                }
                Console.WriteLine("This round is over! Play again? (Y/N)");
                endOfGame = Console.ReadLine().ToUpper();
                userInput = "";
                a1 = " "; a2 = " "; a3 = " "; b1 = " "; b2 = " "; b3 = " "; c1 = " "; c2 = " "; c3 = " ";
            } while (endOfGame != "N");
        }
        static void PrintBoard(string a1, string a2, string a3, string b1, string b2, string b3, string c1, string c2, string c3)
        {
            Console.WriteLine("    |--A--|--B--|--C--|");
            Console.WriteLine("    ___________________");
            Console.WriteLine("    |     |     |     |");
            Console.WriteLine("   1| " + a1 + "   |  " + b1 + "  |  " + c1 + "  |");
            Console.WriteLine("    |     |     |     |");
            Console.WriteLine("    ___________________");
            Console.WriteLine("    |     |     |     |");
            Console.WriteLine("   2| " + a2 + "   |  " + b2 + "  |  " + c2 + "  |");
            Console.WriteLine("    |     |     |     |");
            Console.WriteLine("    ___________________");
            Console.WriteLine("    |     |     |     |");
            Console.WriteLine("   3| " + a3 + "   |  " + b3 + "  |  " + c3 + "  |");
            Console.WriteLine("    |     |     |     |");
        }
    }
}
