using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProjectTrojan
{
    partial class calculator
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

        void setWindowSize(int width, int height)
        {
            Size = new Size(width, height);
        }

        void setButtonText(Button button, string text)
        {
            button.Text = (text);
        }

        void setButtonSize(Button button, int width, int height)
        {
            button.Width = width;
            button.Height = height;
        }

        void initializeUIComponents()
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

            setButtonText(number0, "0");
            setButtonText(number1, "1");
            setButtonText(number2, "2");
            setButtonText(number3, "3");
            setButtonText(number4, "4");
            setButtonText(number5, "5");
            setButtonText(number6, "6");
            setButtonText(number7, "7");
            setButtonText(number8, "8");
            setButtonText(number9, "9");
            setButtonText(pi, "Pi");
            setButtonText(e, "e");
            setButtonText(comma, ",");
            setButtonText(clear, "AC");
            setButtonText(addition, "+");
            setButtonText(substraction, "-");
            setButtonText(multiplication, "*");
            setButtonText(division, "/");
            setButtonText(square, "x²");
            setButtonText(sqrt, "√¯x");
            setButtonText(equals, "=");
            setButtonText(del, "Del");
            setButtonText(factorial, "x!");
            setButtonText(ln, "ln x");
            setButtonText(sinus, "sin");
            setButtonText(cosinus, "cos");
            setButtonText(tangens, "tan");
            setButtonText(sinusHyp, "sinH");
            setButtonText(cosinusHyp, "cosH");
            setButtonText(unitOfAngle, "Rad");
            setButtonText(shift, "Shift");
            setButtonText(outputPrecisionButton, "4 Dgts");
            setButtonText(memoryButton, "M");
            setButtonText(memoryAddSubstButton, "M+");

            setButtonSize(number0, 50, 50);
            setButtonSize(number1, 50, 50);
            setButtonSize(number2, 50, 50);
            setButtonSize(number3, 50, 50);
            setButtonSize(number4, 50, 50);
            setButtonSize(number5, 50, 50);
            setButtonSize(number6, 50, 50);
            setButtonSize(number7, 50, 50);
            setButtonSize(number8, 50, 50);
            setButtonSize(number9, 50, 50);
            setButtonSize(pi, 50, 50);
            setButtonSize(e, 50, 50);
            setButtonSize(comma, 50, 50);
            setButtonSize(clear, 50, 50);
            setButtonSize(addition, 50, 50);
            setButtonSize(substraction, 50, 50);
            setButtonSize(multiplication, 50, 50);
            setButtonSize(division, 50, 50);
            setButtonSize(square, 50, 50);
            setButtonSize(number0, 50, 50);
            setButtonSize(sqrt, 50, 50);
            setButtonSize(equals, 50, 50);
            setButtonSize(del, 50, 50);
            setButtonSize(factorial, 50, 50);
            setButtonSize(ln, 50, 50);
            setButtonSize(sinus, 50, 50);
            setButtonSize(cosinus, 50, 50);
            setButtonSize(sinusHyp, 50, 50);
            setButtonSize(cosinusHyp, 50, 50);
            setButtonSize(tangens, 50, 50);
            setButtonSize(unitOfAngle, 50, 50);
            setButtonSize(shift, 50, 50);
            setButtonSize(outputPrecisionButton, 50, 50);
            setButtonSize(memoryButton, 50, 50);
            setButtonSize(memoryAddSubstButton, 50, 50);
        }

        void setUIComponentsPositions()
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

            addButtonControl(number0);
            addButtonControl(number1);
            addButtonControl(number2);
            addButtonControl(number3);
            addButtonControl(number4);
            addButtonControl(number5);
            addButtonControl(number6);
            addButtonControl(number7);
            addButtonControl(number8);
            addButtonControl(number9);
            addButtonControl(pi);
            addButtonControl(e);
            addButtonControl(comma);
            addButtonControl(clear);
            addButtonControl(addition);
            addButtonControl(substraction);
            addButtonControl(multiplication);
            addButtonControl(division);
            addButtonControl(square);
            addButtonControl(sqrt);
            addTextBoxControl(inputOutputBox);
            addButtonControl(equals);
            addButtonControl(del);
            addButtonControl(factorial);
            addButtonControl(ln);
            addButtonControl(shift);
            addButtonControl(outputPrecisionButton);
            addButtonControl(memoryButton);
            addButtonControl(memoryAddSubstButton);
            addButtonControl(sinus);
            addButtonControl(cosinus);
            addButtonControl(tangens);
            addButtonControl(sinusHyp);
            addButtonControl(cosinusHyp);
            addButtonControl(unitOfAngle);

            setButtonBackColor(number0, Color.LightGray);
            setButtonBackColor(number1, Color.LightGray);
            setButtonBackColor(number2, Color.LightGray);
            setButtonBackColor(number3, Color.LightGray);
            setButtonBackColor(number4, Color.LightGray);
            setButtonBackColor(number5, Color.LightGray);
            setButtonBackColor(number6, Color.LightGray);
            setButtonBackColor(number7, Color.LightGray);
            setButtonBackColor(number8, Color.LightGray);
            setButtonBackColor(number9, Color.LightGray);
            setButtonBackColor(pi, Color.Gray);
            setButtonBackColor(e, Color.Gray);
            setButtonBackColor(clear, Color.Red);
            setButtonBackColor(addition, Color.Orange);
            setButtonBackColor(substraction, Color.Orange);
            setButtonBackColor(multiplication, Color.Orange);
            setButtonBackColor(division, Color.Orange);
            setButtonBackColor(square, Color.Gray);
            setButtonBackColor(sqrt, Color.Gray);
            setButtonBackColor(equals, Color.Orange);
            setButtonBackColor(del, Color.Red);
            setButtonBackColor(factorial, Color.Gray);
            setButtonBackColor(ln, Color.Gray);
            setButtonBackColor(memoryButton, Color.Gray);
            setButtonBackColor(memoryAddSubstButton, Color.Gray);
            setButtonBackColor(sinus, Color.Gray);
            setButtonBackColor(cosinus, Color.Gray);
            setButtonBackColor(tangens, Color.Gray);
            setButtonBackColor(sinusHyp, Color.Gray);
            setButtonBackColor(cosinusHyp, Color.Gray);
            setButtonBackColor(unitOfAngle, Color.Gray);

            setIOBoxForeColor(inputOutputBox, Color.WhiteSmoke);
            setIOBoxBackColor(inputOutputBox, Color.Black);
        }

        void setIOBoxProperties(int width, Font font, bool ReadOnly, HorizontalAlignment alignment)
        {
            inputOutputBox.Width = width;
            inputOutputBox.Font = font;
            inputOutputBox.ReadOnly = ReadOnly;
            inputOutputBox.TextAlign = HorizontalAlignment.Right;
        }

        void setIOBoxText(TextBox IOBox, string text)
        {
            IOBox.Text = text;
        }

        void addButtonClickEvent(Button button, EventHandler clickFunction)
        {
            button.Click += clickFunction;
        }

        void removeButtonClickEvent(Button button, EventHandler clickFunction)
        {
            button.Click -= clickFunction;
        }

        void addButtonControl(Button button)
        {
            Controls.Add(button);
        }

        void addTextBoxControl(TextBox box)
        {
            Controls.Add(box);
        }

        void setButtonBackColor(Button button, Color backColor)
        {
            button.BackColor = backColor;
        }

        void setButtonForeColor(Button button, Color foreColor)
        {
            button.ForeColor = foreColor;
        }

        void setIOBoxBackColor(TextBox box, Color backColor)
        {
            box.BackColor = backColor;
        }

        void setIOBoxForeColor(TextBox box, Color foreColor)
        {
            box.ForeColor = foreColor;
        }

        void createButtonsEventHandlers()
        {
            addButtonClickEvent(number0, number0ButtonClick);
            addButtonClickEvent(number1, number1ButtonClick);
            addButtonClickEvent(number2, number2ButtonClick);
            addButtonClickEvent(number3, number3ButtonClick);
            addButtonClickEvent(number4, number4ButtonClick);
            addButtonClickEvent(number5, number5ButtonClick);
            addButtonClickEvent(number6, number6ButtonClick);
            addButtonClickEvent(number7, number7ButtonClick);
            addButtonClickEvent(number8, number8ButtonClick);
            addButtonClickEvent(number9, number9ButtonClick);
            addButtonClickEvent(pi, piButtonClick);
            addButtonClickEvent(e, eButtonClick);
            addButtonClickEvent(comma, commaButtonClick);
            addButtonClickEvent(clear, clearButtonClick);
            addButtonClickEvent(addition, addButtonClick);
            addButtonClickEvent(substraction, substButtonClick);
            addButtonClickEvent(multiplication, multButtonClick);
            addButtonClickEvent(division, divButtonClick);
            addButtonClickEvent(square, squareButtonClick);
            addButtonClickEvent(sqrt, sqrtButtonClick);
            addButtonClickEvent(equals, equalsButtonClick);
            addButtonClickEvent(del, delButtonClick);
            addButtonClickEvent(factorial, factorialButtonClick);
            addButtonClickEvent(ln, lnButtonClick);
            addButtonClickEvent(sinus, sinusButtonClick);
            addButtonClickEvent(sinusHyp, sinusHypButtonClick);
            addButtonClickEvent(cosinus, cosinusButtonClick);
            addButtonClickEvent(cosinusHyp, cosinusHypButtonClick);
            addButtonClickEvent(tangens, tangensButtonClick);
            addButtonClickEvent(unitOfAngle, unitOfAngleButtonClick);
            addButtonClickEvent(shift, shiftButtonClick);
            addButtonClickEvent(outputPrecisionButton, outputPrecisionButtonClick);
            addButtonClickEvent(memoryAddSubstButton, memoryPButtonClick);
            addButtonClickEvent(memoryButton, memoryButtonClick);
        }

        void setWindowProperties(int width, int height, string title, FormBorderStyle formBorderStyle, bool ActivateMinBox, bool ActivateMaxBox)
        {
            setWindowSize(width, height);
            Text = title;
            FormBorderStyle = formBorderStyle;
            MinimizeBox = ActivateMinBox; 
            MaximizeBox = ActivateMaxBox;
        }

        private void performCurrentOperation()
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

        private void updateOperation(string newOperation)
        {
            newOperand = true;
            currentOperation = newOperation;
            inputLength = 0;
        }

        private bool inputContainsErrorOrInfinity()
        {
            if (inputOutputBox.Text == "Error" || inputOutputBox.Text == "∞" || inputOutputBox.Text == "NaN")
                return true;
            else
                return false;
        }

        private void setNewPrecision(string newPrecision)
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

        private void setOrAddNumber(int number)
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

        private void setCurrentLanguage()
        {
            systemLanguage =
                System.Globalization.CultureInfo.CurrentCulture.ToString().Substring(0, 2);
        }

        private void errorMessage()
        {
            inputOutputBox.Text = "Error";
            operand1 = 0;
            inputLength = 0;
        }

        void toggleShift()
        {
            if (!alternativeFunctionsActive)
            {
                removeButtonClickEvent(sinus, sinusButtonClick);
                addButtonClickEvent(sinus, arcSinusButtonClick);
                removeButtonClickEvent(cosinus, cosinusButtonClick);
                addButtonClickEvent(cosinus, arcCosinusbuttonClick);
                removeButtonClickEvent(tangens, tangensButtonClick);
                addButtonClickEvent(tangens, arcTangensButtonClick);
                removeButtonClickEvent(memoryButton, memoryButtonClick);
                addButtonClickEvent(memoryButton, memoryClearButtonClick);
                removeButtonClickEvent(memoryAddSubstButton, memoryPButtonClick);
                addButtonClickEvent(memoryAddSubstButton, memoryMButtonClick);
                removeButtonClickEvent(factorial, factorialButtonClick);
                addButtonClickEvent(factorial, reciprocalButtonClick);
                removeButtonClickEvent(square, squareButtonClick);
                addButtonClickEvent(square, exponentButtonClick);

                setButtonText(sinus, "arcsin");
                setButtonText(cosinus, "arccos");
                setButtonText(tangens, "arctan");
                setButtonText(factorial, "1/x");
                setButtonText(square, "x^n");
                setButtonText(memoryButton, "MC");
                setButtonText(memoryAddSubstButton, "M-");

                alternativeFunctionsActive = true;

                shift.BackColor = Color.Red;
            }

            else
            {
                addButtonClickEvent(sinus, sinusButtonClick);
                removeButtonClickEvent(sinus, arcSinusButtonClick);
                addButtonClickEvent(cosinus, cosinusButtonClick);
                removeButtonClickEvent(cosinus, arcCosinusbuttonClick);
                addButtonClickEvent(tangens, tangensButtonClick);
                removeButtonClickEvent(tangens, arcTangensButtonClick);
                addButtonClickEvent(memoryButton, memoryButtonClick);
                removeButtonClickEvent(memoryButton, memoryClearButtonClick);
                addButtonClickEvent(memoryAddSubstButton, memoryPButtonClick);
                removeButtonClickEvent(memoryAddSubstButton, memoryMButtonClick);
                addButtonClickEvent(factorial, factorialButtonClick);
                removeButtonClickEvent(factorial, reciprocalButtonClick);
                addButtonClickEvent(square, squareButtonClick);
                removeButtonClickEvent(square, exponentButtonClick);

                setButtonText(sinus, "sin");
                setButtonText(cosinus, "cos");
                setButtonText(tangens, "tan");
                setButtonText(factorial, "x!");
                setButtonText(square, "x²");
                setButtonText(memoryButton, "M");
                setButtonText(memoryAddSubstButton, "M+");

                alternativeFunctionsActive = false;

                shift.BackColor = SystemColors.Control;
            }

        }
    }

}
