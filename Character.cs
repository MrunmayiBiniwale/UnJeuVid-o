using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnJeuVidéo
{
    public class Character
    {
        public string nom;
        public int pointsDeVie;
        public int forceDAttaque;
        public int forceDeDéfense;

        public bool IsAlive() {
            bool isAlive = true;
            if(pointsDeVie <= 0) //if the life points are zero or less than zero then charachter is dead.
                isAlive = false;
            return isAlive;
        }

        public void Attack(Character attaquant)
        {
            if(attaquant.forceDAttaque > forceDeDéfense)
                pointsDeVie = pointsDeVie - (attaquant.forceDAttaque - forceDeDéfense); //calculate life points after the attack.
        }
    }
}
