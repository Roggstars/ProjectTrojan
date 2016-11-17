namespace ProjectTrojan
{
    public class Memory
    {
        private double memoryValue;

        public Memory ()
        {
            memoryValue = 0;
        }

        public void Clear ()
        {
            memoryValue = 0;
        }

        public string ConvertToStringWithPrecision (OutputPrecision precision)
        {
            return memoryValue.ToString (precision.GetPrecision ());
        }

        public bool ValueIsZero ()
        {
            return memoryValue == 0;
        }

        public void Add (double addValue)
        {
            memoryValue += addValue;
        }

        public void Substract (double subValue)
        {
            memoryValue -= subValue;
        }
    }
}