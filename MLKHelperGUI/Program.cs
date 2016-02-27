using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;
using System.Security.AccessControl;

namespace MLKHelperGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //System.Console.WriteLine("Installing your song, if this crash, please ask for support");
            //System.Console.WriteLine("at https://mylittlekaraoke.com/forum/");
            for (int i = 0; i < args.Length; i++)
            {
                RegistryKey regKey1 = Registry.LocalMachine;
                regKey1 = regKey1.OpenSubKey(@"SOFTWARE\\DerpyMuffinsFactory");
                string mlk2 = regKey1.GetValue("MLK Path").ToString();
                String arg1 = ("\"" + args[i] + "\"");
                String mlkpath = ("\'" + mlk2);
                String zip = ( "\"" + mlk2 + @"7zip\7za.exe" + "\"");
                String songs = ( "\"" + mlk2 + @"songs\" + "\"");
                //System.Console.WriteLine(" ");
                //System.Console.WriteLine("DEBUG:");
                //System.Console.WriteLine(" ");
                //System.Console.WriteLine("file path: "+@arg1);
                //System.Console.WriteLine("mlk path: " + @mlkpath);
                //System.Console.WriteLine("7zip path: " + @zip);
                //System.Console.WriteLine("songs path: " + @songs);
                //System.Console.WriteLine(" ");
                Process copy = new Process();
                copy.StartInfo.FileName = zip ;
                copy.StartInfo.Arguments = " x -y -o" + @songs + " " + @arg1;
                copy.Start();
                //System.Console.WriteLine(" ");
                //System.Console.WriteLine("If there was no error, your song is installed");
                //System.Console.WriteLine("Press any key to exit.");
                //Console.ReadKey(true);
                Application.Run(new Form1());
            }
        }
    }
}
