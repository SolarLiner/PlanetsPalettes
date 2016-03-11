using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ookii.Dialogs;

namespace PlanettePalette
{
    public partial class ImportCreate : Form
    {
        public Palette[] Output { get; private set; }

        private List<PalColor> conts;
        
        public ImportCreate()
        {
            InitializeComponent();
            conts = new List<PalColor>();

            for (int i = 0; i < (int)Palette.PaletteClass.count; i++)
            {
                Class.Items.Add(Palette.ClassToString((Palette.PaletteClass)i));
            }
            Class.SelectedIndex = 0;
        }

        private void AddColor_Click(object sender, EventArgs e)
        {
            InputDialog id = new InputDialog();
            id.WindowTitle = "Color Name";
            id.Content = "Enter the color name, like in the config, but without the \"color\" in front (ie: \"Beach\" for \"colorBeach\")";

            id.ShowDialog();

            PalColor pc = new PalColor(new PaletteColor(Color.Black, "color" + id.Input));
            pc.Location = new Point(25, 450 + (conts.Count * 35));

            panel1.Controls.Add(pc);
            conts.Add(pc);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            List<Palette> Out = new List<Palette>();
            if (!string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                foreach (Palette pal in FileHandle.ReadPalettes(richTextBox1.Text)) Out.Add(pal);
            }

            if (!string.IsNullOrWhiteSpace(PalName.Text))
            {
                Palette Created = new Palette(Palette.PaletteType.LAND, Palette.GetClass((string)Class.SelectedItem), PalName.Text, RepColor.BackColor);
                foreach (PalColor palc in conts) Created.AddColor(palc.col);

                Out.Add(Created);
            }

            Output = Out.ToArray();

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (CancelTD.ShowDialog().ButtonType == ButtonType.No) return;

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void RepColor_Click(object sender, EventArgs e)
        {
            ColorChooser cc = new ColorChooser();
            cc.Color = RepColor.BackColor;

            if (cc.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            RepColor.BackColor = cc.Color;
        }
    }
}
