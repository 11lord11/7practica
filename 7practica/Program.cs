using System.Diagnostics;

namespace _7word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folder = null;
            while (true)
            {
                List<ReadedFile> list = Folder.Read(folder);
                int pos = Menu.Start(list,folder);
                if (pos == -1)
                    break;
                else
                    pos--;
                if (File.Exists(list[pos].path))
                {
                    Process.Start(list[pos].path);
                    break;
                }
                else
                    folder = list[pos].path;
            }
        }
    }
}