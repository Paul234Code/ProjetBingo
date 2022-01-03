using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.SimiliBlackJack
{
    public class Croupier
    {
        private Hand handDealer;
        private static int nombrePoints;
        public Hand HandDealer {
            get => handDealer; 
            set => handDealer = value; 
        }
        public static int NombrePoints {
            get => nombrePoints;
            set => nombrePoints = value;
        }
        // Le constructeur de la classe
        public Croupier()
        {
            handDealer = new Hand();
            nombrePoints = 0;
        }


    }
}
