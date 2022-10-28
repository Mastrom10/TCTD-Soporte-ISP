using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERV.Serializacion
{
    public class FileStreamManager
    {
        public static FileStreamManager Instance { get; } = new FileStreamManager();

        private FileStreamManager() { }

        public FileStream GetFileStream(string path, FileMode mode)
        {
            return new FileStream(path, mode);
        }
        public FileStream CreateFile(string path)
        {
            return GetFileStream(path, FileMode.Create);
        }
        

    }
}
