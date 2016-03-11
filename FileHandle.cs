using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Ookii.Dialogs;
using System.Windows.Forms;

namespace PlanettePalette
{
    public static class FileHandle
    {
        public static string FileName { get; set; }

        public static Palette[] ReadPalettes()
        {
            Log.WriteNormal("File.ReadPalettes", "Reading palettes from file '" + FileName + "'");
            return ReadPalettes(File.ReadAllText(FileName));
        }
        public static Palette[] ReadPalettes(string Input)
        {
            Log.WriteNormal("File.ReadPalettes", "Reading palettes from input");
            //File.WriteAllText("output.txt", "// Output of what PlanettePalette parses\n\n"); // Debug only

            List<Palette> pals = new List<Palette>();
            string[] lines = Input.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("Palette") || lines[i].StartsWith("OceanPalette"))
                {
                    i--;
                    List<string> palette = new List<string>();
                    while (!lines[i].Contains("}"))
                    {
                        palette.Add(lines[i]);
                        i++;
                    }
                    palette.Add("}");

                    pals.Add(Palette.Read(palette.ToArray()));
                    //File.AppendAllLines("output.txt", palette.ToArray()); // Debug Only
                }

            }

            return pals.ToArray();
        }

        public static void SavePalettes(Palette[] Palettes)
        {
            if (Palettes != null)
            {
                if (Palettes.Length > 0)
                {
                    Log.WriteNormal("File.SavePalettes", "There are palettes in here, saving started.");

                    Directory.CreateDirectory(Path.Combine(Form1.Root, "backup"));
                    try
                    {
                        string newFile = String.Format("backup\\palette_{0:yyyyMMdd}-{0:HHmmss}.cfg", DateTime.Now);
                        File.Copy(FileName, Path.Combine(Form1.Root, newFile));
                        Log.WriteNormal("File.SavePalettes", "Backup created to '" + newFile + "'");

                        //throw new Exception("LEL gotcha!"); // Debug only
                    }
                    catch (Exception ex)
                    {
                        Log.WriteException(ex);
                        TaskDialog td = new TaskDialog();
                        td.Buttons.Add(new TaskDialogButton("[Risky]Continue without creating a backup file"));
                        td.Buttons.Add(new TaskDialogButton("[Safe] Stop everything and don't save."));
                        td.ButtonStyle = TaskDialogButtonStyle.CommandLinks;
                        td.CenterParent = true;
                        td.Content = "An error occured while trying to make a backup of the current palette file.\nThe error is: " + ex.Message + "\nWhat do you want to do?";
                        td.MainIcon = TaskDialogIcon.Error;
                        td.MainInstruction = "Backup error occured";
                        td.WindowTitle = ex.Source + " error";

                        if (TaskDialog.OSSupportsTaskDialogs)
                        {
                            if (td.ShowDialog() == td.Buttons[1]) return;
                        }
                        else
                        {
                            DialogResult dr = MessageBox.Show("An error occured while trying to make a backup of the current palette file.\n" +
                                                                "The error is: " + ex.Message + "\n" +
                                                                "Do you want to continue anyway? (risky)"
                                                                , td.WindowTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            if (dr == DialogResult.No) return;
                        }
                    }

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("// SpaceEngine Palettes for procedural planets");
                    sb.AppendLine("// Palettes configuration made with PlanetsPalette by SolarLiner");
                    sb.AppendLine();

                    for (int i = 0; i < (int)Palette.PaletteClass.count; i++)
                    {
                        sb.AppendLine("/******************** " + Palette.ClassToString((Palette.PaletteClass)i) + " ********************/");
                        sb.AppendLine();

                        // Land Palettes
                        Palette[] pals = Palettes.Where(pal => (pal.Class == (Palette.PaletteClass)i) && pal.Type == Palette.PaletteType.LAND).ToArray();
                        if (pals.Length > 0)
                        {
                            float weight = 1.0f / pals.Length;
                            for (int j = 0; j < pals.Length; j++)
                            {
                                sb.AppendLine(pals[j].ToString(weight * j, weight * (j + 1), false, false));
                            }
                        }

                        // Ocean Palettes
                        pals = Palettes.Where(pal => (pal.Class == (Palette.PaletteClass)i) && pal.Type == Palette.PaletteType.OCEAN).ToArray();
                        if (pals.Length > 0)
                        {
                            sb.AppendLine("/******** Ocean Palettes ********/");
                            float weight = 1.0f / pals.Length;
                            for (int j = 0; j < pals.Length; j++)
                            {
                                sb.AppendLine(pals[j].ToString(weight * j, weight * (j + 1), false, false));
                            }
                        }
                    }

                    File.WriteAllText(FileName, sb.ToString());
                    Log.WriteNormal("File.SavePalettes", Palettes.Length + " palettes saved.");
                }
                else
                {
                    ArgumentException ae = new ArgumentException("You must have palettes to save them!");
                    Log.WriteException(ae);
                    throw ae;
                }
            }
            else
            {
                ArgumentException ae = new ArgumentException("You must have palettes to save them!");
                Log.WriteException(ae);
                throw ae;
            }
        }

        public static string GetSEdir(string startdir)
        {
            if (!CheckSystemFolder(startdir)) return GetSEdir(Path.Combine(startdir, "\\..\\"));
            else return startdir;
        }
        public static bool CheckSystemFolder(string folder)
        {
            if (Directory.Exists(Path.Combine(folder, "system")))
            {
                if (File.Exists(Path.Combine(folder, "system\\SpaceEngine.exe"))) return true;
                else return false;
            }
            else return false;
        }
    }
}
