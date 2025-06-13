

using Play.Entities;
using System.Data;

internal class Game
{
    private Map map = null!;
    private Hero hero = null!;

    internal void Run()
    {
        Initialize();
        Play();
    }

    private void Play()
    {
        bool gameInProgress=true;
        do
        {
          DrawMap();
          Console.ReadKey();
        } 
        while (gameInProgress);
       
    }

    private void DrawMap()
    {
        Console.Clear();
        for (int y = 0; y < map.Height; y++)
        {
            for (int x = 0; x < map.Width; x++)
            {
            Cell? cell = map.GetCell(y, x);
                //ToDo : Handle null
                Console.ForegroundColor=cell.Color;
                Console.Write(cell.Symbol);
            }
            Console.WriteLine();
        }
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    private void Initialize()
    {
        // ToDo : Read from Config may be
         map=new Map(width: 10,height:10);
        Cell heroCell = map.GetCell(0, 0);
         hero = new Hero(heroCell);

    }
}