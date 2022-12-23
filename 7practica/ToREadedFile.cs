using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7practica
{
    public static class ToReadedFile
    {
        private static string GetName(string path)
        {
            return path.Split('\\')[path.Split("\\").Length -1];
        }
        public static List<ReadedFile> ReadedFiles(List<string> files)
        {
            List<ReadedFile> readedFiles = new List<ReadedFile>();
            foreach (string file in files)
            {
                readedFiles.Add(new ReadedFile(GetName(file), file, File.Exists(file)));
            }
            return readedFiles;
        }

    }

}
