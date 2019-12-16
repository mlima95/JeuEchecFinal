using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuEchec
{
    class Case : Button
    {
        private string name;
          public string NameCase
        {
            get => name; set => name = value;
        }
        public Case(string name)
        {
            this.Name = name;
            this.Size = new System.Drawing.Size(50,50);
            this.Margin = new Padding(0,0,0,1);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);
        }

    }
}
