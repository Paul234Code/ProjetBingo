using ProjetJeuPOO.Bingo;
using ProjetJeuPOO.SimiliBlackJack;
using ProjetJeuPOO.SimiliPendu;
using System;
using System.Collections.Generic;

namespace ProjetJeuPOO
{
    class Controller
    {
        static void Main()
        {
            ListeDeMots liste = new ListeDeMots()
            {
                ListeDeMot = new List<string> {"programmation","informatique","civilisation", "Orange", "Mangue", "developpement", "Recommandation", "Banana", "Poire", "Deroulement", "Pomme", "Limon", "Cerise", "Ordinateur" }
            };           
                       
            StartApplication app =  new StartApplication();
            //app.Demarrer();
            ListeDeMots listeDe = new ListeDeMots();
            foreach (string item in listeDe.ListeDeMot)
            {
                Console.WriteLine(item);
            }


           
            


        }

    }
}
