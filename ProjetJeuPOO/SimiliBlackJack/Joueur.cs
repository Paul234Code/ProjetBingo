﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.SimiliBlackJack
{
    public class Joueur
    {
       
        private decimal mise;
        private Hand handPlayer;
        private static int nombreDePoints;
        private static int nombreDePartie;
        private static int nombreVictoires ;
        // Les proprietes de la classe
        public string Name { get; set; }
        public decimal Mise {
            get { return mise; }
            set { mise = value; } 
        }
        public Hand HandPlayer {
            get { return handPlayer; } 
            set { handPlayer = value; }
        }
        public static int NombreDePoints {
            get => nombreDePoints;
            set => nombreDePoints = value;
        }
        public  static int NombreDeParties {
            get => nombreDePartie;
            set => nombreDePartie = value;
        }
        public  static int NombreVictoires {
            get => nombreVictoires;
            set => nombreVictoires = value;
        }

        public Joueur()
        {
            handPlayer = new Hand();
            nombreDePoints = 0;
            nombreDePartie = 0;
            nombreVictoires = 0;
        }
    }
}
