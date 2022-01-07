using ProjetJeuPOO.Bingo;
using ProjetJeuPOO.SimiliBlackJack;
using ProjetJeuPOO.SimiliPendu;
using System;

namespace ProjetJeuPOO
{
    public class StartApplication
    {
        private Boulier boulier;
        private BlackJackController blackJackController;
        private Pendu pendu;
        private ListeDeMots liste;
        // Le constructeur
        public StartApplication()
        {
            boulier = new Boulier();
            blackJackController = new BlackJackController();
            liste = new ListeDeMots()
            {
                ListeDeMot = new System.Collections.Generic.List<string>() {"Orange", "Mangue","Bonjour", "developpement", "Recommandation", "Banana", "Poire", "Deroulement", "Pomme", "Limon", "Cerise", "Ordinateur" }
            };
            pendu = new Pendu(liste);
        }
        // Fonction qui affiche le Menu principal
        public  void MenuPrincipal()
        {
            Console.WriteLine("1- Jeu de Bingo");
            Console.WriteLine("2- Jeu du SIMILI Black Jack");
            Console.WriteLine("3- Jeu du SIMILI PENDU");
            Console.WriteLine("4- Femer Session");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    boulier.BingoMenu();
                    break;
                case "2":
                    blackJackController.Jouer();
                    break;
                    case"3":
                    pendu.Jouer();
                    break;
                case"4":
                    System.Environment.Exit(0);
                    break;
            }
        }


    }
}
