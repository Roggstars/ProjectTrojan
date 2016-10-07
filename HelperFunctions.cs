using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTrojan
{
    partial class calculator
    {
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
    }

}
