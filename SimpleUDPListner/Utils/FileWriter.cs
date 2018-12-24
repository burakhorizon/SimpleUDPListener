using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class FileWriter
    {
        public string Filepath { get; set; }
        private static readonly object locker = new Object();

        public void WriteToFile(StringBuilder text)
        {
            lock (locker)
            {
                using (FileStream file = new FileStream(Filepath, FileMode.Append, FileAccess.Write, FileShare.Read))
                using (StreamWriter writer = new StreamWriter(file, Encoding.ASCII))
                {
                    writer.Write(DateTime.Now.ToString("yyyy.MM.dd-HH:mm:ss.ff") + " : " + text.ToString());
                }
            }

        }
    }
}
