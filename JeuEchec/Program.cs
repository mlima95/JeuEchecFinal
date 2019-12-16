using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuEchec
{
    static class Program
    {
        static Form_Jeu jeu;
        static Choice choice;
        static Login login;
        static bool solo = false;
        static Joueur Joueur = new Joueur();

        public static Joueur Joueur1 { get => Joueur; set => Joueur = value; }



        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            jeu = new Form_Jeu();
            choice = new Choice();
            login = new Login();
            choice.BtnSolo.Click += new EventHandler(Button_Solo);
            choice.BtnVs.Click += new EventHandler(Button_Multi);
            login.BtnReturn.Click += new EventHandler(Button_Return);
            login.BtnStart.Click += new EventHandler(Button_Start);
            choice.BtnCharger.Click += new EventHandler(Button_Charger);
            Application.EnableVisualStyles();
            Application.Run(choice);
            //Application.SetCompatibleTextRenderingDefault(false);
        }
        static void Button_Solo(object sender, EventArgs e)
        {
            solo = true;
            login.Show();
            choice.Hide();
            if (solo == true)
            {
                login.LblJ2.Hide();
                login.TextBox2.Hide();
            }
        }

        static void Button_Charger(object sender, EventArgs e)
        {
            jeu.Charger = true;
           // jeu.InitPlateau();
            login.Show();
        }


        static void Button_Multi(object sender, EventArgs e)
        {
            solo = false;
            login.Show();
            choice.Hide();
            if (solo == false)
            {
                login.LblJ1.Show();
                login.TextBox1.Show();
                login.LblJ2.Show();
                login.TextBox2.Show();
            }


        }

        static void Button_Start(object sender, EventArgs e)
        {
            if (login.TextBox1.Text.Equals("") || login.TextBox2.Text.Equals(""))
            {
                MessageBox.Show("Champs Vide ! veuillez entrer une saisie .");
            }
            else
            {
                if (login.TextBox2.Text.Equals(""))
                {
                    Joueur.Add(new Joueur("blanc", login.TextBox1.Text));
                }
                else
                {
                    Joueur.Add(new Joueur("blanc", login.TextBox1.Text));
                    Joueur.Add(new Joueur("noir", login.TextBox2.Text));
                }
                login.Hide();
                jeu.InitPlateau();
                jeu.Show();
                jeu.LblTour1.Text = "Au tour de :" + Joueur.getLesJoueurs[0].Nom;
            }

        }

        static void Button_Return(object sender, EventArgs e)
        {
            jeu.Charger = false;
            choice.Show();
            login.Hide();
        }
    }
}
