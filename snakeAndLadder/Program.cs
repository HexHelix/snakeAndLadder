using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 playerOnePos = 0;
            Int32 playerTwoPos = 0;
            bool currentPlayer = true;
            Int32 RoundsPlayed = 0;
            Console.WriteLine("Welcome Player to Snake And Ladder");
            
            while(playerOnePos != 100 || playerTwoPos != 100)
            {

                if (currentPlayer)
                {
                    Console.WriteLine("Player 1, Press enter key to roll dice");
                    Console.ReadLine();
                    int dice = DiceRoll();

                    Console.WriteLine(dice + " was obtained from dice roll");
                    int playoption = PlayOption();

                    if (playoption == 1)
                    {
                        Console.WriteLine("No Play, player position is " + playerOnePos);
                        currentPlayer = !currentPlayer;
                    }
                    else if (playoption == 2)
                    {

                        //playerOnePos += dice;
                        if (playerOnePos + dice > 100)
                        {
                            Console.WriteLine("Need " + (100 - playerOnePos) + "to win.");
                            continue;
                        }
                        else
                        {
                            playerOnePos += dice;
                            Console.WriteLine("Ladder!! , player moved to position " + playerOnePos);
                        }

                    }
                    else if (playoption == 3)
                    {
                        playerOnePos -= dice;
                        if (playerOnePos < 0) playerOnePos = 0;
                        Console.WriteLine("Oh nooo Snake! , player moved to position " + playerOnePos);
                        currentPlayer = !currentPlayer;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                else if (!currentPlayer)
                {
                    Console.WriteLine("Player 2! Press enter key to roll dice");
                    Console.ReadLine();
                    int dice = DiceRoll();

                    Console.WriteLine(dice + " was obtained from dice roll");
                    int playoption = PlayOption();

                    if (playoption == 1)
                    {
                        Console.WriteLine("No Play, player position is " + playerTwoPos);
                        currentPlayer = !currentPlayer;
                    }
                    else if (playoption == 2)
                    {

                        //playerOnePos += dice;
                        if (playerTwoPos + dice > 100)
                        {
                            Console.WriteLine("Need " + (100 - playerTwoPos) + "to win.");
                            continue;
                        }
                        else
                        {
                            playerTwoPos += dice;
                            Console.WriteLine("Ladder!! , player moved to position " + playerTwoPos);
                        }

                    }
                    else if (playoption == 3)
                    {
                        playerTwoPos -= dice;
                        if (playerTwoPos < 0) playerTwoPos = 0;
                        Console.WriteLine("Oh nooo Snake! , player moved to position " + playerTwoPos);
                        currentPlayer = !currentPlayer;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }

                RoundsPlayed++;
                


            } 
             if (playerOnePos == 100)
            {
                Console.WriteLine("Congrats player 1!!! you reached the finish line!. Number of moves played is " + RoundsPlayed);
            }
             else if(playerTwoPos == 100)
            {
                Console.WriteLine("Congrats player 2!!! you reached the finish line!. Number of moves played is " + RoundsPlayed);
            }

        }

        public static int DiceRoll()
        {
            Random Dice = new Random();
            int dicenumber = Dice.Next(1, 7);
            return dicenumber;

        }

        public static int PlayOption()
        {
            Random Play = new Random();
            int PlayOption = Play.Next(1,4);
            return PlayOption;
        }
    }
}
