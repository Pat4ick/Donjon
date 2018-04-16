namespace Donjon
{
    internal class Cell
    {
        public Position Position { get; private set; }
        public string Symbol { get; internal set; } = ".";

        public Cell(Position position)
        {
            Position = position;
        }
    }
}