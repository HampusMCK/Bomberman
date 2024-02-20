using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using Raylib_cs;

Raylib.InitWindow(1000, 1000, "Bomberman");
//Get current monitor screen
int screenIndex = Raylib.GetCurrentMonitor();
//Get screen size
Vector2 screenSize = new Vector2(Raylib.GetMonitorWidth(screenIndex), Raylib.GetMonitorHeight(screenIndex));
//Calculate even margins to center game window on screen
Vector2 screenMargins = new Vector2(screenSize.X / 10, screenSize.Y / 10);
//Change game window config
Raylib.SetWindowSize((int)(screenSize.X - screenMargins.X), (int)(screenSize.Y - screenMargins.Y));
Raylib.SetWindowPosition((int)screenMargins.X / 2, (int)screenMargins.Y / 2);

Grid g = new();
Player p = new();
Human h = new Human(){ID = 0};
Human h2 = new Human(){ID = 1};

int cellSize = 80;

List<Cell> cells = new();
//Calculate even margins to center game grid to game window
Vector2 cellMargin = new Vector2((Raylib.GetScreenWidth() - (cellSize * 10)) / 2, (Raylib.GetScreenHeight() - (cellSize * 10)) / 2);
for (int x = 0; x < 10; x++)
{
    for (int y = 0; y < 10; y++)
    {
        if ((x == 0 && (y == 0 || y == 1 || y == 8 || y == 9)) || (x == 1 && (y == 0 || y == 9)) || (x == 8 && (y == 0 || y == 9)) || (x == 9 && (y == 0 || y == 1 || y == 8 || y == 9)))
            cells.Add(new Cell { type = 0, pos = new Vector2(x, y) });
        else
            cells.Add(new Cell { type = 2, pos = new Vector2(x, y) });
    }
}
while (!Raylib.WindowShouldClose())
{
    h.GetPlayerInput(h.ID, cells);
    h.edgeRestraint(cells);

    h2.GetPlayerInput(h2.ID, cells);
    h2.edgeRestraint(cells);

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.White);
    //Draw game grid
    foreach (Cell c in cells)
    {
        Color color = new Color();
        if (c.type == 0)
            color = Color.Gray;
        if (c.type == 1)
            color = Color.Red;
        if (c.type == 2)
            color = Color.Blue;

        Raylib.DrawRectangle((int)(g.pos[(int)c.pos.X, (int)c.pos.Y].X + cellMargin.X), (int)(g.pos[(int)c.pos.X, (int)c.pos.Y].Y + cellMargin.Y), cellSize, cellSize, color);
        Raylib.DrawRectangleLines((int)(g.pos[(int)c.pos.X, (int)c.pos.Y].X + cellMargin.X), (int)(g.pos[(int)c.pos.X, (int)c.pos.Y].Y + cellMargin.Y), cellSize, cellSize, Color.Black);
    }

    //Draw player rect
    Raylib.DrawRectangle((int)(g.pos[(int)h.pos.X, (int)h.pos.Y].X + cellMargin.X), (int)(g.pos[(int)h.pos.X, (int)h.pos.Y].Y + cellMargin.Y), cellSize, cellSize, Color.Red);
    Raylib.DrawRectangle((int)(g.pos[(int)h2.pos.X, (int)h2.pos.Y].X + cellMargin.X), (int)(g.pos[(int)h2.pos.X, (int)h2.pos.Y].Y + cellMargin.Y), cellSize, cellSize, Color.Red);
    Raylib.EndDrawing();
}