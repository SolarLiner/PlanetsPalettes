using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Ookii.Dialogs;

namespace PlanettePalette
{
    public partial class Form1 : Form
    {
        public static string Root { get { return Application.StartupPath; } }
        public Palette[] Palettes { get; set; }
        public Palette.PaletteClass SelectedClass { get; set; }
        public string SEroot;
        
        public Form1()
        {
            InitializeComponent();
            SelectedClass = Palette.PaletteClass.TERRA;
            Log.WriteNormal("FORM.MAIN", "Main.Init()");
            Palettes = new Palette[0];
        }

        private void Import_Click(object sender, EventArgs e)
        {
            string FileName = SEroot;

            if (!FileHandle.CheckSystemFolder(FileName))
            {
                Log.WriteNormal("Main.Import", "SE folder not found");
                
                VistaFolderBrowserDialog fbd = new VistaFolderBrowserDialog();
                fbd.ShowNewFolderButton = false;
                fbd.Description = "Select Space Engine's root folder";
                fbd.UseDescriptionForTitle = true;

                if (fbd.ShowDialog() != DialogResult.OK) return;

                FileName = fbd.SelectedPath;
            }

            FileHandle.FileName = Path.Combine(FileName, @"textures\common\planet_palette.cfg");
            Palettes = FileHandle.ReadPalettes();

            RefreshBtn_Click(null, EventArgs.Empty);
        }

        private Color GetForeColor(Color color)
        {
            return (color.GetBrightness() < 0.4f ? Color.White : Color.Black);
        }
        private void ChangeItem(ListViewItem lvi, string Name, Color color, Palette.PaletteType Type, Palette.PaletteClass Class)
        {
            ChangeItem(lvi, new Palette(Type, Class, Name, color));
        }
        private void ChangeItem(ListViewItem lvi, Palette palette)
        {
            string Name = palette.Name;
            Color color = palette.RepresentativeColor;

            Log.WriteNormal("Main.ChangeItem", "Changing palette { " + palette.ToString() + " }, Class " + Palette.ClassToString(palette.Class));
            
            lvi.Text = Name;
            lvi.SubItems[1].BackColor = color;
            lvi.SubItems[1].ForeColor = GetForeColor(color);
            lvi.SubItems[1].Text = ColorTranslator.ToHtml(color);
            
            int i = Array.IndexOf(Palettes, (Palette)lvi.Tag);
            Palettes[i] = palette;
            lvi.Tag = palette;
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            PalettesData.Items.Clear();
            Log.WriteNormal("Main.Refresh", "Refreshing for class '" + Palette.ClassToString(SelectedClass) + "'");
            
            uint countLand = 0;
            uint countOcean = 0;
            foreach (Palette pal in Palettes)
            {
                if (pal.Class == SelectedClass)
                {
                    string ColorName = pal.GetColorCode();
                    Color ForeColor = (pal.RepresentativeColor.GetBrightness() < 0.4f ? Color.White : Color.Black);
                    ListViewItem lvi = new ListViewItem(new string[] {pal.Name, ColorName, "N/A%"});

                    if (pal.Type == Palette.PaletteType.OCEAN)
                    {
                        lvi.ForeColor = Color.DarkBlue;
                        countOcean++;
                    }
                    else countLand++;

                    lvi.UseItemStyleForSubItems = false;
                    lvi.SubItems[1].BackColor = pal.RepresentativeColor;
                    lvi.SubItems[1].ForeColor = ForeColor;

                    lvi.Tag = pal;

                    PalettesData.Items.Add(lvi);
                }
            }

            float weightLand = 1.0f / (float)countLand;
            float weightOcean = 1.0f / (float)countOcean;
            Log.WriteNormal("Main.Refresh", " Weight for Land palettes: " + weightLand.ToString("0.0000"));
            Log.WriteNormal("Main.Refresh", "Weight for Ocean palettes: " + weightOcean.ToString("0.0000"));

            foreach (ListViewItem lvi in PalettesData.Items)
            {
                Palette.PaletteType type = ((Palette)lvi.Tag).Type;
                switch (type)
                {
                    case Palette.PaletteType.LAND:
                        lvi.SubItems[2].Text = (weightLand * 100).ToString("0.00") + "%";
                        break;
                    case Palette.PaletteType.OCEAN:
                        lvi.SubItems[2].Text = (weightOcean * 100).ToString("0.00") + "%";
                        break;
                    default:
                        break;
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            FileHandle.SavePalettes(Palettes);
        }

        private void Export_Click(object sender, EventArgs e)
        {
            if (PalettesData.SelectedIndices.Count == 0)
            {
                if (TaskDialog.OSSupportsTaskDialogs)
                {
                    ExportTD.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show(ExportTD.Content, ExportTD.WindowTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                Log.WriteNormal("Main.Export", "Exporting palettes:");
                
                List<Palette> pals = new List<Palette>();
                foreach (ListViewItem lvi in PalettesData.SelectedItems)
                {
                    pals.Add((Palette)lvi.Tag);
                    Log.WriteNormal("Main.Export", "      " + ((Palette)lvi.Tag).ToString());
                }

                ExportPalettes ep = new ExportPalettes(pals.ToArray());
                ep.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();

            if (args.Length > 1)
            {
                SEroot = args[1];
                Log.WriteNormal("Main.Load", "SE Folder aquired from arguments: " + SEroot);
            }
            else if (Settings.Read())
            {
                SEroot = Settings.SEroot;
                Log.WriteNormal("Main.Load", "SE Folder aquired from settings: " + SEroot);
            }
            else
            {
                VistaFolderBrowserDialog fbd = new VistaFolderBrowserDialog();
                fbd.ShowNewFolderButton = false;
                fbd.Description = "Select Space Engine's root folder";
                fbd.UseDescriptionForTitle = true;

                if (fbd.ShowDialog() != DialogResult.OK) return;

                SEroot = fbd.SelectedPath;
                Settings.SEroot = SEroot;
            }

            if (TaskDialog.OSSupportsTaskDialogs) Log.WriteNormal("Main.Load", "System supports custom TaskDialogs");
            else Log.WriteNormal("Main.load", "System does NOT support custom TaskDialogs :(");
        }

        private void Import_Click_1(object sender, EventArgs e)
        {
            Log.WriteNormal("Main.Import", "Import/Creation of palettes ...");
            
            ImportCreate ic = new ImportCreate();
            if (ic.ShowDialog() != DialogResult.OK) return;

            List<Palette> lPal;
            if (Palettes == null) lPal = new List<Palette>();
            else if (Palettes.Length == 0) lPal = new List<Palette>();
            else lPal = new List<Palette>(Palettes);

            Log.WriteNormal("Main.Import", "Imported " + ic.Output.Length + " palettes");

            lPal.AddRange(ic.Output);

            Palettes = lPal.ToArray();
            RefreshBtn_Click(null, EventArgs.Empty);
        }

        private void PalettesData_ContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (PalettesData.SelectedIndices.Count == 0) e.Cancel = true;
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Name = PalettesData.SelectedItems[0].Text;
            
            InputDialog id = new InputDialog();
            id.MainInstruction = "Rename palette";
            id.WindowTitle = "Renaming " + Name + "\"";
            id.Content = "Rename the palette \"" + Name + "\"";
            id.Input = Name;

            if (id.ShowDialog() != DialogResult.OK) return;
            Log.WriteNormal("Main.Rename", Name + " -> " + id.Input);
            Name = id.Input;
            
            PalettesData.SelectedItems[0].Text = Name;
            ((Palette)PalettesData.SelectedItems[0].Tag).Name = Name;
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color color = ((Palette)PalettesData.SelectedItems[0].Tag).RepresentativeColor;

            ColorChooser cc = new ColorChooser();
            cc.Color = color;

            if (cc.ShowDialog() != DialogResult.OK) return;
            color = cc.Color;

            Palette pal = ((Palette)PalettesData.SelectedItems[0].Tag);
            Log.WriteNormal("Main.ChangeColor", pal.RepresentativeColor.Name + " -> " + cc.Color.Name);

            pal.RepresentativeColor = color;

            ChangeItem(PalettesData.SelectedItems[0], pal);
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyPalette mp = new ModifyPalette((Palette)PalettesData.SelectedItems[0].Tag);

            if (mp.ShowDialog() != DialogResult.OK) return;
            Log.WriteNormal("Main.Modify", "Modified palette { " + ((Palette)PalettesData.SelectedItems[0].Tag).ToString() + " }");

            ChangeItem(PalettesData.SelectedItems[0], mp.Output);
            RefreshBtn_Click(null, EventArgs.Empty);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Save();
        }

        internal int _tickCount = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_tickCount < 10)
            {
                if (_tickCount % 2 == 0) ErrorState.ForeColor = Color.Red;
                else ErrorState.ForeColor = Color.Black;
            }
            else if (_tickCount < 50) ErrorState.ForeColor = Color.Black;
            else
            {
                ErrorState.Text = "";
                _tickCount = -1;
                ErrorTimer.Stop();
            }

            _tickCount++;
        }
    }
}
