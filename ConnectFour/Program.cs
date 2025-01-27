namespace ConnectFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connectFourGrid = new string[7, 7]
            {

                { "", "","","","","",""},
                { "", "","","","","",""},
                { "", "","","","","",""},
                { "", "","","","","",""},
                { "", "","","","","",""},
                { "", "","","","","",""},
                { "", "","","","","",""}

            };


            var shadowConnectFourGrid = new string[7, 7]
            {

                { "", "","","","","",""},
                { "", "","","","","",""},
                { "", "","","","","",""},
                { "", "","","","","",""},
                { "", "","","","","",""},
                { "", "","","","","",""},
                { "", "","","","","",""}

            };
            var player1Picks = new string[7, 7];


            Console.WriteLine(connectFourGrid[1, 5]);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("O");
            Console.ResetColor();
            int[] player1J = new int[7];
            bool wrong = true;
            bool wrong2 = true;
            int r = 0;
            bool gameWon = false;
            bool player1Turn = true;
            bool player2Turn = false;
            bool offTheGrid = true;
            int countA = 0;
            int countB = 0;
            int countC = 0;
            int countD = 0;
            int countE = 0;
            int countF = 0;
            int countG = 0;
            bool zeroSlot = false;
            int player1Count = 0;
            Console.WriteLine("This is connect four a two player game (Player 1 is red | Player 2 is yellow)");
            bool endGame = false;
            while (endGame == false)
            {

                for (int i = 0; i < shadowConnectFourGrid.GetLength(0); i++)
                {
                    Console.Write("|");
                    for (int j = 0; j < shadowConnectFourGrid.GetLength(0); j++)
                    {
                        if (connectFourGrid[i, j] == "X ")
                        {

                            shadowConnectFourGrid[i, j] = " O";
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(shadowConnectFourGrid[i, j]);
                            Console.ResetColor();
                            Console.Write(" |");

                        }
                        else if (connectFourGrid[i, j] == "0 ")
                        {
                            shadowConnectFourGrid[i, j] = " O";
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(shadowConnectFourGrid[i, j]);
                            Console.ResetColor();
                            Console.Write(" |");
                        }
                        else
                        {
                            Console.Write("   |");
                        }
                        r++;
                        if (r % 7 == 0)
                        {
                            Console.WriteLine();
                        }


                    }
                    
                }


                Console.ResetColor();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("  0   1   2   3   4   5   6 ");
                Console.WriteLine();
               
                if (player1Turn)
                {
                    Console.WriteLine("Player 1 its your turn choose a place in the grid");
                    string player1Pick = Console.ReadLine();
                    Console.Clear();
                    wrong = true;
                    if (player1Pick == "0")
                    {
                        wrong = false;
                        Console.WriteLine($"You have chosen {player1Pick}");
                        Console.WriteLine();


                        Console.ForegroundColor = ConsoleColor.Red;
                        connectFourGrid[6 - countA, 0] = "X ";
                        if (countA < 6)
                        {
                            countA += 1;
                            player2Turn = true;
                        }
                        else
                        {
                            Console.WriteLine("The 0 slot is full");
                            Console.WriteLine("Try again");
                        }


                        Console.ResetColor();

                    }
                    else if (player1Pick == "1")
                    {
                        wrong = false;
                        Console.WriteLine($"You have chosen {player1Pick}");
                        Console.WriteLine();


                        Console.ForegroundColor = ConsoleColor.Red;
                        connectFourGrid[6 - countB, 1] = "X ";
                        if (countB < 6)
                        {
                            countB += 1;
                            player2Turn = true;
                        }
                        else
                        {
                            Console.WriteLine("The 1 slot is full");
                            Console.WriteLine("Try again");
                        }
                        Console.ResetColor();

                    }
                    else if (player1Pick == "2")
                    {
                        wrong = false;
                        Console.WriteLine($"You have chosen {player1Pick}");
                        Console.WriteLine();


                        Console.ForegroundColor = ConsoleColor.Red;
                        connectFourGrid[6 - countC, 2] = "X ";
                        if (countC < 6)
                        {
                            countC += 1;
                            player2Turn = true;
                        }
                        else
                        {
                            Console.WriteLine("The 2 slot is full");
                            Console.WriteLine("Try again");
                        }
                        Console.ResetColor();

                    }
                    else if (player1Pick == "3")
                    {
                        wrong = false;
                        Console.WriteLine($"You have chosen {player1Pick}");
                        Console.WriteLine();


                        Console.ForegroundColor = ConsoleColor.Red;
                        connectFourGrid[6 - countD, 3] = "X ";
                        if (countD < 6)
                        {
                            countD += 1;
                            player2Turn = true;
                        }
                        else
                        {
                            Console.WriteLine("The 3 slot is full");
                            Console.WriteLine("Try again");
                        }

                        Console.ResetColor();

                    }
                    else if (player1Pick == "4")
                    {
                        wrong = false;
                        Console.WriteLine($"You have chosen {player1Pick}");
                        Console.WriteLine();


                        Console.ForegroundColor = ConsoleColor.Red;
                        connectFourGrid[6 - countE, 4] = "X ";
                        if (countE < 6)
                        {
                            countE += 1;
                            player2Turn = true;
                        }
                        else
                        {
                            Console.WriteLine("The 4 slot is full");
                            Console.WriteLine("Try again");
                        }
                        Console.ResetColor();

                    }
                    else if (player1Pick == "5")
                    {
                        wrong = false;
                        Console.WriteLine($"You have chosen {player1Pick}");
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.Red;
                        connectFourGrid[6 - countF, 5] = "X ";
                        if (countF < 6)
                        {
                            countF += 1;
                            player2Turn = true;
                        }
                        else
                        {
                            Console.WriteLine("The 5 slot is full");
                            Console.WriteLine("Try again");
                        }
                        Console.ResetColor();

                    }
                    else if (player1Pick == "6")
                    {
                        wrong = false;
                        Console.WriteLine($"You have chosen {player1Pick}");
                        Console.WriteLine();


                        Console.ForegroundColor = ConsoleColor.Red;
                        connectFourGrid[6 - countG, 6] = "X ";
                        if (countG < 6)
                        {
                            countG += 1;
                            player2Turn = true;
                        }
                        else
                        {
                            Console.WriteLine("The 6 slot is full");
                            Console.WriteLine("Try again");
                        }
                        Console.ResetColor();
                    }


                    if (wrong)
                    {
                        player2Turn = false;
                        Console.WriteLine("Its not on the grid");
                        Console.WriteLine("Try again player 1");
                    }


                }
                for (int i = 0; i < shadowConnectFourGrid.GetLength(0); i++)
                {
                    if (endGame == true)
                    {
                        break;
                    }
                    for (int j = 0; j < shadowConnectFourGrid.GetLength(0); j++)
                    {
                        if (endGame == true)
                        {
                            break;
                        }
                        if (connectFourGrid[i, j] == "X ")
                        {

                            if (i == 0 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "X " && connectFourGrid[i, j + 2] == "X " && connectFourGrid[i, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 0 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "X " && connectFourGrid[i, j - 2] == "X " && connectFourGrid[i, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 0 && j <= 3)
                            {
                                if (connectFourGrid[i + 1, j + 1] == "X " && connectFourGrid[i + 2, j + 2] == "X " && connectFourGrid[i + 3, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 0 && j >= 3)
                            {
                                if (connectFourGrid[i + 1, j - 1] == "X " && connectFourGrid[i + 2, j - 2] == "X " && connectFourGrid[i + 3, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 0)
                            {
                                if (connectFourGrid[i + 1, j] == "X " && connectFourGrid[i + 2, j] == "X " && connectFourGrid[i + 3, j] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }

                            if (i == 1 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "X " && connectFourGrid[i, j + 2] == "X " && connectFourGrid[i, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 1 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "X " && connectFourGrid[i, j - 2] == "X " && connectFourGrid[i, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 1 && j <= 3)
                            {
                                if (connectFourGrid[i + 1, j + 1] == "X " && connectFourGrid[i + 2, j + 2] == "X " && connectFourGrid[i + 3, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 1 && j >= 3)
                            {
                                if (connectFourGrid[i + 1, j - 1] == "X " && connectFourGrid[i + 2, j - 2] == "X " && connectFourGrid[i + 3, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 1)
                            {
                                if (connectFourGrid[i + 1, j] == "X " && connectFourGrid[i + 2, j] == "X " && connectFourGrid[i + 3, j] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }

                            if (i == 2 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "X " && connectFourGrid[i, j + 2] == "X " && connectFourGrid[i, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 2 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "X " && connectFourGrid[i, j - 2] == "X " && connectFourGrid[i, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 2 && j <= 3)
                            {
                                if (connectFourGrid[i + 1, j + 1] == "X " && connectFourGrid[i + 2, j + 2] == "X " && connectFourGrid[i + 3, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 2 && j >= 3)
                            {
                                if (connectFourGrid[i + 1, j - 1] == "X " && connectFourGrid[i + 2, j - 2] == "X " && connectFourGrid[i + 3, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 2)
                            {
                                if (connectFourGrid[i + 1, j] == "X " && connectFourGrid[i + 2, j] == "X " && connectFourGrid[i + 3, j] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 3 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "X " && connectFourGrid[i, j + 2] == "X " && connectFourGrid[i, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 3 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "X " && connectFourGrid[i, j - 2] == "X " && connectFourGrid[i, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 3 && j <= 3)
                            {
                                if (connectFourGrid[i + 1, j + 1] == "X " && connectFourGrid[i + 2, j + 2] == "X " && connectFourGrid[i + 3, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 3 && j >= 3)
                            {
                                if (connectFourGrid[i + 1, j - 1] == "X " && connectFourGrid[i + 2, j - 2] == "X " && connectFourGrid[i + 3, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 3)
                            {
                                if (connectFourGrid[i + 1, j] == "X " && connectFourGrid[i + 2, j] == "X " && connectFourGrid[i + 3, j] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 4 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "X " && connectFourGrid[i, j + 2] == "X " && connectFourGrid[i, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 4 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "X " && connectFourGrid[i, j - 2] == "X " && connectFourGrid[i, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 4 && j <= 3)
                            {
                                if (connectFourGrid[i - 1, j + 1] == "X " && connectFourGrid[i - 2, j + 2] == "X " && connectFourGrid[i - 3, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 4 && j >= 3)
                            {
                                if (connectFourGrid[i - 1, j - 1] == "X " && connectFourGrid[i - 2, j - 2] == "X " && connectFourGrid[i - 3, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 4)
                            {
                                if (connectFourGrid[i - 1, j] == "X " && connectFourGrid[i - 2, j] == "X " && connectFourGrid[i - 3, j] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 5 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "X " && connectFourGrid[i, j + 2] == "X " && connectFourGrid[i, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 5 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "X " && connectFourGrid[i, j - 2] == "X " && connectFourGrid[i, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 5 && j <= 3)
                            {
                                if (connectFourGrid[i - 1, j + 1] == "X " && connectFourGrid[i - 2, j + 2] == "X " && connectFourGrid[i - 3, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 5 && j >= 3)
                            {
                                if (connectFourGrid[i - 1, j - 1] == "X " && connectFourGrid[i - 2, j - 2] == "X " && connectFourGrid[i - 3, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 5)
                            {
                                if (connectFourGrid[i - 1, j] == "X " && connectFourGrid[i - 2, j] == "X " && connectFourGrid[i - 3, j] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 6 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "X " && connectFourGrid[i, j + 2] == "X " && connectFourGrid[i, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 6 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "X " && connectFourGrid[i, j - 2] == "X " && connectFourGrid[i, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 6 && j <= 3)
                            {
                                if (connectFourGrid[i - 1, j + 1] == "X " && connectFourGrid[i - 2, j + 2] == "X " && connectFourGrid[i - 3, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 6 && j >= 3)
                            {
                                if (connectFourGrid[i - 1, j - 1] == "X " && connectFourGrid[i - 2, j - 2] == "X " && connectFourGrid[i - 3, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 6)
                            {
                                if (connectFourGrid[i - 1, j] == "X " && connectFourGrid[i - 2, j] == "X " && connectFourGrid[i - 3, j] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                        }
                        if (connectFourGrid[i, j] == "0 ")
                        {
                            if (i == 0 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "0 " && connectFourGrid[i, j + 2] == "0 " && connectFourGrid[i, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 0 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "0 " && connectFourGrid[i, j - 2] == "0 " && connectFourGrid[i, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 0 && j <= 3)
                            {
                                if (connectFourGrid[i + 1, j + 1] == "0 " && connectFourGrid[i + 2, j + 2] == "0 " && connectFourGrid[i + 3, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 0 && j >= 3)
                            {
                                if (connectFourGrid[i + 1, j - 1] == "0 " && connectFourGrid[i + 2, j - 2] == "0 " && connectFourGrid[i + 3, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 0)
                            {
                                if (connectFourGrid[i + 1, j] == "0 " && connectFourGrid[i + 2, j] == "0 " && connectFourGrid[i + 3, j] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }

                            if (i == 1 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "0 " && connectFourGrid[i, j + 2] == "0 " && connectFourGrid[i, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 1 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "0 " && connectFourGrid[i, j - 2] == "0 " && connectFourGrid[i, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 1 && j <= 3)
                            {
                                if (connectFourGrid[i + 1, j + 1] == "0 " && connectFourGrid[i + 2, j + 2] == "0 " && connectFourGrid[i + 3, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 1 && j >= 3)
                            {
                                if (connectFourGrid[i + 1, j - 1] == "0 " && connectFourGrid[i + 2, j - 2] == "0 " && connectFourGrid[i + 3, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 1)
                            {
                                if (connectFourGrid[i + 1, j] == "0 " && connectFourGrid[i + 2, j] == "0 " && connectFourGrid[i + 3, j] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }

                            if (i == 2 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "0 " && connectFourGrid[i, j + 2] == "0 " && connectFourGrid[i, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 2 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "0 " && connectFourGrid[i, j - 2] == "0 " && connectFourGrid[i, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 2 && j <= 3)
                            {
                                if (connectFourGrid[i + 1, j + 1] == "0 " && connectFourGrid[i + 2, j + 2] == "0 " && connectFourGrid[i + 3, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 2 && j >= 3)
                            {
                                if (connectFourGrid[i + 1, j - 1] == "0 " && connectFourGrid[i + 2, j - 2] == "0 " && connectFourGrid[i + 3, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 2)
                            {
                                if (connectFourGrid[i + 1, j] == "0 " && connectFourGrid[i + 2, j] == "0 " && connectFourGrid[i + 3, j] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 3 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "0 " && connectFourGrid[i, j + 2] == "0 " && connectFourGrid[i, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 3 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "0 " && connectFourGrid[i, j - 2] == "0 " && connectFourGrid[i, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 3 && j <= 3)
                            {
                                if (connectFourGrid[i + 1, j + 1] == "0 " && connectFourGrid[i + 2, j + 2] == "0 " && connectFourGrid[i + 3, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 3 && j >= 3)
                            {
                                if (connectFourGrid[i + 1, j - 1] == "0 " && connectFourGrid[i + 2, j - 2] == "0 " && connectFourGrid[i + 3, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 3)
                            {
                                if (connectFourGrid[i + 1, j] == "0 " && connectFourGrid[i + 2, j] == "0 " && connectFourGrid[i + 3, j] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 4 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "0 " && connectFourGrid[i, j + 2] == "0 " && connectFourGrid[i, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 4 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "0 " && connectFourGrid[i, j - 2] == "0 " && connectFourGrid[i, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 4 && j <= 3)
                            {
                                if (connectFourGrid[i - 1, j + 1] == "0 " && connectFourGrid[i - 2, j + 2] == "0 " && connectFourGrid[i - 3, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 4 && j >= 3)
                            {
                                if (connectFourGrid[i - 1, j - 1] == "0 " && connectFourGrid[i - 2, j - 2] == "0 " && connectFourGrid[i - 3, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 4)
                            {
                                if (connectFourGrid[i - 1, j] == "0 " && connectFourGrid[i - 2, j] == "0 " && connectFourGrid[i - 3, j] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 5 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "0 " && connectFourGrid[i, j + 2] == "0 " && connectFourGrid[i, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 5 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "0 " && connectFourGrid[i, j - 2] == "0 " && connectFourGrid[i, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 5 && j <= 3)
                            {
                                if (connectFourGrid[i - 1, j + 1] == "0 " && connectFourGrid[i - 2, j + 2] == "0 " && connectFourGrid[i - 3, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 5 && j >= 3)
                            {
                                if (connectFourGrid[i - 1, j - 1] == "0 " && connectFourGrid[i - 2, j - 2] == "0 " && connectFourGrid[i - 3, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 5)
                            {
                                if (connectFourGrid[i - 1, j] == "0 " && connectFourGrid[i - 2, j] == "0 " && connectFourGrid[i - 3, j] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 6 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "0 " && connectFourGrid[i, j + 2] == "0 " && connectFourGrid[i, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 6 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "0 " && connectFourGrid[i, j - 2] == "0 " && connectFourGrid[i, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 6 && j <= 3)
                            {
                                if (connectFourGrid[i - 1, j + 1] == "0 " && connectFourGrid[i - 2, j + 2] == "0 " && connectFourGrid[i - 3, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 6 && j >= 3)
                            {
                                if (connectFourGrid[i - 1, j - 1] == "0 " && connectFourGrid[i - 2, j - 2] == "0 " && connectFourGrid[i - 3, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                            if (i == 6)
                            {
                                if (connectFourGrid[i - 1, j] == "0 " && connectFourGrid[i - 2, j] == "0 " && connectFourGrid[i - 3, j] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player2Turn = false;
                                    break;
                                }
                            }
                        }



                    }
                }


                for (int i = 0; i < shadowConnectFourGrid.GetLength(0); i++)
                {
                    Console.Write("|");
                    for (int j = 0; j < shadowConnectFourGrid.GetLength(0); j++)
                    {
                        if (connectFourGrid[i, j] == "X ")
                        {

                            shadowConnectFourGrid[i, j] = " O";
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(shadowConnectFourGrid[i, j]);
                            Console.ResetColor();
                            Console.Write(" |");

                        }
                        else if (connectFourGrid[i, j] == "0 ")
                        {
                            shadowConnectFourGrid[i, j] = " O";
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(shadowConnectFourGrid[i, j]);
                            Console.ResetColor();
                            Console.Write(" |");
                        }
                        else
                        {
                            Console.Write("   |");
                        }
                        r++;
                        if (r % 7 == 0)
                        {
                            Console.WriteLine();
                        }


                    }

                }
                Console.ResetColor();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("  0   1   2   3   4   5   6 ");
                Console.WriteLine();

                if (player2Turn)
                {
                    Console.WriteLine("Player 2 its your turn choose a place in the grid");
                    string player2Pick = Console.ReadLine();
                    Console.Clear();
                    wrong2 = true;
                    if (player2Pick == "0")
                    {
                        wrong2 = false;
                        Console.WriteLine($"You have chosen {player2Pick}");
                        Console.WriteLine();


                        Console.ForegroundColor = ConsoleColor.Red;
                        connectFourGrid[6 - countA, 0] = "0 ";
                        if (countA < 6)
                        {
                            countA += 1;
                            player1Turn = true;
                        }
                        else
                        {
                            Console.WriteLine("The 0 slot is full");
                            Console.WriteLine("Try again");
                        }
                      Console.ResetColor();




                    }

                    else if (player2Pick == "1")
                    {
                        wrong2 = false;
                        Console.WriteLine($"You have chosen {player2Pick}");
                        Console.WriteLine();


                        Console.ForegroundColor = ConsoleColor.Yellow;
                        connectFourGrid[6 - countB, 1] = "0 ";
                        if (countB < 6)
                        {
                            countB += 1;
                            player1Turn = true;
                        }
                        else
                        {
                            Console.WriteLine("The 1 slot is full");
                            Console.WriteLine("Try again");
                        }
                        Console.ResetColor();
                    }
                    else if (player2Pick == "2")
                    {
                        wrong2 = false;
                        Console.WriteLine($"You have chosen {player2Pick}");
                        Console.WriteLine();


                        Console.ForegroundColor = ConsoleColor.Yellow;
                        connectFourGrid[6 - countC, 2] = "0 ";
                        if (countC < 6)
                        {
                            countC += 1;
                            player1Turn = true;
                        }
                        else
                        {
                            Console.WriteLine("The 2 slot is full");
                            Console.WriteLine("Try again");
                        }
                        Console.ResetColor();
                    }
                    else if (player2Pick == "3")
                    {
                        wrong2 = false;
                        Console.WriteLine($"You have chosen {player2Pick}");
                        Console.WriteLine();


                        Console.ForegroundColor = ConsoleColor.Yellow;
                        connectFourGrid[6 - countD, 3] = "0 ";
                        if (countD < 6)
                        {
                            countD += 1;
                            player1Turn = true;
                        }
                        else
                        {
                            Console.WriteLine("The 3 slot is full");
                            Console.WriteLine("Try again");
                        }
                        Console.ResetColor();
                    }
                    else if (player2Pick == "4")
                    {
                        wrong2 = false;
                        Console.WriteLine($"You have chosen {player2Pick}");
                        Console.WriteLine();


                        Console.ForegroundColor = ConsoleColor.Red;
                        connectFourGrid[6 - countE, 4] = "0 ";
                        if (countE < 6)
                        {
                            countE += 1;
                            player1Turn = true;
                        }
                        else
                        {
                            Console.WriteLine("The 4 slot is full");
                            Console.WriteLine("Try again");
                        }
                        Console.ResetColor();
                    }
                    else if (player2Pick == "5")
                    {
                        wrong2 = false;
                        Console.WriteLine($"You have chosen {player2Pick}");
                        Console.WriteLine();


                        Console.ForegroundColor = ConsoleColor.Yellow;
                        connectFourGrid[6 - countF, 5] = "0 ";
                        if (countF < 6)
                        {
                            countF += 1;
                            player1Turn = true;
                        }
                        else
                        {
                            Console.WriteLine("The 5 slot is full");
                            Console.WriteLine("Try again");
                        }
                        Console.ResetColor();
                    }
                    else if (player2Pick == "6")
                    {
                        wrong2 = false;
                        Console.WriteLine($"You have chosen {player2Pick}");
                        Console.WriteLine();


                        Console.ForegroundColor = ConsoleColor.Yellow;
                        connectFourGrid[6 - countG, 6] = "0 ";
                        if (countG < 6)
                        {
                            countG += 1;
                            player1Turn = true;
                        }
                        else
                        {
                            Console.WriteLine("The 6 slot is full");
                            Console.WriteLine("Try again");
                        }
                        Console.ResetColor();
                    }

                    Console.ResetColor();

                }
                if (wrong2)
                {
                    player1Turn = false;
                    Console.WriteLine("Its not on the grid");
                    Console.WriteLine("Try again player 2");
                }
                for (int i = 0; i < shadowConnectFourGrid.GetLength(0); i++)
                {
                    if (endGame == true)
                    {
                        break;
                    }
                    for (int j = 0; j < shadowConnectFourGrid.GetLength(0); j++)
                    {
                        if (endGame == true)
                        {
                            break;
                        }
                        if (connectFourGrid[i, j] == "X ")
                        {

                            if (i == 0 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "X " && connectFourGrid[i, j + 2] == "X " && connectFourGrid[i, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 0 && j>=3)
                            {
                                if (connectFourGrid[i, j - 1] == "X " && connectFourGrid[i, j - 2] == "X " && connectFourGrid[i, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 0 && j <= 3 )
                            {
                                if (connectFourGrid[i + 1, j + 1] == "X " && connectFourGrid[i+2, j + 2] == "X " && connectFourGrid[i+3, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 0 && j >= 3)
                            {
                                if (connectFourGrid[i + 1, j - 1] == "X " && connectFourGrid[i + 2, j - 2] == "X " && connectFourGrid[i + 3, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 0)
                            {
                                if (connectFourGrid[i + 1,j] == "X " && connectFourGrid[i + 2, j] == "X " && connectFourGrid[i + 3, j] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }

                            if (i == 1 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "X " && connectFourGrid[i, j + 2] == "X " && connectFourGrid[i, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 1 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "X " && connectFourGrid[i, j - 2] == "X " && connectFourGrid[i, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 1 && j <= 3)
                            {
                                if (connectFourGrid[i + 1, j + 1] == "X " && connectFourGrid[i + 2, j + 2] == "X " && connectFourGrid[i + 3, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 1 && j >= 3)
                            {
                                if (connectFourGrid[i + 1, j - 1] == "X " && connectFourGrid[i + 2, j - 2] == "X " && connectFourGrid[i + 3, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 1)
                            {
                                if (connectFourGrid[i + 1, j] == "X " && connectFourGrid[i + 2, j] == "X " && connectFourGrid[i + 3, j] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }

                            if (i == 2 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "X " && connectFourGrid[i, j + 2] == "X " && connectFourGrid[i, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 2 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "X " && connectFourGrid[i, j - 2] == "X " && connectFourGrid[i, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 2 && j <= 3)
                            {
                                if (connectFourGrid[i + 1, j + 1] == "X " && connectFourGrid[i + 2, j + 2] == "X " && connectFourGrid[i + 3, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 2 && j >= 3)
                            {
                                if (connectFourGrid[i + 1, j - 1] == "X " && connectFourGrid[i + 2, j - 2] == "X " && connectFourGrid[i + 3, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 2)
                            {
                                if (connectFourGrid[i + 1, j] == "X " && connectFourGrid[i + 2, j] == "X " && connectFourGrid[i + 3, j] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 3 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "X " && connectFourGrid[i, j + 2] == "X " && connectFourGrid[i, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 3 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "X " && connectFourGrid[i, j - 2] == "X " && connectFourGrid[i, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 3 && j <= 3)
                            {
                                if (connectFourGrid[i + 1, j + 1] == "X " && connectFourGrid[i + 2, j + 2] == "X " && connectFourGrid[i + 3, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 3 && j >= 3)
                            {
                                if (connectFourGrid[i + 1, j - 1] == "X " && connectFourGrid[i + 2, j - 2] == "X " && connectFourGrid[i + 3, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 3)
                            {
                                if (connectFourGrid[i + 1, j] == "X " && connectFourGrid[i + 2, j] == "X " && connectFourGrid[i + 3, j] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 4 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "X " && connectFourGrid[i, j + 2] == "X " && connectFourGrid[i, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 4 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "X " && connectFourGrid[i, j - 2] == "X " && connectFourGrid[i, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 4 && j <= 3)
                            {
                                if (connectFourGrid[i - 1, j + 1] == "X " && connectFourGrid[i - 2, j + 2] == "X " && connectFourGrid[i - 3, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 4 && j >= 3)
                            {
                                if (connectFourGrid[i - 1, j - 1] == "X " && connectFourGrid[i - 2, j - 2] == "X " && connectFourGrid[i - 3, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 4)
                            {
                                if (connectFourGrid[i - 1, j] == "X " && connectFourGrid[i - 2, j] == "X " && connectFourGrid[i - 3, j] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 5 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "X " && connectFourGrid[i, j + 2] == "X " && connectFourGrid[i, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 5 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "X " && connectFourGrid[i, j - 2] == "X " && connectFourGrid[i, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 5 && j <= 3)
                            {
                                if (connectFourGrid[i - 1, j + 1] == "X " && connectFourGrid[i - 2, j + 2] == "X " && connectFourGrid[i - 3, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 5 && j >= 3)
                            {
                                if (connectFourGrid[i - 1, j - 1] == "X " && connectFourGrid[i - 2, j - 2] == "X " && connectFourGrid[i - 3, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 5)
                            {
                                if (connectFourGrid[i - 1, j] == "X " && connectFourGrid[i - 2, j] == "X " && connectFourGrid[i - 3, j] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 6 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "X " && connectFourGrid[i, j + 2] == "X " && connectFourGrid[i, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 6 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "X " && connectFourGrid[i, j - 2] == "X " && connectFourGrid[i, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 6 && j <= 3)
                            {
                                if (connectFourGrid[i - 1, j + 1] == "X " && connectFourGrid[i - 2, j + 2] == "X " && connectFourGrid[i - 3, j + 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 6 && j >= 3)
                            {
                                if (connectFourGrid[i - 1, j - 1] == "X " && connectFourGrid[i - 2, j - 2] == "X " && connectFourGrid[i - 3, j - 3] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 6)
                            {
                                if (connectFourGrid[i - 1, j] == "X " && connectFourGrid[i - 2, j] == "X " && connectFourGrid[i - 3, j] == "X ")
                                {
                                    Console.WriteLine("Player 1 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                        }
                        if (connectFourGrid[i, j] == "0 ")
                        {
                            if (i == 0 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "0 " && connectFourGrid[i, j + 2] == "0 " && connectFourGrid[i, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 0 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "0 " && connectFourGrid[i, j - 2] == "0 " && connectFourGrid[i, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 0 && j <= 3)
                            {
                                if (connectFourGrid[i + 1, j + 1] == "0 " && connectFourGrid[i + 2, j + 2] == "0 " && connectFourGrid[i + 3, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 0 && j >= 3)
                            {
                                if (connectFourGrid[i + 1, j - 1] == "0 " && connectFourGrid[i + 2, j - 2] == "0 " && connectFourGrid[i + 3, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 0)
                            {
                                if (connectFourGrid[i + 1, j] == "0 " && connectFourGrid[i + 2, j] == "0 " && connectFourGrid[i + 3, j] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }

                            if (i == 1 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "0 " && connectFourGrid[i, j + 2] == "0 " && connectFourGrid[i, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 1 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "0 " && connectFourGrid[i, j - 2] == "0 " && connectFourGrid[i, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 1 && j <= 3)
                            {
                                if (connectFourGrid[i + 1, j + 1] == "0 " && connectFourGrid[i + 2, j + 2] == "0 " && connectFourGrid[i + 3, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 1 && j >= 3)
                            {
                                if (connectFourGrid[i + 1, j - 1] == "0 " && connectFourGrid[i + 2, j - 2] == "0 " && connectFourGrid[i + 3, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 1)
                            {
                                if (connectFourGrid[i + 1, j] == "0 " && connectFourGrid[i + 2, j] == "0 " && connectFourGrid[i + 3, j] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }

                            if (i == 2 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "0 " && connectFourGrid[i, j + 2] == "0 " && connectFourGrid[i, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 2 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "0 " && connectFourGrid[i, j - 2] == "0 " && connectFourGrid[i, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 2 && j <= 3)
                            {
                                if (connectFourGrid[i + 1, j + 1] == "0 " && connectFourGrid[i + 2, j + 2] == "0 " && connectFourGrid[i + 3, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 2 && j >= 3)
                            {
                                if (connectFourGrid[i + 1, j - 1] == "0 " && connectFourGrid[i + 2, j - 2] == "0 " && connectFourGrid[i + 3, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 2)
                            {
                                if (connectFourGrid[i + 1, j] == "0 " && connectFourGrid[i + 2, j] == "0 " && connectFourGrid[i + 3, j] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 3 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "0 " && connectFourGrid[i, j + 2] == "0 " && connectFourGrid[i, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 3 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "0 " && connectFourGrid[i, j - 2] == "0 " && connectFourGrid[i, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 3 && j <= 3)
                            {
                                if (connectFourGrid[i + 1, j + 1] == "0 " && connectFourGrid[i + 2, j + 2] == "0 " && connectFourGrid[i + 3, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 3 && j >= 3)
                            {
                                if (connectFourGrid[i + 1, j - 1] == "0 " && connectFourGrid[i + 2, j - 2] == "0 " && connectFourGrid[i + 3, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 3)
                            {
                                if (connectFourGrid[i + 1, j] == "0 " && connectFourGrid[i + 2, j] == "0 " && connectFourGrid[i + 3, j] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 4 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "0 " && connectFourGrid[i, j + 2] == "0 " && connectFourGrid[i, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 4 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "0 " && connectFourGrid[i, j - 2] == "0 " && connectFourGrid[i, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 4 && j <= 3)
                            {
                                if (connectFourGrid[i - 1, j + 1] == "0 " && connectFourGrid[i - 2, j + 2] == "0 " && connectFourGrid[i - 3, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 4 && j >= 3)
                            {
                                if (connectFourGrid[i - 1, j - 1] == "0 " && connectFourGrid[i - 2, j - 2] == "0 " && connectFourGrid[i - 3, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 4)
                            {
                                if (connectFourGrid[i - 1, j] == "0 " && connectFourGrid[i - 2, j] == "0 " && connectFourGrid[i - 3, j] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 5 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "0 " && connectFourGrid[i, j + 2] == "0 " && connectFourGrid[i, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 5 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "0 " && connectFourGrid[i, j - 2] == "0 " && connectFourGrid[i, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 5 && j <= 3)
                            {
                                if (connectFourGrid[i - 1, j + 1] == "0 " && connectFourGrid[i - 2, j + 2] == "0 " && connectFourGrid[i - 3, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 5 && j >= 3)
                            {
                                if (connectFourGrid[i - 1, j - 1] == "0 " && connectFourGrid[i - 2, j - 2] == "0 " && connectFourGrid[i - 3, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 5)
                            {
                                if (connectFourGrid[i - 1, j] == "0 " && connectFourGrid[i - 2, j] == "0 " && connectFourGrid[i - 3, j] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 6 && j <= 3)
                            {
                                if (connectFourGrid[i, j + 1] == "0 " && connectFourGrid[i, j + 2] == "0 " && connectFourGrid[i, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 6 && j >= 3)
                            {
                                if (connectFourGrid[i, j - 1] == "0 " && connectFourGrid[i, j - 2] == "0 " && connectFourGrid[i, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 6 && j <= 3)
                            {
                                if (connectFourGrid[i - 1, j + 1] == "0 " && connectFourGrid[i - 2, j + 2] == "0 " && connectFourGrid[i - 3, j + 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 6 && j >= 3)
                            {
                                if (connectFourGrid[i - 1, j - 1] == "0 " && connectFourGrid[i - 2, j - 2] == "0 " && connectFourGrid[i - 3, j - 3] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                            if (i == 6)
                            {
                                if (connectFourGrid[i - 1, j] == "0 " && connectFourGrid[i - 2, j] == "0 " && connectFourGrid[i - 3, j] == "0 ")
                                {
                                    Console.WriteLine("Player 2 has won");
                                    endGame = true;
                                    player1Turn = false;
                                    break;
                                }
                            }
                        }



                    }
                }

                

            }







        }
    }
}

