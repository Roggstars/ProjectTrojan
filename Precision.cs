using System;

namespace ProjectTrojan
{
    public class OutputPrecision
    {
        string currentPrecision;
        public OutputPrecision ()
        {
            currentPrecision = "g4";
        }

        public string GetCurrentPrecision()
        {
            return currentPrecision;
        }

        public void SetCurrentPrecision(string newPrecision)
        {
            currentPrecision = newPrecision;
        }

        public void SetToNextPrecisionInCycle()
        {
            if (currentPrecision != "g8")
            {
                int currentPrecisionInt = int.Parse(currentPrecision.Substring(1, 1));
                currentPrecisionInt += 1;
                SetCurrentPrecision("g" + currentPrecisionInt.ToString());
            }
            else
                SetCurrentPrecision("g0");
        }
    }
}