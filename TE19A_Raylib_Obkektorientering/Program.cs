using System;
using Raylib_cs;

Raylib.InitWindow(800, 600, "Raylib testing");
Raylib.SetTargetFPS(60);

Avatar gubbe = new Avatar();
Box lådda = new Box();

Rectangle rec2 = new Rectangle(256,64,32,32);

while (!Raylib.WindowShouldClose())
{
  gubbe.Update();

  Raylib.BeginDrawing();
  Raylib.ClearBackground(Color.ORANGE);

  Raylib.DrawRectangle(32,32,32,32, Color.BLUE);

  gubbe.Draw();
  lådda.Draw();

  if (Raylib.CheckCollisionRecs(gubbe.rect, lådda.rectangle) && gubbe.carriedBox == null)
  {
    gubbe.carriedBox = lådda;
  }
  

  if (Raylib.CheckCollisionRecs(gubbe.rect, rec2))
  {
    Raylib.DrawRectangleRec(rec2, Color.BLACK);
  }
  else
  {
    Raylib.DrawRectangleRec(rec2, Color.WHITE);
  }

  Raylib.EndDrawing();
}