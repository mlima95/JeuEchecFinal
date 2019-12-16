using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuEchec
{
    class Joueur
    {
        private string color;
        private string nom;
        List<Joueur> Joueurs = new List<Joueur>();


        public void Add(Joueur joueur)
        {
            Joueurs.Add(joueur);

        }

        public Joueur getJoueur
        {
            get { return this; }
        }

        public string Nom { get => nom; set => nom = value; }
        public string Color { get => color; set => color = value; }
        public List<Joueur> getLesJoueurs { get => Joueurs; set => Joueurs = value; }

        public Joueur()
        {
            // this.nom;
            //  this.color = color;
        }

        public void ChangementJoueur()
        {
            if (this.color.Equals("blanc"))
            {
                this.color = "noir";
            }
            else
            {
                this.color = "blanc";
            }
        }

        public Joueur(string color, string nom)
        {
            this.nom = nom;
            this.color = color;
        }

    }
}
