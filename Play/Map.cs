internal class Map
{
    private Cell[,] cells;
    private int height;
    private int width;

    public Map(int width, int height)
    {
        this.height = height;
        this.width = width;

        cells = new Cell[width, height];

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                cells[y, x] = new Cell();
            }
        }
    }
}