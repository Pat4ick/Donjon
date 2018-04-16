namespace Donjon
{
    internal class Cell
    {
        public Position Position { get; private set; }

        public Cell(Position position)
        {
            Position = position;
        }
    }
}