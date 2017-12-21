using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2017.Day8
{
    public class RegistersCollection
    {
        private Dictionary<string, Register> store = new Dictionary<string, Register>();

        public int CurrentMax => store.Values.Max(r => r.Value);

        public int LifetimeMax => store.Values.Max(r => r.MaxValue);

        public Register this[string registerName]
        {
            get
            {
                this.EnsureRegister(registerName);
                return this.store[registerName];
            }
        }

        private void EnsureRegister(string register)
        {
            if (!store.ContainsKey(register))
            {
                store[register] = new Register();
            }
        }
    }
}