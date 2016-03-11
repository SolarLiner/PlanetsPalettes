using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlanettePalette
{
    public partial class PalColor : UserControl
    {
        public PaletteColor col { get; private set; }
        
        public PalColor()
        {
            InitializeComponent();
            col = new PaletteColor();
            col.SetColor(Color.Black);
            UpdateColorBox();
        }

        public PalColor(PaletteColor Input)
        {
            InitializeComponent();
            
            col = Input;

            UpdateColorBox();
            UpdateLabel();
        }

        private void UpdateLabel()
        {
            ClassLabel.Text = col.Code;
        }

        private void UpdateColorBox()
        {
            R.Text = (col.col.R / 255.0f).ToString("0.000");
            G.Text = (col.col.G / 255.0f).ToString("0.000");
            B.Text = (col.col.B / 255.0f).ToString("0.000");
            A.Text = (col.col.A / 255.0f).ToString("0.000");
        }
        private void UpdateColor()
        {
            float Red = float.Parse(R.Text);
            float Green = float.Parse(G.Text);
            float Blue = float.Parse(B.Text);
            float Alpha = float.Parse(A.Text);

            Color Col = Color.FromArgb((int)(Alpha * 255), (int)(Red * 255), (int)(Green * 255), (int)(Blue * 255));
            col.SetColor(Col);
        }

        private void SetCol_Click(object sender, EventArgs e)
        {
            ColorChooser cc = new ColorChooser();
            cc.Color = col.col;
            if (cc.ShowDialog() != DialogResult.OK) return;

            col.SetColor(Color.FromArgb(255, cc.Color));
            UpdateColorBox();
        }
    }
}
