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
    public partial class ModifyPalette : Form
    {
        private List<PalColor> conts;
        private List<CheckBox> boxes;

        public Palette Output { get; set; }

        public ModifyPalette(Palette Input)
        {
            InitializeComponent();
            Output = Input;
            conts = new List<PalColor>();
            boxes = new List<CheckBox>();

            for (int i = 0; i < (int)Palette.PaletteClass.count; i++)
            {
                Class.Items.Add(Palette.ClassToString((Palette.PaletteClass)i));
            }
            Class.SelectedIndex = 0;

            Log.WriteNormal("Modify.Init", "Initializing and populating form");

            PopulateForm();
        }

        private void PopulateForm()
        {
            // Start 25, 100
            PaletteColor[] cols = Output.Colors.Values.ToArray();
            for (int i = 0; i < cols.Length; i++)
            {
                PalColor palC = new PalColor(cols[i]);
                palC.Location = new Point(25, 100 + (i * 35));

                conts.Add(palC);
                panel1.Controls.Add(palC);

                CheckBox cb = new CheckBox();
                cb.Location = new Point(10, 110 + (i * 35));
                cb.Text = "";
                cb.AutoSize = true;

                panel1.Controls.Add(cb);
                boxes.Add(cb);
            }

            textBox1.Text = Output.Name;
            Class.SelectedIndex = (int)Output.Class;
            RepColor.BackColor = Output.RepresentativeColor;
        }

        private void AddColor_Click(object sender, EventArgs e)
        {
            InputDialog id = new InputDialog();
            id.WindowTitle = "Color Name";
            id.Content = "Enter the color name (ie: \"Beach\" for \"colorBeach\")";

            id.ShowDialog();

            PalColor pc = new PalColor(new PaletteColor(Color.Black, "color" + id.Input));
            pc.Location = new Point(25, 450 + (conts.Count * 35));

            panel1.Controls.Add(pc);
            conts.Add(pc);

            CheckBox cb = new CheckBox();
            cb.Location = new Point(10, 110 + (conts.Count * 35));
            cb.Text = "";
            cb.AutoSize = true;

            panel1.Controls.Add(cb);
            boxes.Add(cb);

            Log.WriteNormal("Modify.AddColor", "Adding color; code '" + pc.col.Code + "'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < conts.Count; i++)
            {
                if (boxes[i].Checked)
                {
                    Log.WriteNormal("Mofidy.RemoveColors", "Removing color code '" + conts[i].col.Code + "'");
                    
                    panel1.Controls.Remove(conts[i]);
                    panel1.Controls.Remove(boxes[i]);

                    conts.RemoveAt(i);
                    boxes.RemoveAt(i);

                    for (int j = i; j < conts.Count; j++)
                    {
                        conts[j].Location = new Point(conts[j].Location.X, conts[j].Location.Y - 35);
                        boxes[j].Location = new Point(boxes[j].Location.X, boxes[j].Location.Y - 35);
                    }
                }
            }
        }

        private void RepColor_Click(object sender, EventArgs e)
        {
            ColorChooser cc = new ColorChooser();
            cc.Color = RepColor.BackColor;

            if (cc.ShowDialog() != DialogResult.OK) return;

            Log.WriteNormal("Modify.ChangeRepColor", RepColor.BackColor.Name + " -> " + cc.Color.Name);
            RepColor.BackColor = cc.Color;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Palette Created = new Palette(Palette.PaletteType.LAND, Palette.GetClass((string)Class.SelectedItem), textBox1.Text, RepColor.BackColor);
            foreach (PalColor palc in conts) Created.AddColor(palc.col);

            Output = Created;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
