using System.ComponentModel.DataAnnotations;
using System.Numerics;

public class Cell
{
    [Range(0, 2)] //0 = empty, 1 = wall, 2 = contains an item
    public int type;
    public Vector2 pos = new Vector2();
}
