using System;
using System.Collections.Generic;
using Builder;
using Decorator;
namespace ComputerAssembler
{
    public class MainApp

    {
        public static void Main()
        {

            //Builder 

            ComputerBuilder PCassembler;
            Store store = new Store();
            PCassembler = new PCassembler();
            store.Construct(PCassembler);
            PCassembler.PC.Show();

            //Decorator

            Decorator.Computer computer = new Decorator.Computer();
            AddFanComputerDecorator computerWithFan = new AddFanComputerDecorator(computer);
            Console.WriteLine(computerWithFan.GetInfo());
            Console.ReadLine();

            //State


        }
    }
}