using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools3
{
    public static class LogManager
    {
        private const string path = "Log";
        private static string prefix = "\t";
        private static string GetFolderPath()
        {
            string tempPath = @$"{path}\{DateTime.Now.Month}";
            if (!Directory.Exists(tempPath))
                Directory.CreateDirectory(tempPath);
            return tempPath;
        }
        private static string GetFilePath()
        {
            string tempPath = @$"{GetFolderPath()}\{DateTime.Now.Day}";
            if (!File.Exists(tempPath))
                File.Create(tempPath).Close();
            return tempPath;
        }
        public static void WriteToLog(string nameProject, string nameFunction, string massege)
        {
            using (StreamWriter sw = new StreamWriter(GetFilePath(), true))
            {
                sw.WriteLine($"{DateTime.Now}{prefix}{nameProject} {nameFunction} {massege}");
            }
        }
        public static void WriteToLogStart(string nameProject, string nameFunction, string massege)
        {
            WriteToLog(nameProject, nameFunction, $"{massege} start");
            prefix += "\t";
        }
        public static void WriteToLogEnd(string nameProject, string nameFunction, string massege)
        {
            prefix = prefix.Substring(1);
            WriteToLog(nameProject, nameFunction, $"{massege} end");
        }
        public static void DeleteOldFolders()
        {
            string[] directory = Directory.GetDirectories(path);
            foreach (string dir in directory)
            {
                int num = int.Parse(dir);
                if (DateTime.Now.Month > 2)
                    if (DateTime.Now.Month > num + 2)
                        Directory.Delete(dir);
                    else
                     if (!(num == 11 && DateTime.Now.Month == 2))
                        if (num != 12)
                            Directory.Delete(dir);

            }


        }

    }




}
