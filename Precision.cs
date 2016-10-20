using System;

namespace ProjectTrojan
{
    public class OutputPrecision
    {
        string precision;

        public OutputPrecision ()
        {
            precision = "g4";
        }

        public string GetPrecision ()
        {
            return precision;
        }

        public void SetPrecision (string newPrecision)
        {
            precision = newPrecision;
        }

        public void CycleToNextPrecision ()
        {
            if (precision != "g8")
            {
                int currentPrecisionInt = int.Parse (precision.Substring (1, 1));
                currentPrecisionInt += 1;
                SetPrecision ("g" + currentPrecisionInt.ToString ());
            }
            else
                SetPrecision ("g0");
        }
    }
}