using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuEchec
{
    class Piece
    {
        private string color;

        public Piece(string color)
        {
            this.Color = color;
        }

        public string Color { get => color; set => color = value; }
    }
}
