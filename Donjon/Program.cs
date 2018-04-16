using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donjon
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain;
            do
            {


                var game = new Game();
                game.run();
                Console.WriteLine("Another game?");
                var keyInfo = Console.ReadKey(); //
                var key = keyInfo.Key;
                if (key == ConsoleKey.Y)
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            } while (playAgain);
        }
    }
}
