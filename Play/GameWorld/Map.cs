
using System.Diagnostics;


internal class Map
{
    private Cell[,] cells;
    public int Height { get; }
    public int Width { get; }
    public List<Creature> Creatures { get; }=new List<Creature>(); 
    public Map(int width, int height)
    {
        Height = height;
        Width = width;

        cells = new Cell[width, height];

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                cells[y, x] = new Cell();
            }
        }
    }
    //ToDo : Do better
    internal Cell GetCell(int y, int x)
    {
        return (x < 0 || x >= Width || y < 0 || y >= Height) ? null : cells[y, x];
        //try
        //{
        //    return cells[y, x];
        //}
        //catch (Exception ex)
        //{
        //    {
        //        Debug.WriteLine(ex.Message);
        //        return null;
        //    }
        //}
    }
}