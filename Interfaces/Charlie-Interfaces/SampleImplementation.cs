using System;
using System.Collections.Generic;
using System.Text;

namespace Charlie.Interfaces
{
    class SampleImplementation : ISampleInterface
    {
        public string GetString()
        {
            return "hi";
        }

        public int DoubleValue(int v)
        {
            return v * 2;
        }

        public void DoSomething()
        {
            // logic
        }
    }
}
