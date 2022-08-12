using System;
namespace Day4_SnakeAndLadder
{
    class FirstPlayer
    {
        public void Player1()
        {
            int player = 0;
            int Win_position = 100;
            int DiceRolled = 0;
            Random random = new Random();
            int Player1 = random.Next(0, 1);
            while (player < Win_position)
            {
                int DiceNumber = random.Next(1, 6);
                int turn = random.Next(0, 2);

                switch (turn)
                {
                    case 0:
                        Console.WriteLine("NO PLAY");
                        break;

                    case 1:
                        player += DiceNumber;
                        Console.WriteLine("Ladder" + player);
                        if (player > 100)
                        {
                            player -= DiceNumber;
                        }
                        break;

                    default:
                        player -= DiceNumber;
                        Console.WriteLine("Snake" + player);
                        if (player < 0)
                        {
                            player = 0;
                        }
                        break;
                }
                DiceRolled++;
                Console.Write("Total Number of Dice Rolled: " + DiceRolled);
            }
            Console.WriteLine("\n You wins");
        }
    }
}