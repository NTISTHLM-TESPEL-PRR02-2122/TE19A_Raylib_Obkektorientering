using System;
using Raylib_cs;

  public class Box
  {
    public Rectangle rectangle = new Rectangle(128, 0, 32,32);

    public void Update()
    {

    }

    public void Draw()
    {
      Raylib.DrawRectangleRec(rectangle, Color.BROWN);
    }
  }