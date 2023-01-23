/*2. Divide your tic-tac-toe game into functions and classes according to functionality
 * (e.g., separate class form game mechanics and separate class for displaying).*/

using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
namespace Classes_Separation

{
    class Classes_Separation

    {
        public static void Main(string[] args)
        {
            Console.WriteLine("<TicTacToe Game> \n");
            Console.WriteLine("Welcome to the main menu: \na) New game. \nb) About the author. \nc) Exit.\n");
            Console.WriteLine("Choose from the options mentioned above: ");
            Mechanics mechanics = new Mechanics();
        }

    }
}