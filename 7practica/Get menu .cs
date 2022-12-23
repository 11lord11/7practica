using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7practica
{
    public static class GetMenu
    {
        public static List<string> ToMenuString(List<ReadedFile> files)
        {
            List<string> strings = new List<string>();
            foreach (ReadedFile file in files)
            {
                if (file.file == false )
                {
                    strings.Add(file.name + '\\');
                }
                else
                {
                    strings.Add(file.name);
                }
            }
            return strings;
        }
        public static void ShowMenu(List<string> lines, string firstLine)
        {
            Console.WriteLine(firstLine);
            foreach (string line in lines)
            {
                Console.WriteLine("   " + line);
            }
        }
    }
}
