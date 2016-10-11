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
            inputOutputBox.Text = "0";
        }

        //Diese Methode reagiert auf den Klick auf den Funktions/Shift Button, welcher benoetigt wird,
        //um ein uebersichtlicheres UI zu gewaehrleisten. Dazu werden einem Button mehrere Funktionen
        //zugewiesen anstatt viele neue (Platz einnehmende) Buttons zu erzeugen. Der Button schaltet
        //zwischen Winkelfunktionen und ihren Umkehrfunktionen um.
        void ShiftButtonClick(object sender, EventArgs e)
        {
            ToggleShift();
        }
        //memory Funktionen

        // Abspeichern des Inhaltes der inputOutputBox 
        void MemoryButtonClick(object sender, EventArgs e)
        {
            if (memoryValue != 0)
            {
                inputOutputBox.Text = memoryValue.ToString(outputCommaPrecision);
                newOperand = false;
            }
        }

        //Löschen des Speichers
        void MemoryClearButtonClick(object sender, EventArgs e)
        {
            memoryValue = 0;
            memoryButton.BackColor = Color.Gray;
        }

        void MemoryAddButtonClick(object sender, EventArgs e)
        {
            memoryValue += double.Parse(inputOutputBox.Text);

            if (memoryValue != 0)
                memoryButton.BackColor = Color.PaleVioletRed;
            else
                memoryButton.BackColor = Color.Gray;
            
            newOperand = true;
        }

        void MemorySubstractButtonClick(object sender, EventArgs e)
        {
            memoryValue -= double.Parse(inputOutputBox.Text);

            if (memoryValue != 0)
                memoryButton.BackColor = Color.PaleVioletRed;
            else
                memoryButton.BackColor = Color.Gray;
            
            newOperand = true;
        }


        //Zahlen

        //Diese Methode reagiert auf den Klick auf den Ziffer 0 Button. Dieser erstellt, je nach
        //bisheriger Eingabe entweder eine 0 in der TextBox oder haengt eine '0' an den aktuellen
        //TextBox String an, erweitert somit die Eingabe um eine Zehnerpotenz.
        void Number0ButtonClick(object sender, EventArgs e)
        {
            AddNumber(0);
        }

        //Diese Methode reagiert auf den Klick auf den Ziffer 1 Button. Dieser erstellt, je nach
        //bisheriger Eingabe entweder eine '1' in der TextBox oder haengt eine '1' an den aktuellen
        //TextBox String an.
        void Number1ButtonClick(object sender, EventArgs e)
        {
            AddNumber(1);
        }

        //Diese Methode reagiert auf den Klick auf den Ziffer 2 Button. Dieser erstellt, je nach
        //bisheriger Eingabe entweder eine '2' in der TextBox oder haengt eine '2' an den aktuellen
        //TextBox String an.
        void Number2ButtonClick(object sender, EventArgs e)
        {
            AddNumber(2);
        }

        //Diese Methode reagiert auf den Klick auf den Ziffer 3 Button. Dieser erstellt, je nach
        //bisheriger Eingabe entweder eine '3' in der TextBox oder haengt eine '3' an den aktuellen
        //TextBox String an.
        void Number3ButtonClick(object sender, EventArgs e)
        {
            AddNumber(3);
        }

        //Diese Methode reagiert auf den Klick auf den Ziffer 4 Button. Dieser erstellt, je nach
        //bisheriger Eingabe entweder eine '4' in der TeIOBoxngt eine '4' an den aktuellen
        //TextBox String an.
        void Number4ButtonClick(object sender, EventArgs e)
        {
            AddNumber(4);
        }

        //Diese Methode reagiert auf den Klick auf den Ziffer 5 Button. Dieser erstellt, je nach
        //bisheriger Eingabe entweder eine '5' in der TextBox oder haengt eine '5' an den aktuellen
        //TextBox String an.
        void Number5ButtonClick(object sender, EventArgs e)
        {
            AddNumber(5);
        }

        //Diese Methode reagiert auf den Klick auf den Ziffer 6 Button. Dieser erstellt, je nach
        //bisheriger Eingabe entweder eine '6' in der TextBox oder haengt eine '6' an den aktuellen
        //TextBox String an.
        void Number6ButtonClick(object sender, EventArgs e)
        {
            AddNumber(6);
        }

        //Diese Methode reagiert auf den Klick auf den Ziffer 7 Button. Dieser erstellt, je nach
        //bisheriger Eingabe entweder eine '7' in der TextBox oder haengt eine '7' an den aktuellen
        //TextBox String an.
        void Number7ButtonClick(object sender, EventArgs e)
        {
            AddNumber(7);
        }

        //Diese Methode reagiert auf den Klick auf den Ziffer 8 Button. Dieser erstellt, je nach
        //bisheriger Eingabe entweder eine '8' in der TextBox oder haengt eine '8' an den aktuellen
        //TextBox String an.
        void Number8ButtonClick(object sender, EventArgs e)
        {
            AddNumber(8);
        }

        //Diese Methode reagiert auf den Klick auf den Ziffer 9 Button. Dieser erstellt, je nach
        //bisheriger Eingabe entweder eine '9' in der TextBox oder haengt eine '9' an den aktuellen
        //TextBox String an.
        void Number9ButtonClick(object sender, EventArgs e)
        {
            AddNumber(9);
        }

        //Diese Methode reagiert auf den Klick auf den Button der Konstante Pi. Sie setzt den String der
        //TextBox auf die Konstante Pi.
        void PiButtonClick(object sender, EventArgs e)
        {
            inputOutputBox.Text = (Math.PI).ToString(outputCommaPrecision);
            newOperand = false;
        }

        void EButtonClick(object sender, EventArgs e)
        {
            inputOutputBox.Text = (Math.E).ToString(outputCommaPrecision);
            newOperand = false;
        }

        //Vereinfacht und erweitern die Bedienung des Rechners

        //Diese Methode reagiert auf den Klick auf den Komma Button. Es muss von System zu System,
        //abhaengig von der Sprache, unterschieden werden, ob ein '.' oder ein ',' eingesetzt wird,
        //da Systeme verschieden auf die beiden Zeichen reagieren.
        void CommaButtonClick(object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity())
                return;
            
            AddComma();
        }

        //Diese Methode reagiert auf den Klick auf den Clear Button, welcher saemtliche gespeicherten
        //Ergebnisse sowie die aktuelle Eingabe leert.
        void ClearButtonClick(object sender, EventArgs e)
        {
            inputOutputBox.Text = "0";
            sinus.Text = "sin";
            cosinus.Text = "cos";
            tangens.Text = "tan";
            memoryButton.Text = "M";
            memoryAddSubstButton.Text = "M+";
            shift.BackColor = SystemColors.Control;
            alternativeFunctionsActive = false;
            operand1 = 0;
            UpdateOperation("none");
        }

        //Grundrechenarten

        //Diese Methode reagiert auf den Klick auf den Delete Button, welcher den zuletzt eingegebenen
        //Teil der TextBox entfernt (bspw. im Falle eines Vertippens).
        void DelButtonClick(object sender, EventArgs e)
        {
            if (!newOperand)
            {
                if (inputOutputBox.Text == "Error")
                {
                    inputOutputBox.Text = "0";
                    inputLength = 0;
                }
                else if ((inputOutputBox.Text.Contains("-") && inputOutputBox.TextLength == 2))
                {
                    inputOutputBox.Text = "0";
                    inputLength = 0;
                }
                else if (inputOutputBox.TextLength == 1)
                {
                    inputOutputBox.Text = "0";
                    inputLength = 0;
                }
                else if (inputOutputBox.TextLength > 1)
                {
                    inputOutputBox.Text = inputOutputBox.Text.Substring(0, (inputOutputBox.TextLength - 1));
                    inputLength -= 1;
                }
            }
        }

        //Diese Methode reagiert auf den Klick auf den Power Button, welcher die aktuelle Eingabe mit
        //einer nach dem Druecken des Buttons eingegebenen Zahl potenziert.
        void ExponentButtonClick(object sender, EventArgs e)
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
        void AddButtonClick(object sender, EventArgs e)
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
        void SubstButtonClick(object sender, EventArgs e)
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
        void MultButtonClick(object sender, EventArgs e)
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
        void DivButtonClick(object sender, EventArgs e)
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
        void UnitOfAngleButtonClick(object sender, EventArgs e)
        {
            if (unitOfAngle.Text == "Rad")
                unitOfAngle.Text = "Grad";
            else
                unitOfAngle.Text = "Rad";
        }

        //Diese Methode reagiert auf den Klick auf den Sinus Button und bewirkt eine Berechnung des
        //Sinus fuer die aktuelle Eingabe.
        void SinusButtonClick(object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity())
                return;

            CalculateAngularFunction (Math.Sin, double.Parse(inputOutputBox.Text));

            newOperand = true;
        }

        //Diese Methode reagiert auf den Klick auf den sinusHyp Button und bewirkt eine Berechnung des
        //sinusHyp fuer die aktuelle Eingabe.
        void SinusHypButtonClick(object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity())
                return;

            CalculateAngularFunction (Math.Sinh, double.Parse(inputOutputBox.Text));

            newOperand = true;
        }

        //Diese Methode reagiert auf den Klick auf den Cosinus Button und bewirkt eine Berechnung des
        //Cosinus fuer die aktuelle Eingabe.
        void CosinusButtonClick(object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity())
                return;

            CalculateAngularFunction (Math.Cos, double.Parse(inputOutputBox.Text));

            newOperand = true;
        }

        //Diese Methode reagiert auf den Klick auf den cosinusHyp Button und bewirkt eine Berechnung des
        //cosinusHyp fuer die aktuelle Eingabe.
        void CosinusHypButtonClick(object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity())
                return;

            CalculateAngularFunction (Math.Cosh, double.Parse(inputOutputBox.Text));

            newOperand = true;
        }

        //Diese Methode reagiert auf den Klick auf den Tangens Button und bewirkt eine Berechnung des
        //Tangens fuer die aktuelle Eingabe.
        void TangensButtonClick(object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity())
                return;

            CalculateAngularFunction (Math.Tan, double.Parse(inputOutputBox.Text));

            newOperand = true;
        }

        //Diese Methode reagiert auf den Klick auf den ASinus Button und bewirkt eine Berechnung des
        //ArcSinus fuer die aktuelle Eingabe.
        void ArcSinusButtonClick(object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity())
                return;

            CalculateArcAngularFunction (Math.Asin, double.Parse (inputOutputBox.Text));

            newOperand = true;
        }

        //Diese Methode reagiert auf den Klick auf den ACosinus Button und bewirkt eine Berechnung des
        //ArcCosinus fuer die aktuelle Eingabe.
        void ArcCosinusButtonClick(object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity())
                return;

            CalculateArcAngularFunction (Math.Acos, double.Parse (inputOutputBox.Text));

            newOperand = true;
        }

        //Diese Methode reagiert auf den Klick auf den ATangens Button und bewirkt eine Berechnung des
        //ArcTangens fuer die aktuelle Eingabe.
        void ArcTangensButtonClick(object sender, EventArgs e)
        {
            if (InputContainsErrorOrInfinity())
                return;

            CalculateArcAngularFunction (Math.Atan, double.Parse (inputOutputBox.Text));

            newOperand = true;
        }


        //Weitere mathematische Optionen

        //Diese Methode reagiert auf den Klick auf den Factorial Button und bewirkt die Berechnung der
        //Fakultaet (Produkt saemtlicher ganzer Zahlen kleiner gleich der Eingabe). Dabei ist zu
        //beachten, dass die Fakultaet nur fuer natuerliche Zahlen und '0' definiert ist. 
        void FactorialButtonClick(object sender, EventArgs e)
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
        void ReciprocalButtonClick(object sender, EventArgs e)
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
        void SquareButtonClick(object sender, EventArgs e)
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
        void LnButtonClick(object sender, EventArgs e)
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
        void SqrtButtonClick(object sender, EventArgs e)
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
        void EqualsButtonClick(object sender, EventArgs e)
        {
            if (!newOperand)
            {
                PerformCurrentOperation();
            }

            UpdateOperation("none");
        }

        //Änderung des Layout und Einbindung weiterer Funktionen

        void OutputPrecisionButtonClick(object sender, EventArgs e)
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