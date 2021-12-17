using System;
using System.Collections.Generic;
using System.Text;

//Classe représentant un objet boule 

namespace ProjetJeuPOO.Bingo
{
    class BingoBall
    {
        private int number;
        private char letter;
        // Les proprietes
        public int Number {
            get => number;
            set => number = value;
        }
        public char Letter {
            get => letter;
            set => letter = value;
        }
        // Le constructeur
        public BingoBall(int number,char letter)
        {
            this.number = number;
            this.letter = letter;
        }
    }
}
