internal class Map
{
    private Cell[,] cells;
    private int height;
    private int width;

    public Map(int width, int height)
    {
        this.height = height;
        this.width = width;

        cells=new Cell[width,height];
    }
}