using System;

namespace Donjon
{
    internal class Map
    {
        public int Height { get;}
        public int Width {get;}
        private Cell[,] cells;

        public Map(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            this.cells = new Cell[width, height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    var position = new Position(x, y);
                    cells[x, y] = new Cell(position);
                }
            }
        }

        // lowers the probability of creating an external bug - not possible to set as null
        internal Cell Cell(int x, int y)
        {
            // todo: validate x and y
            return cells[x, y];
            throw new NotImplementedException();
        }
    }
}