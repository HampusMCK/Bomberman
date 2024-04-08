using System.Numerics;

public class Grid
{
    private static float z = 3; //cell size devided by 20
    public Vector2[,] pos = new Vector2[13, 13]; //Array of positions
    
    public void populateGrid()
    {
        for (int x = 0; x < 13; x++)
        {
            for (int y = 0; y < 13; y++)
            {
                pos[x,y] = new Vector2((y*20)*z, (x*20)*z);
            }
        }
    }
}
