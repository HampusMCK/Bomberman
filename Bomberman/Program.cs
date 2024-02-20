using System.Numerics;
using System.Runtime.InteropServices;
using Raylib_cs;

Grid g = new();
Player p = new();
int cellSize = 80;
int margin = 100;

Raylib.InitWindow(1000, 1000, "Bomberman");
while (!Raylib.WindowShouldClose())
{
    if (Raylib.IsKeyPressed(KeyboardKey.D))
        p.pos.Y += 1;
    if (Raylib.IsKeyPressed(KeyboardKey.A))
        p.pos.Y -= 1;
    if (Raylib.IsKeyPressed(KeyboardKey.S))
        p.pos.X += 1;
    if (Raylib.IsKeyPressed(KeyboardKey.W))
        p.pos.X -= 1;

    if (p.pos.X < 0)
        p.pos.X = 0;
    if (p.pos.X > 9)
        p.pos.X = 9;
    if (p.pos.Y < 0)
        p.pos.Y = 0;
    if (p.pos.Y > 9)
        p.pos.Y = 9;
        
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.White);
    for (int x = 0; x < 10; x++)
    {
        for (int y = 0; y < 10; y++)
        {
            Raylib.DrawRectangle((int)g.pos[x, y].X + margin, (int)g.pos[x, y].Y + margin, cellSize, cellSize, Color.Black);
            Raylib.DrawRectangleLines((int)g.pos[x, y].X + margin, (int)g.pos[x, y].Y + margin, cellSize, cellSize, Color.Gray);
        }
    }
    Raylib.DrawRectangle((int)g.pos[(int)p.pos.X, (int)p.pos.Y].X + margin, (int)g.pos[(int)p.pos.X, (int)p.pos.Y].Y + margin, cellSize, cellSize, Color.Red);
    Raylib.EndDrawing();
}