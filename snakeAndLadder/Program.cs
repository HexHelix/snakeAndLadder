﻿using System;
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
            Console.WriteLine("Welcome Player to Snake And Ladder");
            
            while(playerOnePos != 100)
            {
                Console.WriteLine("Press enter key to roll dice");
                int dice = DiceRoll();
                Console.WriteLine(dice + " was obtained from dice roll");
                int playoption = PlayOption();
                
                if(playoption == 1)
                {
                    Console.WriteLine("No Play, player position is " + playerOnePos);
                }
                else if(playoption == 2)
                {

                    //playerOnePos += dice;
                    if(playerOnePos + dice > 100)
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
                else if(playerOnePos == 3)
                {
                    playerOnePos -= dice;
                    if(playerOnePos < 0)playerOnePos = 0;
                    Console.WriteLine("Oh nooo Snake! , player moved to position " + playerOnePos);
                }

            }

            Console.WriteLine("Congrats!!! you reached the finish line!");


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
