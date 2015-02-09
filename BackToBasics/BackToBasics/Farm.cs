using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasics
{
    class Farm
    {
        string nom;
        List<Pony> list_pony;
        int cur_gold;


        public Farm(string name, int gold)
        {
            this.nom = name;
            this.cur_gold = gold;
            list_pony = new List<Pony>();
        }


        public void display()
        {
            Random rnd = new Random();
            
            for(int i = 0; i < list_pony.Count; i++)
            {
                list_pony[i].display();
                for(int j = 0; j < rnd.Next(7); j++) //"7 et c'est bon"  cf Reflet d'Acide
                {
                    Console.Write(" ");
                }
            }
        }


        public void add_gold(int nb)
        {
            this.cur_gold = cur_gold + nb;
            if (cur_gold < 0)
                cur_gold = 0;
            Console.WriteLine("Le magasin possede {0} Gold", cur_gold);
        }


        public void add_pony(Pony poney)
        {
            list_pony.Add(poney);
        }

    }
}
