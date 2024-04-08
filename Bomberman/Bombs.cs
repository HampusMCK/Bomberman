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
        //Get position where bomb is placed
        pos = p.pos;
        //Var to keep track of the cell being checked
        Vector2 cellBeingChecked = new Vector2();
        //List of directions
        List<Vector2> dir = new List<Vector2>()
        {
            new Vector2(1, 0),
            new Vector2(-1, 0),
            new Vector2(0, 1),
            new Vector2(0, -1)
        };
        for (int i = 0; i < 4; i++) //Loop 4x (up, down, right, left)
        {
            for (int x = 1; x < range + 1; x++) //Loop range leangth
            {
                cellBeingChecked = pos + (dir[i] * x); //Check cell to the direction defined by the list * the step of the range
                foreach (Cell c in cells)
                {
                    if (c.pos == cellBeingChecked) //Check if the cell is in the right position
                    {
                        switch (x) //Switch based on step of range
                        {
                            case 1: //First step
                                if (c.type == 3) //If unbreakable wall
                                    x = range + 1; //Set x to out of loop to prevent checking next step
                                if (c.type == 2) //If breakable wall
                                {
                                    c.changeType("Damage"); //Break wall
                                    x = range + 1; //Set c to out of loop to prevent checking next step
                                }
                                break;
                            case 2: //Second step
                                if (c.type == 3) //If unbreakable wall
                                    x = range + 1; //Set x to out of loop to prevent checking next step
                                if (c.type == 2) //If breakable wall
                                {
                                    c.changeType("Damage"); //Break wall
                                    x = range + 1; //Set x to out of loop to prevent checking next step
                                }
                                break;
                            case 3: //Second step
                                if (c.type == 3) //If unbreakable wall
                                    x = range + 1; //Set x to out of loop to prevent checking next step
                                if (c.type == 2) //If breakable wall
                                {
                                    c.changeType("Damage"); //Break wall
                                    x = range + 1; //Set x to out of loop to prevent checking next step
                                }
                                break;
                            case 4: //Second step
                                if (c.type == 2) //If breakable wall
                                    c.changeType("Damage"); //Break wall
                                break;
                        }
                    }
                }
            }
        }
    }
}