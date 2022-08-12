using Day4_SnakeAndLadder;
using Day4_SnakeAndLedder;
using System;

namespace Day4_SnakeAndLedder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake & ladder Game");
            Console.WriteLine("1 for SinglePlayer");
            Console.WriteLine("2 For Multiplayers");

            int turn = Convert.ToInt32(Console.ReadLine());

            switch (turn)
            {

                case 1:
                    FirstPlayer singlePlayer = new FirstPlayer();
                    singlePlayer.Player1();
                    break;
                case 2:
                    SecondPlayer multiplayer = new SecondPlayer();
                    multiplayer.Player2();
                    break;
            }
        }
    }
}