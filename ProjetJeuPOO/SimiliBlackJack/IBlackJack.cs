﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.SimiliBlackJack
{
    public interface IBlackJack
    {
        public void Jouer();
        public void VoirScore();
        public void DealCard(); // distribuer les cartes
    }
}
