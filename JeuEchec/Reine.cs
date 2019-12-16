﻿using JeuEchec.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuEchec
{
    class Reine : Piece
    {
        private Bitmap image;
        public Bitmap Image { get => image; set => image = value; }
        public Reine(string color) : base(color)
        {
            if (color == "noir")
            {
                image = new Bitmap(Resources.reineN);
            }
            else
            {
                image = new Bitmap(Resources.reineB);
            }
        }

       
    }
}
