using System;
using System.Collections.Generic;
using System.Text;

// Classe représentant un objet carte pour le joueur.
// Un joueur a au minimum une carte.

namespace ProjetJeuPOO.Bingo
{
    class BingoCard
    {
        private BingoBall[,] carteJoeur ;
        public BingoBall[,] CarteJoeur {
            get =>carteJoeur;
            set => carteJoeur = value;
        }
        // Le constructeur de la classe
        public BingoCard()
        {
            carteJoeur = new BingoBall[5, 5];
        }
        // Fonction qui permet de construire une carte du joueur
        public int[,] CreerCarteJoueur(List<int> liste)
        {
            int[,] Tableau = new int[5, 5];
            Tableau[2, 2] = 0;
            List<int> listeB = Construire(liste, 1, 15);
            List<int> listeI = Construire(liste, 16, 30);
            List<int> listeN = ConstruireMilieu(liste, 31, 45);
            List<int> listeG = Construire(liste, 46, 60);
            List<int> listeO = Construire(liste, 61, 75);
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
            return Tableau;
        }
        // permet de construire les colonnes B,I,G,0
        public List<int> Construire(List<int> liste, int minimum, int maximum)
        {
            List<int> listeB = new List<int>();
            int indice;
            int randomNumber;
            //int compteur = 0;
            Random random = new Random();
            while (listeB.Count < 5)
            {
                indice = random.Next(0, liste.Count);
                randomNumber = liste[indice];
                if (minimum <= randomNumber && randomNumber <= maximum)
                {
                    if (!listeB.Contains(randomNumber))
                    {
                        listeB.Add(randomNumber);
                    }
                }
            }
            return listeB;
        }
        // fonction qui construit la colonne du milieu N
        public List<int> ConstruireMilieu(List<int> liste, int minimum, int maximum)
        {
            List<int> listeB = new List<int>();
            int indice, randomNumber;
            Random random = new Random();
            while (listeB.Count < 5)
            {
                indice = random.Next(0, liste.Count);
                randomNumber = liste[indice];
                if (minimum <= randomNumber && randomNumber <= maximum)
                {
                    if (!listeB.Contains(randomNumber))
                    {
                        listeB.Add(randomNumber);
                    }
                }
            }
            return listeB;
        }

    }
}
