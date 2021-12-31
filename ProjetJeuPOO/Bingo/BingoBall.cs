using System;
using System.Collections.Generic;
using System.Text;

//Classe représentant un objet boule 

namespace ProjetJeuPOO.Bingo
{
    public class BingoBall
    {
        private int number;     
        // Les proprietes
        public int Number {
            get => number;
            set => number = value;
        }       
        // Le constructeur
        public BingoBall(int number)
        {
            this.number = number;          
        }
    }
}
