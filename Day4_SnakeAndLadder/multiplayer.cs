using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_SnakeAndLadder
{
    class SecondPlayer
    {
        public void Player2()
        {
            {
                int First_player = 0;
                int Second_player = 0;
                int Win_position = 100;
                int DiceRolled = 0;
                Random random = new Random();
                int Player1 = random.Next(0, 1);
                while (First_player < Win_position && Second_player < Win_position)
                {
                    if (Player1 == 0)
                    {

                        int DicePlayer1 = random.Next(1, 6);
                        int turn = random.Next(0, 2);

                        switch (turn)
                        {
                            case 0:
                                Console.WriteLine("NO PLAY");
                                break;

                            case 1:
                                First_player += DicePlayer1;
                                Console.WriteLine("Ladder" + First_player);
                                if (First_player > 100)
                                {
                                    First_player -= DicePlayer1;
                                }
                                break;

                            default:
                                First_player -= DicePlayer1;
                                Console.WriteLine("Snake" + First_player);
                                if (First_player < 0)
                                {
                                    First_player = 0;
                                }
                                break;
                        }
                        DiceRolled++;
                        Console.Write("Total Number of Dice Rolled: " + DiceRolled);
                    }



                    else
                    {
                        int DicePlayer2 = random.Next(1, 6);
                        int turn = random.Next(0, 2);
                        switch (turn)
                        {
                            case 0:
                                Console.WriteLine("NO PLAY");
                                break;

                            case 1:
                                Second_player += DicePlayer2;
                                Console.WriteLine("Ladder" + Second_player);
                                if (Second_player > 100)
                                {
                                    Second_player -= DicePlayer2;
                                }
                                break;

                            default:
                                Second_player -= DicePlayer2;
                                Console.WriteLine("Snake" + Second_player);
                                if (Second_player < 0)
                                {
                                    Second_player = 0;
                                }
                                break;
                        }
                        DiceRolled++;
                        Console.Write("Number of times dice rolled: " + DiceRolled);
                    }

                }
                if (First_player == Win_position)
                    Console.WriteLine("\nFirst Player wins");
                else
                    Console.WriteLine("\nSecond Player wins");
            }
        }
    }
}