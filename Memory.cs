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

        public void SetValue (double newMemoryValue)
        {
            memoryValue = newMemoryValue;
        }

        double GetValue ()
        {
            return memoryValue;
        }

        public string ConvertToStringWithPrecision(OutputPrecision precision)
        {
            return memoryValue.ToString (precision.GetPrecision());
        }

        public bool ValueIsZero()
        {
            return memoryValue == 0;
        }

        public void AddValue (double addValue)
        {
            memoryValue += addValue;
        }

        public void SubstractValue (double subValue)
        {
            memoryValue -= subValue;
        }
    }
}