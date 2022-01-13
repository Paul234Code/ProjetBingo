using System;
using System.Collections.Generic;
using System.IO;

namespace ProjetJeuPOO.SimiliPendu
{
    class ListeDeMots
    {
        private List<string> listeDeMot;
        // Constructeur
        public List<string> ListeDeMot
        {
            get => listeDeMot;
            set => listeDeMot = value;
        }
        // Le constructeur
        public ListeDeMots()
        {
            
            InitializeMot();        
        }
        // Fonction qui initialise la liste avec les mots
        public void InitializeMot()
        {
            listeDeMot = new List<string>();
            var listeDeMots = new List<string>() {"programmation","informatique","Pomme","Ordinateur","Limon","Cerise","Deroulement","Poire","Banana","civilisation", "Orange","Mangue", "developpement","Universite" };

            foreach (var item in listeDeMots)
            {
                listeDeMot.Add(item);
            }
        }
        // Fonction qui permet de retourner un mot au hasard
        public string getRandomWord()
        {
            Random random = new Random();
            int index = random.Next(0, listeDeMot.Count);
            return listeDeMot[index];
        }
    }
}
