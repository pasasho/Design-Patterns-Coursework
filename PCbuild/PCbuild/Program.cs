using System;
using System.Collections.Generic;
using PCbuild.BuilderPattern;
using Decorator;
using PCbuild.State;

namespace ComputerAssembler
{
    public class MainApp

    {
        public static void Main()
        {

            //Builder 

            ComputerBuilder PCassembler;
            ComputerStore store = new ComputerStore();
            PCassembler = new PCassembler();
            store.Construct(PCassembler);
            PCassembler.PC.Show(); 

            //Decorator

            Decorator.Computer computer = new Decorator.Computer();
            AddFanComputerDecorator computerWithFan = new AddFanComputerDecorator(computer);
            Console.WriteLine(computerWithFan.GetInfo());
            Console.WriteLine("");
            //State

            Console.WriteLine("System is booted up and temperatures will be measured when under load\n");
            
            // Open a new temperature

            Temperature temperature = new Temperature("Case Temperature");

            // Adjust system load
            Console.WriteLine("System booted: Temperature is - 30 C*");
            temperature.AddLoad(30);
            temperature.AddLoad(15);
            temperature.AddLoad(10);
            temperature.LowerLoad(20);
            temperature.LowerLoad(10);

            Console.ReadKey();
        }
    }
}