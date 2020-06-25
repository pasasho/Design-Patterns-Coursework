using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    interface IComputer
    {
        string GetInfo();
    }

    class Computer : IComputer
    {
        public string GetInfo()
        {
           return "";
        }
    }

    class AddFanComputerDecorator : IComputer
    {
        public IComputer _computer;

        public AddFanComputerDecorator(IComputer computer)
        {
            _computer = computer;
        }

        public string GetInfo()
        {
            return _computer.GetInfo() + "+ Noctua 14' Fan added";
        }
    }
}