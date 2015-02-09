using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasics
{
    class Shop
    {

        string nom;
        List<Pony> list_pony;
        int argent;

        public Shop(string name, int gold)
        {
            this.nom = name;
            this.argent = gold;
            list_pony = new List<Pony>();
        }


        public void display()
        {
            for(int i = 0; i < list_pony.Count; i++)
            {
                list_pony[i].display();
                Console.Write("|");
            }
        }


        public void add_gold(int nb)
        {
            this.argent = argent + nb;
            if (argent < 0)
                argent = 0;
            Console.WriteLine("Le magasin possede {0} Gold", argent);
        }


        public void add_pony(Pony poney)
        {
            list_pony.Add(poney);
        }



        public Pony get_pony()
        {
            Pony on_te_vire = list_pony[list_pony.Count - 1];
            list_pony.RemoveAt(list_pony.Count - 1);
            return on_te_vire;
        }

    }
}
