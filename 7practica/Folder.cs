using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7practica 
{
   
   
   
   
  
    public class Folder
    {
        public static List<ReadedFile> Read(string path)
        {
            List<ReadedFile> files = new List<ReadedFile>();
            if (path == null)
            {
                files.AddRange(GetDrives());
            }
            else {
                
                files.AddRange(GetFiles(path));
            }
            return files;
        }
        private static List<ReadedFile> GetFiles(string path)
        {
            List<ReadedFile> files = new List<ReadedFile>();
            files.AddRange(ToReadedFile.ReadedFiles(Directory.GetDirectories(path).ToList()));
            files.AddRange(ToReadedFile.ReadedFiles(Directory.GetFiles(path).ToList()));
            return files;
        }
        private static List<ReadedFile> GetDrives()
        {
            List<ReadedFile> drives = new List<ReadedFile>();
            foreach (DriveInfo drive in  DriveInfo.GetDrives())
                drives.Add(new ReadedFile($"{drive.Name} Свободно {Math.Round(Convert.ToDouble(drive.AvailableFreeSpace) / 1024 / 1024 / 1024, 2)} гб", drive.Name, false));
            return drives;
        }
    }
}
