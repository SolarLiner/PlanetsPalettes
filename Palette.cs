using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Text.RegularExpressions;

namespace PlanettePalette
{
    public class PaletteColor
    {
        public string Code { get; set; }
        public string Name { get { return Code.Replace("color", ""); } }
        public bool IsUsed { get; set; }
        public Color col { get; private set; }

        public bool SetColor(byte Alpha, byte Red, byte Green, byte Blue)
        {
            try
            {
                col = Color.FromArgb((int)Alpha, (int)Red, (int)Green, (int)Blue);
                IsUsed = true;
                return true;
            }
            catch { return false; }
        }
        public bool SetColor(string Col4part)
        {
            try
            {
                Regex r = new Regex(@"^\((.*?), (.*?), (.*?), (.*?)\)$");
                Match m = r.Match(Col4part);

                float Red = float.Parse(m.Groups[1].Value);
                float Green = float.Parse(m.Groups[2].Value);
                float Blue = float.Parse(m.Groups[3].Value);
                float Alpha = float.Parse(m.Groups[4].Value);

                col = Color.FromArgb((int)Math.Round(Alpha * 255),
                                     (int)Math.Round(Red * 255),
                                     (int)Math.Round(Green * 255),
                                     (int)Math.Round(Blue * 255));
                return true;
            }
            catch { return false; }
        }
        public bool SetColor(Color col)
        {
            return SetColor(col.A, col.R, col.G, col.B);
        }

        public PaletteColor() { }
        public PaletteColor(byte Alpha, byte Red, byte Green, byte Blue, string CodeName)
        {
            if (SetColor(Alpha, Red, Green, Blue)) Code = CodeName;
        }
        public PaletteColor(Color Col, string CodeName)
        {
            Code = CodeName;
            col = Col;
            IsUsed = true;
        }
        public PaletteColor(string CodeName)
        {
            Code = CodeName;
            IsUsed = false;
        }

        public override string ToString()
        {
            float fR = (float)Math.Round(col.R / 255.0, 2);
            float fG = (float)Math.Round(col.G / 255.0, 2);
            float fB = (float)Math.Round(col.B / 255.0, 2);
            float fA = (float)Math.Round(col.A / 255.0, 2);

            return String.Format(Code.PadRight(15)+ "({0:0.00}, {1:0.00}, {2:0.00}, {3:0.00})", fR, fG, fB, fA);
        }
        public string ToString(bool Forum)
        {
            if (!Forum) return ToString();

            float fR = (float)Math.Round(col.R / 255.0, 2);
            float fG = (float)Math.Round(col.G / 255.0, 2);
            float fB = (float)Math.Round(col.B / 255.0, 2);
            float fA = (float)Math.Round(col.A / 255.0, 2);

            return String.Format("[color=Orange]{4}[/color]({0:0.00}, {1:0.00}, {2:0.00}, {3:0.00})", fR, fG, fB, fA, Code.PadRight(15));
        }
    }

    public class Palette
    {
        public enum PaletteType
        {
            LAND,
            OCEAN
        }

        public enum PaletteClass
        {
            TERRA,
            DESERT,
            OCEANIA,
            SELENA,
            ICE_WORLD,
            TITAN,
            ASTEROID,
            ICE_GIANT,
            GAS_GIANT,
            BROWN_DWARF,
            count
        }
        public static PaletteClass GetClass(string input)
        {
            switch (input.ToLowerInvariant())
            {
                case "terra":
                    return PaletteClass.TERRA;
                case "desert":
                    return PaletteClass.DESERT;
                case "oceania":
                    return PaletteClass.OCEANIA;
                case "selena":
                    return PaletteClass.SELENA;
                case "iceworld":
                    return PaletteClass.ICE_WORLD;
                case "titan":
                    return PaletteClass.TITAN;
                case "asteroid":
                    return PaletteClass.ASTEROID;
                case "icegiant":
                    return PaletteClass.ICE_GIANT;
                case "gasgiant":
                    return PaletteClass.GAS_GIANT;
                case "browndwarf":
                    return PaletteClass.BROWN_DWARF;
                default:
                    return PaletteClass.TERRA;
            }
        }
        public static string ClassToString(PaletteClass input)
        {
            switch (input)
            {
                case PaletteClass.TERRA:
                    return "Terra";
                case PaletteClass.DESERT:
                    return "Desert";
                case PaletteClass.OCEANIA:
                    return "Oceania";
                case PaletteClass.SELENA:
                    return "Selena";
                case PaletteClass.ICE_WORLD:
                    return "IceWorld";
                case PaletteClass.TITAN:
                    return "Titan";
                case PaletteClass.ASTEROID:
                    return "Asteroid";
                case PaletteClass.ICE_GIANT:
                    return "IceGiant";
                case PaletteClass.GAS_GIANT:
                    return "GasGiant";
                case PaletteClass.BROWN_DWARF:
                    return "BrownDwarf";
                default:
                    return string.Empty;
            }
        }

        public PaletteType Type;
        public PaletteClass Class { get; set; }
        public string Name { get; set; }
        public Color RepresentativeColor { get; set; }
        public Image Illustration { get; private set; }

        public Dictionary<string, PaletteColor> Colors { get; private set; }
        public void AddColor(PaletteColor col)
        {
            Colors.Add(col.Code, col);
        }
        public void AddColor(PaletteColor[] cols)
        {
            foreach (PaletteColor col in cols) AddColor(col);
        }

        public void RemoveColor(PaletteColor col)
        {
            RemoveColor(col.Code);
        }
        public void RemoveColor(string code)
        {
            Colors.Remove(code);
        }

        public void ReplaceColors(PaletteColor[] pals)
        {
            Colors.Clear();
            foreach (PaletteColor col in pals)
            {
                AddColor(col);
            }
        }

        public void ClearColors()
        {
            Colors = new Dictionary<string, PaletteColor>();
        }


        public Palette(PaletteType type, PaletteClass Parent, string PaletteName, Color RepColor)
        {
            Type = type;
            Class = Parent;
            Name = PaletteName;
            RepresentativeColor = RepColor;

            Colors = new Dictionary<string, PaletteColor>();
        }
        public Palette(PaletteType type, PaletteClass Parent, string Title)
        {
            SetColorAndNameFromTitle(Parent, Title);
            Type = type;
            Class = Parent;

            Colors = new Dictionary<string, PaletteColor>();
        }

        public void SetColorAndNameFromTitle(PaletteClass Parent, string Title)
        {
            Title = Title.Replace("//", "");
            string[] splitted = Title.Split('|');
            string name = splitted[0].Trim();
            if (splitted.Length == 2)
            {
                string colCode = splitted[1].Trim();
                RepresentativeColor = ColorTranslator.FromHtml(colCode);
            }
            else RepresentativeColor = GetRandomColor(Parent);
            Name = name;
        }

        static Random r = new Random();
        public static Color GetRandomColor(PaletteClass Parent)
        {
            string imgPath = System.IO.Path.Combine(new string[] { Form1.Root, "img", ClassToString(Parent) + ".bmp" });
            Bitmap bmp = new Bitmap(imgPath);
            
            int x = r.Next(bmp.Width);
            int y = r.Next(bmp.Height);
            Color col = bmp.GetPixel(r.Next(bmp.Width), r.Next(bmp.Height));
            bmp.Dispose();

            return col;
        }

        public bool SetImage(Image img)
        {
            if (img.Width - img.Height == 0)
            {
                Illustration = img;
                return true;
            }
            else return false;
        }

        public string GetNameFormatted()
        {
            return Name.Replace("|", "-");
        }

        public string GetColorCode()
        {
            return ColorTranslator.ToHtml(RepresentativeColor);
        }

        public override string ToString()
        {
            return GetNameFormatted() + " | " + GetColorCode();
        }

        public string ToString(float RangeStart, float RangeEnd, bool ForExport, bool Forum)
        {
            StringBuilder sb = new StringBuilder();
            if (Forum) sb.AppendLine("[color=Green]// " + ToString() + "[/color]");
            else sb.AppendLine("// " + ToString());
            if(Forum) sb.AppendLine("[color=Blue]"+(Type == PaletteType.LAND ? "Palette" : "OceanPalette")+"[/color]");
            else sb.AppendLine(Type == PaletteType.LAND ? "Palette" : "OceanPalette");
            sb.AppendLine("{");
            if(Forum) sb.AppendLine("\t[color=Red]Class          [/color]\"" + ClassToString(Class) + "\"");
            else sb.AppendLine("\tClass          \"" + ClassToString(Class) + "\"");

            if (ForExport)
            {
                if (Forum) sb.AppendLine("\t[color=Green]//StyleRange   TO BE REPLACED[/color]");
                else sb.AppendLine("\t//StyleRange   TO BE REPLACED");
            }
            else
            {
                if(Forum) sb.AppendLine(String.Format("\t[color=Orange]StyleRange[/color]     ({0:0.00}, {1:0.00})", RangeStart, RangeEnd));
                else sb.AppendLine(String.Format("\tStyleRange     ({0:0.00}, {1:0.00})", RangeStart, RangeEnd));
            }

            foreach (PaletteColor col in Colors.Values) sb.AppendLine("\t" + col.ToString(Forum));
            sb.AppendLine("}");

            return sb.ToString();
        }

        public static Palette Read(string[] lines)
        {
            string title = lines[0];
            lines[0] = "";

            Palette.PaletteType Type = PaletteType.LAND;
            List<PaletteColor> pals = new List<PaletteColor>();
            string parent = "";

            foreach (string line in lines)
            {
                string content = line.Trim();
                if (content == "Palette") Type = PaletteType.LAND;
                else if (content == "OceanPalette") Type = PaletteType.OCEAN;
                else if (content == "{" || content == "}") continue;
                else if (content.StartsWith("//")) continue;
                else
                {
                    string[] split = content.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    if (split.Length >= 2)
                    {
                        if (split[0] == "StyleRange") continue;
                        if (split[0] == "Class") parent = split[1].Trim('"');
                        else
                        {
                            split = content.Split('(');

                            PaletteColor col = new PaletteColor(split[0].Trim());
                            col.SetColor('(' + split[1].Trim());
                            pals.Add(col);
                        }
                    }
                }
            }

            Palette pal = new Palette(Type, GetClass(parent), title);
            pal.AddColor(pals.ToArray());
            return pal;
        }
    }
}
