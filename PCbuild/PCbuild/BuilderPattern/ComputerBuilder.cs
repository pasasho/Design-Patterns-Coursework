using System;
using System.Collections.Generic;
using System.Text;

namespace PCbuild.BuilderPattern
{
    abstract class ComputerBuilder
    {
        protected Computer computer;

        public Computer PC
        {
            get { return computer; }
        }

        public abstract void AssembleGPU();
        public abstract void AssembleCPU();
        public abstract void AssembleMotherboard();
        public abstract void AssembleRAM();
    }
}
