using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTools
{
    public static class LogManager
    {
        private static string path = "Log";
        private static string prefix = "\t";
        private static string GetFolderPath()
        {
            string p = $@"{path}\{DateTime.Now.Month}";
            if (!Directory.Exists(p))
                Directory.CreateDirectory(p);
            return p;

        }
        private static string GetFilePath()
        {
            string p = $@"{GetFolderPath()}\{DateTime.Now.Day}";
            if (!File.Exists(p))
                File.Create(p).Close();
            return p;
        }

        public static void WriteToLog(string nameProject, string nameFunctuin, string message)
        {
            using (StreamWriter sw = new StreamWriter(GetFilePath(), true))
            {
                sw.WriteLine($"{DateTime.Now}{prefix} {nameProject} {nameFunctuin} {message}");
            }
        }

        public static void WriteToLogStart(string nameProject, string nameFunctuin, string message)
        {
            WriteToLog(nameProject, nameFunctuin, $"{message} start");
            prefix += "\t";
        }
        public static void WriteToLogEnd(string nameProject, string nameFunctuin, string message)
        {
            prefix = prefix.Substring(1);
            WriteToLog(nameProject, nameFunctuin, $"{message} end");
        }
        public static void DeleteOldFolders()
        {
            string[] directories = Directory.GetDirectories(path);
            foreach (string dir in directories)
            {
                string d = dir.Substring(4);
                int number = int.Parse(d);
                if(DateTime.Now.Month-2> DateTime.Now.Month)
                    Directory.Delete($@"{path}\{d}", true);
                else
                {
                    if (DateTime.Now.Month == 1)
                    {
                        if (!(number == 11 || number == 12))
                            Directory.Delete($@"{path}\{d}", true);
                    }
                    else
                    {
                        if (!(number == 1 || number == 12))
                            Directory.Delete($@"{path}\{d}", true);
                    }
                   
                }
              
            }
        }
    }
}
