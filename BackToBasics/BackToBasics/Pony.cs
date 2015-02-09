using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasics
{
    class Pony
    {
        protected int size;
        protected string pony;
        protected ConsoleColor color_poney;


        public Pony (ConsoleColor couleur)
        {
            Random rnd = new Random();
            this.size = rnd.Next(2, 10);
            this.color_poney = couleur;
            this.pony = "";
        }


        public void display()
        {
            ConsoleColor previous = Console.ForegroundColor;
            pony = pony + ".";
            for(int i = 0; i < size; i++)
            {
                pony = pony + "=";
            }
            pony = pony + ".°";
            Console.ForegroundColor = color_poney;
            Console.Write(pony);
            Console.ForegroundColor = previous;
        }

    }
}
