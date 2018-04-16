namespace Donjon
{
    internal class Map
    {
        private readonly int height;
        private readonly int width;
        private Cell[,] cells;

        public Map(int width, int height)
        {
            this.width = width;
            this.height = height;
            this.cells = new Cell[width, height];
        }
    }
}