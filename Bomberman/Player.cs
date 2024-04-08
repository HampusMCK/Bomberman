using System.Numerics;

public class Player
{
    public string Name;
    public int ID; //Player Index
    public bool Alive = true;
    public Vector2 pos;
    public Vector2 dir;
    public Bombs bomb = new Bombs(); //Weapon Place Holder
    public Item Upgrade; //Upgrade Place Holder

    public void edgeRestraint(List<Cell> cells) //Void to prevent player moving out of grid
    {
        if (pos.X < 0)
            pos.X = 0;
        if (pos.X > 12)
            pos.X = 12;
        if (pos.Y < 0)
            pos.Y = 0;
        if (pos.Y > 12)
            pos.Y = 12;

        //Calculate result of moving onto new cell
        foreach (Cell c in cells)
        {
            if (c.type == 2 || c.type == 3)//Prevent player from moving onto cells with walls
                if (pos == c.pos)
                    pos -= dir;

            if (c.type == 1) //Pickup item from cell if it contains item
                if (c.pos == pos)
                {
                    c.changeType("Player");
                    if (bomb.range < 5)
                        bomb.range++;
                }
        }
    }
}
