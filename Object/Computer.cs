using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Computer
    {
        bool powerOn = false;
        public void Boot() { }
        public void Shutdown() { }
        public void Reset() { }
    }

    public class Notebook : Computer
    {
        bool fingerScan = false;
        public bool HasFingerScanDevice() { return fingerScan; }

        public void CloseLid()
        {
            Shutdown();
        }
    }

    public class Desktop : Computer
    {

    }

    public class Netbook : Computer
    {

    }
}
