using ProjetJeuPOO.Bingo;
using ProjetJeuPOO.SimiliBlackJack;
using ProjetJeuPOO.SimiliPendu;
using System;
using System.Collections.Generic;
using System.Threading;

namespace ProjetJeuPOO
{
    public class StartApplication
    {
        private Boulier boulier = new Boulier();
        private BlackJackController blackJackController;
        private Pendu pendu;
        // Le constructeur
        public StartApplication()
        {
            boulier = new Boulier();
            blackJackController = new BlackJackController();          
            pendu = new Pendu();
        }
        // Fonction qui identifie le nom de l'Utilisateur
        public string Identification()
        {
            Console.WriteLine("Entrer votre nom pour démarrer");
            string nom = Console.ReadLine();
            Console.Clear();
            return nom;
        }
        // Fonction qui permet de demarrer un jeu
        public void Demarrer()
        {
            Console.WriteLine("1- Demarrer un Jeu");
            Console.WriteLine("2- Quitter l'application");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    RunApp(Identification());
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
            }
        }
        // Fonction qui affiche les parties jouees
        public void VoireScore()
        {
            Console.WriteLine("+++++++++++++++++ Score du Bingo +++++++++++++++++++++++++++");
            Console.WriteLine();
            Console.WriteLine($"Nombre parties jouees: {Boulier.NombrePartiesJouees}");
            Console.WriteLine($"Nombre de Victoires :  {Boulier.NombreVictoires}");
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++ Score du Simili black jack +++++++++++++++");
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++ Score du Pendu +++++++++++++++++++++++++++");
        }
        // Fonction qui affiche un message de Bienvenue
        public void Message(string name)
        {
            Console.WriteLine();
            for (int i = 0; i < 100; i++)
            {
                Console.Write("#");
                Thread.Sleep(10);            
            }
            Console.WriteLine();
            Console.WriteLine($"#####\t\t\t\tBienvenue {name} dans Application \t\t\t############");
            for (int i = 0; i < 100; i++)
            {
                Console.Write("#");
                Thread.Sleep(10);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            VoireScore();
        }
        // Fonction qui affiche le Menu de l'application
        public void MenuApp()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1- Bingo");
            Console.WriteLine("2- SIMILI Black Jack");
            Console.WriteLine("3- Le Pendu");
            Console.WriteLine("4- Femer Session");
        }
        // Fonction qui affiche le Menu principal de l'application
        public void RunApp(string prenom)
        {
            Message(prenom);
            MenuApp();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    boulier.StartBingoApp();
                    break;
                case "2":
                    blackJackController.Jouer();
                    break;
                case "3":
                    pendu.PenduMenu();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
            }
        }


    }
}
