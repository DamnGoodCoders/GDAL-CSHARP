using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace GPDF2GTIF
{
    static class Program
    {
        public static String fPath = "";
        public static String fName = "";
        public static String fOutput = "./Exports";

        // Getters and Setters
        public static void SetfName(String a) {
            fName = a;
        }
        public static String GetfName()
        {
            return fName;
        }

        public static void SetfOutput(String a)
        {
            fOutput = a;
        }
        public static String GetfOutput()
        {
            return fOutput;
        }

        // Getters and Setters End
        public static void ChooseF()
        {

        }

        private static void CreatePro()
        {
            try
            {
                String cmdargs = "/C gdal_translate -of PDF " + fPath + fName  + " testlol.tif";
              System.Diagnostics.Process.Start("CMD.exe", cmdargs);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error! : " + e.ToString());
            }
            finally
            {

            }
        }

        public static void CreateDir()
        {
            try
            {
                if (!Directory.Exists(fPath))
                {
                    DirectoryInfo di = Directory.CreateDirectory(fPath);
                    DirectoryInfo dl = Directory.CreateDirectory(fOutput);
                    CreatePro();
                }
                else
                {
                    Console.WriteLine("Directory Already Exists.");
                    CreatePro();
                    return;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Failed to Process Request : {0}", e.ToString());
            }
            finally
            {

            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
