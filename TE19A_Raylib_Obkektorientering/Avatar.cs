using System;
using Raylib_cs;

public class Avatar
{
  public Rectangle rect;
  public float speed = 5;

  public Texture2D texture;

  public Box carriedBox;

  public Avatar()
  {
    rect = new Rectangle(0, 0, 32, 32);
    texture = Raylib.LoadTexture("avatar.png");
  }

  public void Update()
  {
    if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
    {
      rect.x += 3;
    }
    else if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
    {
      rect.x -= 3;
    }

    if (carriedBox != null)
    {
      carriedBox.rectangle.x = rect.x + 16;
      carriedBox.rectangle.y = rect.y + 16;
    }
  }

  public void Draw()
  {
    Raylib.DrawTexture(texture, (int)rect.x, (int)rect.y, Color.WHITE);
  }

}