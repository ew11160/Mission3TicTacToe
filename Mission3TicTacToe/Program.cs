using System;

namespace Mission3TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine("Player 1 is X, Player 2 is O");

            int[] choices = new int[9];
            
            for (i = 0; i < 9; i++) 
            {
                int position = 0;
                if (i % 2 == 1)
                {
                    Console.WriteLine("Player 1, pick a position: ");
                    position = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Player 2, pick a position");
                    position = Console.ReadLine();
                }
            }
        }
    }
}
