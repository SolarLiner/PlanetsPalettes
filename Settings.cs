using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using IniParser;

namespace PlanettePalette
{
    static class Settings
    {
        public static string ConfigFile { get { return @"./config.ini"; } }

        public static string SEroot { get; set; }
        
        public static bool Read()
        {
            if (File.Exists(ConfigFile))
            {
                try
                {
                    IniData ini = (new FileIniDataParser()).LoadFile(ConfigFile);
                    SEroot = ini["GLOBAL"]["SpaceEngine"];

                    Log.WriteNormal("Settings.Read", "Reading settings");
                    return true;
                }
                catch { return false; }
            }

            return false;
        }

        public static void Save()
        {
            Log.WriteNormal("Settings.Save", "Saving settings");
            
            IniData ini = new IniData();
            ini.Sections.AddSection("GLOBAL");
            ini["GLOBAL"].AddKey("SpaceEngine", SEroot);

            (new FileIniDataParser()).SaveFile(ConfigFile, ini);
        }
    }
}
