using System;
using System.Collections.Generic;
using System.Text;
using PCbuild.State;

namespace PCbuild.State
{
    class OptimalTemp : State
    {
        // Overloaded constructors

        public OptimalTemp(State state) :
          this(state.SystemTemperature, state.Temperature)
        {
        }

        public OptimalTemp(int info, Temperature temp)
        {
            this.sysInfo = info;
            this.temperature = temp;
            Initialize();
        }

        private void Initialize()
        {
            lowerLimit = 0;
            upperLimit = 64;
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
            if (sysInfo > upperLimit)
            {
                temperature.State = new HighTemp(this);
            }
        }

    }
}
