using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuEchec
{
    public partial class Form_Jeu : Form
    {
        DateTime date;
        int joueur = 0;
        Plateau plateau;
        Dictionary<Case, Piece> dictionnaire;
        bool charger = false;

        public bool Charger { get => charger; set => charger = value; }

        public Form_Jeu()
        {
            InitializeComponent();
            this.date = DateTime.Now;
           // InitPlateau();
        }
        public void InitPlateau()
        {

            String name;
            plateau = new Plateau();
            if(Charger)
            {
                plateau.Load();
            }
            
            dictionnaire = plateau.getMap();
            
            foreach (KeyValuePair<Case, Piece> Objet in dictionnaire)
            {

                name = Objet.Key.NameCase;
                if (Objet.Value != null)
                {
                    Type t = Objet.Value.GetType();
                    if (t.Equals(typeof(Pion)))
                    {
                        Pion pion1 = (Pion)Objet.Value;
                        Objet.Key.Image = pion1.Image;
                    }
                    if (t.Equals(typeof(Roi)))
                    {
                        Roi Roi1 = (Roi)Objet.Value;
                        Objet.Key.Image = Roi1.Image;
                    }
                    if (t.Equals(typeof(Reine)))
                    {
                        Reine Reine1 = (Reine)Objet.Value;
                        Objet.Key.Image = Reine1.Image;
                    }
                    if (t.Equals(typeof(Tour)))
                    {
                        Tour Tour1 = (Tour)Objet.Value;
                        Objet.Key.Image = Tour1.Image;
                    }
                    if (t.Equals(typeof(Fou)))
                    {
                        Fou Fou1 = (Fou)Objet.Value;
                        Objet.Key.Image = Fou1.Image;
                    }
                    if (t.Equals(typeof(Cavalier)))
                    {
                        Cavalier Cavalier1 = (Cavalier)Objet.Value;
                        Objet.Key.Image = Cavalier1.Image;
                    }
                }
                Objet.Key.Click += new EventHandler(Pieces_Click);
                flowLayoutPanel1.Controls.Add(Objet.Key);
            }
        }
        private void Pieces_Click(object sender, EventArgs e)
        {
            lbTimer.Text = (DateTime.Now - date).ToString();
            Type NamePiece;
            string[] NomPieces = new string[2];
            string NomPiecesFin = "";
            Joueur LeJoueur = Program.Joueur1.getLesJoueurs[joueur];
            Case casePiece = (Case)sender;
            bool resultFinGame;
            if (casePiece.BackColor == Color.Green)
            {
                string[] lbCase;
                lbCase = lb_position.Text.Split(':');
                string name = lbCase[1];
                Case caseLoc = new Case(name) ;
                foreach (KeyValuePair<Case, Piece> Objet in dictionnaire)
                {
                    if (Objet.Key.Name.Equals(name))
                    {
                        caseLoc = Objet.Key;
                        NamePiece = Objet.Value.GetType();
                        NomPiecesFin = Convert.ToString(NamePiece);
                        NomPieces = NomPiecesFin.Split('.');
                        NomPiecesFin = NomPieces[1];
                    }
                }
                foreach (KeyValuePair<Case, Piece> Objet in dictionnaire)
                {
                    Objet.Key.BackColor = Color.Transparent;
                }
                plateau.Deplacement(caseLoc,casePiece);
                plateau.Save();
                listBoxHisto.Items.Add("Le joueur : "+LeJoueur.Nom+" a deplacé "+ NomPiecesFin + " de la position " + caseLoc.Name + " en "+casePiece.Name);
                resultFinGame = FinJeu();
                if(resultFinGame == false)
                {
                    if (joueur == 1)
                    {
                        joueur = 0;
                        LeJoueur = Program.Joueur1.getLesJoueurs[joueur];
                        LblTour.Text = "Au tour de :" + LeJoueur.Nom;
                    }
                    else
                    {
                        joueur = 1;
                        LeJoueur = Program.Joueur1.getLesJoueurs[joueur];
                        LblTour.Text = "Au tour de :" + LeJoueur.Nom;
                    }
                }
                else
                {
                    if (resultFinGame == true)
                    {
                        if (joueur == 1 || joueur == 0)
                        {
                            LeJoueur = Program.Joueur1.getLesJoueurs[joueur];
                            DialogResult result = MessageBox.Show("Fin du jeu " + LeJoueur.Nom + " a gagné Voulez vous recommencer ?", "Alert !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result.Equals(DialogResult.Yes))
                            {
                                dictionnaire.Clear();
                                flowLayoutPanel1.Controls.Clear();
                                InitPlateau();
                                this.date = DateTime.Now;
                                listBoxHisto.Items.Clear();
                                lb_position.Text = "Position :";
                                joueur = 0;
                                LeJoueur = Program.Joueur1.getLesJoueurs[joueur];
                                LblTour.Text = "Au tour de :" + LeJoueur.Nom;
                            }
                            if (result.Equals(DialogResult.No))
                            {
                                this.Close();
                            }
                        }

                    }
                }
 
            }
            else
            {

                List<Case> LesCases = new List<Case>();
                LesCases = plateau.Deplacement_possible(casePiece, LeJoueur);
                foreach(Case uneCase in LesCases)
                {
                    uneCase.BackColor = Color.Green;
                }
                lb_position.Text = "Position :" + casePiece.Name;
                picture_Piece.Image = casePiece.Image;
            }
        }
        private bool FinJeu()
        {
            int i = 0;

            foreach (KeyValuePair<Case, Piece> Objet in dictionnaire)
            {
                if (Objet.Value != null)
                {
                    Type t = Objet.Value.GetType();
                    if (t.Equals(typeof(Roi)))
                    {
                        i = i + 1;
                    }
                }
            }
            return (i == 2 ? false : true);
        }

    }
}
