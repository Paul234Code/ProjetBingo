using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.SimiliPendu
{
    class Pendu : IPendu
    {
        static int nbrePartieJouee = 0;
        static int nbreVictoires = 0;
        private ListeDeMots listeDeMot;
        public ListeDeMots ListeDeMots { get; set; } 
        // Le constructeur de la classe Pendu
        public Pendu(ListeDeMots listeDeMot)
        {
            this.listeDeMot = listeDeMot;

        }
       // Fonction qui transforme un string en string (----------)
       public string TransformRandomWord()
       {
            string str = listeDeMot.getRandomWord();
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = '-';
            }
            return new string(chars);
       }
        public void AfficherGagnant()
        {
            throw new NotImplementedException();
        }

        public void Jouer()
        {
            throw new NotImplementedException();
        }
    }
}
