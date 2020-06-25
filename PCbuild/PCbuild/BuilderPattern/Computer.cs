using System;
using System.Collections.Generic;
using System.Text;

namespace PCbuild.BuilderPattern
{
    class Computer
    {
        private string _computerType;
        private Dictionary<string, string> _parts =
          new Dictionary<string, string>();

        // Constructor

        public Computer(string computerPart)
        {
            this._computerType = computerPart;
        }

        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("Computer is being assembled");
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Computer Type: {0}", _computerType);
            Console.WriteLine(" Graphics Processing Unit (GPU): {0}", _parts["GPU"]);
            Console.WriteLine(" Central Processing Unit (CPU): {0}", _parts["CPU"]);
            Console.WriteLine(" Motherboard {0}", _parts["Motherboard"]);
            Console.WriteLine(" RAM : {0}", _parts["RAM"]);
        }
    }
}
