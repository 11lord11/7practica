using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace _7practica
{
    class Program
    {
        private static void Main()
        {
            string currentFolderPath = null;

            do
            {
                List<ReadedFile> fileSystemEntries = Folder.GetDrivesOrFiles(currentFolderPath);
                int cursorPosition = Menu.Start(fileSystemEntries, currentFolderPath);

                if (cursorPosition == -1)
                {
                    break;
                }

                cursorPosition--;
                string selectedPath = fileSystemEntries[cursorPosition].path;

                if (File.Exists(selectedPath))
                {
                    Process.Start(selectedPath);
                    break;
                }

                currentFolderPath = selectedPath;
            } while (true);
        }
    }
}