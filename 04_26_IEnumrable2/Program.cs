using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _04_26_IEnumrable2
{
    class Hardware { }

    class USB
    {
        string name;

        public USB(string name) { this.name = name; }

        public override string ToString()
        {
            return name;
        }
    }

    class Notebook : Hardware
    {
        USB[] usbList = new USB[] { new USB("USB1"), new USB("USB2") };

        public IEnumerator GetEnumerator()
        {
            return new USBEnumerator(usbList);
        }

        public class USBEnumerator : IEnumerator
        {
            int pos = -1;
            int length = 0;
            object[] list;
            
            public USBEnumerator(USB[] usb)
            {
                list = usb;
                length = usb.Length;
            }

            public object Current
            {
                get { return list[pos]; }
            }

            public bool MoveNext()
            {
                if(pos >= length - 1)
                {
                    return false;
                }

                pos++;
                return true;
            }

            public void Reset()
            {
                pos = -1;
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();

            IEnumerator enumerator = notebook.GetEnumerator();

            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.ToString());
            }

            foreach(USB usb in notebook)
            {
                Console.WriteLine(usb.ToString());
            }
        }
    }
}
