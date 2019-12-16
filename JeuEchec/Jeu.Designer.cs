using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace JeuEchec
{
    partial class Form_Jeu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxHisto = new System.Windows.Forms.ListBox();
            this.LblTour = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_position = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.picture_Piece = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new JeuEchec.Layout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Piece)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxHisto
            // 
            this.listBoxHisto.FormattingEnabled = true;
            this.listBoxHisto.Location = new System.Drawing.Point(0, 529);
            this.listBoxHisto.Name = "listBoxHisto";
            this.listBoxHisto.Size = new System.Drawing.Size(284, 82);
            this.listBoxHisto.TabIndex = 2;
            // 
            // LblTour
            // 
            this.LblTour.AutoSize = true;
            this.LblTour.Location = new System.Drawing.Point(290, 529);
            this.LblTour.Name = "LblTour";
            this.LblTour.Size = new System.Drawing.Size(62, 13);
            this.LblTour.TabIndex = 3;
            this.LblTour.Text = "Au tour de :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pièce Selectionnée";
            // 
            // lb_position
            // 
            this.lb_position.AutoSize = true;
            this.lb_position.Location = new System.Drawing.Point(393, 595);
            this.lb_position.Name = "lb_position";
            this.lb_position.Size = new System.Drawing.Size(44, 13);
            this.lb_position.TabIndex = 6;
            this.lb_position.Text = "Position";
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Location = new System.Drawing.Point(299, 595);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(33, 13);
            this.lbTimer.TabIndex = 7;
            this.lbTimer.Text = "Timer";
            // 
            // picture_Piece
            // 
            this.picture_Piece.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picture_Piece.Location = new System.Drawing.Point(486, 540);
            this.picture_Piece.Name = "picture_Piece";
            this.picture_Piece.Size = new System.Drawing.Size(86, 71);
            this.picture_Piece.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture_Piece.TabIndex = 5;
            this.picture_Piece.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BackgroundImage = global::JeuEchec.Properties.Resources.Plateau;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 12);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(56, 47, 48, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(507, 504);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // Form_Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 617);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.lb_position);
            this.Controls.Add(this.picture_Piece);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblTour);
            this.Controls.Add(this.listBoxHisto);
            this.MaximizeBox = false;
            this.Name = "Form_Jeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plateau";
            ((System.ComponentModel.ISupportInitialize)(this.picture_Piece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxHisto;
        private System.Windows.Forms.Label LblTour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picture_Piece;
        private System.Windows.Forms.Label lb_position;
        private System.Windows.Forms.Label lbTimer;
        private Layout flowLayoutPanel1;

        public Label LblTour1 { get => LblTour; set => LblTour = value; }
    }
}

