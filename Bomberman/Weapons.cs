using System.Numerics;

public class Weapons : Item
{
    public int damage;
    public string name;
    public Vector2 pos = new();

    public virtual void Use(Player p, List<Cell> cells)
    {
        foreach (Cell c in cells)
            if (c.pos == pos + p.dir)
                c.changeType("Damage");
    }
}
