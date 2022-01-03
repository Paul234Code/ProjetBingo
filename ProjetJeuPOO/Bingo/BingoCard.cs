using System;
using System.Threading;

// Classe représentant un objet carte pour le joueur.
// Un joueur a au minimum une carte.
namespace ProjetJeuPOO.Bingo
{
    public class BingoCard
    {
        private BingoBall[,] carteJoueur;
        public BingoBall[,] CarteJoueur
        {
            get => carteJoueur;
            set => carteJoueur = value;
        }
        // Le constructeur de la classe
        public BingoCard()
        {
            carteJoueur = new BingoBall[5, 5];
        }
        // Fonction qui permet d'afficher la carte  du joueur
        public void AfficheAnnonceur()
        {
            int i = 0;
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"{'B'}\t| {'I'}\t| {'N'}\t| {'G'}\t| {'O'}\t|");
            Console.WriteLine("-----------------------------------------");
            while (i < carteJoueur.GetLength(0))
            {
                for (int j = 0; j < carteJoueur.GetLength(1); j++)
                {
                    if (i == 2 && j == 2)
                    {
                        Console.Write($"{0}\t| ");
                    }
                    else if (carteJoueur[i, j] == null)
                    {
                        Console.Write($"{0}\t| ");
                    }
                    else
                    {
                        Console.Write($"{carteJoueur[i, j].Number}\t| ");
                    }
                }
                Console.WriteLine();
                i++;
            }
            Console.WriteLine("-----------------------------------------");
            Thread.Sleep(4000);
            Console.Clear();

        }



    }
}
