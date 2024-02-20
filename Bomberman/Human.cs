using System.Numerics;
using Raylib_cs;

public class Human : Player
{
    public void GetPlayerInput(int playerID, List<Cell> cells)
    {
        if (playerID == 0)
        {
            if (Raylib.IsKeyPressed(KeyboardKey.D))
            {
                pos.Y += 1;
                dir = new Vector2(0, 1);
            }
            if (Raylib.IsKeyPressed(KeyboardKey.A))
            {
                pos.Y -= 1;
                dir = new Vector2(0, -1);
            }
            if (Raylib.IsKeyPressed(KeyboardKey.S))
            {
                pos.X += 1;
                dir = new Vector2(1, 0);
            }
            if (Raylib.IsKeyPressed(KeyboardKey.W))
            {
                pos.X -= 1;
                dir = new Vector2(-1, 0);
            }

            if (Raylib.IsKeyPressed(KeyboardKey.E))
                if (Weapon != null)
                    Weapon.Use(this, cells);
        }

        if (playerID == 1)
        {
            if (Raylib.IsKeyPressed(KeyboardKey.Right))
            {
                pos.Y += 1;
                dir = new Vector2(0, 1);
            }
            if (Raylib.IsKeyPressed(KeyboardKey.Left))
            {
                pos.Y -= 1;
                dir = new Vector2(0, -1);
            }
            if (Raylib.IsKeyPressed(KeyboardKey.Down))
            {
                pos.X += 1;
                dir = new Vector2(1, 0);
            }
            if (Raylib.IsKeyPressed(KeyboardKey.Up))
            {
                pos.X -= 1;
                dir = new Vector2(-1, 0);
            }

            if (Raylib.IsKeyPressed(KeyboardKey.L))
                if (Weapon != null)
                    Weapon.Use(this, cells);
        }
    }
}
