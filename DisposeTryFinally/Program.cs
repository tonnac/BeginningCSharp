using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FildLogger
{
    class FileLogger : IDisposable
    {
        FileStream _fs;

        public FileLogger(string fileName)
        {
            _fs = new FileStream(fileName, FileMode.Create);
        }

        public void Write(string txt)
        {
        }

        public void Dispose()
        {
            _fs.Close();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //FileLogger log = null;

            //try
            //{
            //    log = new FileLogger("sample.log");

            //    log.Write("start");
            //    log.Write("end");
            //}
            //finally
            //{
            //    log.Dispose();
            //}

            using(FileLogger log = new FileLogger("sample.log"))
            {
                log.Write("start");
                log.Write("end");
            }
        }
    }
}
