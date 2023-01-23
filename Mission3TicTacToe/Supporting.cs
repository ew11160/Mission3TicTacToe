using System;
using System.Collections.Generic;
using System.Text;

namespace Mission3TicTacToe
{
    class Supporting // basically a file folder
    {
        // receive the board array from driver class
        // not sure if this is right. Make sure it receives the right array
        // also check our array numbers

        // method to print the board based on information passed
        public void printBoard(string[] arr) // on their end they pass us what we need
        {
            Console.WriteLine(" {0} | {1} | {2} ", arr[0], arr[1], arr[2]); // string parsing grabbing the three arguments following the string
            Console.WriteLine("-----------------");
            Console.WriteLine(" {0} | {1} | {2} ", arr[3], arr[4], arr[5]);
            Console.WriteLine("-----------------");
            Console.WriteLine(" {0} | {1} | {2} ", arr[6], arr[7], arr[8]);
        }

        // method that receives the game board array as input and returns if there is a winner and who it was

        // check for a winner or a draw
        // and end the while loop for the whole program
        public (string, bool) checkWinner(string[] arr, Boolean winner)
        {
            winner = true; 
            if (arr[0] == arr[1] && arr[1] == arr[2])
            {
                return ("You're the winner!", winner);
            }
            else if (arr[3] == arr[4] && arr[4] == arr[5])
            {
                return ("Winner do a funky dance", winner);
            }
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return ("Winner take a bow!", winner);
            }
            else if (arr[0] == arr[3] && arr[3] == arr[6])
            {
                return ("Congratulations, you won!", winner);
            }
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return ("Winner winner chicken dinner", winner);
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return ("Champion!", winner);
            }
            else if (arr[0] == arr[4] && arr[4] == arr[8])
            {
                return ("High Five! You won!", winner);
            }
            else if (arr[2] == arr[4] && arr[4] == arr[6])
            {
                return ("You hit the jackpot!", winner);
            }
            else if (arr[0] != "1" && arr[1] != "2" && arr[2] != "3" && arr[3] != "4" && arr[4] != "5" && arr[5] != "6" && arr[6] != "7" && arr[7] != "8" && arr[8] != "9")
            {
                return ("It's a draw", winner);
            }
            else
            {
                winner = false;
                return ("Make your next move", winner);
            }
        }
            
    }
}
