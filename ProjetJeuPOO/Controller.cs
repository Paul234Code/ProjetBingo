using ProjetJeuPOO.SimiliPendu;
using System;
using System.Collections.Generic;

namespace ProjetJeuPOO
{
    class Controller
    {
        static void Main()
        {
            StartApplication app = new StartApplication();
            //app.Demarrer();
            ListeDeMots dem = new ListeDeMots();
            foreach (string s in dem.ListeDeMot)
            {
                Console.WriteLine(s);
            }
        }
    }
}
