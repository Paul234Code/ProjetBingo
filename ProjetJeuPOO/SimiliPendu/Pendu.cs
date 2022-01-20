using System;
using System.Collections.Generic;
using System.Threading;

namespace ProjetJeuPOO.SimiliPendu
{
    class Pendu : IPendu
    {
        static int NombrePartieJouee = 0;
        static int NombreVictoires = 0;
        static int PointsDeVies = 10;
        private static int NombreDePointsJoueur = 0;
        private static int NombreDePointsComputer = 0;
        Player player;
        private ListeDeMots listeDeMot;
        private Dictionary<char, bool> lettresJouees;
        public ListeDeMots ListeDeMots
        {
            get => listeDeMot;
            set => listeDeMot = value;
        }
        public Dictionary<char, bool> LettresJouees
        {
            get => lettresJouees;
            set => lettresJouees = value;
        }
        // Le constructeur de la classe Pendu
        public Pendu()
        {
            listeDeMot = new ListeDeMots();
            lettresJouees = new Dictionary<char, bool>();
            player = new Player();
        }
        // Fonction qui transforme un string en string (----------)
        public string TransformRandomWord(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = '-';
            }
            return new string(chars);
        }
        // Fonction qui donne un indice pour les mots de plus de 10 caracteres
        public string TransformRandomWord2(string str)
        {
            List<int> listeEntiers = GetRandomNumber(str.Length);
            char[] TabChar = str.ToCharArray();
            for (int i = 0; i < TabChar.Length; i++)
            {
                TabChar[i] = '-';
            }
            for (int i = 0; i < listeEntiers.Count; i++)
            {
                int indice = listeEntiers[i];
                TabChar[indice] = str[indice];
            }
            return new string(TabChar);
        }
        // Fonction qui retourne une liste de 5 entier distinctes
        public List<int> GetRandomNumber(int n)
        {
            List<int> liste = new List<int>();
            Random random = new Random();
            int number;
            while (liste.Count < 6)
            {
                number = random.Next(0, n);
                if (!liste.Contains(number))
                {
                    liste.Add(number);
                }               
            }
            return liste;
        }
        // Fonction boolenne qui retourne true si le mot contient un tiret
        public bool Verifiy(string str)
        {
            return str.Contains('-');
        }
        // Fonction qui permet de retourner la liste des indices d'un caractere dans un tableau
        public List<int> GetIndexOf(char[] Tabchar, char caracter)
        {
            int i = 0;
            List<int> listeIndice = new List<int>();
            while (i < Tabchar.Length)
            {
                if (Tabchar[i] == caracter)
                {
                    listeIndice.Add(i);
                }
                i++;
            }
            return listeIndice;
        }
        // Fonction qui inserre un char dans le mot transformer
        public string InsererChar(string str, char caracter, int position)
        {
            char[] TabChar = str.ToCharArray();
            if (TabChar[position] == '-')
            {
                TabChar[position] = caracter;
            }
            return new string(TabChar);
        }
        // Fonction qui insere un caractere par un caractere donnéé
        public string InserCharAtPosition(string str, char caracter, int position)
        {
            char[] Tab = str.ToCharArray();
            Tab[position] = caracter;
            return new string(Tab);
        }
        // Fonction qui affiche le gagnant du tournoi
        public void AfficherGagnant()
        {
            Console.WriteLine("Score du Tournoi:");
            Console.WriteLine($"Joeur: {NombreDePointsJoueur}");
            Console.WriteLine($"Ordinateur: {NombreDePointsComputer}");
            if (NombreDePointsJoueur > NombreDePointsComputer)
            {
                Console.WriteLine("Le Joueur est gagnant");
                ++NombreVictoires;
            }
            else
            {
                Console.WriteLine("L'Ordinateur est gagnant");
            }
        }
        public void JouerAvecMot10(string str1, string str2)
        {
            string tempon = str1;
            var lettresJouees = new Dictionary<char, bool>();
            while (Verifiy(str2))
            {
                Console.WriteLine("Enter a letter:");
                string saisie = Console.ReadLine();
                bool conversion = char.TryParse(saisie, out char chars);
                if (conversion && char.IsLetter(chars))
                {
                    if (tempon.Contains(chars)) //&& 
                    {
                        if (lettresJouees.ContainsKey(chars))
                        {
                            Console.WriteLine($"La lettre {chars} est deja jouéé", Console.ForegroundColor = ConsoleColor.Red);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            List<int> indices = GetIndexOf(tempon.ToCharArray(), chars);
                            int longueur = indices.Count;
                            Console.WriteLine($"Bravo! le  mot contient  la lettre {chars}", Console.ForegroundColor = ConsoleColor.Green);
                            Console.ForegroundColor = ConsoleColor.White;
                            while (longueur > 0)
                            {
                                int index = indices[0];
                                string chaine = InsererChar(str2, chars, index);
                                //tempon = InserCharAtPosition(tempon, '=', index);
                                str2 = chaine;
                                indices.RemoveAt(0);
                                longueur--;
                            }
                            Console.WriteLine(str2);
                            Console.WriteLine(Verifiy(str2));
                            lettresJouees[chars] = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Le mot ne contient pas la lettre {chars}", Console.ForegroundColor = ConsoleColor.Red);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    Console.WriteLine("Veuillez entrer une lettre valide", Console.ForegroundColor = ConsoleColor.Red);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        // Fonction qui permet de jouer au jeu
        public void startPenduApp()
        {
            Console.WriteLine("Bienvenue dans le jeu SIMILI PENDU");
            Console.WriteLine();
            Console.WriteLine("Demarrage du jeu en cours.......");
            Thread.Sleep(3000);
            {
                while (PointsDeVies > 0)
                {
                    Jouer();
                    PointsDeVies--;
                }
            }
        }
        // Fonction qui demarre le jeu du pendu
        public void Jouer()
        {
            Console.WriteLine("Bienvenue dans le jeu du SIMILI PENDU");
            Console.WriteLine();
            Console.WriteLine("Demarrage du jeu en cours.......");
            Thread.Sleep(3000);
            while (NombreDePointsComputer < 3 && NombreDePointsJoueur < 3)
            {
                Console.WriteLine($"Demarrage de la partie {++NombrePartieJouee}");
                string randomWord = listeDeMot.GetRandomWord();
                Console.WriteLine(randomWord);
                if (randomWord.Length <= 10)
                {
                    string str1 = TransformRandomWord(randomWord);
                    Console.WriteLine(str1);
                    JouerAvecMot10(randomWord, str1);
                    if (randomWord.Equals(str1))
                    {
                        NombreDePointsJoueur++;
                        Console.WriteLine(NombreDePointsJoueur);
                    }
                    else
                    {
                        NombreDePointsComputer++;
                    }
                }
                else
                {
                    string str2 = TransformRandomWord(randomWord);
                    Console.WriteLine(str2);
                    AvoirUnIndice(randomWord);
                    JouerAvecMot10(randomWord, str2);
                    if (randomWord.Equals(str2))
                    {
                        NombreDePointsJoueur++;
                        Console.WriteLine(NombreDePointsJoueur);
                    }
                    else
                    {
                        NombreDePointsComputer++;
                    }
                }
                Console.WriteLine("Voulez-vous jouer une nouvelle partie?");
                Console.WriteLine("Taper [ENTER] pour continuer or CTRL+C pour quitter");
                Console.ReadLine();
                Console.Clear();
            }
            AfficherGagnant();
            Console.WriteLine("Voulez-vous lancer un nouveau tournoi ou quitter");
            Console.WriteLine("1- Lancer nouveau Tournoi");
            Console.WriteLine("2- Retourner au Menu principal");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Jouer();
                    break;

                case "2":
                    break;
            }
        }
        // Possibilité d'avoir un indice pour un mot de plus de 10 caracteres
        public void AvoirUnIndice(string str)
        {
            Console.WriteLine("Le mot a devinner contient plus de 10 lettres");
            Console.WriteLine("Mais avez droit a un indice et voici comment faire");
            Console.WriteLine("Entrer le nombre de caractere pour indice(max: 6)");
            string str2 = Console.ReadLine();
            bool resultat = int.TryParse(str2, out int number);
            if (resultat)
            {
                var liste = GetListeNumber(str, number);
                Console.WriteLine("Le mot contient les lettres suivants");
                foreach (var item in liste)
                {
                    Console.Write($" {str.ToCharArray()[item]} ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Entrer un nombre entier de caractere valide");
            }
        }
        // Fonction qui genere un nombre de valeur aleatoirs et retourne une liste
        public List<int> GetListeNumber(string str, int number)
        {
            Random random = new Random();
            List<int> liste = new List<int>();
            while (number >= 1)
            {
                int valeur = random.Next(0, str.Length);
                if (!liste.Contains(valeur))
                {
                    liste.Add(valeur);
                }
                number--;
            }
            return liste;
        }
        // Fonction qui permet de jouer une nouveau Tournoi
        public void NouvellePartie()
        {
            Jouer();
        }
        // Le menu de pendu
        public void PenduMenu()
        {
            Console.Clear();
            Console.WriteLine("1- Demarrer le Jeu");
            Console.WriteLine("2- Quitter le Jeu");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Jouer();
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
