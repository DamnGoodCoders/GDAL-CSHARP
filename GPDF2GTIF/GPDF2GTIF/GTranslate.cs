using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPDF2GTIF
{
    class GTranslate
    {
        private static String fPath;
        private static String fName;
        private static String fOutputPath;
        private static String fOutputFileName;

        // Getters and Setters
        public String GetfName()
        {
            return fName;
        }
        public void SetfName(String a)
        {
            fName = @a;
        }
        public String GetfOutput()
        {
            return fOutputPath;
        }
        public void SetfOutputPath(String a)
        {
            fOutputPath = @a;
        }
        public String GetfPath()
        {
            return fPath;
        }
        public void SetfPath(String a)
        {
            fPath = @a;
        }
        public String GetfOutputFileName()
        {
            return fOutputFileName;
        }
        public void SetfOutputFilename(String a)
        {
            fOutputFileName = @a;
        }
        // Getters and Setters End

        private static void CreatePro()
        {
            try
            {
                String cmdargs = "/C gdal_translate " + fPath + "/" + fName + " " + fOutputPath + '/' + fOutputFileName;
                Console.WriteLine("Path : " + @fPath + " File Name : " + @fName + "Output Destination: " + fOutputPath);
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

        public void CreateDir()
        {
            try
            {
                if (!Directory.Exists(fPath))
                {
                    DirectoryInfo di = Directory.CreateDirectory(fPath.ToString());
                    DirectoryInfo dl = Directory.CreateDirectory(fOutputPath.ToString());
                    CreatePro();
                }
                else
                {
                    Console.WriteLine("Directory Already Exists.");
                    CreatePro();
                    return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to Process Request : {0}", e.ToString());
            }
            finally
            {

            }
        }

        public GTranslate()
        {
            SetfPath(@"./Imports");
            SetfName(@"Example.pdf");
            SetfOutputPath(@"./Exports");
            SetfOutputFilename(@"Example.tif");
        }
    }
}

