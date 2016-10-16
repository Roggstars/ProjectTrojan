using System;

namespace ProjectTrojan
{
    public class Memory
    {
        double memoryValue;

        public Memory ()
        {
            memoryValue = 0;
        }

        public void SetMemoryValue (double newMemoryValue)
        {
            memoryValue = newMemoryValue;
        }

        public double GetMemoryValue ()
        {
            return memoryValue;
        }

        public void AddValueToMemory (double addValue)
        {
            memoryValue += addValue;
        }

        public void SubstractValueFromMemory (double subValue)
        {
            memoryValue -= subValue;
        }
    }
}