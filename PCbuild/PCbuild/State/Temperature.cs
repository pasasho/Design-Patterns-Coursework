using System;
using System.Collections.Generic;
using System.Text;
using PCbuild.State;

namespace PCbuild.State
{
    class Temperature
    {
        private State _state;
        private string _owner;

        // Constructor

        public Temperature(string owner)
        {
            // System boots up at 30 C*

            this._owner = owner;
            this._state = new OptimalTemp(30, this);
        }

        // Properties

        public int CurrentTemp
        {
            get { return _state.SystemTemperature; }
        }

        public State State
        {
            get { return _state; }
            set { _state = value; }
        }

        public void AddLoad(int amount)
        {
            _state.Deposit(amount);
            Console.WriteLine("Added Load {0} --- ", amount);
            Console.WriteLine(" SystemTemperature = {0}C*", this.CurrentTemp);
            Console.WriteLine(" Status = {0}",
              this.State.GetType().Name);
            Console.WriteLine("");
        }

        public void LowerLoad(int amount)
        {
            _state.Withdraw(amount);
            Console.WriteLine("Reduced Load {0} --- ", amount);
            Console.WriteLine(" SystemTemperature = {0}C*", this.CurrentTemp);
            Console.WriteLine(" Status = {0}\n",
              this.State.GetType().Name);
        }
    }
}
