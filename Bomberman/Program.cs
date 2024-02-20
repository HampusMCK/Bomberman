using System.Numerics;
using System.Runtime.InteropServices;
using Raylib_cs;

Raylib.InitWindow(1000, 1000, "Bomberman");
int screenIndex = Raylib.GetCurrentMonitor();
Vector2 screenSize = new Vector2(Raylib.GetMonitorWidth(screenIndex), Raylib.GetMonitorHeight(screenIndex));
Vector2 screenMargins = new Vector2(screenSize.X / 10, screenSize.Y / 10);
Raylib.SetWindowSize((int)(screenSize.X - screenMargins.X), (int)(screenSize.Y - screenMargins.Y));
Raylib.SetWindowPosition((int)screenMargins.X / 2, (int)screenMargins.Y / 2);

Grid g = new();
Player p = new();
int cellSize = 80;
Vector2 cellMargin = new Vector2((Raylib.GetScreenWidth() - (cellSize * 10)) / 2, (Raylib.GetScreenHeight() - (cellSize * 10)) / 2);

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

    p.edgeRestraint();

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.White);
    for (int x = 0; x < 10; x++)
    {
        for (int y = 0; y < 10; y++)
        {
            Raylib.DrawRectangle((int)(g.pos[x, y].X + cellMargin.X), (int)(g.pos[x, y].Y + cellMargin.Y), cellSize, cellSize, Color.Black);
            Raylib.DrawRectangleLines((int)(g.pos[x, y].X + cellMargin.X), (int)(g.pos[x, y].Y + cellMargin.Y), cellSize, cellSize, Color.Gray);
        }
    }
    Raylib.DrawRectangle((int)(g.pos[(int)p.pos.X, (int)p.pos.Y].X + cellMargin.X), (int)(g.pos[(int)p.pos.X, (int)p.pos.Y].Y + cellMargin.Y), cellSize, cellSize, Color.Red);
    Raylib.EndDrawing();
}