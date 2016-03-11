using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanettePalette
{
    internal static class Log
    {
        public static string LogPath
        {
            get
            {
                DateTime now = DateTime.Now;
                string FileName = String.Format("LOG_{0:yyyy}-{0:MM}-{0:dd}.log", now);
                return System.IO.Path.GetFullPath(@"./logs/" + FileName);
            }
        }

        public static void InitializeLog()
        {
            string LogDir = System.IO.Path.GetDirectoryName(LogPath);
            if (!System.IO.Directory.Exists(LogDir))
            {
                System.IO.Directory.CreateDirectory(LogDir);
            }

            if (!System.IO.File.Exists(LogPath))
            {
                string[] contents = new string[] {"============== PlanettePalette LOG ==============",
                                                  "** Created by SolarLiner",
                                                  "** Version " + System.Windows.Forms.Application.ProductVersion,
                                                  "** Log Created on "+DateTime.Now.ToLongTimeString(),
                                                  "===============================================", "", ""};
                System.IO.File.WriteAllLines(LogPath, contents);
            }
            else System.IO.File.AppendAllLines(LogPath, new string[2]);
        }

        public static void WriteNormal(string context, string text)
        {
            if (!System.IO.File.Exists(LogPath))
            {
                string[] contents = new string[] {"============== PlanettePalette LOG ==============",
                                                  "** Created by SolarLiner",
                                                  "** Version " + System.Windows.Forms.Application.ProductVersion,
                                                  "** Log Created on "+DateTime.Now.ToLongTimeString(),
                                                  "===============================================", "", ""};
                System.IO.File.WriteAllLines(LogPath, contents);
            }
            System.IO.File.AppendAllText(LogPath, String.Format("[{0}]{1:HH:mm:ss}.{2:000}: {3}\n", context.ToUpperInvariant(), DateTime.Now, DateTime.Now.Millisecond, text));
        }

        public static void WriteException(Exception e)
        {
            WriteNormal("ERROR in \"" + e.Source + "\"", e.Message + "\n" + e.StackTrace);
        }
    }
}
