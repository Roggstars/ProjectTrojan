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
        Button pi;
        Button e;
        Button comma;
        Button clear;
        Button addition;
        Button substraction;
        Button multiplication;
        Button division;
        Button square;
        Button sqrt;
        Button equals;
        Button del;
        Button factorial;
        Button ln;
        Button sinus;
        Button cosinus;
        Button tangens;
        Button sinusHyp;
        Button cosinusHyp;
        Button unitOfAngle;
        Button shift;
        Button outputPrecisionButton;
        Button memoryButton;
        Button memoryAddSubstButton;

        void SetWindowSize(int width, int height)
        {
            Size = new Size(width, height);
        }

        void SetButtonText(Button button, string text)
        {
            button.Text = (text);
        }

        void SetButtonSize(Button button, int width, int height)
        {
            button.Width = width;
            button.Height = height;
        }

        void InitializeUIComponents()
        {
            number0 = new Button();
            number1 = new Button();
            number2 = new Button();
            number3 = new Button();
            number4 = new Button();
            number5 = new Button();
            number6 = new Button();
            number7 = new Button();
            number8 = new Button();
            number9 = new Button();
            pi = new Button();
            e = new Button();
            comma = new Button();
            clear = new Button();
            addition = new Button();
            substraction = new Button();
            multiplication = new Button();
            division = new Button();
            square = new Button();
            sqrt = new Button();
            equals = new Button();
            del = new Button();
            factorial = new Button();
            ln = new Button();
            sinus = new Button();
            cosinus = new Button();
            tangens = new Button();
            sinusHyp = new Button();
            cosinusHyp = new Button();
            unitOfAngle = new Button();
            shift = new Button();
            outputPrecisionButton = new Button();
            memoryButton = new Button();
            memoryAddSubstButton = new Button();

            inputOutputBox = new TextBox();

            SetButtonText(number0, "0");
            SetButtonText(number1, "1");
            SetButtonText(number2, "2");
            SetButtonText(number3, "3");
            SetButtonText(number4, "4");
            SetButtonText(number5, "5");
            SetButtonText(number6, "6");
            SetButtonText(number7, "7");
            SetButtonText(number8, "8");
            SetButtonText(number9, "9");
            SetButtonText(pi, "Pi");
            SetButtonText(e, "e");
            SetButtonText(comma, ",");
            SetButtonText(clear, "AC");
            SetButtonText(addition, "+");
            SetButtonText(substraction, "-");
            SetButtonText(multiplication, "*");
            SetButtonText(division, "/");
            SetButtonText(square, "x²");
            SetButtonText(sqrt, "√¯x");
            SetButtonText(equals, "=");
            SetButtonText(del, "Del");
            SetButtonText(factorial, "x!");
            SetButtonText(ln, "ln x");
            SetButtonText(sinus, "sin");
            SetButtonText(cosinus, "cos");
            SetButtonText(tangens, "tan");
            SetButtonText(sinusHyp, "sinH");
            SetButtonText(cosinusHyp, "cosH");
            SetButtonText(unitOfAngle, "Rad");
            SetButtonText(shift, "Shift");
            SetButtonText(outputPrecisionButton, "4 Dgts");
            SetButtonText(memoryButton, "M");
            SetButtonText(memoryAddSubstButton, "M+");

            SetButtonSize(number0, 50, 50);
            SetButtonSize(number1, 50, 50);
            SetButtonSize(number2, 50, 50);
            SetButtonSize(number3, 50, 50);
            SetButtonSize(number4, 50, 50);
            SetButtonSize(number5, 50, 50);
            SetButtonSize(number6, 50, 50);
            SetButtonSize(number7, 50, 50);
            SetButtonSize(number8, 50, 50);
            SetButtonSize(number9, 50, 50);
            SetButtonSize(pi, 50, 50);
            SetButtonSize(e, 50, 50);
            SetButtonSize(comma, 50, 50);
            SetButtonSize(clear, 50, 50);
            SetButtonSize(addition, 50, 50);
            SetButtonSize(substraction, 50, 50);
            SetButtonSize(multiplication, 50, 50);
            SetButtonSize(division, 50, 50);
            SetButtonSize(square, 50, 50);
            SetButtonSize(number0, 50, 50);
            SetButtonSize(sqrt, 50, 50);
            SetButtonSize(equals, 50, 50);
            SetButtonSize(del, 50, 50);
            SetButtonSize(factorial, 50, 50);
            SetButtonSize(ln, 50, 50);
            SetButtonSize(sinus, 50, 50);
            SetButtonSize(cosinus, 50, 50);
            SetButtonSize(sinusHyp, 50, 50);
            SetButtonSize(cosinusHyp, 50, 50);
            SetButtonSize(tangens, 50, 50);
            SetButtonSize(unitOfAngle, 50, 50);
            SetButtonSize(shift, 50, 50);
            SetButtonSize(outputPrecisionButton, 50, 50);
            SetButtonSize(memoryButton, 50, 50);
            SetButtonSize(memoryAddSubstButton, 50, 50);

            AddButtonControl(number0);
            AddButtonControl(number1);
            AddButtonControl(number2);
            AddButtonControl(number3);
            AddButtonControl(number4);
            AddButtonControl(number5);
            AddButtonControl(number6);
            AddButtonControl(number7);
            AddButtonControl(number8);
            AddButtonControl(number9);
            AddButtonControl(pi);
            AddButtonControl(e);
            AddButtonControl(comma);
            AddButtonControl(clear);
            AddButtonControl(addition);
            AddButtonControl(substraction);
            AddButtonControl(multiplication);
            AddButtonControl(division);
            AddButtonControl(square);
            AddButtonControl(sqrt);
            AddTextBoxControl(inputOutputBox);
            AddButtonControl(equals);
            AddButtonControl(del);
            AddButtonControl(factorial);
            AddButtonControl(ln);
            AddButtonControl(shift);
            AddButtonControl(outputPrecisionButton);
            AddButtonControl(memoryButton);
            AddButtonControl(memoryAddSubstButton);
            AddButtonControl(sinus);
            AddButtonControl(cosinus);
            AddButtonControl(tangens);
            AddButtonControl(sinusHyp);
            AddButtonControl(cosinusHyp);
            AddButtonControl(unitOfAngle);

            SetButtonBackColor(number0, Color.LightGray);
            SetButtonBackColor(number1, Color.LightGray);
            SetButtonBackColor(number2, Color.LightGray);
            SetButtonBackColor(number3, Color.LightGray);
            SetButtonBackColor(number4, Color.LightGray);
            SetButtonBackColor(number5, Color.LightGray);
            SetButtonBackColor(number6, Color.LightGray);
            SetButtonBackColor(number7, Color.LightGray);
            SetButtonBackColor(number8, Color.LightGray);
            SetButtonBackColor(number9, Color.LightGray);
            SetButtonBackColor(pi, Color.Gray);
            SetButtonBackColor(e, Color.Gray);
            SetButtonBackColor(clear, Color.Red);
            SetButtonBackColor(addition, Color.Orange);
            SetButtonBackColor(substraction, Color.Orange);
            SetButtonBackColor(multiplication, Color.Orange);
            SetButtonBackColor(division, Color.Orange);
            SetButtonBackColor(square, Color.Gray);
            SetButtonBackColor(sqrt, Color.Gray);
            SetButtonBackColor(equals, Color.Orange);
            SetButtonBackColor(del, Color.Red);
            SetButtonBackColor(factorial, Color.Gray);
            SetButtonBackColor(ln, Color.Gray);
            SetButtonBackColor(memoryButton, Color.Gray);
            SetButtonBackColor(memoryAddSubstButton, Color.Gray);
            SetButtonBackColor(sinus, Color.Gray);
            SetButtonBackColor(cosinus, Color.Gray);
            SetButtonBackColor(tangens, Color.Gray);
            SetButtonBackColor(sinusHyp, Color.Gray);
            SetButtonBackColor(cosinusHyp, Color.Gray);
            SetButtonBackColor(unitOfAngle, Color.Gray);

            SetIOBoxForeColor(inputOutputBox, Color.WhiteSmoke);
            SetIOBoxBackColor(inputOutputBox, Color.Black);
        }

        void SetUIComponentsPositions()
        {
            inputOutputBox.Location = new Point(5, 5);

            sinus.Location = new Point(inputOutputBox.Left, inputOutputBox.Top + inputOutputBox.Height + 10);
            cosinus.Location = new Point(sinus.Left + sinus.Width, sinus.Top);
            tangens.Location = new Point(cosinus.Left + cosinus.Width, cosinus.Top);
            unitOfAngle.Location = new Point(tangens.Left + tangens.Width + 10 + ln.Width + e.Width + 10, tangens.Top);

            sinusHyp.Location = new Point(sinus.Left, sinus.Top + sinus.Height);
            cosinusHyp.Location = new Point(cosinus.Left, cosinus.Top + cosinus.Height);
            pi.Location = new Point(tangens.Left, tangens.Top + tangens.Height);
            shift.Location = new Point(pi.Left + pi.Width + 10 + ln.Width + e.Width + 10, pi.Top);

            square.Location = new Point(sinusHyp.Left, sinusHyp.Top + sinusHyp.Height + 10);
            sqrt.Location = new Point(square.Left + square.Width, square.Top);
            factorial.Location = new Point(sqrt.Left + sqrt.Width, sqrt.Top);
            ln.Location = new Point(factorial.Left + factorial.Width + 10, factorial.Top);
            e.Location = new Point(ln.Left + ln.Width, ln.Top);
            outputPrecisionButton.Location = new Point(e.Left + e.Width + 10, e.Top);

            number7.Location = new Point(square.Left, square.Top + square.Height + 20);
            number8.Location = new Point(number7.Left + number8.Width, number7.Top);
            number9.Location = new Point(number8.Left + number9.Width, number7.Top);
            del.Location = new Point(number9.Left + number9.Width + 10, number9.Top);
            clear.Location = new Point(del.Left + del.Width, del.Top);

            number4.Location = new Point(number7.Left, number7.Top + number7.Height);
            number5.Location = new Point(number4.Left + number4.Width, number4.Top);
            number6.Location = new Point(number5.Left + number5.Width, number5.Top);
            multiplication.Location = new Point(number6.Left + number6.Width + 10, number6.Top);
            division.Location = new Point(multiplication.Left + multiplication.Width, multiplication.Top);

            number1.Location = new Point(number4.Left, number4.Top + number4.Height);
            number2.Location = new Point(number5.Left, number5.Top + number5.Height);
            number3.Location = new Point(number6.Left, number6.Top + number6.Height);
            addition.Location = new Point(number3.Left + number3.Width + 10, number3.Top);
            substraction.Location = new Point(addition.Left + addition.Width, addition.Top);

            number0.Location = new Point(number1.Left, number1.Top + number1.Height);
            comma.Location = new Point(number2.Left, number2.Top + number2.Height);
            memoryButton.Location = new Point(comma.Left + comma.Width, comma.Top);
            memoryAddSubstButton.Location = new Point(memoryButton.Left + memoryButton.Width + 10, memoryButton.Top);
            equals.Location = new Point(memoryAddSubstButton.Left + memoryAddSubstButton.Width, memoryAddSubstButton.Top);
        }

        void SetIOBoxProperties(int width, Font font, bool ReadOnly, HorizontalAlignment alignment)
        {
            inputOutputBox.Width = width;
            inputOutputBox.Font = font;
            inputOutputBox.ReadOnly = ReadOnly;
            inputOutputBox.TextAlign = HorizontalAlignment.Right;
        }

        void SetIOBoxText(TextBox IOBox, string text)
        {
            IOBox.Text = text;
        }

        void AddButtonClickEvent(Button button, EventHandler clickFunction)
        {
            button.Click += clickFunction;
        }

        void RemoveButtonClickEvent(Button button, EventHandler clickFunction)
        {
            button.Click -= clickFunction;
        }

        void AddButtonControl(Button button)
        {
            Controls.Add(button);
        }

        void AddTextBoxControl(TextBox box)
        {
            Controls.Add(box);
        }

        void SetButtonBackColor(Button button, Color backColor)
        {
            button.BackColor = backColor;
        }

        void SetButtonForeColor(Button button, Color foreColor)
        {
            button.ForeColor = foreColor;
        }

        void SetIOBoxBackColor(TextBox box, Color backColor)
        {
            box.BackColor = backColor;
        }

        void SetIOBoxForeColor(TextBox box, Color foreColor)
        {
            box.ForeColor = foreColor;
        }

        void CreateButtonsEventHandlers()
        {
            AddButtonClickEvent(number0, number0ButtonClick);
            AddButtonClickEvent(number1, number1ButtonClick);
            AddButtonClickEvent(number2, number2ButtonClick);
            AddButtonClickEvent(number3, number3ButtonClick);
            AddButtonClickEvent(number4, number4ButtonClick);
            AddButtonClickEvent(number5, number5ButtonClick);
            AddButtonClickEvent(number6, number6ButtonClick);
            AddButtonClickEvent(number7, number7ButtonClick);
            AddButtonClickEvent(number8, number8ButtonClick);
            AddButtonClickEvent(number9, number9ButtonClick);
            AddButtonClickEvent(pi, piButtonClick);
            AddButtonClickEvent(e, eButtonClick);
            AddButtonClickEvent(comma, commaButtonClick);
            AddButtonClickEvent(clear, clearButtonClick);
            AddButtonClickEvent(addition, addButtonClick);
            AddButtonClickEvent(substraction, substButtonClick);
            AddButtonClickEvent(multiplication, multButtonClick);
            AddButtonClickEvent(division, divButtonClick);
            AddButtonClickEvent(square, squareButtonClick);
            AddButtonClickEvent(sqrt, sqrtButtonClick);
            AddButtonClickEvent(equals, equalsButtonClick);
            AddButtonClickEvent(del, delButtonClick);
            AddButtonClickEvent(factorial, factorialButtonClick);
            AddButtonClickEvent(ln, lnButtonClick);
            AddButtonClickEvent(sinus, sinusButtonClick);
            AddButtonClickEvent(sinusHyp, sinusHypButtonClick);
            AddButtonClickEvent(cosinus, cosinusButtonClick);
            AddButtonClickEvent(cosinusHyp, cosinusHypButtonClick);
            AddButtonClickEvent(tangens, tangensButtonClick);
            AddButtonClickEvent(unitOfAngle, unitOfAngleButtonClick);
            AddButtonClickEvent(shift, shiftButtonClick);
            AddButtonClickEvent(outputPrecisionButton, outputPrecisionButtonClick);
            AddButtonClickEvent(memoryAddSubstButton, memoryPButtonClick);
            AddButtonClickEvent(memoryButton, memoryButtonClick);
        }

        void SetWindowProperties(int width, int height, string title, FormBorderStyle formBorderStyle, bool ActivateMinBox, bool ActivateMaxBox)
        {
            SetWindowSize(width, height);
            Text = title;
            FormBorderStyle = formBorderStyle;
            MinimizeBox = ActivateMinBox; 
            MaximizeBox = ActivateMaxBox;
        }

        void PerformCurrentOperation()
        {
            switch (currentOperation)
            {
                case "addition":
                    operand1 = (operand1 + double.Parse(inputOutputBox.Text));
                    inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
                    break;
                case "substraction":
                    operand1 = (operand1 - double.Parse(inputOutputBox.Text));
                    inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
                    break;
                case "multiplication":
                    operand1 = (operand1 * double.Parse(inputOutputBox.Text));
                    inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
                    break;
                case "division":
                    operand1 = (operand1 / double.Parse(inputOutputBox.Text));
                    inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
                    break;
                case "pow":
                    operand1 = (Math.Pow(operand1, double.Parse(inputOutputBox.Text)));
                    inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
                    break;
                case "none":
                    operand1 = double.Parse(inputOutputBox.Text);
                    break;
            }
        }

        void UpdateOperation(string newOperation)
        {
            newOperand = true;
            currentOperation = newOperation;
        }

        bool InputContainsErrorOrInfinity()
        {
            if (inputOutputBox.Text == "Error" || inputOutputBox.Text == "∞" || inputOutputBox.Text == "NaN")
                return true;
            else
                return false;
        }

        void SetNewIOPrecision(string newPrecision)
        {
            if (newPrecision != "g8")
            {
                int newPrecisionInt = int.Parse(newPrecision.Substring(1, 1));
                newPrecisionInt += 1;
                outputCommaPrecision = "g" + newPrecisionInt.ToString();
            }
            else
                outputCommaPrecision = "g0";

            if (outputCommaPrecision == "g1")
                outputPrecisionButton.Text = outputCommaPrecision.Substring(1, 1) + " Dgt";
            else
                outputPrecisionButton.Text = outputCommaPrecision.Substring(1, 1) + " Dgts";
        }

        void AddNumber(int number)
        {
            if (inputLength == 0 && inputOutputBox.Text == "0" && number == 0)
            { }
            else if (inputLength == 0 || newOperand || inputOutputBox.Text == "∞" || inputOutputBox.Text == "Error")
            {
                inputOutputBox.Text = number.ToString();
                inputLength = 1;
            }
            else
            {
                inputOutputBox.Text += number.ToString();
                inputLength += 1;
            }
            newOperand = false;
        }

        void SetCurrentLanguage()
        {
            systemLanguage =
                System.Globalization.CultureInfo.CurrentCulture.ToString().Substring(0, 2);
        }

        void ErrorMessage()
        {
            inputOutputBox.Text = "Error";
            operand1 = 0;
            newOperand = true;
        }

        void AddComma()
        {
            if (systemLanguage == "de")
            {
                if (!inputOutputBox.Text.Contains(","))
                {
                    inputOutputBox.Text += ",";
                    inputLength += 1;
                }
            }
            else
            {
                if (!inputOutputBox.Text.Contains("."))
                {
                    inputOutputBox.Text += ".";
                    inputLength += 1;
                }
            }

        }

        void SetOperand1(double newValue)
        {
            operand1 = newValue;
        }

        void ToggleShift()
        {
            if (!alternativeFunctionsActive)
            {
                RemoveButtonClickEvent(sinus, sinusButtonClick);
                AddButtonClickEvent(sinus, arcSinusButtonClick);
                RemoveButtonClickEvent(cosinus, cosinusButtonClick);
                AddButtonClickEvent(cosinus, arcCosinusbuttonClick);
                RemoveButtonClickEvent(tangens, tangensButtonClick);
                AddButtonClickEvent(tangens, arcTangensButtonClick);
                RemoveButtonClickEvent(memoryButton, memoryButtonClick);
                AddButtonClickEvent(memoryButton, memoryClearButtonClick);
                RemoveButtonClickEvent(memoryAddSubstButton, memoryPButtonClick);
                AddButtonClickEvent(memoryAddSubstButton, memoryMButtonClick);
                RemoveButtonClickEvent(factorial, factorialButtonClick);
                AddButtonClickEvent(factorial, reciprocalButtonClick);
                RemoveButtonClickEvent(square, squareButtonClick);
                AddButtonClickEvent(square, exponentButtonClick);

                SetButtonText(sinus, "arcsin");
                SetButtonText(cosinus, "arccos");
                SetButtonText(tangens, "arctan");
                SetButtonText(factorial, "1/x");
                SetButtonText(square, "x^n");
                SetButtonText(memoryButton, "MC");
                SetButtonText(memoryAddSubstButton, "M-");

                alternativeFunctionsActive = true;

                shift.BackColor = Color.Red;
            }

            else
            {
                AddButtonClickEvent(sinus, sinusButtonClick);
                RemoveButtonClickEvent(sinus, arcSinusButtonClick);
                AddButtonClickEvent(cosinus, cosinusButtonClick);
                RemoveButtonClickEvent(cosinus, arcCosinusbuttonClick);
                AddButtonClickEvent(tangens, tangensButtonClick);
                RemoveButtonClickEvent(tangens, arcTangensButtonClick);
                AddButtonClickEvent(memoryButton, memoryButtonClick);
                RemoveButtonClickEvent(memoryButton, memoryClearButtonClick);
                AddButtonClickEvent(memoryAddSubstButton, memoryPButtonClick);
                RemoveButtonClickEvent(memoryAddSubstButton, memoryMButtonClick);
                AddButtonClickEvent(factorial, factorialButtonClick);
                RemoveButtonClickEvent(factorial, reciprocalButtonClick);
                AddButtonClickEvent(square, squareButtonClick);
                RemoveButtonClickEvent(square, exponentButtonClick);

                SetButtonText(sinus, "sin");
                SetButtonText(cosinus, "cos");
                SetButtonText(tangens, "tan");
                SetButtonText(factorial, "x!");
                SetButtonText(square, "x²");
                SetButtonText(memoryButton, "M");
                SetButtonText(memoryAddSubstButton, "M+");

                alternativeFunctionsActive = false;

                shift.BackColor = SystemColors.Control;
            }
        }
    }
}
