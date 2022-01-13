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
            InitializeListMot();           
        }
        // Fonction qui initialise la liste avec les mots du fichier
        public void InitializeListMot()
        {           
            string filePath = "C:/Users/14182/Source/Repos/ProjetBingo/ProjetJeuPOO/SimiliPendu/TextFile1.txt";
            string[] TableauString = File.ReadAllLines(filePath);           
            foreach (var item in TableauString)
            {
                listeDeMot.Add(item);
            }
        }
        // Fonction qui permet de retourner un mot au hasard
        public string GetRandomWord()
        {
            Random random = new Random();
            int index = random.Next(0, listeDeMot.Count);
            return listeDeMot[index];
        }
    }
}
