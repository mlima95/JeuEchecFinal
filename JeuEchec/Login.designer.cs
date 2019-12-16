using System.Windows.Forms;

namespace JeuEchec
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblJ1 = new System.Windows.Forms.Label();
            this.lblJ2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJ1
            // 
            this.lblJ1.AutoSize = true;
            this.lblJ1.Location = new System.Drawing.Point(13, 27);
            this.lblJ1.Name = "lblJ1";
            this.lblJ1.Size = new System.Drawing.Size(48, 13);
            this.lblJ1.TabIndex = 0;
            this.lblJ1.Text = "Joueur 1";
            // 
            // lblJ2
            // 
            this.lblJ2.AutoSize = true;
            this.lblJ2.Location = new System.Drawing.Point(12, 63);
            this.lblJ2.Name = "lblJ2";
            this.lblJ2.Size = new System.Drawing.Size(48, 13);
            this.lblJ2.TabIndex = 1;
            this.lblJ2.Text = "Joueur 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(82, 115);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(3, 169);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 220);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblJ2);
            this.Controls.Add(this.lblJ1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJ1;
        private System.Windows.Forms.Label lblJ2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnStart;
        private Button btnReturn;

        public Label LblJ1 { get => lblJ1; set => lblJ1 = value; }
        public Label LblJ2 { get => lblJ2; set => lblJ2 = value; }
        public TextBox TextBox1 { get => textBox1; set => textBox1 = value; }
        public TextBox TextBox2 { get => textBox2; set => textBox2 = value; }
        public Button BtnReturn { get => btnReturn; set => btnReturn = value; }
        public Button BtnStart { get => btnStart; set => btnStart = value; }
    }
}