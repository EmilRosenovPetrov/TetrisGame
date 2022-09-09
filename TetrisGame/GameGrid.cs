namespace TetrisGame
{
    public class GameGrid
    {
        private readonly int[,] grid;

        public int Rows { get; }

        public int Columns { get; }

        public int this[int r, int c]
        {
            get => grid[r, c];
            set => grid[r, c] = value;
        }

        public GameGrid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            grid = new int[Rows, Columns];
        }
    }
}
