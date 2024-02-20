using System.Numerics;

public class Player
{
    public string Name;
    public int ID; //Player ID
    public int Health;
    public Vector2 pos;
    public Weapons Weapon; //Weapon Place Holder

    public void edgeRestraint() //Void to prevent player moving out of grid
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
