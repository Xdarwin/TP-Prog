using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasics
{
    class Program
    {
        static Farm ferme;
        static Shop magasin;

        static void Main(string[] args)
        {
            init();
            acces_shop();
        }



        static private void init()
        {
            Console.WriteLine("Bienvenue, pour commencer vous allez devoir donner le nom du magasin et de la ferme que vous voulez\n");
            Console.Write("Nom de la ferme : ");
            ferme = new Farm(Console.ReadLine(), 1500);
            Console.WriteLine("Votre ferme possede 1500 Gold");
            Console.WriteLine();
            Console.Write("Nom de la magasin : ");
            magasin = new Shop(Console.ReadLine(), 1500);

            //Remplissage du magasin
            Console.Write("Combien voulez vous de poneys dans le magasin ? ");
            int nb2 =  Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < nb2; i++)
            {
                Console.Write("La couleur de votre poney (bleu, rouge, jaune, blanc, ou vert): ");
                switch (Console.ReadLine())
                {
                    case "bleu":
                        magasin.add_pony(new Pony(ConsoleColor.Blue));
                        break;

                    case "rouge":
                        magasin.add_pony(new Pony(ConsoleColor.Red));
                        break;

                    case "jaune":
                        magasin.add_pony(new Pony(ConsoleColor.Yellow));
                        break;

                    case "blanc":
                        magasin.add_pony(new Pony(ConsoleColor.White));
                        break;

                    case "vert":
                        magasin.add_pony(new Pony(ConsoleColor.Green));
                        break;

                    default:
                        Console.WriteLine("Cette couleur n'est pas disponible si vous ne possedez pas le DLC MORECOLORS. Votre poney aura la couleur blanche par defaut.");
                        magasin.add_pony(new Pony(ConsoleColor.White));
                        break;
                }
            }

        }






        static private void acces_farm()
        {
            bool quit;
            quit = false;
            int nb;
            while(!quit)
            {
                Console.WriteLine("Vous voici a la ferme, vous pouvez :");
                Console.WriteLine("1. Ajouter de l'argent,\n2. afficher le champs des poneys\n3. Lire une chanson bien de chez nous\n4. Quitter\nEntrez le numero : ");
                switch (Console.ReadLine())
                {
                    case "1" :
                        Console.Write("Le montant a ajoute (positif ou negatif) : ");
                        nb = Convert.ToInt32(Console.ReadLine());
                        ferme.add_gold(nb);
                        break;

                    case "2":
                        ferme.display();
                        break;

                    case"3":
                        Console.WriteLine("Elle descend de la montagne a cheval !");
                        Console.WriteLine("Elle descend de la montagne a cheval !");
                        Console.WriteLine("Elle descend, elle descend, elle descend de la montagne a cheval !");
                        break;

                    case "4":
                        quit = true;
                        break;
                    default :
                        Console.WriteLine("Nombre pas valide.");
                        break;
                }
            }
        }




        static private void acces_shop()
        {
            bool quit;
            quit = false;
            int nb;
            while (!quit)
            {
                Console.WriteLine("Vous voici au magasin, vous pouvez :");
                Console.WriteLine("1. Ajouter de l'argent,\n2. afficher le champs des poneys\n3. Lire une chanson bien de chez nous\n4. Quitter\nEntrez le numero : ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Le montant a ajoute (positif ou negatif) : ");
                        nb = Convert.ToInt32(Console.ReadLine());
                        magasin.add_gold(nb);
                        
                        break;

                    case "2":
                        magasin.display();
                        break;

                    case "3":
                        Console.WriteLine("BLABLABLABLABLABLABLABLABLA DONNEZVOTREARGENT BLABLABLABLABLABLABLA");
                        break;

                    case "4":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Nombre pas valide.");
                        break;
                }
            }
        }



        static private void menu()
        {

        }

    }
}
