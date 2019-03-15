using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Snake
{
    public class GameObj
    {
        
        
            public List<Point> body;
            public ConsoleColor tus;
            public char beine;

        

        public GameObj (int x, int y, ConsoleColor tus, char c)
            {
                body = new List<Point> {
                   new Point(x,y)
                     };

                this.tus = tus;
                this.beine = c;
               
    
        }


        public void Korsetu()
            {
                Console.ForegroundColor = tus;
                foreach(Point p in body)
                {
                    Console.SetCursorPosition(p.x, p.y);
                    Console.Write(beine);
                }
            }

        public bool Objdagy(GameObj obj)
        {
            foreach(Point p in obj.body)
            {
                if (body[0].x == p.x && body[0].y == p.y)
                    return true;
            }
            return false;
        }
      



    }
       
    }