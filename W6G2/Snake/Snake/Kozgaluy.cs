using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Kozgaluy : GameObj
    {
        enum Direction
        {
            NONE,
            RIGHT,
            LEFT,
            UP,
            DOWN
        }
        Direction direction = Direction.NONE;
        public Kozgaluy (int x, int y, ConsoleColor t, char c): base (x, y, t, c) 
        {

            }

        public void hozgaluy(ConsoleKeyInfo key)
        {
           
              for(int t = body.Count - 1; t > 0; t--)
                {
                    body[t].x = body[t - 1].x;
                    body[t].y = body[t - 1].y;
                }
            if (key.Key == ConsoleKey.UpArrow && direction != Direction.DOWN)
            { body[0].y--; direction = Direction.UP; }
            if (key.Key == ConsoleKey.DownArrow && direction != Direction.UP)
            { body[0].y++; direction = Direction.DOWN; }
            if (key.Key == ConsoleKey.LeftArrow && direction != Direction.RIGHT)
            { body[0].x--; direction = Direction.LEFT; }
            if (key.Key == ConsoleKey.RightArrow && direction != Direction.LEFT)
            { body[0].x++; direction = Direction.RIGHT; }

        }
    }
}
