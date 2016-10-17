using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProjectTrojan
{
    partial class Calculator : Form
    {
        int inputLength;
        string systemLanguage;
        bool newOperand;
        double operand1;
        string currentOperation = "none";
        bool alternativeFunctionsActive;
        Memory currentMemory = new Memory ();
        OutputPrecision outputPrecision = new OutputPrecision ();

        TextBox inputOutputBox;

        public Calculator ()
        {
            SetCurrentLanguage ();
            InitializeCalculatorAndUIComponents ();
        }

        void ShiftButtonClick (object sender, EventArgs e)
        {
            ToggleShift ();
        }

        void MemoryButtonClick (object sender, EventArgs e)
        {
            if (currentMemory.GetMemoryValue () != 0)
            {
                inputOutputBox.Text = currentMemory.GetMemoryValue ().ToString (outputPrecision.GetCurrentPrecision ());
                newOperand = false;
            }
        }

        void MemoryClearButtonClick (object sender, EventArgs e)
        {
            currentMemory.SetMemoryValue (0);
            memoryButton.BackColor = Color.Gray;
        }

        void MemoryAddButtonClick (object sender, EventArgs e)
        {
            currentMemory.AddValueToMemory (double.Parse (inputOutputBox.Text));

            if (currentMemory.GetMemoryValue () != 0)
                memoryButton.BackColor = Color.PaleVioletRed;
            else
                memoryButton.BackColor = Color.Gray;
            
            newOperand = true;
        }

        void MemorySubstractButtonClick (object sender, EventArgs e)
        {
            currentMemory.SubstractValueFromMemory (double.Parse (inputOutputBox.Text));

            if (currentMemory.GetMemoryValue () != 0)
                memoryButton.BackColor = Color.PaleVioletRed;
            else
                memoryButton.BackColor = Color.Gray;
            
            newOperand = true;
        }

        void Number0ButtonClick (object sender, EventArgs e)
        {
            AddNumber (0);
        }

        void Number1ButtonClick (object sender, EventArgs e)
        {
            AddNumber (1);
        }

        void Number2ButtonClick (object sender, EventArgs e)
        {
            AddNumber (2);
        }

        void Number3ButtonClick (object sender, EventArgs e)
        {
            AddNumber (3);
        }

        void Number4ButtonClick (object sender, EventArgs e)
        {
            AddNumber (4);
        }

        void Number5ButtonClick (object sender, EventArgs e)
        {
            AddNumber (5);
        }

        void Number6ButtonClick (object sender, EventArgs e)
        {
            AddNumber (6);
        }

        void Number7ButtonClick (object sender, EventArgs e)
        {
            AddNumber (7);
        }

        void Number8ButtonClick (object sender, EventArgs e)
        {
            AddNumber (8);
        }

        void Number9ButtonClick (object sender, EventArgs e)
        {
            AddNumber (9);
        }

        void PiButtonClick (object sender, EventArgs e)
        {
            inputOutputBox.Text = (Math.PI).ToString (outputPrecision.GetCurrentPrecision ());
            newOperand = false;
        }

        void EButtonClick (object sender, EventArgs e)
        {
            inputOutputBox.Text = (Math.E).ToString (outputPrecision.GetCurrentPrecision ());
            newOperand = false;
        }

        void CommaButtonClick (object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity ())
                return;
            
            AddComma ();
        }

        void ClearButtonClick (object sender, EventArgs e)
        {
            SetButtonsToDefault ();
            alternativeFunctionsActive = false;
            operand1 = 0;
            SetNewOperation ("none");
        }

        void DelButtonClick (object sender, EventArgs e)
        {
            if (!newOperand)
            {
                if (InputContainsErrorOrInfinity ())
                {
                    ResetIOToZero ();
                }
                else
                if ((inputOutputBox.Text.Contains ("-") && inputOutputBox.TextLength == 2))
                {
                    ResetIOToZero ();
                }
                else
                if (inputOutputBox.TextLength == 1)
                {
                    ResetIOToZero ();
                }
                else
                if (inputOutputBox.TextLength > 1)
                {
                    inputOutputBox.Text = inputOutputBox.Text.Substring (0, (inputOutputBox.TextLength - 1));
                    inputLength -= 1;
                }
            }
        }

        void ExponentButtonClick (object sender, EventArgs e)
        {
            if (!newOperand)
                PerformCurrentOperation ();
            UpdateOperation ("pow");
        }

        void AddButtonClick (object sender, EventArgs e)
        {
            if (!newOperand)
                PerformCurrentOperation ();
            UpdateOperation ("addition");
        }

        void SubstButtonClick (object sender, EventArgs e)
        {
            if (!newOperand)
                PerformCurrentOperation ();
            UpdateOperation ("substraction");
        }

        void MultButtonClick (object sender, EventArgs e)
        {
            if (!newOperand)
                PerformCurrentOperation ();
            UpdateOperation ("multiplication");
        }

        void DivButtonClick (object sender, EventArgs e)
        {
            if (!newOperand)
                PerformCurrentOperation ();
            UpdateOperation ("division");
        }

        void UnitOfAngleButtonClick (object sender, EventArgs e)
        {
            if (unitOfAngle.Text == "Rad")
                unitOfAngle.Text = "Grad";
            else
                unitOfAngle.Text = "Rad";
        }

        void SinusButtonClick (object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity ())
                return;

            CalculateAngularFunction (Math.Sin, double.Parse (inputOutputBox.Text));
            newOperand = true;
        }

        void SinusHypButtonClick (object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity ())
                return;

            CalculateAngularFunction (Math.Sinh, double.Parse (inputOutputBox.Text));
            newOperand = true;
        }

        void CosinusButtonClick (object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity ())
                return;

            CalculateAngularFunction (Math.Cos, double.Parse (inputOutputBox.Text));
            newOperand = true;
        }

        void CosinusHypButtonClick (object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity ())
                return;

            CalculateAngularFunction (Math.Cosh, double.Parse (inputOutputBox.Text));
            newOperand = true;
        }

        void TangensButtonClick (object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity ())
                return;

            CalculateAngularFunction (Math.Tan, double.Parse (inputOutputBox.Text));
            newOperand = true;
        }

        void ArcSinusButtonClick (object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity ())
                return;

            CalculateArcAngularFunction (Math.Asin, double.Parse (inputOutputBox.Text));
            newOperand = true;
        }

        void ArcCosinusButtonClick (object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity ())
                return;

            CalculateArcAngularFunction (Math.Acos, double.Parse (inputOutputBox.Text));
            newOperand = true;
        }

        void ArcTangensButtonClick (object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity ())
                return;

            CalculateArcAngularFunction (Math.Atan, double.Parse (inputOutputBox.Text));
            newOperand = true;
        }

        void FactorialButtonClick (object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity ())
                return;

            if (double.Parse (inputOutputBox.Text) < 0)
            {
                inputOutputBox.Text = "Error";
                newOperand = true;
                return;
            }

            double EPSILON = 0.0000000000000001f;
            double tempMax = double.Parse (inputOutputBox.Text);

            if (Math.Abs ((tempMax % 1)) < EPSILON)
            {
                double temp = 1;
                for (int i = 1; i <= tempMax; i++)
                    temp *= i;

                operand1 = temp;
                inputOutputBox.Text = operand1.ToString (outputPrecision.GetCurrentPrecision ());
                newOperand = true;
            }
            else
            {
                inputOutputBox.Text = "Error";
                newOperand = true;
            }
        }

        void ReciprocalButtonClick (object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity ())
                return;

            double X = double.Parse (inputOutputBox.Text);
            double EPSILON = 0.0000000000000001f;
            if (Math.Abs (X) < EPSILON)
            {
                inputOutputBox.Text = "Error";
                newOperand = true;
            }
            else
            {
                double x = 0;
                x = 1 / X;
                operand1 = x;
                inputOutputBox.Text = operand1.ToString (outputPrecision.GetCurrentPrecision ());
                newOperand = true;
            }
        }

        void SquareButtonClick (object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity ())
                return;
            
            operand1 = double.Parse (inputOutputBox.Text) * double.Parse (inputOutputBox.Text);
            inputOutputBox.Text = operand1.ToString (outputPrecision.GetCurrentPrecision ());
            inputLength = 0;
            newOperand = true;
        }

        void LnButtonClick (object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity ())
                return;

            double lnValue = double.Parse (inputOutputBox.Text);
            if (lnValue > 0)
            {
                operand1 = Math.Log (lnValue);
                inputOutputBox.Text = operand1.ToString (outputPrecision.GetCurrentPrecision ());
                inputLength = 0;
            }
            else
                ErrorMessage ();
            newOperand = true;
        }

        void SqrtButtonClick (object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity ())
                return;
            
            double sqrtValue = Math.Sqrt (double.Parse (inputOutputBox.Text));
            if (sqrtValue > 0)
            {
                operand1 = Math.Sqrt (double.Parse (inputOutputBox.Text));
                inputOutputBox.Text = operand1.ToString (outputPrecision.GetCurrentPrecision ());
            }
            else
                ErrorMessage ();
            newOperand = true;
        }

        void BinomialCoefficientButtonClick (object sender, EventArgs e)
        {
            if (!newOperand)
                PerformCurrentOperation ();
            UpdateOperation ("binominal");
        }

        void EqualsButtonClick (object sender, EventArgs e)
        {
            if (!newOperand)
                PerformCurrentOperation ();
            UpdateOperation ("none");
        }

        void OutputPrecisionButtonClick (object sender, EventArgs e)
        {
            outputPrecision.SetToNextPrecisionInCycle ();
            if (outputPrecision.GetCurrentPrecision () == "g1")
                outputPrecisionButton.Text = (outputPrecision.GetCurrentPrecision ().Substring (1, 1) + " Dgt");
            else
                outputPrecisionButton.Text = (outputPrecision.GetCurrentPrecision ().Substring (1, 1) + " Dgts");
        }
    }

    class MainClass
    {
        public static void Main ()
        {
            Application.Run (new Calculator ());
            return;
        }
    }
}