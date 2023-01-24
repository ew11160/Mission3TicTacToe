using System;

namespace Mission3TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine("Player 1 is X, Player 2 is O");
            Console.WriteLine();

            string[] choices = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Boolean winner = false;
            int i = 0;

            // Print Initial Board Here
            Supporting support = new Supporting();
            support.printBoard(choices);

            while (winner == false)
            {
                int position = 0;

                if (i % 2 == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Player 2, pick a position: ");
                    position = Convert.ToInt32(Console.ReadLine());

                    choices[position-1] = "O";
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Player 1, pick a position: ");
                    position = Convert.ToInt32(Console.ReadLine());

                    choices[position-1] = "X";
                }

                i = i + 1; // Incremenent Counter

                // Print Board Here
                Console.WriteLine();
                support.printBoard(choices);

                // Print Winner
                (string nextPlay, bool isWinner) = support.checkWinner(choices,winner);
                Console.WriteLine(nextPlay);
                winner = isWinner;
            }
        }
    }
}

