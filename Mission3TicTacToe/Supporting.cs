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
        string[] arr;

        // method to print the board based on information passed
        public void printBoard()
        {
            Console.WriteLine(" {0} | {1} | {2} ", arr[1], arr[2], arr[3]);
            Console.WriteLine("-----------------");
            Console.WriteLine(" {0} | {1} | {2} ", arr[4], arr[5], arr[6]);
            Console.WriteLine("-----------------");
            Console.WriteLine(" {0} | {1} | {2} ", arr[7], arr[8], arr[9]);
        }

        // method that receives the game board array as input and returns if there is a winner and who it was

        // check for a winner or a draw
        public string checkWinner()
        {
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return ("You're the winner!");
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return ("winer");
            }
            else if (arr[7] == arr[8] && arr[8] == arr[9])
            {
                return ("winer");
            }
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return ("winer");
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return ("winer");
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return ("winer");
            }
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return ("winer");
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return ("winer");
            }
            else if (arr[1] != "1" && arr[2] != "2" && arr[3] != "3" && arr[4] != "4" && arr[5] != "5" && arr[6] != "6" && arr[7] != "7" && arr[8] != "8" && arr[9] != "9") ;
            {
                return ("It's a draw");
            }
            // tell the function to keep playing
        }
            
    }
}
