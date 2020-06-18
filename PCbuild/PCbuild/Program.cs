using System;
using System.Collections.Generic;

namespace Builder.PC
{
    public class MainApp

    {
        public static void Main()
        {
            ComputerBuilder PCassembler;

            Store store = new Store();

            PCassembler = new PCassembler();
            store.Construct(PCassembler);
            PCassembler.Vehicle.Show();

        }
    }
    class Store

    {
        public void Construct(ComputerBuilder computerBuilder)
        {
            computerBuilder.AssembleGPU();
            computerBuilder.AssembleCPU();
            computerBuilder.AssembleMotherboard();
            computerBuilder.AssembleRAM();
        }
    }

    abstract class ComputerBuilder

    {
        protected Computer computer;

        public Computer Vehicle
        {
            get { return computer; }
        }


        public abstract void AssembleGPU();
        public abstract void AssembleCPU();
        public abstract void AssembleMotherboard();
        public abstract void AssembleRAM();
    }
 
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
    
    class Computer

    {
        private string _vehicleType;
        private Dictionary<string, string> _parts =
          new Dictionary<string, string>();

        // Constructor

        public Computer(string vehicleType)
        {
            this._vehicleType = vehicleType;
        }

        // Indexer

        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("Computer is being assembled");
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Computer Type: {0}", _vehicleType);
            Console.WriteLine(" Graphics Processing Unit (GPU): {0}", _parts["GPU"]);
            Console.WriteLine(" Central Processing Unit (CPU): {0}", _parts["CPU"]);
            Console.WriteLine(" Motherboard {0}", _parts["Motherboard"]);
            Console.WriteLine(" RAM : {0}", _parts["RAM"]);
        }
    }
}