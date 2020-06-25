using System;
using System.Collections.Generic;
using System.Text;
using PCbuild.State;

namespace PCbuild.State
{
    abstract class State
    {
        protected Temperature temperature;
        protected int sysInfo;
        protected int lowerLimit;
        protected int upperLimit;

        // Properties

        public Temperature Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

        public int SystemTemperature
        {
            get { return sysInfo; }
            set { sysInfo = value; }
        }

        public abstract void Deposit(int amount);
        public abstract void Withdraw(int amount);
    }
}
