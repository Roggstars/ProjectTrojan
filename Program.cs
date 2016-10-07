using System;
using System.Windows.Forms;
using System.Drawing;

class calculator : Form
{
    int inputLength;
    string systemLanguage;
    bool newOperand;
    double operand1;
    string currentOperation = "none";
    string outputCommaPrecision = "g4";
    bool alternativeFunctionsActive;
    double memoryValue = 0;

    //Erstellt Buttons
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
    Button cosinusHyp;
    Button sinusHyp;
    Button unitOfAngle;
    Button shift;
    Button outputPrecisionButton;
    Button m;
    Button mp;

    //Erstellt TextBox
    TextBox inputOutputBox;
    
    public calculator()
    {
        setCurrentLanguage();

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
        m = new Button();
        mp = new Button();

        inputOutputBox = new TextBox();

        //Setzt inputOutputBox auf ReadOnly
        inputOutputBox.ReadOnly = true;
        //Legt Inhalt der Buttons fest
        number0.Text = ("0");
        number1.Text = ("1");
        number2.Text = ("2");
        number3.Text = ("3");
        number4.Text = ("4");
        number5.Text = ("5");
        number6.Text = ("6");
        number7.Text = ("7");
        number8.Text = ("8");
        number9.Text = ("9");
        pi.Text = ("π");
        e.Text = ("e");
        comma.Text = (",");
        clear.Text = ("AC");
        addition.Text = ("+");
        substraction.Text = ("-");
        multiplication.Text = ("*");
        division.Text = ("/");
        square.Text = ("x²");
        sqrt.Text = ("√¯x");
        equals.Text = ("=");
        del.Text = ("DEL");
        factorial.Text = ("x!");
        ln.Text = ("ln");
        sinus.Text = ("sin");
        cosinus.Text = ("cos");
        tangens.Text = ("tan");
        sinusHyp.Text = ("sinh");
        cosinusHyp.Text = ("cosh");
        unitOfAngle.Text = ("Rad");
        shift.Text = ("Fn");
        outputPrecisionButton.Text = ("4 Dgts");
        m.Text = ("M");
        mp.Text = ("M+");

        Size = new Size(390, 500);

        //Legt Hoehe und Breite der Buttons fest
        number0.Height = 50;
        number0.Width = 50;
        number1.Height = 50;
        number1.Width = 50;
        number2.Height = 50;
        number2.Width = 50;
        number3.Height = 50;
        number3.Width = 50;
        number4.Height = 50;
        number4.Width = 50;
        number5.Height = 50;
        number5.Width = 50;
        number6.Height = 50;
        number6.Width = 50;
        number7.Height = 50;
        number7.Width = 50;
        number8.Height = 50;
        number8.Width = 50;
        number9.Height = 50;
        number9.Width = 50;
        pi.Height = 50;
        pi.Width = 50;
        e.Height = 50;
        e.Width = 50;
        comma.Height = 50;
        comma.Width = 50;
        clear.Height = 50;
        clear.Width = 50;
        addition.Height = 50;
        addition.Width = 50;
        substraction.Height = 50;
        substraction.Width = 50;
        multiplication.Height = 50;
        multiplication.Width = 50;
        division.Height = 50;
        division.Width = 50;
        square.Height = 50;
        square.Width = 50;
        sqrt.Height = 50;
        sqrt.Width = 50;
        equals.Height = 50;
        equals.Width = 50;
        del.Height = 50;
        del.Width = 50;
        factorial.Height = 50;
        factorial.Width = 50;
        ln.Height = 50;
        ln.Width = 50;
        sinus.Height = 50;
        sinus.Width = 50;
        cosinus.Height = 50;
        cosinus.Width = 50;
        cosinusHyp.Width = 50;
        cosinusHyp.Height = 50;
        sinusHyp.Height = 50;
        sinusHyp.Width = 50;
        tangens.Width = 50;
        tangens.Height = 50;
        unitOfAngle.Height = 50;
        unitOfAngle.Width = 50;
        shift.Height = 50;
        shift.Width = 50;
        outputPrecisionButton.Height = 50;
        outputPrecisionButton.Width = 50;
        m.Height = 50;
        m.Width = 50;
        mp.Height = 50;
        mp.Width = 50;

        //Legt Hoehe und Breite der Ergebnis-inputOutputBox fest
        inputOutputBox.Width = 320;
        inputOutputBox.Font = new Font("Arial", 30, FontStyle.Bold);

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
        m.Location = new Point(comma.Left + comma.Width, comma.Top);
        mp.Location = new Point(m.Left + m.Width + 10, m.Top);
        equals.Location = new Point(mp.Left + mp.Width, mp.Top);

        //Erstelle EventHandler mit entsprechenden ButtonClick Funktionen um ClickEvent der Buttons zu
        //kontrollieren.
        number0.Click += number0ButtonClick;
        number1.Click += number1ButtonClick;
        number2.Click += number2ButtonClick;
        number3.Click += number3ButtonClick;
        number4.Click += number4ButtonClick;
        number5.Click += number5ButtonClick;
        number6.Click += number6ButtonClick;
        number7.Click += number7ButtonClick;
        number8.Click += number8ButtonClick;
        number9.Click += number9ButtonClick;
        pi.Click += piButtonClick;
        e.Click += eButtonClick;
        comma.Click += commaButtonClick;
        clear.Click += clearButtonClick;
        addition.Click += addButtonClick;
        substraction.Click += substButtonClick;
        multiplication.Click += multButtonClick;
        division.Click += divButtonClick;
        square.Click += squareButtonClick;
        sqrt.Click += sqrtButtonClick;
        equals.Click += equalsButtonClick;
        del.Click += delButtonClick;
        factorial.Click += factorialButtonClick;
        ln.Click += lnButtonClick;
        sinus.Click += sinusButtonClick;
        sinusHyp.Click += sinusHypButtonClick;
        cosinusHyp.Click += cosinusHypButtonClick;
        cosinus.Click += cosinusButtonClick;
        tangens.Click += tangensButtonClick;
        unitOfAngle.Click += unitOfAngleButtonClick;
        shift.Click += shiftButtonClick;
        outputPrecisionButton.Click += outputPrecisionButtonClick;
        mp.Click += memoryPButtonClick;
        m.Click += memoryButtonClick;

        //Setze Ergebnis auf 0
        inputOutputBox.Text = "0";

        //Füge Controls für die Buttons hinzu
        Controls.Add(number0);
        Controls.Add(number1);
        Controls.Add(number2);
        Controls.Add(number3);
        Controls.Add(number4);
        Controls.Add(number5);
        Controls.Add(number6);
        Controls.Add(number7);
        Controls.Add(number8);
        Controls.Add(number9);
        Controls.Add(pi);
        Controls.Add(e);
        Controls.Add(comma);
        Controls.Add(clear);
        Controls.Add(addition);
        Controls.Add(substraction);
        Controls.Add(multiplication);
        Controls.Add(division);
        Controls.Add(square);
        Controls.Add(sqrt);
        Controls.Add(inputOutputBox);
        Controls.Add(equals);
        Controls.Add(del);
        Controls.Add(factorial);
        Controls.Add(ln);
        Controls.Add(shift);
        Controls.Add(outputPrecisionButton);
        Controls.Add(m);
        Controls.Add(mp);
        Controls.Add(sinus);
        Controls.Add(cosinus);
        Controls.Add(tangens);
        Controls.Add(sinusHyp);
        Controls.Add(cosinusHyp);
        Controls.Add(unitOfAngle);

        Text = ("Project Trojan"); //Fenstertitel
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MinimizeBox = false; //Deaktivieren der minimize und maximize inputOutputBox neben der Schließen-inputOutputBox
                             //in der Titelleiste
        MaximizeBox = false;

        //Farben
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

        inputOutputBox.TextAlign = HorizontalAlignment.Right;
        inputOutputBox.ForeColor = Color.WhiteSmoke;
        inputOutputBox.BackColor = Color.Black;
        addition.BackColor = Color.Orange;
        substraction.BackColor = Color.Orange;
        multiplication.BackColor = Color.Orange;
        division.BackColor = Color.Orange;
        square.BackColor = Color.Gray;
        sqrt.BackColor = Color.Gray;
        factorial.BackColor = Color.Gray;
        equals.BackColor = Color.Orange;
        ln.BackColor = Color.Gray;
        m.BackColor = Color.Gray;
        mp.BackColor = Color.Gray; 

        e.BackColor = Color.Gray;
        pi.BackColor = Color.Gray;

        sinus.BackColor = Color.Gray;
        cosinus.BackColor = Color.Gray;
        sinusHyp.BackColor = Color.Gray;
        cosinusHyp.BackColor = Color.Gray;
        tangens.BackColor = Color.Gray;
        unitOfAngle.BackColor = Color.Gray;

        del.BackColor = Color.Red;
        clear.BackColor = Color.Red;
    }

    //Diese Methode reagiert auf den Klick auf den Funktions/Shift Button, welcher benoetigt wird,
    //um ein uebersichtlicheres UI zu gewaehrleisten. Dazu werden einem Button mehrere Funktionen
    //zugewiesen anstatt viele neue (Platz einnehmende) Buttons zu erzeugen. Der Button schaltet
    //zwischen Winkelfunktionen und ihren Umkehrfunktionen um.
    void shiftButtonClick(object sender, EventArgs e)
    {
        if (!alternativeFunctionsActive)
        {
            sinus.Click -= sinusButtonClick;
            sinus.Click += arcSinusButtonClick;
            cosinus.Click -= cosinusButtonClick;
            cosinus.Click += arcCosinusbuttonClick;
            tangens.Click -= tangensButtonClick;
            tangens.Click += arcTangensButtonClick;
            m.Click -= memoryButtonClick;
            m.Click += memoryClearButtonClick;
            mp.Click -= memoryPButtonClick;
            mp.Click += memoryMButtonClick;
            factorial.Click -= factorialButtonClick;
            factorial.Click += reciprocalButtonClick;
            square.Click += exponentButtonClick;
            square.Click -= squareButtonClick;

            sinus.Text = "arcsin";
            cosinus.Text = "arccos";
            tangens.Text = "arctan";
            factorial.Text = "1/x";
            square.Text = "x^n";
            m.Text = "MC";
            mp.Text = "M-";

            alternativeFunctionsActive = true;

            shift.BackColor = Color.Red;
        }

        else
        {
            sinus.Click += sinusButtonClick;
            sinus.Click -= arcSinusButtonClick;
            cosinus.Click += cosinusButtonClick;
            cosinus.Click -= arcCosinusbuttonClick;
            tangens.Click += tangensButtonClick;
            tangens.Click -= arcTangensButtonClick;
            m.Click += memoryButtonClick;
            m.Click -= memoryClearButtonClick;
            mp.Click += memoryPButtonClick;
            mp.Click -= memoryMButtonClick;
            factorial.Click += factorialButtonClick;
            factorial.Click -= reciprocalButtonClick;
            square.Click += squareButtonClick;
            square.Click -= exponentButtonClick;
        
            sinus.Text = "sin";
            cosinus.Text = "cos";
            tangens.Text = "tan";
            m.Text = "M";
            factorial.Text = "x!";
            square.Text = "x²";
            mp.Text = "M+";

            alternativeFunctionsActive = false;

            shift.BackColor = SystemColors.Control;
        }
    }
//m Funktionen

    // Abspeichern des Inhaltes der inputOutputBox 
    void memoryButtonClick(object sender, EventArgs e)
    {
        if (memoryValue != 0)
        {
            inputOutputBox.Text = memoryValue.ToString(outputCommaPrecision);
            newOperand = false;
        }
    }

    //Löschen des Speichers
    void memoryClearButtonClick(object sender, EventArgs e)
    {
        memoryValue = 0;
        m.BackColor = Color.Gray;
    }

    void memoryPButtonClick(object sender, EventArgs e)
    {
        memoryValue += double.Parse(inputOutputBox.Text);
        if (memoryValue != 0)
            m.BackColor = Color.PaleVioletRed;
        else
            m.BackColor = Color.Gray;
        newOperand = true;
    }

    void memoryMButtonClick(object sender, EventArgs e)
    {
        memoryValue -= double.Parse(inputOutputBox.Text);
        if (memoryValue != 0)
            m.BackColor = Color.PaleVioletRed;
        else
            m.BackColor = Color.Gray;
        newOperand = true;
    }


//Zahlen

    //Diese Methode reagiert auf den Klick auf den Ziffer 0 Button. Dieser erstellt, je nach
    //bisheriger Eingabe entweder eine 0 in der TextBox oder haengt eine '0' an den aktuellen
    //TextBox String an, erweitert somit die Eingabe um eine Zehnerpotenz.
    void number0ButtonClick(object sender, EventArgs e)
    {
        setOrAddNumber(0);
    }

    //Diese Methode reagiert auf den Klick auf den Ziffer 1 Button. Dieser erstellt, je nach
    //bisheriger Eingabe entweder eine '1' in der TextBox oder haengt eine '1' an den aktuellen
    //TextBox String an.
    void number1ButtonClick(object sender, EventArgs e)
    {
        setOrAddNumber(1);
    }

    //Diese Methode reagiert auf den Klick auf den Ziffer 2 Button. Dieser erstellt, je nach
    //bisheriger Eingabe entweder eine '2' in der TextBox oder haengt eine '2' an den aktuellen
    //TextBox String an.
    void number2ButtonClick(object sender, EventArgs e)
    {
        setOrAddNumber(2);
    }

    //Diese Methode reagiert auf den Klick auf den Ziffer 3 Button. Dieser erstellt, je nach
    //bisheriger Eingabe entweder eine '3' in der TextBox oder haengt eine '3' an den aktuellen
    //TextBox String an.
    void number3ButtonClick(object sender, EventArgs e)
    {
        setOrAddNumber(3);
    }

    //Diese Methode reagiert auf den Klick auf den Ziffer 4 Button. Dieser erstellt, je nach
    //bisheriger Eingabe entweder eine '4' in der TextBox oder haengt eine '4' an den aktuellen
    //TextBox String an.
    void number4ButtonClick(object sender, EventArgs e)
    {
        setOrAddNumber(4);
    }

    //Diese Methode reagiert auf den Klick auf den Ziffer 5 Button. Dieser erstellt, je nach
    //bisheriger Eingabe entweder eine '5' in der TextBox oder haengt eine '5' an den aktuellen
    //TextBox String an.
    void number5ButtonClick(object sender, EventArgs e)
    {
        setOrAddNumber(5);
    }

    //Diese Methode reagiert auf den Klick auf den Ziffer 6 Button. Dieser erstellt, je nach
    //bisheriger Eingabe entweder eine '6' in der TextBox oder haengt eine '6' an den aktuellen
    //TextBox String an.
    void number6ButtonClick(object sender, EventArgs e)
    {
        setOrAddNumber(6);
    }

    //Diese Methode reagiert auf den Klick auf den Ziffer 7 Button. Dieser erstellt, je nach
    //bisheriger Eingabe entweder eine '7' in der TextBox oder haengt eine '7' an den aktuellen
    //TextBox String an.
    void number7ButtonClick(object sender, EventArgs e)
    {
        setOrAddNumber(7);
    }

    //Diese Methode reagiert auf den Klick auf den Ziffer 8 Button. Dieser erstellt, je nach
    //bisheriger Eingabe entweder eine '8' in der TextBox oder haengt eine '8' an den aktuellen
    //TextBox String an.
    void number8ButtonClick(object sender, EventArgs e)
    {
        setOrAddNumber(8);
    }

    //Diese Methode reagiert auf den Klick auf den Ziffer 9 Button. Dieser erstellt, je nach
    //bisheriger Eingabe entweder eine '9' in der TextBox oder haengt eine '9' an den aktuellen
    //TextBox String an.
    void number9ButtonClick(object sender, EventArgs e)
    {
        setOrAddNumber(9);
    }

    //Diese Methode reagiert auf den Klick auf den Button der Konstante Pi. Sie setzt den String der
    //TextBox auf die Konstante Pi.
    void piButtonClick(object sender, EventArgs e)
    {
        inputOutputBox.Text = (Math.PI).ToString(outputCommaPrecision);
        newOperand = false;
    }

    void eButtonClick(object sender, EventArgs e)
    {
        inputOutputBox.Text = (Math.E).ToString(outputCommaPrecision);
        newOperand = false;
    }

//Vereinfacht und erweitern die Bedienung des Rechners

    //Diese Methode reagiert auf den Klick auf den Komma Button. Es muss von System zu System,
    //abhaengig von der Sprache, unterschieden werden, ob ein '.' oder ein ',' eingesetzt wird,
    //da Systeme verschieden auf die beiden Zeichen reagieren.
    void commaButtonClick(object sender, EventArgs e)
    {
        if (systemLanguage == "de")
        {
            if (!inputOutputBox.Text.Contains(","))
            {
                inputOutputBox.Text += ",";
                inputLength += 1;
            }
        }
        else {
            if (!inputOutputBox.Text.Contains("."))
            {
                inputOutputBox.Text += ".";
                inputLength += 1;
            }
        }
    }

    //Diese Methode reagiert auf den Klick auf den Clear Button, welcher saemtliche gespeicherten
    //Ergebnisse sowie die aktuelle Eingabe leert.
    void clearButtonClick(object sender, EventArgs e)
    {
        inputOutputBox.Text = "0";
        sinus.Text = "sin";
        cosinus.Text = "cos";
        tangens.Text = "tan";
        m.Text = "m";
        mp.Text = "m+";
        shift.BackColor = SystemColors.Control;
        alternativeFunctionsActive = false;
        operand1 = 0;
        inputLength = 0;
        newOperand = false;
        currentOperation = "none";
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
    void exponentButtonClick(object sender, EventArgs e)
    {
        if (!newOperand)
        {
            performCurrentOperation();
        }

        updateOperation("pow");
    }


    //Diese Methode reagiert auf den Klick auf den addition Button und bewirkt die Berechnung der Summe
    //der aktuellen Eingabe und einer nach dem Klick einzugebenen Zahl. Die Berechnung wird nach
    //einem weiteren Klick auf eine der Operations Buttons (addition, substraction, multiplication, division) oder den Equals
    //Button ausgefuehrt und angezeigt.
    void addButtonClick(object sender, EventArgs e)
    {
        if (!newOperand)
        {
            performCurrentOperation();
        }

        updateOperation("addition");
    }

    //Diese Methode reagiert auf den Klick auf den substraction Button und bewirkt die Berechnung der
    //Differenz der aktuellen Eingabe und einer nach dem Klick einzugebenen Zahl. Die Berechnung
    //wird nach einem weiteren Klick auf eine der Operations Buttons (addition, substraction, multiplication, division) oder
    //den Equals Button ausgefuehrt und angezeigt.
    void substButtonClick(object sender, EventArgs e)
    {
        if (!newOperand)
        {
            performCurrentOperation();
        }

        updateOperation("substraction");
    }

    //Diese Methode reagiert auf den Klick auf den multiplication Button und bewirkt die Berechnung des
    //Produkts der aktuellen Eingabe und einer nach dem Klick einzugebenen Zahl. Die Berechnung wird
    //nach einem weiteren Klick auf eine der Operations Buttons (addition, substraction, multiplication, division) oder den
    //Equals Button ausgefuehrt und angezeigt.
    void multButtonClick(object sender, EventArgs e)
    {
        if (!newOperand)
        {
            performCurrentOperation();
        }

        updateOperation("multiplication");
    }

    //Diese Methode reagiert auf den Klick auf den division Button und bewirkt die Berechnung des
    //Quotienten der aktuellen Eingabe und einer nach dem Klick einzugebenen Zahl. Die Berechnung
    //wird nach einem weiteren Klick auf eine der Operations Buttons (addition, substraction, multiplication, division) oder
    //den Equals Button ausgefuehrt und angezeigt.
    void divButtonClick(object sender, EventArgs e)
    {
        if (!newOperand)
        {
            performCurrentOperation();
        }

        updateOperation("division");
    }

//Winkelfunktionen

     //Diese Methode reagiert auf den Klick auf den unitOfAngle Button und schaltet zwischen dem
    //Grad und dem Radian Modus von Winkelfunktionen (0°-360°/0-2*Pi) um.
    void unitOfAngleButtonClick(object sender, EventArgs e)
    {
        if (unitOfAngle.Text == "Rad")
            unitOfAngle.Text = "Grad"; //Ist noch nicht fertig eingebunden nur der Button steht schon
        else
            unitOfAngle.Text = "Rad";
    }

    //Diese Methode reagiert auf den Klick auf den Sinus Button und bewirkt eine Berechnung des
    //Sinus fuer die aktuelle Eingabe.
    void sinusButtonClick(object sender, EventArgs e)
    {
        checkForErrorOrInfinity();

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
        checkForErrorOrInfinity();

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
        checkForErrorOrInfinity();

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
        checkForErrorOrInfinity();

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
        checkForErrorOrInfinity();

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
        checkForErrorOrInfinity();

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
        checkForErrorOrInfinity();

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
        checkForErrorOrInfinity();

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
        checkForErrorOrInfinity();
        
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
        checkForErrorOrInfinity();

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
        checkForErrorOrInfinity();

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
        checkForErrorOrInfinity();

        double lnValue = double.Parse(inputOutputBox.Text);

        if (lnValue > 0)
        {
            operand1 = Math.Log(lnValue);
            inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
            inputLength = 0;
        }
        else
        {
            errorMessage();
        }
        newOperand = true;
    }

    //Diese Methode reagiert auf den Klick auf den Sqrt Button und berechnet die Quadratwurzel
    //des aktuell eingegebenen Wertes. Ist dieser negativ wird ein Error ausgegeben.
    void sqrtButtonClick(object sender, EventArgs e)
    {
        checkForErrorOrInfinity();

        double sqrtValue = Math.Sqrt(double.Parse(inputOutputBox.Text));

        if (sqrtValue > 0)
        {
            operand1 = Math.Sqrt(double.Parse(inputOutputBox.Text));
            inputOutputBox.Text = operand1.ToString(outputCommaPrecision);
        }
        else
        {
            errorMessage();
        }
        newOperand = true;
    }

    //Diese Methode reagiert auf den Klick auf den Equals Button und bewirkt die Berechnung der
    //aktuelle currentOperation.
    void equalsButtonClick(object sender, EventArgs e)
    {
        if (!newOperand)
        {
            performCurrentOperation();
        }

        updateOperation("none");
    }

//Änderung des Layout und Einbindung weiterer Funktionen

    void outputPrecisionButtonClick(object sender, EventArgs e)
    {
        setNewPrecision(outputCommaPrecision);
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

    private void checkForErrorOrInfinity()
    {
        if (inputOutputBox.Text == "Error" || inputOutputBox.Text == "∞")
            return;
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
        else {
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

class MainClass
{
    //Diese Methode erzeugt die Standardnachrichtenschleife um die ClickEvents des 'calculator'
    //abzufragen.
    public static void Main()
    {
        Application.Run(new calculator());
        return;
    }
}
