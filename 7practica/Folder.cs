using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _7practica
{
    class Folder
    {
        public static List<ReadedFile> GetDrivesOrFiles(string path)
        {
            var drivesOrFiles = new List<ReadedFile>();

            if (path != null)
            {
                drivesOrFiles.AddRange(GetFiles(path));
            }
            else
            {
                drivesOrFiles.AddRange(GetDrives());
            }

            return drivesOrFiles;
        }

        static List<ReadedFile> GetFiles(string path)
        {
            var dirsAndFiles = new List<ReadedFile>();
            var dirs = ToReadedFile.ReadedFiles(Directory.GetDirectories(path).ToList());
            var files = ToReadedFile.ReadedFiles(Directory.GetFiles(path).ToList());

            dirsAndFiles.AddRange(dirs);
            dirsAndFiles.AddRange(files);

            return dirsAndFiles;
        }

        static List<ReadedFile> GetDrives()
        {
            var drives = new List<ReadedFile>();

            foreach (var drive in DriveInfo.GetDrives())
            {
                var freeGigabytes = KilobytesToBytes(drive.AvailableFreeSpace);
                var freeSpace = $"{drive.Name} Свободно {freeGigabytes} гб";
                drives.Add(new ReadedFile(freeSpace, drive.Name, false));
            }

            return drives;
        }

        static double KilobytesToBytes(long kilobytes)
        {
            return Math.Round(kilobytes / 1024f / 1024 / 1024, 2);
        }
    }
}
