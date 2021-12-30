using System;
using System.Collections.Generic;
using System.Text;

// Classe qui représente le boulier. On y retire les boules au hazard.

namespace ProjetJeuPOO.Bingo
{
    class Boulier : IBingoBoulier
    {
        private Player player;
        private BingoBall[,] Annonceur;
        private List<BingoBall> boulier;
        // Le constructeur de la classe




        public void add(BingoBall element)
        {
            throw new NotImplementedException();
        }

        public BingoBall getRanbomBall()
        {
            throw new NotImplementedException();
        }

        public int getSize()
        {
            throw new NotImplementedException();
        }

        public bool isEmpty()
        {
            throw new NotImplementedException();
        }

        public void restartBoulier()
        {
            throw new NotImplementedException();
        }
        public void BingoMenu()
        {
            Console.WriteLine("Choisir l'option suivante : ");
            Console.WriteLine("1 - Initialiser une nouvelle partie");
            Console.WriteLine("2 - Visualiser une carte");
            Console.WriteLine("3 - Visualiser la carte de l'annonceur");
            Console.WriteLine("4 - Tirez une boule");
            Console.WriteLine("5 - Fin de partie");
        }

    }
}
