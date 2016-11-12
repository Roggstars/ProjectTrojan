using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProjectTrojan
{
    partial class Calculator
    {
        Button number0;
        Button number1;
        Button number2;
        Button number3;
        Button number4;
        Button number5;
        Button number6;
        Button number7;
        Button number8;
        Button number9;
        Button addition;
        Button substraction;
        Button multiplication;
        Button division;
        Button equals;
        Button comma;
        Button delete;
        Button clear;
        Button shift;
        Button square;
        Button squareRoot;
        Button factorial;
        Button natualLogarithm;
        Button sinus;
        Button sinusHyp;
        Button cosinus;
        Button cosinusHyp;
        Button tangens;
        Button unitOfAngle;
        Button outputPrecisionButton;
        Button memoryButton;
        Button memoryAddSubstButton;
        Button pi;
        Button e;

        TextBox IOBox;

        void InitializeCalculatorAndUIComponents ()
        {
            SetWindowSizeAndProperties ();
            CreateUIComponents ();
            RemoveButtonBorders ();
            SetButtonCursors ();
            SetUIButtonsTexts ();
            SetUIButtonsSizes ();
            AddControlsToUIComponents ();
            CreateButtonsEventHandlers ();
            SetUIComponentsColors ();
            SetIOBoxProperties ();
            SetUIComponentsPositions ();
        }

        void SetWindowSizeAndProperties ()
        {
            Size windowSize = new Size (345, 492);
            Size = windowSize;
            Text = "Project Trojan";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            MaximizeBox = false;
        }

        void CreateUIComponents ()
        {
            number0 = new Button ();
            number1 = new Button ();
            number2 = new Button ();
            number3 = new Button ();
            number4 = new Button ();
            number5 = new Button ();
            number6 = new Button ();
            number7 = new Button ();
            number8 = new Button ();
            number9 = new Button ();
            addition = new Button ();
            substraction = new Button ();
            multiplication = new Button ();
            division = new Button ();
            equals = new Button ();
            comma = new Button ();
            delete = new Button ();
            clear = new Button ();
            shift = new Button ();
            square = new Button ();
            squareRoot = new Button ();
            factorial = new Button ();
            natualLogarithm = new Button ();
            sinus = new Button ();
            sinusHyp = new Button ();
            cosinus = new Button ();
            cosinusHyp = new Button ();
            tangens = new Button ();
            unitOfAngle = new Button ();
            outputPrecisionButton = new Button ();
            memoryButton = new Button ();
            memoryAddSubstButton = new Button ();
            pi = new Button ();
            e = new Button ();

            IOBox = new TextBox ();
        }

        void RemoveButtonBorders ()
        {
            RemoveButtonBordersFromButton (number0);
            RemoveButtonBordersFromButton (number1);
            RemoveButtonBordersFromButton (number2);
            RemoveButtonBordersFromButton (number3);
            RemoveButtonBordersFromButton (number4);
            RemoveButtonBordersFromButton (number5);
            RemoveButtonBordersFromButton (number6);
            RemoveButtonBordersFromButton (number7);
            RemoveButtonBordersFromButton (number8);
            RemoveButtonBordersFromButton (number9);
            RemoveButtonBordersFromButton (addition);
            RemoveButtonBordersFromButton (substraction);
            RemoveButtonBordersFromButton (multiplication);
            RemoveButtonBordersFromButton (division);
            RemoveButtonBordersFromButton (equals);
            RemoveButtonBordersFromButton (comma);
            RemoveButtonBordersFromButton (delete);
            RemoveButtonBordersFromButton (clear);
            RemoveButtonBordersFromButton (shift);
            RemoveButtonBordersFromButton (square);
            RemoveButtonBordersFromButton (squareRoot);
            RemoveButtonBordersFromButton (factorial);
            RemoveButtonBordersFromButton (natualLogarithm);
            RemoveButtonBordersFromButton (sinus);
            RemoveButtonBordersFromButton (sinusHyp);
            RemoveButtonBordersFromButton (cosinus);
            RemoveButtonBordersFromButton (cosinusHyp);
            RemoveButtonBordersFromButton (tangens);
            RemoveButtonBordersFromButton (unitOfAngle);
            RemoveButtonBordersFromButton (outputPrecisionButton);
            RemoveButtonBordersFromButton (memoryButton);
            RemoveButtonBordersFromButton (memoryAddSubstButton);
            RemoveButtonBordersFromButton (pi);
            RemoveButtonBordersFromButton (e);
        }

        void RemoveButtonBordersFromButton (Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
        }

        void SetButtonCursors ()
        {
            SetButtonCursorForButton (number0);
            SetButtonCursorForButton (number1);
            SetButtonCursorForButton (number2);
            SetButtonCursorForButton (number3);
            SetButtonCursorForButton (number4);
            SetButtonCursorForButton (number5);
            SetButtonCursorForButton (number6);
            SetButtonCursorForButton (number7);
            SetButtonCursorForButton (number8);
            SetButtonCursorForButton (number9);
            SetButtonCursorForButton (addition);
            SetButtonCursorForButton (substraction);
            SetButtonCursorForButton (multiplication);
            SetButtonCursorForButton (division);
            SetButtonCursorForButton (equals);
            SetButtonCursorForButton (comma);
            SetButtonCursorForButton (delete);
            SetButtonCursorForButton (clear);
            SetButtonCursorForButton (shift);
            SetButtonCursorForButton (square);
            SetButtonCursorForButton (squareRoot);
            SetButtonCursorForButton (factorial);
            SetButtonCursorForButton (natualLogarithm);
            SetButtonCursorForButton (sinus);
            SetButtonCursorForButton (sinusHyp);
            SetButtonCursorForButton (cosinus);
            SetButtonCursorForButton (cosinusHyp);
            SetButtonCursorForButton (tangens);
            SetButtonCursorForButton (unitOfAngle);
            SetButtonCursorForButton (outputPrecisionButton);
            SetButtonCursorForButton (memoryButton);
            SetButtonCursorForButton (memoryAddSubstButton);
            SetButtonCursorForButton (pi);
            SetButtonCursorForButton (e);
        }

        void SetButtonCursorForButton (Button button)
        {
            button.Cursor = Cursors.Hand;
        }

        void SetUIButtonsTexts ()
        {
            number0.Text = "0";
            number1.Text = "1";
            number2.Text = "2";
            number3.Text = "3";
            number4.Text = "4";
            number5.Text = "5";
            number6.Text = "6";
            number7.Text = "7";
            number8.Text = "8";
            number9.Text = "9";
            addition.Text = "+";
            substraction.Text = "-";
            multiplication.Text = "*";
            division.Text = "/";
            equals.Text = "=";
            comma.Text = ",";
            delete.Text = "Del";
            clear.Text = "AC";
            shift.Text = "Shift";
            square.Text = "x²";
            squareRoot.Text = "√¯x";
            factorial.Text = "x!";
            natualLogarithm.Text = "ln x";
            sinus.Text = "sin";
            sinusHyp.Text = "sinH";
            cosinus.Text = "cos";
            cosinusHyp.Text = "cosH";
            tangens.Text = "tan";
            unitOfAngle.Text = "Rad";
            outputPrecisionButton.Text = "4 Dgts";
            memoryButton.Text = "M";
            memoryAddSubstButton.Text = "M+";
            pi.Text = "Pi";
            e.Text = "e";
        }

        void SetUIButtonsSizes ()
        {
            Size standardButtonSize = new Size (50, 50);

            SetButtonSize (number0, standardButtonSize);
            SetButtonSize (number1, standardButtonSize);
            SetButtonSize (number2, standardButtonSize);
            SetButtonSize (number3, standardButtonSize);
            SetButtonSize (number4, standardButtonSize);
            SetButtonSize (number5, standardButtonSize);
            SetButtonSize (number6, standardButtonSize);
            SetButtonSize (number7, standardButtonSize);
            SetButtonSize (number8, standardButtonSize);
            SetButtonSize (number9, standardButtonSize);
            SetButtonSize (addition, standardButtonSize);
            SetButtonSize (substraction, standardButtonSize);
            SetButtonSize (multiplication, standardButtonSize);
            SetButtonSize (division, standardButtonSize);
            SetButtonSize (equals, standardButtonSize);
            SetButtonSize (comma, standardButtonSize);
            SetButtonSize (delete, standardButtonSize);
            SetButtonSize (clear, standardButtonSize);
            SetButtonSize (shift, standardButtonSize);
            SetButtonSize (square, standardButtonSize);
            SetButtonSize (squareRoot, standardButtonSize);
            SetButtonSize (factorial, standardButtonSize);
            SetButtonSize (natualLogarithm, standardButtonSize);
            SetButtonSize (sinus, standardButtonSize);
            SetButtonSize (sinusHyp, standardButtonSize);
            SetButtonSize (cosinus, standardButtonSize);
            SetButtonSize (cosinusHyp, standardButtonSize);
            SetButtonSize (tangens, standardButtonSize);
            SetButtonSize (unitOfAngle, standardButtonSize);
            SetButtonSize (outputPrecisionButton, standardButtonSize);
            SetButtonSize (memoryButton, standardButtonSize);
            SetButtonSize (memoryAddSubstButton, standardButtonSize);
            SetButtonSize (pi, standardButtonSize);
            SetButtonSize (e, standardButtonSize);
        }

        void SetButtonSize (Button button, Size size)
        {
            button.Width = size.Width;
            button.Height = size.Height;
        }

        void AddControlsToUIComponents ()
        {
            Controls.Add (number0);
            Controls.Add (number1);
            Controls.Add (number2);
            Controls.Add (number3);
            Controls.Add (number4);
            Controls.Add (number5);
            Controls.Add (number6);
            Controls.Add (number7);
            Controls.Add (number8);
            Controls.Add (number9);
            Controls.Add (addition);
            Controls.Add (substraction);
            Controls.Add (multiplication);
            Controls.Add (division);
            Controls.Add (equals);
            Controls.Add (comma);
            Controls.Add (delete);
            Controls.Add (clear);
            Controls.Add (shift);
            Controls.Add (square);
            Controls.Add (squareRoot);
            Controls.Add (factorial);
            Controls.Add (natualLogarithm);
            Controls.Add (sinus);
            Controls.Add (sinusHyp);
            Controls.Add (cosinus);
            Controls.Add (cosinusHyp);
            Controls.Add (tangens);
            Controls.Add (unitOfAngle);
            Controls.Add (outputPrecisionButton);
            Controls.Add (memoryButton);
            Controls.Add (memoryAddSubstButton);
            Controls.Add (pi);
            Controls.Add (e);

            Controls.Add (IOBox);
        }

        void CreateButtonsEventHandlers ()
        {
            number0.Click += Number0ButtonClick;
            number1.Click += Number1ButtonClick;
            number2.Click += Number2ButtonClick;
            number3.Click += Number3ButtonClick;
            number4.Click += Number4ButtonClick;
            number5.Click += Number5ButtonClick;
            number6.Click += Number6ButtonClick;
            number7.Click += Number7ButtonClick;
            number8.Click += Number8ButtonClick;
            number9.Click += Number9ButtonClick;
            addition.Click += AddButtonClick;
            substraction.Click += SubstButtonClick;
            multiplication.Click += MultButtonClick;
            division.Click += DivButtonClick;
            equals.Click += EqualsButtonClick;
            comma.Click += CommaButtonClick;
            delete.Click += DelButtonClick;
            clear.Click += ClearButtonClick;
            shift.Click += ShiftButtonClick;
            square.Click += SquareButtonClick;
            squareRoot.Click += SqrtButtonClick;
            factorial.Click += FactorialButtonClick;
            natualLogarithm.Click += LnButtonClick;
            sinus.Click += SinusButtonClick;
            sinusHyp.Click += SinusHypButtonClick;
            cosinus.Click += CosinusButtonClick;
            cosinusHyp.Click += CosinusHypButtonClick;
            tangens.Click += TangensButtonClick;
            unitOfAngle.Click += UnitOfAngleButtonClick;
            outputPrecisionButton.Click += OutputPrecisionButtonClick;
            memoryButton.Click += MemoryButtonClick;
            memoryAddSubstButton.Click += MemoryAddButtonClick;
            pi.Click += PiButtonClick;
            e.Click += EButtonClick;
        }

        void SetUIComponentsColors ()
        {
            number0.BackColor = Color.LightGray;
            number1.BackColor = Color.LightGray;
            number2.BackColor = Color.LightGray;
            number3.BackColor = Color.LightGray;
            number4.BackColor = Color.LightGray;
            number5.BackColor = Color.LightGray;
            number6.BackColor = Color.LightGray;
            number7.BackColor = Color.LightGray;
            number8.BackColor = Color.LightGray;
            number9.BackColor = Color.LightGray;
            addition.BackColor = Color.Orange;
            substraction.BackColor = Color.Orange;
            multiplication.BackColor = Color.Orange;
            division.BackColor = Color.Orange;
            equals.BackColor = Color.Orange;
            delete.BackColor = Color.Red;
            clear.BackColor = Color.Red;
            square.BackColor = Color.Gray;
            squareRoot.BackColor = Color.Gray;
            factorial.BackColor = Color.Gray;
            natualLogarithm.BackColor = Color.Gray;
            sinus.BackColor = Color.Gray;
            sinusHyp.BackColor = Color.Gray;
            cosinus.BackColor = Color.Gray;
            cosinusHyp.BackColor = Color.Gray;
            tangens.BackColor = Color.Gray;
            unitOfAngle.BackColor = Color.Gray;
            memoryButton.BackColor = Color.Gray;
            memoryAddSubstButton.BackColor = Color.Gray;
            pi.BackColor = Color.Gray;
            e.BackColor = Color.Gray;

            IOBox.ForeColor = Color.WhiteSmoke;
            IOBox.BackColor = Color.Black;
        }

        void SetIOBoxProperties ()
        {
            IOBox.Width = 320;
            IOBox.Font = new Font ("ArialBlack", 30, FontStyle.Bold);
            IOBox.ReadOnly = true;
            IOBox.TextAlign = HorizontalAlignment.Right;
            IOBox.Text = "0";
        }

        void SetUIComponentsPositions ()
        {
            IOBox.Location = new Point (5, 5);

            sinus.Location = new Point (IOBox.Left, IOBox.Top + IOBox.Height + 10);
            cosinus.Location = new Point (sinus.Left + sinus.Width, sinus.Top);
            tangens.Location = new Point (cosinus.Left + cosinus.Width, cosinus.Top);
            unitOfAngle.Location = new Point (tangens.Left + tangens.Width + 10 + natualLogarithm.Width + e.Width + 10, tangens.Top);

            sinusHyp.Location = new Point (sinus.Left, sinus.Top + sinus.Height);
            cosinusHyp.Location = new Point (cosinus.Left, cosinus.Top + cosinus.Height);
            pi.Location = new Point (tangens.Left, tangens.Top + tangens.Height);
            shift.Location = new Point (pi.Left + pi.Width + 10 + natualLogarithm.Width + e.Width + 10, pi.Top);

            square.Location = new Point (sinusHyp.Left, sinusHyp.Top + sinusHyp.Height + 10);
            squareRoot.Location = new Point (square.Left + square.Width, square.Top);
            factorial.Location = new Point (squareRoot.Left + squareRoot.Width, squareRoot.Top);
            natualLogarithm.Location = new Point (factorial.Left + factorial.Width + 10, factorial.Top);
            e.Location = new Point (natualLogarithm.Left + natualLogarithm.Width, natualLogarithm.Top);
            outputPrecisionButton.Location = new Point (e.Left + e.Width + 10, e.Top);

            number7.Location = new Point (square.Left, square.Top + square.Height + 20);
            number8.Location = new Point (number7.Left + number8.Width, number7.Top);
            number9.Location = new Point (number8.Left + number9.Width, number7.Top);
            delete.Location = new Point (number9.Left + number9.Width + 10, number9.Top);
            clear.Location = new Point (delete.Left + delete.Width, delete.Top);

            number4.Location = new Point (number7.Left, number7.Top + number7.Height);
            number5.Location = new Point (number4.Left + number4.Width, number4.Top);
            number6.Location = new Point (number5.Left + number5.Width, number5.Top);
            multiplication.Location = new Point (number6.Left + number6.Width + 10, number6.Top);
            division.Location = new Point (multiplication.Left + multiplication.Width, multiplication.Top);

            number1.Location = new Point (number4.Left, number4.Top + number4.Height);
            number2.Location = new Point (number5.Left, number5.Top + number5.Height);
            number3.Location = new Point (number6.Left, number6.Top + number6.Height);
            addition.Location = new Point (number3.Left + number3.Width + 10, number3.Top);
            substraction.Location = new Point (addition.Left + addition.Width, addition.Top);

            number0.Location = new Point (number1.Left, number1.Top + number1.Height);
            comma.Location = new Point (number2.Left, number2.Top + number2.Height);
            memoryButton.Location = new Point (comma.Left + comma.Width, comma.Top);
            memoryAddSubstButton.Location = new Point (memoryButton.Left + memoryButton.Width + 10, memoryButton.Top);
            equals.Location =
                new Point (memoryAddSubstButton.Left + memoryAddSubstButton.Width, memoryAddSubstButton.Top);
        }

        void SetCalculatorLanguageTo (out string systemLanguage)
        {
            systemLanguage =
                System.Globalization.CultureInfo.CurrentCulture.ToString ().Substring (0, 2);
        }

        void AddNumber (int number)
        {
            if (IOIsZero () && number == 0)
                return;
            else
            if (newOperand || IOContainsErrorOrInfinity () || IOIsZero ())
                IOBox.Text = number.ToString ();
            else
                IOBox.Text += number.ToString ();
            newOperand = false;
        }

        void AddComma ()
        {
            if (calculatorLanguage == "de" && !IOBox.Text.Contains (","))
                IOBox.Text += ",";
            else
            if (calculatorLanguage == "en" && !IOBox.Text.Contains ("."))
                IOBox.Text += ".";
        }

        void ResetIOToZero ()
        {
            IOBox.Text = "0";
            newOperand = true;
        }

        void ErrorMessage (string message)
        {
            IOBox.Text = "Error";
            MessageBox.Show ("An error with the code -" + message + "- has occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            operand = 0;
            newOperand = true;
        }

        void ErrorMessage ()
        {
            ErrorMessage ("Error");
        }

        bool IOContainsErrorOrInfinity ()
        {
            if (IOBox.Text == "Error" || IOBox.Text == "∞" || IOBox.Text == "NaN")
                return true;
            else
                return false;
        }

        bool IOIsZero ()
        {
            return IOBox.Text == "0";
        }

        void PerformCurrentOperation ()
        {
            switch (currentOperation)
            {
            case "addition":
                operand = (operand + double.Parse (IOBox.Text));
                break;
            case "substraction":
                operand = (operand - double.Parse (IOBox.Text));
                break;
            case "multiplication":
                operand = (operand * double.Parse (IOBox.Text));
                break;
            case "division":
                operand = (operand / double.Parse (IOBox.Text));
                break;
            case "pow":
                operand = (Math.Pow (operand, double.Parse (IOBox.Text)));
                break;
            case "binominal":
                CalculateBinomialCoefficientOf (operand, double.Parse (IOBox.Text));
                break;
            case "none":
                operand = double.Parse (IOBox.Text);
                return;
            }
            IOBox.Text = operand.ToString (outputPrecision.GetPrecision ());
        }

        void SetNewOperationTo (string newOperation)
        {
            newOperand = true;
            currentOperation = newOperation;
        }

        void ToggleShift ()
        {
            if (!alternativeFunctionsActive)
            {
                SetButtonEventHandlersToShiftCase ();
                SetButtonTextsToShiftCase ();
                alternativeFunctionsActive = true;
                shift.BackColor = Color.Red;
            }
            else
            {
                SetButtonEventHandlersToNonShiftCase ();
                SetButtonTextsToNonShiftCase ();
                alternativeFunctionsActive = false;
                shift.BackColor = SystemColors.Control;
            }
        }

        void SetButtonEventHandlersToShiftCase ()
        {
            sinus.Click -= SinusButtonClick;
            sinus.Click -= ArcSinusButtonClick;
            sinus.Click += ArcSinusButtonClick;
            cosinus.Click -= CosinusButtonClick;
            cosinus.Click -= ArcCosinusButtonClick;
            cosinus.Click += ArcCosinusButtonClick;
            tangens.Click -= TangensButtonClick;
            tangens.Click -= ArcTangensButtonClick;
            tangens.Click += ArcTangensButtonClick;
            memoryButton.Click -= MemoryButtonClick;
            memoryButton.Click -= MemoryClearButtonClick;
            memoryButton.Click += MemoryClearButtonClick;
            memoryAddSubstButton.Click -= MemoryAddButtonClick;
            memoryAddSubstButton.Click -= MemorySubstractButtonClick;
            memoryAddSubstButton.Click += MemorySubstractButtonClick;
            factorial.Click -= FactorialButtonClick;
            factorial.Click -= ReciprocalButtonClick;
            factorial.Click += ReciprocalButtonClick;
            square.Click -= SquareButtonClick;
            square.Click -= ExponentButtonClick;
            square.Click += ExponentButtonClick;
            division.Click -= DivButtonClick;
            division.Click -= BinomialCoefficientButtonClick;
            division.Click += BinomialCoefficientButtonClick;
        }

        void SetButtonEventHandlersToNonShiftCase ()
        {
            sinus.Click -= SinusButtonClick;
            sinus.Click -= ArcSinusButtonClick;
            sinus.Click += SinusButtonClick;
            cosinus.Click -= ArcCosinusButtonClick;
            cosinus.Click -= CosinusButtonClick;
            cosinus.Click += CosinusButtonClick;
            tangens.Click -= ArcTangensButtonClick;
            tangens.Click -= TangensButtonClick;
            tangens.Click += TangensButtonClick;
            memoryButton.Click -= MemoryClearButtonClick;
            memoryButton.Click -= MemoryButtonClick;
            memoryButton.Click += MemoryButtonClick;
            memoryAddSubstButton.Click -= MemorySubstractButtonClick;
            memoryAddSubstButton.Click -= MemoryAddButtonClick;
            memoryAddSubstButton.Click += MemoryAddButtonClick;
            factorial.Click -= ReciprocalButtonClick;
            factorial.Click -= FactorialButtonClick;
            factorial.Click += FactorialButtonClick;
            square.Click -= ExponentButtonClick;
            square.Click -= SquareButtonClick;
            square.Click += SquareButtonClick;
            division.Click -= BinomialCoefficientButtonClick;
            division.Click -= DivButtonClick;
            division.Click += DivButtonClick;
        }

        void SetButtonTextsToShiftCase ()
        {
            sinus.Text = "arcsin";
            cosinus.Text = "arccos";
            tangens.Text = "arctan";
            factorial.Text = "1/x";
            square.Text = "x^n";
            memoryButton.Text = "MC";
            memoryAddSubstButton.Text = "M-";
            division.Text = "nPr";
        }

        void SetButtonTextsToNonShiftCase ()
        {
            sinus.Text = "sin";
            cosinus.Text = "cos";
            tangens.Text = "tan";
            factorial.Text = "x!";
            square.Text = "x²";
            memoryButton.Text = "M";
            memoryAddSubstButton.Text = "M+";
            division.Text = " / ";
        }

        void SetButtonsToInitState ()
        {
            IOBox.Text = "0";
            SetButtonEventHandlersToNonShiftCase ();
            SetButtonTextsToNonShiftCase ();
            alternativeFunctionsActive = false;
            shift.BackColor = SystemColors.Control;
        }

        double CalculateSquareOf (double squareValue)
        {
            return squareValue * squareValue;
        }

        int CalculateFactorialOf (int factorialValue)
        {
            int factorial = 1;
            for (int i = 1; i <= factorialValue; i++)
                factorial *= i;
            return factorial;
        }

        delegate double AngularFunction (double value);

        void CalculateAngularFunction (AngularFunction angularFunction, double boxValue)
        {
            if (unitOfAngle.Text == "Rad")
            {
                operand = (angularFunction (boxValue));
                IOBox.Text = operand.ToString (outputPrecision.GetPrecision ());
            }
            else
            {
                var temp = boxValue;
                temp *= (Math.PI / 180);
                operand = angularFunction (temp);
                IOBox.Text = operand.ToString (outputPrecision.GetPrecision ());
            }
        }

        void CalculateArcAngularFunction (AngularFunction angularFunction, double boxValue)
        {
            if (unitOfAngle.Text == "Rad")
            {
                operand = (angularFunction (boxValue));
                IOBox.Text = operand.ToString (outputPrecision.GetPrecision ());
            }
            else
            {
                operand = angularFunction (boxValue) * 180 / Math.PI;
                IOBox.Text = operand.ToString (outputPrecision.GetPrecision ());
            }
        }

        void CalculateBinomialCoefficientOf (double n, double k)
        {
            double binom = 1;

            if (BinomialCoefficientIsCalculatableOf (n, k))
            {
                for (int i = 1; i <= k; i++)
                    binom = binom * (n - i + 1) / i;
                operand = binom;
            }
            else
                ErrorMessage ();
        }

        bool BinomialCoefficientIsCalculatableOf (double n, double k)
        {
            return (n > k && (n % 1) + (k % 1) < zeroTolerance && n > 0);
        }
    }
}