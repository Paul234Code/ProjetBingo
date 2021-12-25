using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.SimiliPendu
{
    class Pendu : IPendu
    {
        //static int nbrePartieJouee = 0;
        //static int nbreVictoires = 0;
        private ListeDeMots listeDeMot;
        public ListeDeMots ListeDeMots {
            get => listeDeMot; 
            set => listeDeMot = value; 
        } 
        // Le constructeur de la classe Pendu
        public Pendu(ListeDeMots listeDeMot)
        {
            this.listeDeMot = listeDeMot;
        }
       // Fonction qui transforme un string en string (----------)
       public string TransformRandomWord(string str)
       {           
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = '-';
            }         
            return new string(chars);
       }
       // Fonction qui donne un indice pour les mots de plus de 10 caracteres
       public string TransformRandomWord2(string str)
       {
            List<int> listeEntiers = GetRandomNumber(str.Length);
            char[] TabChar = str.ToCharArray();
            for(int i = 0; i< TabChar.Length; i++)
            {
                TabChar[i] = '-';
            }
            for(int i = 0; i< listeEntiers.Count; i++)
            {
                int indice = listeEntiers[i];
                TabChar[indice] = str[indice];
            }
            return new string(TabChar);
       }
       // Fonction qui retourne une liste de 4 entier distinctes
        public List<int> GetRandomNumber(int n)
        {
            List<int> liste = new List<int>();
            Random random = new Random();
            int number ;
            while (liste.Count < 6)
            {
                number = random.Next(0, n);
                if (!liste.Contains(number))
                {
                    liste.Add(number);
                }
                else
                {

                }
            }
            return liste;
        }
        public bool Verifiy(string str)
        {           
            bool trouve = false;
            for(int indice = 0; indice < str.Length; indice++)
            {
                if(str[indice] == '-')
                {
                    trouve = true;
                }
                else
                {
                    continue;                    
                }               
            }
            return trouve;
        }
        // Fonction qui permet de retourner l'indice d'un caractere dans un tableau
       public int GetIndexOf( char[] Tabchar,char caracter)
       {
            int i = 0;
            while (i < Tabchar.Length && Tabchar[i]!= caracter)
            {
                i++;
            }
            if(i < Tabchar.Length)
            {
                Tabchar[i] = '=';
                return i;
            }
            else
            {
                return -1;
            }
       }
        // Fonction qui inserre un char dans le mot transformer
        public string InsererChar(string str, char caracter,int position)
        {
            char[] TabChar = str.ToCharArray();
            if (TabChar[position] == '-')
            {
                TabChar[position] = caracter;
            }
            else
            {

            }
            return new string(TabChar);           
        }
        // Fonction qui insere un caractere par un caractere donnéé
        public string InserCharAtPosition(string str,char caracter, int position)
        {
            char[] Tab = str.ToCharArray();
            Tab[position] = caracter;
            return new string(Tab);
        }
        public void AfficherGagnant()
        {
            throw new NotImplementedException();
        }
        public void JouerAvecMot10(string str1, string str2)
        {
            string tempon = str1;
            while (Verifiy(str2))
            {
                Console.WriteLine("Enter a letter:");
                string saisie = Console.ReadLine();
                bool conversion = char.TryParse(saisie, out char chars);
                int indice = GetIndexOf(tempon.ToCharArray(), chars);
                Console.WriteLine("indice = " + indice);
                string chaine = InsererChar(str2, chars, indice);
                tempon = InserCharAtPosition(tempon, '=', indice);
                str2 = chaine;
                Console.WriteLine(str2);
                Console.WriteLine(Verifiy(str2));
            }
        }

        public void Jouer()
        {
            string randomWord = listeDeMot.getRandomWord();
            Console.WriteLine(randomWord);
            if(randomWord.Length <= 10)
            {
                string str1 = TransformRandomWord(randomWord);
                Console.WriteLine(str1);
                JouerAvecMot10(randomWord, str1);
            }
            else
            {
                string str2 = TransformRandomWord2(randomWord);
                Console.WriteLine(str2);
                JouerAvecMot10(randomWord, str2);
            }
        }
    }
}
