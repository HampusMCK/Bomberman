using System.Numerics;
using Raylib_cs;

public class Bombs : Weapons
{
    public int range = 2; //Range to calculate effected cells
    public int damageRange; //Range to calculate effected players
    public int damagaFallOut; //Decrease in damage per cell away from explosion
    public int fuseTime = 3;

    public override void Use(Player p, List<Cell> cells)
    {
        pos = p.pos;
        Rectangle blastArea = new Rectangle(pos.X - range, pos.Y - range, new Vector2(range * 2, range * 2));
        foreach (Cell c in cells)
        {
            if (c.type == 2)
            {
                if (Raylib.CheckCollisionPointRec(c.pos, blastArea))
                    c.changeType("Damage");
            }
        }
    }
}
