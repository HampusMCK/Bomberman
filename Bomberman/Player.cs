using System.Numerics;

public class Player
{
    public string Name;
    public int ID;
    public int Health;
    public Vector2 pos;
    public Weapons Weapon;

    public void edgeRestraint()
    {
        if (pos.X < 0)
            pos.X = 0;
        if (pos.X > 9)
            pos.X = 9;
        if (pos.Y < 0)
            pos.Y = 0;
        if (pos.Y > 9)
            pos.Y = 9;
    }
}
