using System;

namespace Donjon
{
    internal class Game
    {
        public Game()
        {

        }

        internal void run()
        {
            init(); // Could be in construcor
            bool gameInProgress = false;
            do
            {
                Draw();
                var key = Console.ReadKey(intercept: true).Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow: MoveHero(); break;
                    case ConsoleKey.DownArrow: MoveHero(); break;
                    case ConsoleKey.LeftArrow: MoveHero(); break;
                    case ConsoleKey.RightArrow: MoveHero(); break;
                    default: break;
                }

            } while (gameInProgress);

            Console.WriteLine("Game Over");
        }

        private void MoveHero()
        {
            throw new NotImplementedException();
        }

        private void Draw()
        {
            throw new NotImplementedException();
        }

        private void init()
        {
            throw new NotImplementedException();
        }
    }
}