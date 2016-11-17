using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProjectTrojan
{
    partial class Calculator : Form
    {
        internal readonly string calculatorLanguage;
        internal readonly double zeroTolerance = 0.0000000000001f;

        internal double operand;
        internal string currentOperation = "none";
        internal bool newOperand;
        internal bool alternativeFunctionsActive;

        internal readonly Memory calculatorMemory = new Memory ();
        internal readonly OutputPrecision outputPrecision = new OutputPrecision ();

        public Calculator ()
        {
            InitializeCalculatorAndUiComponents ();
            SetCalculatorLanguageTo (out calculatorLanguage);
        }

        private void Number0ButtonClick (object sender, EventArgs eventArgs)
        {
            AddNumber (0);
        }

        private void Number1ButtonClick (object sender, EventArgs eventArgs)
        {
            AddNumber (1);
        }

        private void Number2ButtonClick (object sender, EventArgs eventArgs)
        {
            AddNumber (2);
        }

        private void Number3ButtonClick (object sender, EventArgs eventArgs)
        {
            AddNumber (3);
        }

        private void Number4ButtonClick (object sender, EventArgs eventArgs)
        {
            AddNumber (4);
        }

        private void Number5ButtonClick (object sender, EventArgs eventArgs)
        {
            AddNumber (5);
        }

        private void Number6ButtonClick (object sender, EventArgs eventArgs)
        {
            AddNumber (6);
        }

        private void Number7ButtonClick (object sender, EventArgs eventArgs)
        {
            AddNumber (7);
        }

        private void Number8ButtonClick (object sender, EventArgs eventArgs)
        {
            AddNumber (8);
        }

        private void Number9ButtonClick (object sender, EventArgs eventArgs)
        {
            AddNumber (9);
        }

        private void AddButtonClick (object sender, EventArgs eventArgs)
        {
            if (!newOperand)
                PerformCurrentOperation ();
            SetNewOperationTo ("addition");
        }

        private void SubstButtonClick (object sender, EventArgs eventArgs)
        {
            if (!newOperand)
                PerformCurrentOperation ();
            SetNewOperationTo ("substraction");
        }

        private void MultButtonClick (object sender, EventArgs eventArgs)
        {
            if (!newOperand)
                PerformCurrentOperation ();
            SetNewOperationTo ("multiplication");
        }

        private void DivButtonClick (object sender, EventArgs eventArgs)
        {
            if (!newOperand)
                PerformCurrentOperation ();
            SetNewOperationTo ("division");
        }

        private void BinomialCoefficientButtonClick (object sender, EventArgs eventArgs)
        {
            if (!newOperand)
                PerformCurrentOperation ();
            SetNewOperationTo ("binominal");
        }

        private void EqualsButtonClick (object sender, EventArgs eventArgs)
        {
            if (!newOperand)
                PerformCurrentOperation ();
            SetNewOperationTo ("none");
        }

        private void CommaButtonClick (object sender, EventArgs eventArgs)
        {
            if (IoContainsErrorOrInfinity ())
                return;

            AddComma ();
        }

        private void DelButtonClick (object sender, EventArgs eventArgs)
        {
            if (newOperand) return;
            if (IoContainsErrorOrInfinity ()
                || (ioBox.Text.Contains ("-") && ioBox.TextLength == 2)
                || ioBox.TextLength == 1)
                ResetIoToZero ();
            else if (ioBox.TextLength > 1)
                ioBox.Text = ioBox.Text.Substring (0, (ioBox.TextLength - 1));
        }

        private void ClearButtonClick (object sender, EventArgs eventArgs)
        {
            SetButtonsToInitState ();
            alternativeFunctionsActive = false;
            operand = 0;
            SetNewOperationTo ("none");
        }

        private void ShiftButtonClick (object sender, EventArgs eventArgs)
        {
            ToggleShift ();
        }

        private void SquareButtonClick (object sender, EventArgs eventArgs)
        {
            if (IoContainsErrorOrInfinity ())
                return;

            operand = CalculateSquareOf (double.Parse (ioBox.Text));
            ioBox.Text = operand.ToString (outputPrecision.GetPrecision ());
            newOperand = true;
        }

        private void ExponentButtonClick (object sender, EventArgs eventArgs)
        {
            if (!newOperand)
                PerformCurrentOperation ();
            SetNewOperationTo ("pow");
        }

        private void SqrtButtonClick (object sender, EventArgs eventArgs)
        {
            if (IoContainsErrorOrInfinity ())
                return;

            if (double.Parse (ioBox.Text) > 0)
            {
                operand = Math.Sqrt (double.Parse (ioBox.Text));
                ioBox.Text = operand.ToString (outputPrecision.GetPrecision ());
            }
            else
                ErrorMessage ("Low0Error");
            newOperand = true;
        }

        private void FactorialButtonClick (object sender, EventArgs eventArgs)
        {
            if (IoContainsErrorOrInfinity ())
                return;

            if (double.Parse (ioBox.Text) < 0)
            {
                ErrorMessage ("Low0Error");
                return;
            }

            double factorialValue = double.Parse (ioBox.Text);

            if ((factorialValue % 1) < zeroTolerance)
            {
                operand = CalculateFactorialOf ((int)factorialValue);
                ioBox.Text = operand.ToString (outputPrecision.GetPrecision ());
                newOperand = true;
            }
            else
                ErrorMessage ("UncalculatableFactorial");
        }

        private void ReciprocalButtonClick (object sender, EventArgs eventArgs)
        {
            if (IoContainsErrorOrInfinity ())
                return;

            operand = 1 / operand;
            ioBox.Text = operand.ToString (outputPrecision.GetPrecision ());
            newOperand = true;
        }

        private void LnButtonClick (object sender, EventArgs eventArgs)
        {
            if (IoContainsErrorOrInfinity ())
                return;

            if (double.Parse (ioBox.Text) > 0)
            {
                operand = Math.Log (double.Parse (ioBox.Text));
                ioBox.Text = operand.ToString (outputPrecision.GetPrecision ());
                newOperand = true;
            }
            else
                ErrorMessage ("Low0Error");
        }

        private void SinusButtonClick (object sender, EventArgs eventArgs)
        {
            if (IoContainsErrorOrInfinity ())
                return;

            CalculateAngularFunction (Math.Sin, double.Parse (ioBox.Text));
            newOperand = true;
        }

        private void SinusHypButtonClick (object sender, EventArgs eventArgs)
        {
            if (IoContainsErrorOrInfinity ())
                return;

            CalculateAngularFunction (Math.Sinh, double.Parse (ioBox.Text));
            newOperand = true;
        }

        private void ArcSinusButtonClick (object sender, EventArgs eventArgs)
        {
            if (IoContainsErrorOrInfinity ())
                return;

            if (double.Parse (ioBox.Text) < -1 || double.Parse (ioBox.Text) > 1)
            {
                ErrorMessage ("OutOfDefArea");
                return;
            }

            CalculateArcAngularFunction (Math.Asin, double.Parse (ioBox.Text));
            newOperand = true;
        }

        private void CosinusButtonClick (object sender, EventArgs eventArgs)
        {
            if (IoContainsErrorOrInfinity ())
                return;

            CalculateAngularFunction (Math.Cos, double.Parse (ioBox.Text));
            newOperand = true;
        }

        private void CosinusHypButtonClick (object sender, EventArgs eventArgs)
        {
            if (IoContainsErrorOrInfinity ())
                return;

            CalculateAngularFunction (Math.Cosh, double.Parse (ioBox.Text));
            newOperand = true;
        }

        private void ArcCosinusButtonClick (object sender, EventArgs eventArgs)
        {
            if (IoContainsErrorOrInfinity ())
                return;

            if (double.Parse (ioBox.Text) < -1 || double.Parse (ioBox.Text) > 1)
            {
                ErrorMessage ("OutOfDefArea");
                return;
            }

            CalculateArcAngularFunction (Math.Acos, double.Parse (ioBox.Text));
            newOperand = true;
        }

        private void TangensButtonClick (object sender, EventArgs eventArgs)
        {
            if (IoContainsErrorOrInfinity ())
                return;

            CalculateAngularFunction (Math.Tan, double.Parse (ioBox.Text));
            newOperand = true;
        }

        private void ArcTangensButtonClick (object sender, EventArgs eventArgs)
        {
            if (IoContainsErrorOrInfinity ())
                return;

            if (double.Parse (ioBox.Text) < -1 || double.Parse (ioBox.Text) > 1)
            {
                ErrorMessage ("OutOfDefArea");
                return;
            }

            CalculateArcAngularFunction (Math.Atan, double.Parse (ioBox.Text));
            newOperand = true;
        }

        private void UnitOfAngleButtonClick (object sender, EventArgs eventArgs)
        {
            unitOfAngle.Text = unitOfAngle.Text == "Rad" ? "Grad" : "Rad";
        }

        private void OutputPrecisionButtonClick (object sender, EventArgs eventArgs)
        {
            outputPrecision.CycleToNextPrecision ();
            if (outputPrecision.GetPrecision () == "g1")
                outputPrecisionButton.Text = (outputPrecision.GetPrecision ().Substring (1, 1) + " Dgt");
            else
                outputPrecisionButton.Text = (outputPrecision.GetPrecision ().Substring (1, 1) + " Dgts");
        }

        private void MemoryButtonClick (object sender, EventArgs eventArgs)
        {
            ioBox.Text = calculatorMemory.ConvertToStringWithPrecision (outputPrecision);
            newOperand = true;
        }

        private void MemoryClearButtonClick (object sender, EventArgs eventArgs)
        {
            calculatorMemory.Clear ();
            memoryButton.BackColor = Color.Gray;
        }

        private void MemoryAddButtonClick (object sender, EventArgs eventArgs)
        {
            calculatorMemory.Add (double.Parse (ioBox.Text));

            memoryButton.BackColor = !calculatorMemory.ValueIsZero () ? Color.PaleVioletRed : Color.Gray;

            newOperand = true;
        }

        private void MemorySubstractButtonClick (object sender, EventArgs eventArgs)
        {
            calculatorMemory.Substract (double.Parse (ioBox.Text));

            memoryButton.BackColor = !calculatorMemory.ValueIsZero () ? Color.PaleVioletRed : Color.Gray;

            newOperand = true;
        }

        private void PiButtonClick (object sender, EventArgs eventArgs)
        {
            ioBox.Text = (Math.PI).ToString (outputPrecision.GetPrecision ());
            newOperand = false;
        }

        private void EButtonClick (object sender, EventArgs eventArgs)
        {
            ioBox.Text = (Math.E).ToString (outputPrecision.GetPrecision ());
            newOperand = false;
        }
    }
}