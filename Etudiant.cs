using System;
using System.Collections.Generic;
using System.Text;

namespace CalculMoyenne
{
    class Etudiant
    {
        private string nom;
        private int ds;
        private int exam;
        private int np;
        
        public void Initialise(String N, int D, int E, int NP)
        {
            this.nom = N;
            this.ds = D;
            this.exam = E;
            this.np = NP;
        }

        public double Moyenne()
        {
            double Moy = this.ds * 0.3 + this.np * 0.2 + this.exam * 0.5;
            return Moy;
        }

        public string Afficher()
        {
            return nom + "\t" + this.Moyenne().ToString();
        }
    }

    

}
