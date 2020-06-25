using System;
using System.Collections.Generic;
using System.Text;

namespace PCbuild.BuilderPattern
{
    class PCassembler : ComputerBuilder
    {
        public PCassembler()
        {
            computer = new Computer("Pesonal Computer (PC)");
        }

        public override void AssembleGPU()
        {
            computer["GPU"] = "AMD RX590";
        }

        public override void AssembleCPU()
        {
            computer["CPU"] = "Ryzen 3600";
        }

        public override void AssembleMotherboard()
        {
            computer["Motherboard"] = "x570 Gigabyte Aorus";
        }

        public override void AssembleRAM()
        {
            computer["RAM"] = "16gb 3200mhz";
        }
    }
}
