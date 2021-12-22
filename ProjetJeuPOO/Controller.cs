using System;
using System.Collections.Generic;
using ProjetJeuPOO.Bingo;
using ProjetJeuPOO.SimiliBlackJack;
using ProjetJeuPOO.SimiliPendu;

namespace ProjetJeuPOO
{
    class Controller
    {
        static void Main(string[] args)
        {
            ListeDeMots liste = new ListeDeMots()
            {
                 ListeDeMot = new List<string>{"Orange","Mangue","Banana","Poire"}
            };
            
            string str1 = liste.getRandomWord();
            Console.WriteLine(str1);
            Pendu pendu = new Pendu(liste);
            string str =  pendu.TransformRandomWord();
            Console.WriteLine(str); 

        }
    }
}
