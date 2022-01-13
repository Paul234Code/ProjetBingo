using ProjetJeuPOO.Bingo;
using ProjetJeuPOO.SimiliBlackJack;
using ProjetJeuPOO.SimiliPendu;
using System;
using System.Threading;
using System.Collections.Generic;

namespace ProjetJeuPOO
{
    public class App
    {

        
        private BlackJackController blackJackController = new BlackJackController();
        private Boulier  boulier = new Boulier();
        /*ListeDeMots liste = new ListeDeMots()
        {
            ListeDeMot = new List<string>() { "Orange", "Mangue", "Bonjour", "developpement", "Recommandation", "Banana", "Poire", "Deroulement", "Pomme", "Limon", "Cerise", "Ordinateur" }
            }; */
        private Pendu pendu = new Pendu();

        public  void Menu()
        {
            Console.WriteLine("1- Jeu du Bingo");
            Console.WriteLine("2- Jeu du SIMILI Black Jack");
            Console.WriteLine("3- Jeu du SIMILI Pendu");
            Console.WriteLine("4- Femer Session");
            string choice = Console.ReadLine();
        }

    }
}
