using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Food :GameObj
    {
        public Food(int x, int y,  ConsoleColor tus, char c): base(x, y, tus, c)
        {

        }
        public void Oryny ()
        {
            Random random = new Random();
            int x = random.Next (2, Console.WindowWidth/4);
            int y = random.Next (2, Console.WindowHeight/4);
            body[0].x =x;
            body[0].y = y;

        }
    }

}
