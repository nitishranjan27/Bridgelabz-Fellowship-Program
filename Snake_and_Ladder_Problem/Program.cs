
using System;
using SnakeLadderGame;

namespace Snake_and_Ladder_Problem

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Board size?");
            int boardsize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of players?");
            int players = Convert.ToInt32(Console.ReadLine());
            Game g = new(boardsize, players);
            g.Play();
        }
    }
}