using ProjetJeuPOO.Bingo;
using ProjetJeuPOO.SimiliBlackJack;
using ProjetJeuPOO.SimiliPendu;
using System;
using System.Threading;

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
        // Fonction qui identifie le nom de la personne
        public void Identification()
        {
            Console.WriteLine("Enter votre nom");
            string nom = Console.ReadLine();
        }
        // Fonction qui affiche le Menu principal
        public  void MenuPrincipal()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("#");
                Thread.Sleep(5);
            }
            Console.WriteLine();
            Console.WriteLine("\t\t\t\tBienvenue dans Application");
            for(int i = 0; i< 100; i++)
            {
                Console.Write("#");
                Thread.Sleep(5);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1- Jeu du Bingo");
            Console.WriteLine("2- Jeu du SIMILI Black Jack");
            Console.WriteLine("3- Jeu du SIMILI PENDU");
            Console.WriteLine("4- Femer Session");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    boulier.StartBingoApp();
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
