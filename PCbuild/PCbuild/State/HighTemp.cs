using System;
using System.Collections.Generic;
using System.Text;
using PCbuild.State;

namespace PCbuild.State
{
    class HighTemp : State
    {
        // Overloaded constructors

        public HighTemp(State state)
          : this(state.SystemTemperature, state.Temperature)
        { }

        public HighTemp(int info, Temperature temp)
        {
            this.sysInfo = info;
            this.temperature = temp;
            Initialize();
        }

        private void Initialize()
        {
            lowerLimit = 65;
            upperLimit = 1000;
        }

        public override void Deposit(int amount)
        {
            sysInfo += amount;
            StateChangeCheck();
        }

        public override void Withdraw(int amount)
        {
            sysInfo -= amount;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (sysInfo < lowerLimit)
            {
                temperature.State = new OptimalTemp(this);
            }
        }

    }
}
