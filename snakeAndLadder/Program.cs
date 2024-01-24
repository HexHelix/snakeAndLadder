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
            Console.WriteLine("Welcome Player to Snake And Ladder");
            Console.WriteLine(DiceRoll());

        }

        public static int DiceRoll()
        {
            Random Dice = new Random();
            int dicenumber = Dice.Next(1, 7);
            return dicenumber;

        }
    }
}
