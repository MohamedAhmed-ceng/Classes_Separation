using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Separation
{
    internal class Mechanics
    {
        public int player=1;
        public int choice;
        public int endGameCondidition=0;
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public Mechanics()
        {
            string input1 = Console.ReadLine();
            if (input1 == "a")
            {
                do
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Player1: X and Player2: O");
                    Console.WriteLine("\n");
                    if (player % 2 == 0)
                    {
                        Console.WriteLine("Player 2 turn");
                    }
                    else
                    {
                        Console.WriteLine("Player 1 turn");
                    }
                    Console.WriteLine("\n");

                    Display display = new Display();

                    try
                    {
                        choice = int.Parse(Console.ReadLine());
                        if (arr[choice] != 'X' && arr[choice] != 'O')
                        {
                            if (player % 2 == 0)
                            {
                                arr[choice] = 'O';
                                player++;
                            }
                            else
                            {
                                arr[choice] = 'X';
                                player++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nNot allowed! The square {0} is already reserved for {1}", choice, arr[choice]);
                            Console.WriteLine("\n");
                        }
                        endGameCondidition = CheckWin();
                    }
                    catch
                    {
                        Console.WriteLine("\nPlease insert a valid number between 1 and 9");
                        Console.WriteLine("\n");
                    }
                    finally
                    {
                        CheckWin();
                    }
                }
                while (endGameCondidition != 1 && endGameCondidition != -1);

                Display board = new Display();

                if (endGameCondidition == 1)
                {
                    Console.WriteLine("\nPlayer {0} is the winner!", (player % 2) + 1);
                }
                else
                {
                    Console.WriteLine("\nDraw Match");
                }
                Console.ReadLine();
            }
            else if (input1 == "b")
            {
                Console.WriteLine("\nThe programmer of this simple game is Mohamed Ahmed");
            }
            else
            {
                Console.WriteLine("\nAre you sure you want to quit? [y/n]");
                string input2 = Console.ReadLine();
                if (input2 == "y")
                {
                    Console.WriteLine("\nThe program is closing. Thank you for your time.");
                }
                else
                {
                    Console.WriteLine("\nWelcome Back!");
                }
            }
            static int CheckWin()
            {
                if (arr[1] == arr[2] && arr[2] == arr[3])
                {
                    return 1;
                }
                else if (arr[4] == arr[5] && arr[5] == arr[6])
                {
                    return 1;
                }
                else if (arr[6] == arr[7] && arr[7] == arr[8])
                {
                    return 1;
                }
                else if (arr[1] == arr[4] && arr[4] == arr[7])
                {
                    return 1;
                }
                else if (arr[2] == arr[5] && arr[5] == arr[8])
                {
                    return 1;
                }
                else if (arr[3] == arr[6] && arr[6] == arr[9])
                {
                    return 1;
                }
                else if (arr[1] == arr[5] && arr[5] == arr[9])
                {
                    return 1;
                }
                else if (arr[3] == arr[5] && arr[5] == arr[7])
                {
                    return 1;
                }
                else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4'&& arr[5] != '5'
                                       && arr[6] != '6'&& arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
