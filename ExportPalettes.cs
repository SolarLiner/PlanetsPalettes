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
    public partial class ExportPalettes : Form
    {
        public Palette[] SelectedPalettes { get; private set; }

        public ExportPalettes(Palette[] Selected)
        {
            InitializeComponent();
            Log.WriteNormal("Export.Init", "new ExportPalettes(Palette[])");

            this.MaximumSize = new Size(710, (int)(Screen.PrimaryScreen.WorkingArea.Height * (2.0f / 3.0f)));

            SelectedPalettes = Selected;
            PopulateForm();
        }

        private void PopulateForm()
        {
            // Label height: 13
            // Textbox height: 20
            // Margin height: 5

            // Start height: 109
            // Name: 21 | Type: 272 | RepColor: 406

            Log.WriteNormal("Export.Init", "Initializing controls ...");

            TextBox[] TBs = new TextBox[SelectedPalettes.Length];
            Label[] Labels = new Label[SelectedPalettes.Length];
            Panel[] Panels = new Panel[SelectedPalettes.Length];

            for (int i = 0; i<SelectedPalettes.Length; i++)
            {
                // Name (TextBox)
                TBs[i] = new TextBox();
                TBs[i].Location = new Point(21, 109 + (i * 25));
                TBs[i].Size = new Size(251, 20);
                TBs[i].Text = SelectedPalettes[i].Name;
                panel1.Controls.Add(TBs[i]);

                // Type (Label)
                Labels[i] = new Label();
                Labels[i].Location = new Point(272, 113 + (i * 25));
                Labels[i].Text = Palette.ClassToString(SelectedPalettes[i].Class);
                panel1.Controls.Add(Labels[i]);

                // Color (Panel)
                Panels[i] = new Panel();
                Panels[i].Location = new Point(406, 109 + (i * 25));
                Panels[i].Size = new Size(50, 20);
                Panels[i].BackColor = SelectedPalettes[i].RepresentativeColor;
                Panels[i].Click += new EventHandler(ExportPalettes_Click);
                panel1.Controls.Add(Panels[i]);
            }
        }

        void ExportPalettes_Click(object sender, EventArgs e)
        {
            Panel sel = (Panel)sender;

            ColorChooser cc = new ColorChooser();
            cc.Color = sel.BackColor;

            if (cc.ShowDialog() != DialogResult.OK) return;
            sel.BackColor = cc.Color;
        }

        private void ExportTD_ButtonClicked(object sender, TaskDialogItemClickedEventArgs e)
        {
            if (e.Item == ExportTD.Buttons[1])
            {
                string tempFname = Path.ChangeExtension(Path.GetTempFileName(), "txt");
                Log.WriteNormal("Export.ShowExp", "Showing exported data using " + tempFname);

                File.WriteAllText(tempFname, Clipboard.GetText());

                System.Diagnostics.Process.Start(tempFname);
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (FileExport.Checked)
            {
                // TODO
                Log.WriteNormal("Export.DoFile", "Exporting as file under N/A");
            }
            else if (CopyPastePlain.Checked)
            {
                StringBuilder sb = new StringBuilder();

                foreach (Palette pal in SelectedPalettes)
                {
                    sb.AppendLine(pal.ToString(.0f, 1f, true, false));
                    sb.AppendLine();
                }

                Log.WriteNormal("Export.DoPlain", "Setting clipboard to exported data");
                Clipboard.SetText(sb.ToString());

                ExportTD.Content = "Palettes have been successfully exported and copied to your clipboard. Paste that anywhere!";

                if (TaskDialog.OSSupportsTaskDialogs)
                {
                    ExportTD.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show(ExportTD.Content, ExportTD.WindowTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (CopyPasteForum.Checked)
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("[code]");
                foreach (Palette pal in SelectedPalettes) sb.AppendLine(pal.ToString(.0f, 1f, true, true));
                sb.Append("[/code]");

                Log.WriteNormal("Export.DoForumColored", "Setting clipboard to exported colored forum data");
                Clipboard.SetText(sb.ToString());

                ExportTD.Content = "Palettes have been successfully exported and copied to your clipboard. Paste that on a forum post!";

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
                StringBuilder sb = new StringBuilder();

                sb.Append("[code]");
                foreach (Palette pal in SelectedPalettes) sb.AppendLine(pal.ToString(.0f, 1f, true, false));
                sb.Append("[/code]");

                Log.WriteNormal("Export.DoForumPlain", "Setting clipboard to exported plain forum data");
                Clipboard.SetText(sb.ToString());

                ExportTD.Content = "Palettes have been successfully exported and copied to your clipboard. Paste that on a forum post!";
                ExportTD.WindowTitle = "Export successful";

                if (TaskDialog.OSSupportsTaskDialogs)
                {
                    ExportTD.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show(ExportTD.Content, ExportTD.WindowTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
