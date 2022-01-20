using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using ProjetJeuPOO.Bingo;
using ProjetJeuPOO.SimiliBlackJack;
using ProjetJeuPOO.SimiliPendu;

namespace ProjetJeuPOO
{
    public class App
    {
        // Attributs
        private BlackJackController blackJackController =  new BlackJackController();
        private Boulier boulier = new Boulier();
        private Pendu pendu = new Pendu();
        // Les Fonctions de la classe
        public void MenuApp()
        {
            Message(Identification());
            Console.WriteLine();       
            Console.WriteLine("1- Bingo");
            Console.WriteLine("2- SIMILI Black Jack");
            Console.WriteLine("3- Le Pendu");
            Console.WriteLine("4- Femer Session");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    BingoApp();
                    break;
                case "2":
                    BlackJackApp();
                    break;
                case "3":
                    PenduApp();
                    break;
                case "4":
                    FermerSession();
                    break;
            }
        }
        // Fonction qui identifie le nom de l'Utilisateur
        public string Identification()
        {
            Console.WriteLine("Entrer votre nom pour démarrer");
            string nom = Console.ReadLine();
            Console.Clear();
            return nom;
        }
        // Fonction qui affiche un message de Bienvenue
        public void Message(string name)
        {
            Console.WriteLine();
            for (int i = 0; i < 80; i++)
            {
                Console.Write("+");
                Thread.Sleep(10);
            }
            Console.WriteLine();
            Console.WriteLine($"+++++++++++++++\tBienvenue {name.ToUpper()} dans l'espace Jeu Application +++++++++++++++++++");
            for (int i = 0; i < 80; i++)
            {
                Console.Write("+");
                Thread.Sleep(10);
            }
            Console.WriteLine();
           // VoireScore();
        }
        // Fonction qui lance un nouveau Tournoi de BlackJack
        public void LancerNouveauTournoi()
        {
            Console.WriteLine("Voullez-vous lancer un nouveau Tournoi  Retourner au Menu principal [Y/N]?");
            string choice = Console.ReadLine();
            switch (choice.ToUpper())
            {
                case "Y":
                    blackJackController.Jouer();
                    break;
                case "N":
                    MenuApp();
                    break;
            }
        }
        // Fonction qui demarre l'application principal
        public void Demarrer()
        {
            Console.WriteLine("Bienvenue Dans l'Application");
            Console.WriteLine("1- Demarrer");
            Console.WriteLine("2- Quitter l'application");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    MenuApp();
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
            }
        }
        // fonction qui ferme la session ou qui lance a nouveau l'application
        public void FermerSession()
        {
            Console.WriteLine("Voulez-vous quitter l'application[Y/N]?");
            string response = Console.ReadLine();
            switch (response.ToUpper())
            {
                case "Y":
                    Environment.Exit(0);
                    break;
                case "N":
                    Demarrer();
                    break;
            }
        }
        // Fonction pour le Bingo
        public void BlackJackApp()
        {
            Console.WriteLine();
            Console.WriteLine("Bienvenue dans le Jeu Blacjack");
            Console.WriteLine("1- Demarrer Le Jeu");
            Console.WriteLine("2- Quitter Le Jeu");
            string answer = Console.ReadLine();
            switch (answer.ToUpper())
            {
                case "1":
                    blackJackController.Jouer();
                    break;
                case"2":
                    MenuApp();
                    break;
            }

        }
        // Fonction qui demarre pour le jeu du Boulier
        public void BingoApp()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("Bienvenue dans le Jeu du Bingo");
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.WriteLine("Choisir l'option suivante : ");
            Console.WriteLine("1 - Initialiser une nouvelle partie");
            Console.WriteLine("2 - Visualiser une carte");
            Console.WriteLine("3 - Visualiser la carte de l'annonceur");
            Console.WriteLine("4 - Tirez une boule");
            Console.WriteLine("5 - Fin de partie");
            Console.WriteLine();
            while(boulier.MyListe.Count > 0)
            {
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        boulier.Initialisation();
                        break;
                    case "2":
                        boulier.Visualiser();
                        break;
                    case "3":
                        boulier.VisualiserCarteAnnonceur();
                        break;
                    case "4":
                        boulier.getRanbomBall();
                        break;
                    case "5":
                        boulier.restartBoulier();
                        break;
                }

            }
            
                

            
            
        }
        // Fonction pour qui demarre le jeu Pendu
        public void PenduApp()
        {
            Console.WriteLine("Bienvenue dans le jeu du SIMILI PENDU");
            Console.WriteLine("1- Demarrer Le Jeu");
            Console.WriteLine("2- Quitter Le Jeu");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    pendu.Jouer();
                    break;
                case "2":
                    NouvellePartie();
                    break;                    
            }
        }
        // Fonction qui lance une nouvelle partie du pendu
        public void NouvellePartie()
        {
            Console.WriteLine("1- Voulez-vous Lancer nouveau Tournoi ou Retourner au Menu principal[Y/N]?");
            string choice = Console.ReadLine();
            switch (choice.ToUpper())
            {
                case "Y":
                    pendu.Jouer();
                    break ;
                case "N":
                    MenuApp();
                    break;
            }

        }
    }
}
