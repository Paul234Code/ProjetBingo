using System;
using System.Collections.Generic;
using System.Text;
using ProjetJeuPOO.Bingo;
using ProjetJeuPOO.SimiliBlackJack;
using ProjetJeuPOO.SimiliPendu;

namespace ProjetJeuPOO
{
    class Controller
    {
        static void Main()
        {
            ListeDeMots liste = new ListeDeMots()
            {
                 ListeDeMot = new List<string>{"Orange","Mangue", "developpement", "Recommandation", "Banana","Poire","Deroulement","Pomme","Limon","Cerise","Ordinateur"}
            };
            //Pendu pendu = new Pendu(liste);
           // pendu.Jouer();         
            BlackJackController blackJackController = new BlackJackController();                     
            //blackJackController.DealCard();
            //blackJackController.Jouer();
            Boulier boulier = new Boulier();
            /* boulier.Initialisation();
             boulier.Visualiser();
             Console.WriteLine();
             boulier.VisualiserCarteAnnonceur();
             boulier.getRanbomBall();
             boulier.VisualiserCarteAnnonceur();
             boulier.Visualiser();
             boulier.Visualiser();
             boulier.Visualiser(); */
            Console.WriteLine("1- Identification");
            Console.WriteLine("2- Quitter l'Application");
            while (!boulier.isEmpty())
            {
                boulier.StartBingoApp();
            }
        }
        // Fonction du menu principal
        public void MenuPrincipal()
        {
            Console.WriteLine("1- Jeu de Bingo");
            Console.WriteLine("2- Jeu du SIMILI Black Jack");
            Console.WriteLine("3- Jeu du SIMILI PENDU");
        }
    }
}
