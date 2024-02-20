using System.ComponentModel.DataAnnotations;
using System.Numerics;

public class Cell
{
    [Range(0, 3)] //0 = empty, 1 = contains an item, 2 = wall, 3 = unbreakable wall
    public int type;
    public Vector2 pos = new Vector2();

    public void changeType(string typeOfChange)
    {
        if (typeOfChange == "Damage")
            if (type == 2)
            {
                Random gen = new Random();
                int newType = gen.Next(0, 5);
                if (newType < 3)
                    newType = 0;
                else
                    newType = 1;
                type = newType;
            }
        if (typeOfChange == "Player")
            if (type == 1)
                type = 0;
    }
}
