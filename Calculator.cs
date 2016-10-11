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
        string outputCommaPrecision = "g4";
        bool alternativeFunctionsActive;
        double memoryValue = 0;


        //Erstellt TextBox
        TextBox inputOutputBox;

        public Calculator()
        {
            SetCurrentLanguage();
            SetWindowProperties(390, 500, "Project Trojan", FormBorderStyle.FixedDialog, false, false);
            InitializeUIComponents();
            SetIOBoxProperties(320, new Font("ArialBlack", 30, FontStyle.Bold), true, HorizontalAlignment.Right);
            SetUIComponentsPositions();
            CreateButtonsEventHandlers();
            SetIOBoxText(inputOutputBox, "0");
        }

        //Diese Methode reagiert auf den Klick auf den Funktions/Shift Button, welcher benoetigt wird,
        //um ein uebersichtlicheres UI zu gewaehrleisten. Dazu werden einem Button mehrere Funktionen
        //zugewiesen anstatt viele neue (Platz einnehmende) Buttons zu erzeugen. Der Button schaltet
        //zwischen Winkelfunktionen und ihren Umkehrfunktionen um.
        void shiftButtonClick(object sender, EventArgs e)
        {
            ToggleShift();
        }
        //memory Funktionen

        // Abspeichern des Inhaltes der inputOutputBox 
        void memoryButtonClick(object sender, EventArgs e)
        {
            if (memoryValue != 0)
            {
                SetIOBoxText(inputOutputBox, memoryValue.ToString(outputCommaPrecision));
                newOperand = false;
            }
        }

        //Löschen des Speichers
        void memoryClearButtonClick(object sender, EventArgs e)
        {
            memoryValue = 0;
            SetButtonBackColor(memoryButton, Color.Gray);
        }

        void memoryPButtonClick(object sender, EventArgs e)
        {
            memoryValue += double.Parse(inputOutputBox.Text);

            if (memoryValue != 0)
                SetButtonBackColor(memoryButton, Color.PaleVioletRed);
            else
                SetButtonBackColor(memoryButton, Color.Gray);
            
            newOperand = true;
        }

        void memoryMButtonClick(object sender, EventArgs e)
        {
            memoryValue -= double.Parse(inputOutputBox.Text);

            if (memoryValue != 0)
                SetButtonBackColor(memoryButton, Color.PaleVioletRed);
            else
                SetButtonBackColor(memoryButton, Color.Gray);
            
            newOperand = true;
        }


        //Zahlen

        //Diese Methode reagiert auf den Klick auf den Ziffer 0 Button. Dieser erstellt, je nach
        //bisheriger Eingabe entweder eine 0 in der TextBox oder haengt eine '0' an den aktuellen
        //TextBox String an, erweitert somit die Eingabe um eine Zehnerpotenz.
        void number0ButtonClick(object sender, EventArgs e)
        {
            AddNumber(0);
        }

        //Diese Methode reagiert auf den Klick auf den Ziffer 1 Button. Dieser erstellt, je nach
        //bisheriger Eingabe entweder eine '1' in der TextBox oder haengt eine '1' an den aktuellen
        //TextBox String an.
        void number1ButtonClick(object sender, EventArgs e)
        {
            AddNumber(1);
        }

        //Diese Methode reagiert auf den Klick auf den Ziffer 2 Button. Dieser erstellt, je nach
        //bisheriger Eingabe entweder eine '2' in der TextBox oder haengt eine '2' an den aktuellen
        //TextBox String an.
        void number2ButtonClick(object sender, EventArgs e)
        {
            AddNumber(2);
        }

        //Diese Methode reagiert auf den Klick auf den Ziffer 3 Button. Dieser erstellt, je nach
        //bisheriger Eingabe entweder eine '3' in der TextBox oder haengt eine '3' an den aktuellen
        //TextBox String an.
        void number3ButtonClick(object sender, EventArgs e)
        {
            AddNumber(3);
        }

        //Diese Methode reagiert auf den Klick auf den Ziffer 4 Button. Dieser erstellt, je nach
        //bisheriger Eingabe entweder eine '4' in der TeIOBoxngt eine '4' an den aktuellen
        //TextBox String an.
        void number4ButtonClick(object sender, EventArgs e)
        {
            AddNumber(4);
        }

        //Diese Methode reagiert auf den Klick auf den Ziffer 5 Button. Dieser erstellt, je nach
        //bisheriger Eingabe entweder eine '5' in der TextBox oder haengt eine '5' an den aktuellen
        //TextBox String an.
        void number5ButtonClick(object sender, EventArgs e)
        {
            AddNumber(5);
        }

        //Diese Methode reagiert auf den Klick auf den Ziffer 6 Button. Dieser erstellt, je nach
        //bisheriger Eingabe entweder eine '6' in der TextBox oder haengt eine '6' an den aktuellen
        //TextBox String an.
        void number6ButtonClick(object sender, EventArgs e)
        {
            AddNumber(6);
        }

        //Diese Methode reagiert auf den Klick auf den Ziffer 7 Button. Dieser erstellt, je nach
        //bisheriger Eingabe entweder eine '7' in der TextBox oder haengt eine '7' an den aktuellen
        //TextBox String an.
        void number7ButtonClick(object sender, EventArgs e)
        {
            AddNumber(7);
        }

        //Diese Methode reagiert auf den Klick auf den Ziffer 8 Button. Dieser erstellt, je nach
        //bisheriger Eingabe entweder eine '8' in der TextBox oder haengt eine '8' an den aktuellen
        //TextBox String an.
        void number8ButtonClick(object sender, EventArgs e)
        {
            AddNumber(8);
        }

        //Diese Methode reagiert auf den Klick auf den Ziffer 9 Button. Dieser erstellt, je nach
        //bisheriger Eingabe entweder eine '9' in der TextBox oder haengt eine '9' an den aktuellen
        //TextBox String an.
        void number9ButtonClick(object sender, EventArgs e)
        {
            AddNumber(9);
        }

        //Diese Methode reagiert auf den Klick auf den Button der Konstante Pi. Sie setzt den String der
        //TextBox auf die Konstante Pi.
        void piButtonClick(object sender, EventArgs e)
        {
            SetIOBoxText(inputOutputBox, (Math.PI).ToString(outputCommaPrecision));
            newOperand = false;
        }

        void eButtonClick(object sender, EventArgs e)
        {
            SetIOBoxText(inputOutputBox, (Math.E).ToString(outputCommaPrecision));
            newOperand = false;
        }

        //Vereinfacht und erweitern die Bedienung des Rechners

        //Diese Methode reagiert auf den Klick auf den Komma Button. Es muss von System zu System,
        //abhaengig von der Sprache, unterschieden werden, ob ein '.' oder ein ',' eingesetzt wird,
        //da Systeme verschieden auf die beiden Zeichen reagieren.
        void commaButtonClick(object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity())
                return;
            
            AddComma();
        }

        //Diese Methode reagiert auf den Klick auf den Clear Button, welcher saemtliche gespeicherten
        //Ergebnisse sowie die aktuelle Eingabe leert.
        void clearButtonClick(object sender, EventArgs e)
        {
            SetIOBoxText(inputOutputBox, "0");
            SetButtonText(sinus, "sin");
            SetButtonText(cosinus, "cos");
            SetButtonText(tangens, "tan");
            SetButtonText(memoryButton, "M");
            SetButtonText(memoryAddSubstButton, "M+");
            SetButtonBackColor(shift, SystemColors.Control);
            alternativeFunctionsActive = false;
            SetOperand1(0);
            UpdateOperation("none");
        }

        //Grundrechenarten

        //Diese Methode reagiert auf den Klick auf den Delete Button, welcher den zuletzt eingegebenen
        //Teil der TextBox entfernt (bspw. im Falle eines Vertippens).
        void delButtonClick(object sender, EventArgs e)
        {
            if (!newOperand)
            {
                if (inputOutputBox.Text == "Error")
                {
                    SetIOBoxText(inputOutputBox, "0");
                    inputLength = 0;
                }
                else if ((inputOutputBox.Text.Contains("-") && inputOutputBox.TextLength == 2))
                {
                    SetIOBoxText(inputOutputBox, "0");
                    inputLength = 0;
                }
                else if (inputOutputBox.TextLength == 1)
                {
                    SetIOBoxText(inputOutputBox, "0");
                    inputLength = 0;
                }
                else if (inputOutputBox.TextLength > 1)
                {
                    SetIOBoxText(inputOutputBox, inputOutputBox.Text.Substring(0, (inputOutputBox.TextLength - 1)));
                    inputLength -= 1;
                }
            }
        }

        //Diese Methode reagiert auf den Klick auf den Power Button, welcher die aktuelle Eingabe mit
        //einer nach dem Druecken des Buttons eingegebenen Zahl potenziert.
        void exponentButtonClick(object sender, EventArgs e)
        {
            if (!newOperand)
            {
                PerformCurrentOperation();
            }

            UpdateOperation("pow");
        }


        //Diese Methode reagiert auf den Klick auf den addition Button und bewirkt die Berechnung der Summe
        //der aktuellen Eingabe und einer nach dem Klick einzugebenen Zahl. Die Berechnung wird nach
        //einem weiteren Klick auf eine der Operations Buttons (addition, substraction, multiplication, division) oder den Equals
        //Button ausgefuehrt und angezeigt.
        void addButtonClick(object sender, EventArgs e)
        {
            if (!newOperand)
            {
                PerformCurrentOperation();
            }

            UpdateOperation("addition");
        }

        //Diese Methode reagiert auf den Klick auf den substraction Button und bewirkt die Berechnung der
        //Differenz der aktuellen Eingabe und einer nach dem Klick einzugebenen Zahl. Die Berechnung
        //wird nach einem weiteren Klick auf eine der Operations Buttons (addition, substraction, multiplication, division) oder
        //den Equals Button ausgefuehrt und angezeigt.
        void substButtonClick(object sender, EventArgs e)
        {
            if (!newOperand)
            {
                PerformCurrentOperation();
            }

            UpdateOperation("substraction");
        }

        //Diese Methode reagiert auf den Klick auf den multiplication Button und bewirkt die Berechnung des
        //Produkts der aktuellen Eingabe und einer nach dem Klick einzugebenen Zahl. Die Berechnung wird
        //nach einem weiteren Klick auf eine der Operations Buttons (addition, substraction, multiplication, division) oder den
        //Equals Button ausgefuehrt und angezeigt.
        void multButtonClick(object sender, EventArgs e)
        {
            if (!newOperand)
            {
                PerformCurrentOperation();
            }

            UpdateOperation("multiplication");
        }

        //Diese Methode reagiert auf den Klick auf den division Button und bewirkt die Berechnung des
        //Quotienten der aktuellen Eingabe und einer nach dem Klick einzugebenen Zahl. Die Berechnung
        //wird nach einem weiteren Klick auf eine der Operations Buttons (addition, substraction, multiplication, division) oder
        //den Equals Button ausgefuehrt und angezeigt.
        void divButtonClick(object sender, EventArgs e)
        {
            if (!newOperand)
            {
                PerformCurrentOperation();
            }

            UpdateOperation("division");
        }

        //Winkelfunktionen

        //Diese Methode reagiert auf den Klick auf den unitOfAngle Button und schaltet zwischen dem
        //Grad und dem Radian Modus von Winkelfunktionen (0°-360°/0-2*Pi) um.
        void unitOfAngleButtonClick(object sender, EventArgs e)
        {
            if (unitOfAngle.Text == "Rad")
                SetButtonText(unitOfAngle, "Grad");
            else
                SetButtonText(unitOfAngle, "Rad");
        }

        //Diese Methode reagiert auf den Klick auf den Sinus Button und bewirkt eine Berechnung des
        //Sinus fuer die aktuelle Eingabe.
        void sinusButtonClick(object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity())
                return;

            if (unitOfAngle.Text == "Rad")
            {
                operand1 = (Math.Sin(double.Parse(inputOutputBox.Text)));
                inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
            }
            else if (unitOfAngle.Text == "Grad")
            {
                var temp = double.Parse(inputOutputBox.Text);
                temp *= (Math.PI / 180);
                operand1 = Math.Sin(temp);
                inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
            }
            else
            {
                inputOutputBox.Text = "Error";
                operand1 = 0;
                inputLength = 0;
            }

            newOperand = true;
        }

        //Diese Methode reagiert auf den Klick auf den sinusHyp Button und bewirkt eine Berechnung des
        //sinusHyp fuer die aktuelle Eingabe.
        void sinusHypButtonClick(object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity())
                return;

            if (unitOfAngle.Text == "Rad")
            {
                operand1 = (Math.Sinh(double.Parse(inputOutputBox.Text)));
                inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
            }
            else if (unitOfAngle.Text == "Grad")
            {
                var temp = double.Parse(inputOutputBox.Text);
                temp *= (Math.PI / 180);
                operand1 = Math.Sinh(temp);
                inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
            }
            else
            {
                inputOutputBox.Text = "Error";
            }

            newOperand = true;
        }

        //Diese Methode reagiert auf den Klick auf den Cosinus Button und bewirkt eine Berechnung des
        //Cosinus fuer die aktuelle Eingabe.
        void cosinusButtonClick(object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity())
                return;

            if (unitOfAngle.Text == "Rad")
            {
                operand1 = (Math.Cos(double.Parse(inputOutputBox.Text)));
                inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
            }
            else if (unitOfAngle.Text == "Grad")
            {
                var temp = double.Parse(inputOutputBox.Text);
                temp *= (Math.PI / 180);
                operand1 = Math.Cos(temp);
                inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
            }
            else
            {
                inputOutputBox.Text = "Error";
                operand1 = 0;
                inputLength = 0;
            }

            newOperand = true;
        }

        //Diese Methode reagiert auf den Klick auf den cosinusHyp Button und bewirkt eine Berechnung des
        //cosinusHyp fuer die aktuelle Eingabe.
        void cosinusHypButtonClick(object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity())
                return;

            if (unitOfAngle.Text == "Rad")
            {
                operand1 = (Math.Cosh(double.Parse(inputOutputBox.Text)));
                inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
            }
            else if (unitOfAngle.Text == "Grad")
            {
                var temp = double.Parse(inputOutputBox.Text);
                temp *= (Math.PI / 180);
                operand1 = Math.Cosh(temp);
                inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
            }
            else
            {
                inputOutputBox.Text = "Error";
            }

            newOperand = true;
        }

        //Diese Methode reagiert auf den Klick auf den Tangens Button und bewirkt eine Berechnung des
        //Tangens fuer die aktuelle Eingabe.
        void tangensButtonClick(object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity())
                return;

            if (unitOfAngle.Text == "Rad")
            {
                operand1 = (Math.Tan(double.Parse(inputOutputBox.Text)));
                inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
            }
            else if (unitOfAngle.Text == "Grad")
            {
                var temp = double.Parse(inputOutputBox.Text);
                temp *= (Math.PI / 180);
                operand1 = Math.Tan(temp);
                inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
            }
            else
            {
                inputOutputBox.Text = "Error";
                operand1 = 0;
                inputLength = 0;
            }

            newOperand = true;
        }

        //Diese Methode reagiert auf den Klick auf den ASinus Button und bewirkt eine Berechnung des
        //ArcSinus fuer die aktuelle Eingabe.
        void arcSinusButtonClick(object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity())
                return;

            if (unitOfAngle.Text == "Rad")
            {
                operand1 = (Math.Asin(double.Parse(inputOutputBox.Text)));
                inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
            }
            else if (unitOfAngle.Text == "Grad")
            {
                operand1 = Math.Asin(double.Parse(inputOutputBox.Text)) * 180 / Math.PI;
                inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
            }
            else
            {
                inputOutputBox.Text = "Error";
                operand1 = 0;
                inputLength = 0;
            }

            newOperand = true;
        }

        //Diese Methode reagiert auf den Klick auf den ACosinus Button und bewirkt eine Berechnung des
        //ArcCosinus fuer die aktuelle Eingabe.
        void arcCosinusbuttonClick(object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity())
                return;

            if (unitOfAngle.Text == "Rad")
            {
                operand1 = (Math.Acos(double.Parse(inputOutputBox.Text)));
                inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
            }
            else if (unitOfAngle.Text == "Grad")
            {
                operand1 = Math.Acos(double.Parse(inputOutputBox.Text)) * 180 / Math.PI;
                inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
            }
            else
            {
                inputOutputBox.Text = "Error";
                operand1 = 0;
                inputLength = 0;
            }

            newOperand = true;
        }

        //Diese Methode reagiert auf den Klick auf den ATangens Button und bewirkt eine Berechnung des
        //ArcTangens fuer die aktuelle Eingabe.
        void arcTangensButtonClick(object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity())
                return;

            if (unitOfAngle.Text == "Rad")
            {
                operand1 = (Math.Atan(double.Parse(inputOutputBox.Text)));
                inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
            }
            else if (unitOfAngle.Text == "Grad")
            {
                operand1 = Math.Atan(double.Parse(inputOutputBox.Text)) * 180 / Math.PI;
                inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
            }
            else
            {
                inputOutputBox.Text = "Error";
                operand1 = 0;
                inputLength = 0;
            }

            newOperand = true;
        }


        //Weitere mathematische Optionen

        //Diese Methode reagiert auf den Klick auf den Factorial Button und bewirkt die Berechnung der
        //Fakultaet (Produkt saemtlicher ganzer Zahlen kleiner gleich der Eingabe). Dabei ist zu
        //beachten, dass die Fakultaet nur fuer natuerliche Zahlen und '0' definiert ist. 
        void factorialButtonClick(object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity())
                return;

            if (double.Parse(inputOutputBox.Text) < 0)
            {
                inputOutputBox.Text = "Error";
                newOperand = true;
                return;
            }

            double EPSILON = 0.0000000000000001f;
            double tempMax = double.Parse(inputOutputBox.Text);

            if (Math.Abs((tempMax % 1)) < EPSILON)
            {
                double temp = 1;
                for (int i = 1; i <= tempMax; i++)
                    temp *= i;

                operand1 = temp;
                inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
                newOperand = true;
            }
            else
            {
                inputOutputBox.Text = "Error";
                newOperand = true;
            }
        }

        //Diese Methode reagiert auf den Klick auf den Factorial Button wenn SHIFT zuvorgedrückt wurde und bewirkt die Berechnung des
        //Kehrwertes. Dabei ist darauf zu achten, dass der Wert ungleich 0 ist.
        void reciprocalButtonClick(object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity())
                return;

            double X = double.Parse(inputOutputBox.Text);
            double EPSILON = 0.0000000000000001f;
            if (Math.Abs(X) < EPSILON)
            {
                inputOutputBox.Text = "Error";
                newOperand = true;
            }
            else
            {
                double x = 0;
                x = 1 / X;
                operand1 = x;
                inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
                newOperand = true;
            }
        }

        //Diese Methode reagiert auf den Klick auf den Square Button und bewirkt die Quadrierung der
        //aktuellen Eingabe.
        void squareButtonClick(object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity())
                return;

            operand1 = double.Parse(inputOutputBox.Text) * double.Parse(inputOutputBox.Text);
            inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
            inputLength = 0;
            newOperand = true;
        }

        //Diese Methode reagiert auf den Klick auf den Ln Button und bewirkt die Berechnung des
        //natuerlichen Logarithmus der aktuellen Eingabe. Dieser ist nur fuer positive Zahlen
        //definiert.
        void lnButtonClick(object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity())
                return;

            double lnValue = double.Parse(inputOutputBox.Text);

            if (lnValue > 0)
            {
                operand1 = Math.Log(lnValue);
                inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
                inputLength = 0;
            }
            else
            {
                ErrorMessage();
            }
            newOperand = true;
        }

        //Diese Methode reagiert auf den Klick auf den Sqrt Button und berechnet die Quadratwurzel
        //des aktuell eingegebenen Wertes. Ist dieser negativ wird ein Error ausgegeben.
        void sqrtButtonClick(object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity())
                return;

            double sqrtValue = Math.Sqrt(double.Parse(inputOutputBox.Text));

            if (sqrtValue > 0)
            {
                operand1 = Math.Sqrt(double.Parse(inputOutputBox.Text));
                inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
            }
            else
            {
                ErrorMessage();
            }
            newOperand = true;
        }

        //Diese Methode reagiert auf den Klick auf den Equals Button und bewirkt die Berechnung der
        //aktuelle currentOperation.
        void equalsButtonClick(object sender, EventArgs e)
        {
            if (!newOperand)
            {
                PerformCurrentOperation();
            }

            UpdateOperation("none");
        }

        //Änderung des Layout und Einbindung weiterer Funktionen

        void outputPrecisionButtonClick(object sender, EventArgs e)
        {
            SetNewIOPrecision(outputCommaPrecision);
        }


        class MainClass
        {
            //Diese Methode erzeugt die Standardnachrichtenschleife um die ClickEvents des 'calculator'
            //abzufragen.
            public static void Main()
            {
                Application.Run(new Calculator());
                return;
            }
        }
    }
}