using System.Windows.Forms;

namespace JeuEchec
{
    partial class Choice
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
            this.btnSolo = new System.Windows.Forms.Button();
            this.btnVs = new System.Windows.Forms.Button();
            this.btnCharger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSolo
            // 
            this.btnSolo.Location = new System.Drawing.Point(57, 34);
            this.btnSolo.Name = "btnSolo";
            this.btnSolo.Size = new System.Drawing.Size(106, 23);
            this.btnSolo.TabIndex = 0;
            this.btnSolo.Text = "Solo";
            this.btnSolo.UseVisualStyleBackColor = true;
            // 
            // btnVs
            // 
            this.btnVs.Location = new System.Drawing.Point(57, 76);
            this.btnVs.Name = "btnVs";
            this.btnVs.Size = new System.Drawing.Size(106, 23);
            this.btnVs.TabIndex = 1;
            this.btnVs.Text = "1 VS 1";
            this.btnVs.UseVisualStyleBackColor = true;
            // 
            // btnCharger
            // 
            this.btnCharger.Location = new System.Drawing.Point(57, 116);
            this.btnCharger.Name = "btnCharger";
            this.btnCharger.Size = new System.Drawing.Size(106, 23);
            this.btnCharger.TabIndex = 2;
            this.btnCharger.Text = "Charger";
            this.btnCharger.UseVisualStyleBackColor = true;
            // 
            // Choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 161);
            this.Controls.Add(this.btnCharger);
            this.Controls.Add(this.btnVs);
            this.Controls.Add(this.btnSolo);
            this.Name = "Choice";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSolo;
        private System.Windows.Forms.Button btnVs;
        private Button btnCharger;

        public Button BtnSolo { get => btnSolo; set => btnSolo = value; }
        public Button BtnVs { get => btnVs; set => btnVs = value; }
        public Button BtnCharger { get => btnCharger; set => btnCharger = value; }
    }
}