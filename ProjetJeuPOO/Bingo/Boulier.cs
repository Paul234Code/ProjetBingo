using System;
using System.Collections.Generic;
using System.Threading;

// Classe qui représente le boulier. On y retire les boules au hazard.

namespace ProjetJeuPOO.Bingo
{
    public class Boulier : IBingoBoulier
    {
        private Player player;
        private BingoBall[,] Annonceur;
        private List<BingoBall> boulier;
        public List<BingoBall> MyListe
        {
            get => boulier; set => boulier = value;
        }
        public static int NombrePartiesJouees { get; set; } = 0;
        public static int NombreVictoires { get; set; } = 0;
        // Le constructeur de la classe
        public Boulier()
        {
            player = new Player();
            Annonceur = new BingoBall[15, 5];
            InitializeBoulier();
        }
        // Fonction qui permet d'initialiser le boulier
        public void InitializeBoulier()
        {
            boulier = new List<BingoBall>();
            // la colonne B
            for (int i = 1; i <= 15; i++)
            {
                boulier.Add(new BingoBall(i,'B'));
            }
            // La colonne I
            for(int i = 16;i <= 30; i++)
            {
                boulier.Add(new BingoBall(i, 'I'));
            }
            // La colonne N
            for (int i = 31; i <= 45; i++)
            {
                boulier.Add(new BingoBall(i, 'I'));
            }
            // La colonne G
            for (int i = 46; i <= 60; i++)
            {
                boulier.Add(new BingoBall(i, 'I'));
            }
            // La colonne O
            for (int i = 61; i <= 75; i++)
            {
                boulier.Add(new BingoBall(i, 'I'));
            }
        }
        // Fonction qui initialise le nombres de cartes du joeur
        public void Initialisation()
        {
            Console.WriteLine("Combien de carte desirez-vous:(max 4)");
            string numero = Console.ReadLine();
            bool resultat = int.TryParse(numero, out int numberOfcard);
            if (resultat)
            {
                for (int i = 1; i <= numberOfcard; i++)
                {
                    BingoCard bingoCard = CreerCarteJoueur();
                    player.AddBingoCard(bingoCard, i);
                }
            }
            else
            {
                Console.WriteLine("Veullez entre un nombre valide (max 4)");
            }
            Console.WriteLine("Initialisation du nombre de cartes en cours.........");
            Thread.Sleep(3000);
            for (int i = 1; i <= numberOfcard; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Thread.Sleep(1000);
                Console.WriteLine($"Initialisation carte numero {i}.....ok");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Initialisation terminé avec success......ok");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);
            Console.Clear();
            BingoMenu();
        }
        // Fonction qui permet de construire une carte du joueur
        public BingoCard CreerCarteJoueur()
        {
            BingoBall[,] Tableau = new BingoBall[5, 5];
            BingoCard bingoCard = new BingoCard();
            Tableau[2, 2] = null;
            List<BingoBall> listeB = Construire(1, 15);
            List<BingoBall> listeI = Construire(16, 30);
            List<BingoBall> listeN = ConstruireMilieu(31, 45);
            List<BingoBall> listeG = Construire(46, 60);
            List<BingoBall> listeO = Construire(61, 75);
            for (int i = 0; i < listeB.Count; i++)
            {
                Tableau[i, 0] = listeB[i];
                Tableau[i, 1] = listeI[i];
                Tableau[i, 3] = listeG[i];
                Tableau[i, 4] = listeO[i];
            }
            Tableau[0, 2] = listeN[0];
            Tableau[1, 2] = listeN[1];
            Tableau[3, 2] = listeN[2];
            Tableau[4, 2] = listeN[3];
            bingoCard.CarteJoueur = Tableau;
            return bingoCard;
        }
        // permet de construire les colonnes B,I,G,0
        public List<BingoBall> Construire(int minimum, int maximum)
        {
            List<BingoBall> listeB = new List<BingoBall>();
            int indice;
            BingoBall randomBall;
            Random random = new Random();
            while (listeB.Count < 5)
            {
                indice = random.Next(0, boulier.Count);
                randomBall = boulier[indice];
                if (minimum <= randomBall.Number && randomBall.Number <= maximum)
                {
                    if (!listeB.Contains(randomBall))
                    {
                        listeB.Add(randomBall);
                    }
                }
            }
            return listeB;
        }
        // Fonction qui permet de visualiser une carte
        public void Visualiser()
        {
            Console.WriteLine("Entrer le numero de la carte a afficher");
            string saisie = Console.ReadLine();
            bool result = int.TryParse(saisie, out int numeroCarte);
            if (result)
            {
                if (numeroCarte > 0)
                {
                    bool resulat = player.Dictionnary.ContainsKey(numeroCarte);
                    if (resulat)
                    {
                        player.Dictionnary[numeroCarte].AfficheAnnonceur();
                    }
                    else
                    {
                        Console.WriteLine("carte non trouvable");
                    }
                }
                else
                {
                    Console.WriteLine("Le numero de la carte doit etre positif");
                }
            }
            else
            {
                Console.WriteLine("Entrer un numero de carte valide");
            }
            Console.ReadLine();
            Console.Clear();
            BingoMenu();
        }
        // Fonction qui permet de visualiser la carte de l'annonceur
        public void VisualiserCarteAnnonceur()
        {
            int i = 0;
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"{'B'}\t| {'I'}\t| {'N'}\t| {'G'}\t| {'O'}\t|");
            Console.WriteLine("-----------------------------------------");
            while (i < Annonceur.GetLength(0))
            {
                for (int j = 0; j < Annonceur.GetLength(1); j++)
                {
                    if (Annonceur[i, j] == null)
                    {
                        Console.Write($"{0}\t| ");
                    }
                    else
                    {
                        Console.Write($"{Annonceur[i, j].Number}\t| ");
                    }
                }
                Console.WriteLine();
                i++;
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            Thread.Sleep(5000);
            Console.ReadLine();
            Console.Clear();
            BingoMenu();
        }
        // fonction qui construit la colonne du milieu N
        public List<BingoBall> ConstruireMilieu(int minimum, int maximum)
        {
            List<BingoBall> listeB = new List<BingoBall>();
            int indice;
            BingoBall randomBall;
            Random random = new Random();
            while (listeB.Count < 5)
            {
                indice = random.Next(0, boulier.Count);
                randomBall = boulier[indice];
                if (minimum <= randomBall.Number && randomBall.Number <= maximum)
                {
                    if (!listeB.Contains(randomBall))
                    {
                        listeB.Add(randomBall);
                    }
                }
            }
            return listeB;
        }
        // Fonction qui permet de tirer une boule au hasard dans le boulier
        public BingoBall getRanbomBall()
        {
            Random random = new Random();
            int number = random.Next(1, boulier.Count);
            BingoBall bingoBall = boulier[number];
            add(bingoBall);
            foreach (var keys in player.Dictionnary.Keys)
            {
                if (Verifier(player.Dictionnary[keys], bingoBall))
                {
                    Console.WriteLine($"Boule numero {bingoBall.Number} trouver dans la carte {keys}");
                }
            }
            boulier.RemoveAt(number);
            return bingoBall;
        }
        // Fonction qui ajoute une boule tirée au hasard dans la carte de l'annonceur
        public void add(BingoBall bingoBall)
        {
            if (bingoBall.Number <= 15)
            {
                InsererNumber(bingoBall, 0);
            }
            else if (bingoBall.Number <= 30)
            {
                InsererNumber(bingoBall, 1);
            }
            else if (bingoBall.Number <= 45)
            {
                InsererNumber(bingoBall, 2);
            }
            else if (bingoBall.Number <= 60)
            {
                InsererNumber(bingoBall, 3);
            }
            else
            {
                InsererNumber(bingoBall, 4);
            }
        }
        // Fonction qui permet d'inserer une boule dans une colonne de la carte de l'annonceur
        public void InsererNumber(BingoBall ball, int colonne)
        {
            List<BingoBall> liste = new List<BingoBall>();
            //liste.Add(valeur);
            for (int ligne = 0; ligne < Annonceur.GetLength(0); ligne++)
            {
                if (Annonceur[ligne, colonne] == null)
                {
                    Annonceur[ligne, colonne] = ball;
                    break;
                }
            }
            liste.Sort();
            for (int i = 0; i < Annonceur.GetLength(0); i++)
            {
                liste.Add(Annonceur[i, colonne]);
            }
            liste.Sort();
            liste.Reverse();
            for (int i = 0; i < liste.Count; i++)
            {
                Annonceur[i, colonne] = liste[i];
            }
        }

        // Fonction qui retourne la taille de la liste
        public int getSize()
        {
            return boulier.Count;
        }
        // Fonction qui verifie si le boulier est vide ou pas 
        public bool isEmpty()
        {
            return boulier.Count == 0;
        }

        public void restartBoulier()
        {
            Console.Clear();
            Console.WriteLine("Retourner au menu ou démarrer une nouvelle partie?");
            Console.WriteLine("1- Demarrer une nouvelle partie");
            Console.WriteLine("2- Retourner au menu principal");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    BingoMenu();
                    break;
                case "2":
                    Console.Clear();                 
                    break;
            }
        }
        // Menu principal du jeu Bingo 
        public void BingoMenu()
        {
            Console.WriteLine("Bienvenue dans le Jeu du Bingo");
            Console.WriteLine();
            Console.WriteLine("Choisir l'option suivante : ");
            Console.WriteLine("1 - Initialiser une nouvelle partie");
            Console.WriteLine("2 - Visualiser une carte");
            Console.WriteLine("3 - Visualiser la carte de l'annonceur");
            Console.WriteLine("4 - Tirez une boule");
            Console.WriteLine("5 - Fin de partie");
            Console.WriteLine();
            //string choice = Console.ReadLine();
        }
        public void StartBingoApp()
        {
           // BingoMenu();
            while (boulier.Count > 0)
            {
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Initialisation();
                        break;
                    case "2":
                        Visualiser();
                        break;
                    case "3":
                        VisualiserCarteAnnonceur();
                        break;
                    case "4":
                        getRanbomBall();
                        break;
                    case "5":
                        restartBoulier();
                        break;
                }
            }
        }
        // Fonction qui permet de verifier si un entier ou une boule dans le tableau
        // fonction a utilser dans pour verifier qu'une boole tirée est present dans la carte  du joueur
        public bool Verifier(BingoCard currentBingoCard, BingoBall bingoBall)
        {
            bool trouve = false;
            int ligne = 0;

            while (ligne < currentBingoCard.CarteJoueur.GetLength(0))
            {
                for (int colonne = 0; colonne < currentBingoCard.CarteJoueur.GetLength(1); colonne++)
                {
                    BingoBall bingo = currentBingoCard.CarteJoueur[ligne, colonne];
                    if (bingo == null)
                    {
                        continue;
                    }
                    else if (bingo.Number == bingoBall.Number)
                    {
                        trouve = true;
                        currentBingoCard.CarteJoueur[ligne, colonne] = null;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                ligne++;
            }
            return trouve;
        }

    }
}
