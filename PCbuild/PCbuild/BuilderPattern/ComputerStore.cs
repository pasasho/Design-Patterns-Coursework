using System;
using System.Collections.Generic;
using System.Text;

namespace PCbuild.BuilderPattern
{
    class ComputerStore
    {
        public void Construct(ComputerBuilder computerBuilder)
        {
            computerBuilder.AssembleGPU();
            computerBuilder.AssembleCPU();
            computerBuilder.AssembleMotherboard();
            computerBuilder.AssembleRAM();
        }
    }
}
