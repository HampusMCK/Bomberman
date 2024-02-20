using System.Numerics;

public class Grid
{
    private static float x = 4; //cell size devided by 20
    public Vector2[,] pos = new Vector2[10, 10]{ //Array of positions
        {new Vector2(0 * x, 0 * x), new  Vector2(20 * x,0 * x), new Vector2(40 * x,0 * x),new Vector2(60 * x, 0 * x),new Vector2(80 * x,0 * x),new Vector2(100 * x,0 * x),new Vector2(120 * x,0 * x),new Vector2(140 * x,0 * x),new Vector2(160 * x,0 * x),new Vector2(180 * x,0 * x)},

        {new Vector2(0 * x, 20 * x), new  Vector2(20 * x,20 * x), new Vector2(40 * x,20 * x),new Vector2(60 * x, 20 * x),new Vector2(80 * x,20 * x),new Vector2(100 * x,20 * x),new Vector2(120 * x,20 * x),new Vector2(140 * x,20 * x),new Vector2(160 * x,20 * x),new Vector2(180 * x,20 * x)},

        {new Vector2(0 * x, 40 * x), new  Vector2(20 * x,40 * x), new Vector2(40 * x,40 * x),new Vector2(60 * x, 40 * x),new Vector2(80 * x,40 * x),new Vector2(100 * x,40 * x),new Vector2(120 * x,40 * x),new Vector2(140 * x,40 * x),new Vector2(160 * x,40 * x),new Vector2(180 * x,40 * x)},

        {new Vector2(0 * x, 60 * x), new  Vector2(20 * x,60 * x), new Vector2(40 * x,60 * x),new Vector2(60 * x, 60 * x),new Vector2(80 * x,60 * x),new Vector2(100 * x,60 * x),new Vector2(120 * x,60 * x),new Vector2(140 * x,60 * x),new Vector2(160 * x,60 * x),new Vector2(180 * x,60 * x)},

        {new Vector2(0 * x, 80 * x), new  Vector2(20 * x,80 * x), new Vector2(40 * x,80 * x),new Vector2(60 * x, 80 * x),new Vector2(80 * x,80 * x),new Vector2(100 * x,80 * x),new Vector2(120 * x,80 * x),new Vector2(140 * x,80 * x),new Vector2(160 * x,80 * x),new Vector2(180 * x,80 * x)},

        {new Vector2(0 * x, 100 * x), new  Vector2(20 * x,100 * x), new Vector2(40 * x,100 * x),new Vector2(60 * x, 100 * x),new Vector2(80 * x,100 * x),new Vector2(100 * x,100 * x),new Vector2(120 * x,100 * x),new Vector2(140 * x,100 * x),new Vector2(160 * x,100 * x),new Vector2(180 * x,100 * x)},

        {new Vector2(0 * x, 120 * x), new  Vector2(20 * x,120 * x), new Vector2(40 * x,120 * x),new Vector2(60 * x, 120 * x),new Vector2(80 * x,120 * x),new Vector2(100 * x,120 * x),new Vector2(120 * x,120 * x),new Vector2(140 * x,120 * x),new Vector2(160 * x,120 * x),new Vector2(180 * x,120 * x)},

        {new Vector2(0 * x, 140 * x), new  Vector2(20 * x,140 * x), new Vector2(40 * x,140 * x),new Vector2(60 * x, 140 * x),new Vector2(80 * x,140 * x),new Vector2(100 * x,140 * x),new Vector2(120 * x,140 * x),new Vector2(140 * x,140 * x),new Vector2(160 * x,140 * x),new Vector2(180 * x,140 * x)},

        {new Vector2(0 * x, 160 * x), new  Vector2(20 * x,160 * x), new Vector2(40 * x,160 * x),new Vector2(60 * x, 160 * x),new Vector2(80 * x,160 * x),new Vector2(100 * x,160 * x),new Vector2(120 * x,160 * x),new Vector2(140 * x,160 * x),new Vector2(160 * x,160 * x),new Vector2(180 * x,160 * x)},

        {new Vector2(0 * x, 180 * x), new  Vector2(20 * x,180 * x), new Vector2(40 * x,180 * x),new Vector2(60 * x, 180 * x),new Vector2(80 * x,180 * x),new Vector2(100 * x,180 * x),new Vector2(120 * x,180 * x),new Vector2(140 * x,180 * x),new Vector2(160 * x,180 * x),new Vector2(180 * x,180 * x)}
    };
}
