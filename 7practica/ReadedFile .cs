using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7practica
{
    public class ReadedFile
    {
        public string name;
        public string path;
        public bool file;
        public ReadedFile()
        {
                
        }
        public ReadedFile(string name, string path, bool file)
        {
            this.name = name;
            this.path = path;
            this.file = file;
        }
    }
}
