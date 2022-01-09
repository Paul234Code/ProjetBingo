using ProjetJeuPOO.Bingo;
using ProjetJeuPOO.SimiliBlackJack;
using ProjetJeuPOO.SimiliPendu;
using System;
using System.Collections.Generic;

namespace ProjetJeuPOO
{
    class Controller
    {
        static void Main()
        {
            ListeDeMots liste = new ListeDeMots()
            {
                ListeDeMot = new List<string> {"programmation","informatique","civilisation", "Orange", "Mangue", "developpement", "Recommandation", "Banana", "Poire", "Deroulement", "Pomme", "Limon", "Cerise", "Ordinateur" }
            };
            
            Console.WriteLine("Entrer votre nom pour commencer");
            string nom = Console.ReadLine();
            Player player = new Player();
            Player.Name = nom;
            Console.WriteLine($"Bienvenue {nom}");
            Console.WriteLine();
            
            StartApplication app =  new StartApplication();
            app.MenuPrincipal();
            Pendu pendu = new Pendu(liste);
            //pendu.Jouer();         
            BlackJackController blackJackController = new BlackJackController();
            //blackJackController.DealCard();
            //blackJackController.Jouer();
            Boulier boulier = new Boulier();
            /* 
            while (!boulier.isEmpty())
            {
                boulier.StartBingoApp();
            }   */
            


        }

    }
}
