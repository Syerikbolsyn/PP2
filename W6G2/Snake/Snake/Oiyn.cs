using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snake
{
    public class Oiyn
    {
        List<GameObj> shygaru;
        public Kozgaluy kz;
        public Food food;
        public bool isAlive;
        public Kedergi kdrg;
        public string s;
        public Oiyn()
        {
            shygaru = new List<GameObj>();
            kz = new Kozgaluy(20, 20, ConsoleColor.DarkGreen, '0');
            food = new Food(0, 0, ConsoleColor.Yellow, 'o');
            kdrg = new Kedergi(ConsoleColor.Red, '>');
            kdrg.Kedergiohu();
            while (food.Objdagy(kz) || food.Objdagy(kdrg))

                food.Oryny();
            Console.WriteLine();
          s = Console.ReadLine();
           

            shygaru.Add(kz);
            shygaru.Add(food);
            shygaru.Add(kdrg);
            isAlive = true;

        }

        public void Basta()
        {
          
            ConsoleKeyInfo key = Console.ReadKey(true);

            while (isAlive && key.Key != ConsoleKey.Escape)
            {
                Korsetu();
                key = Console.ReadKey();
                if (kz.Objdagy(food))
                {
                    kz.body.Add(new Point(0, 0));
                    while (food.Objdagy(kz) || food.Objdagy(kdrg))
                        food.Oryny();

                    if (kz.body.Count == 3)
                        kdrg.NextLevel();
                }
                if ( kz.Objdagy(kdrg))
                {
                    isAlive = false;
                }
                kz.hozgaluy(key);


            }

            if(!isAlive)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(20, 15);
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Game Over,  Try Again");
                
            }

        }



        public void Korsetu()
        {
            Console.Clear();
            Console.SetCursorPosition(7, 0);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("NAme" +" "+s);
            foreach (GameObj g in shygaru)
            {
                g.Korsetu();
            }

        }


    }
}

       

