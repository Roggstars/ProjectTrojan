using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProjectTrojan
{
    partial class Calculator : Form
    {
        readonly string calculatorLanguage;
        readonly double zeroTolerance = 0.0000000000001f;

        double operand;
        string currentOperation = "none";
        bool newOperand;
        bool alternativeFunctionsActive;

        Memory calculatorMemory = new Memory ();
        OutputPrecision outputPrecision = new OutputPrecision ();

        public Calculator ()
        {
            InitializeCalculatorAndUIComponents ();
            SetCurrentLanguage (out calculatorLanguage);
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

        void AddButtonClick (object sender, EventArgs e)
        {
            if (!newOperand)
                PerformCurrentOperation ();
            SetNewOperation ("addition");
        }

        void SubstButtonClick (object sender, EventArgs e)
        {
            if (!newOperand)
                PerformCurrentOperation ();
            SetNewOperation ("substraction");
        }

        void MultButtonClick (object sender, EventArgs e)
        {
            if (!newOperand)
                PerformCurrentOperation ();
            SetNewOperation ("multiplication");
        }

        void DivButtonClick (object sender, EventArgs e)
        {
            if (!newOperand)
                PerformCurrentOperation ();
            SetNewOperation ("division");
        }

        void BinomialCoefficientButtonClick (object sender, EventArgs e)
        {
            if (!newOperand)
                PerformCurrentOperation ();
            SetNewOperation ("binominal");
        }

        void EqualsButtonClick (object sender, EventArgs e)
        {
            if (!newOperand)
                PerformCurrentOperation ();
            SetNewOperation ("none");
        }

        void CommaButtonClick (object sender, EventArgs e)
        {
            if (IOContainsErrorOrInfinity ())
                return;
            
            AddComma ();
        }

        void DelButtonClick (object sender, EventArgs e)
        {
            if (!newOperand)
            {
                if (IOContainsErrorOrInfinity ()
                    || (IOBox.Text.Contains ("-") && IOBox.TextLength == 2)
                    || IOBox.TextLength == 1)
                    ResetIOToZero ();
                else
                if (IOBox.TextLength > 1)
                    IOBox.Text = IOBox.Text.Substring (0, (IOBox.TextLength - 1));
            }
        }

        void ClearButtonClick (object sender, EventArgs e)
        {
            SetButtonsToInitState ();
            alternativeFunctionsActive = false;
            operand = 0;
            SetNewOperation ("none");
        }

        void ShiftButtonClick (object sender, EventArgs e)
        {
            ToggleShift ();
        }

        void SquareButtonClick (object sender, EventArgs e)
        {
            if (IOContainsErrorOrInfinity ())
                return;

            operand = double.Parse (IOBox.Text) * double.Parse (IOBox.Text);
            IOBox.Text = operand.ToString (outputPrecision.GetPrecision ());
            newOperand = true;
        }

        void ExponentButtonClick (object sender, EventArgs e)
        {
            if (!newOperand)
                PerformCurrentOperation ();
            SetNewOperation ("pow");
        }

        void SqrtButtonClick (object sender, EventArgs e)
        {
            if (IOContainsErrorOrInfinity ())
                return;

            if (double.Parse (IOBox.Text) > 0)
            {
                operand = Math.Sqrt (double.Parse (IOBox.Text));
                IOBox.Text = operand.ToString (outputPrecision.GetPrecision ());
            }
            else
                ErrorMessage ("Low0Error");
            newOperand = true;
        }

        void FactorialButtonClick (object sender, EventArgs e)
        {
            if (IOContainsErrorOrInfinity ())
                return;

            if (double.Parse (IOBox.Text) < 0)
            {
                ErrorMessage ("Low0Error");
                return;
            }

            double factorialValue = double.Parse (IOBox.Text);

            if ((factorialValue % 1) < zeroTolerance)
            {
                double factorial = 1;
                for (int i = 1; i <= factorialValue; i++)
                    factorial *= i;

                operand = factorial;
                IOBox.Text = operand.ToString (outputPrecision.GetPrecision ());
                newOperand = true;
            }
            else
                ErrorMessage ("Low0Error");
        }

        void ReciprocalButtonClick (object sender, EventArgs e)
        {
            if (IOContainsErrorOrInfinity ())
                return;

            operand = 1 / operand;
            IOBox.Text = operand.ToString (outputPrecision.GetPrecision ());
            newOperand = true;
        }

        void LnButtonClick (object sender, EventArgs e)
        {
            if (IOContainsErrorOrInfinity ())
                return;

            if (double.Parse (IOBox.Text) > 0)
            {
                operand = Math.Log (double.Parse (IOBox.Text));
                IOBox.Text = operand.ToString (outputPrecision.GetPrecision ());
                newOperand = true;
            }
            else
                ErrorMessage ("Low0Error");
        }

        void SinusButtonClick (object sender, EventArgs e)
        {
            if (IOContainsErrorOrInfinity ())
                return;

            CalculateAngularFunction (Math.Sin, double.Parse (IOBox.Text));
            newOperand = true;
        }

        void SinusHypButtonClick (object sender, EventArgs e)
        {
            if (IOContainsErrorOrInfinity ())
                return;

            CalculateAngularFunction (Math.Sinh, double.Parse (IOBox.Text));
            newOperand = true;
        }

        void ArcSinusButtonClick (object sender, EventArgs e)
        {
            if (IOContainsErrorOrInfinity ())
                return;
            
            if (double.Parse (IOBox.Text) < -1 || double.Parse (IOBox.Text) > 1)
            {
                ErrorMessage ("OutOfDefArea");
                return;
            }

            CalculateArcAngularFunction (Math.Asin, double.Parse (IOBox.Text));
            newOperand = true;
        }

        void CosinusButtonClick (object sender, EventArgs e)
        {
            if (IOContainsErrorOrInfinity ())
                return;

            CalculateAngularFunction (Math.Cos, double.Parse (IOBox.Text));
            newOperand = true;
        }

        void CosinusHypButtonClick (object sender, EventArgs e)
        {
            if (IOContainsErrorOrInfinity ())
                return;

            CalculateAngularFunction (Math.Cosh, double.Parse (IOBox.Text));
            newOperand = true;
        }

        void ArcCosinusButtonClick (object sender, EventArgs e)
        {
            if (IOContainsErrorOrInfinity ())
                return;
            
            if (double.Parse (IOBox.Text) < -1 || double.Parse (IOBox.Text) > 1)
            {
                ErrorMessage ("OutOfDefArea");
                return;
            }

            CalculateArcAngularFunction (Math.Acos, double.Parse (IOBox.Text));
            newOperand = true;
        }

        void TangensButtonClick (object sender, EventArgs e)
        {
            if (IOContainsErrorOrInfinity ())
                return;

            CalculateAngularFunction (Math.Tan, double.Parse (IOBox.Text));
            newOperand = true;
        }

        void ArcTangensButtonClick (object sender, EventArgs e)
        {
            if (IOContainsErrorOrInfinity ())
                return;

            if (double.Parse (IOBox.Text) < -1 || double.Parse (IOBox.Text) > 1)
            {
                ErrorMessage ("OutOfDefArea");
                return;
            }

            CalculateArcAngularFunction (Math.Atan, double.Parse (IOBox.Text));
            newOperand = true;
        }

        void UnitOfAngleButtonClick (object sender, EventArgs e)
        {
            if (unitOfAngle.Text == "Rad")
                unitOfAngle.Text = "Grad";
            else
                unitOfAngle.Text = "Rad";
        }

        void OutputPrecisionButtonClick (object sender, EventArgs e)
        {
            outputPrecision.CycleToNextPrecision ();
            if (outputPrecision.GetPrecision () == "g1")
                outputPrecisionButton.Text = (outputPrecision.GetPrecision ().Substring (1, 1) + " Dgt");
            else
                outputPrecisionButton.Text = (outputPrecision.GetPrecision ().Substring (1, 1) + " Dgts");
        }

        void MemoryButtonClick (object sender, EventArgs e)
        {
            if (calculatorMemory.GetMemoryValue () != 0)
            {
                IOBox.Text = calculatorMemory.GetMemoryValue ().ToString (outputPrecision.GetPrecision ());
                newOperand = false;
            }
        }

        void MemoryClearButtonClick (object sender, EventArgs e)
        {
            calculatorMemory.SetMemoryValue (0);
            memoryButton.BackColor = Color.Gray;
        }

        void MemoryAddButtonClick (object sender, EventArgs e)
        {
            calculatorMemory.AddValueToMemory (double.Parse (IOBox.Text));

            if (calculatorMemory.GetMemoryValue () != 0)
                memoryButton.BackColor = Color.PaleVioletRed;
            else
                memoryButton.BackColor = Color.Gray;

            newOperand = true;
        }

        void MemorySubstractButtonClick (object sender, EventArgs e)
        {
            calculatorMemory.SubstractValueFromMemory (double.Parse (IOBox.Text));

            if (calculatorMemory.GetMemoryValue () != 0)
                memoryButton.BackColor = Color.PaleVioletRed;
            else
                memoryButton.BackColor = Color.Gray;

            newOperand = true;
        }

        void PiButtonClick (object sender, EventArgs e)
        {
            IOBox.Text = (Math.PI).ToString (outputPrecision.GetPrecision ());
            newOperand = false;
        }

        void EButtonClick (object sender, EventArgs e)
        {
            IOBox.Text = (Math.E).ToString (outputPrecision.GetPrecision ());
            newOperand = false;
        }
    }
}