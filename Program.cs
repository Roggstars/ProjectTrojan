using System;
using System.Windows.Forms;
using System.Drawing;

class calculator : Form
{
    int input_length;
    string system_language;
    bool new_operand;
    double operand1;
    string operation = "none";
    string precision = "g4";
    bool function;
    double memory = 0;

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
    Button E;
    Button comma;
    Button clear;
    Button add;
    Button subst;
    Button mult;
    Button div;
    Button square;
    Button sqrt;
    Button equals;
    Button del;
    Button factorial;
    Button ln;
    Button sinus;
    Button cosinus;
    Button tangens;
    Button cosinush;
    Button sinush;
    Button gradrad;
    Button shift;
    Button comma_precision;
    Button M;
    Button mp;

    //Erstellt TextBox
    TextBox box;

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
        E = new Button();
        comma = new Button();
        clear = new Button();
        add = new Button();
        subst = new Button();
        mult = new Button();
        div = new Button();
        square = new Button();
        sqrt = new Button();
        equals = new Button();
        del = new Button();
        factorial = new Button();
        ln = new Button();
        sinus = new Button();
        cosinus = new Button();
        tangens = new Button();
        sinush = new Button();
        cosinush = new Button();
        gradrad = new Button();
        shift = new Button();
        comma_precision = new Button();
        M = new Button();
        mp = new Button();

        box = new TextBox();

        //Setzt Box auf ReadOnly
        box.ReadOnly = true;
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
        E.Text = ("e");
        comma.Text = (",");
        clear.Text = ("AC");
        add.Text = ("+");
        subst.Text = ("-");
        mult.Text = ("*");
        div.Text = ("/");
        square.Text = ("x²");
        sqrt.Text = ("√¯x");
        equals.Text = ("=");
        del.Text = ("DEL");
        factorial.Text = ("x!");
        ln.Text = ("ln");
        sinus.Text = ("sin");
        cosinus.Text = ("cos");
        tangens.Text = ("tan");
        sinush.Text = ("sinh");
        cosinush.Text = ("cosh");
        gradrad.Text = ("Rad");
        shift.Text = ("Fn");
        comma_precision.Text = ("4 Dgts");
        M.Text = ("M");
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
        E.Height = 50;
        E.Width = 50;
        comma.Height = 50;
        comma.Width = 50;
        clear.Height = 50;
        clear.Width = 50;
        add.Height = 50;
        add.Width = 50;
        subst.Height = 50;
        subst.Width = 50;
        mult.Height = 50;
        mult.Width = 50;
        div.Height = 50;
        div.Width = 50;
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
        cosinush.Width = 50;
        cosinush.Height = 50;
        sinush.Height = 50;
        sinush.Width = 50;
        tangens.Width = 50;
        tangens.Height = 50;
        gradrad.Height = 50;
        gradrad.Width = 50;
        shift.Height = 50;
        shift.Width = 50;
        comma_precision.Height = 50;
        comma_precision.Width = 50;
        M.Height = 50;
        M.Width = 50;
        mp.Height = 50;
        mp.Width = 50;

        //Legt Hoehe und Breite der Ergebnis-Box fest
        box.Width = 320;
        box.Font = new Font("Arial", 30, FontStyle.Bold);

        box.Location = new Point(5, 5);

        sinus.Location = new Point(box.Left, box.Top + box.Height + 10);
        cosinus.Location = new Point(sinus.Left + sinus.Width, sinus.Top);
        tangens.Location = new Point(cosinus.Left + cosinus.Width, cosinus.Top);
        gradrad.Location = new Point(tangens.Left + tangens.Width + 10 + ln.Width + E.Width + 10, tangens.Top);

        sinush.Location = new Point(sinus.Left, sinus.Top + sinus.Height);
        cosinush.Location = new Point(cosinus.Left, cosinus.Top + cosinus.Height);
        pi.Location = new Point(tangens.Left, tangens.Top + tangens.Height);
        shift.Location = new Point(pi.Left + pi.Width + 10 + ln.Width + E.Width + 10, pi.Top);

        square.Location = new Point(sinush.Left, sinush.Top + sinush.Height + 10);
        sqrt.Location = new Point(square.Left + square.Width, square.Top);
        factorial.Location = new Point(sqrt.Left + sqrt.Width, sqrt.Top);
        ln.Location = new Point(factorial.Left + factorial.Width + 10, factorial.Top);
        E.Location = new Point(ln.Left + ln.Width, ln.Top);
        comma_precision.Location = new Point(E.Left + E.Width + 10, E.Top);

        number7.Location = new Point(square.Left, square.Top + square.Height + 20);
        number8.Location = new Point(number7.Left + number8.Width, number7.Top);
        number9.Location = new Point(number8.Left + number9.Width, number7.Top);
        del.Location = new Point(number9.Left + number9.Width + 10, number9.Top);
        clear.Location = new Point(del.Left + del.Width, del.Top);

        number4.Location = new Point(number7.Left, number7.Top + number7.Height);
        number5.Location = new Point(number4.Left + number4.Width, number4.Top);
        number6.Location = new Point(number5.Left + number5.Width, number5.Top);
        mult.Location = new Point(number6.Left + number6.Width + 10, number6.Top);
        div.Location = new Point(mult.Left + mult.Width, mult.Top);

        number1.Location = new Point(number4.Left, number4.Top + number4.Height);
        number2.Location = new Point(number5.Left, number5.Top + number5.Height);
        number3.Location = new Point(number6.Left, number6.Top + number6.Height);
        add.Location = new Point(number3.Left + number3.Width + 10, number3.Top);
        subst.Location = new Point(add.Left + add.Width, add.Top);

        number0.Location = new Point(number1.Left, number1.Top + number1.Height);
        comma.Location = new Point(number2.Left, number2.Top + number2.Height);
        M.Location = new Point(comma.Left + comma.Width, comma.Top);
        mp.Location = new Point(M.Left + M.Width + 10, M.Top);
        equals.Location = new Point(mp.Left + mp.Width, mp.Top);

        //Erstelle EventHandler mit entsprechenden _Click Funktionen um ClickEvent der Buttons zu
        //kontrollieren.
        number0.Click += Number0_Click;
        number1.Click += Number1_Click;
        number2.Click += Number2_Click;
        number3.Click += Number3_Click;
        number4.Click += Number4_Click;
        number5.Click += Number5_Click;
        number6.Click += Number6_Click;
        number7.Click += Number7_Click;
        number8.Click += Number8_Click;
        number9.Click += Number9_Click;
        pi.Click += Pi_Click;
        E.Click += E_Click;
        comma.Click += Comma_Click;
        clear.Click += Clear_Click;
        add.Click += Add_Click;
        subst.Click += Subst_Click;
        mult.Click += Mult_Click;
        div.Click += Div_Click;
        square.Click += Square_Click;
        sqrt.Click += Sqrt_Click;
        equals.Click += Equals_Click;
        del.Click += Del_Click;
        factorial.Click += Factorial_Click;
        ln.Click += Ln_Click;
        sinus.Click += Sinus_Click;
        sinush.Click += Sinush_Click;
        cosinush.Click += Cosinush_Click;
        cosinus.Click += Cosinus_Click;
        tangens.Click += Tangens_Click;
        gradrad.Click += GradRad_Click;
        shift.Click += Shift_Click;
        comma_precision.Click += Comma_Precision_Click;
        mp.Click += mp_Click;
        M.Click += M_Click;

        //Setze Ergebnis auf 0
        box.Text = "0";

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
        Controls.Add(E);
        Controls.Add(comma);
        Controls.Add(clear);
        Controls.Add(add);
        Controls.Add(subst);
        Controls.Add(mult);
        Controls.Add(div);
        Controls.Add(square);
        Controls.Add(sqrt);
        Controls.Add(box);
        Controls.Add(equals);
        Controls.Add(del);
        Controls.Add(factorial);
        Controls.Add(ln);
        Controls.Add(shift);
        Controls.Add(comma_precision);
        Controls.Add(M);
        Controls.Add(mp);
        Controls.Add(sinus);
        Controls.Add(cosinus);
        Controls.Add(tangens);
        Controls.Add(sinush);
        Controls.Add(cosinush);
        Controls.Add(gradrad);

        Text = ("Project Trojan"); //Fenstertitel
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MinimizeBox = false; //Deaktivieren der minimize und maximize Box neben der Schließen-Box
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

        box.TextAlign = HorizontalAlignment.Right;
        box.ForeColor = Color.WhiteSmoke;
        box.BackColor = Color.Black;
        add.BackColor = Color.Orange;
        subst.BackColor = Color.Orange;
        mult.BackColor = Color.Orange;
        div.BackColor = Color.Orange;
        square.BackColor = Color.Gray;
        sqrt.BackColor = Color.Gray;
        factorial.BackColor = Color.Gray;
        equals.BackColor = Color.Orange;
        ln.BackColor = Color.Gray;
        M.BackColor = Color.Gray;
        mp.BackColor = Color.Gray; 

        E.BackColor = Color.Gray;
        pi.BackColor = Color.Gray;

        sinus.BackColor = Color.Gray;
        cosinus.BackColor = Color.Gray;
        sinush.BackColor = Color.Gray;
        cosinush.BackColor = Color.Gray;
        tangens.BackColor = Color.Gray;
        gradrad.BackColor = Color.Gray;

        del.BackColor = Color.Red;
        clear.BackColor = Color.Red;
    }

    //Diese Methode reagiert auf den Klick auf den Funktions/Shift Button, welcher benoetigt wird,
    //um ein uebersichtlicheres UI zu gewaehrleisten. Dazu werden einem Button mehrere Funktionen
    //zugewiesen anstatt viele neue (Platz einnehmende) Buttons zu erzeugen. Der Button schaltet
    //zwischen Winkelfunktionen und ihren Umkehrfunktionen um.
    void Shift_Click(object sender, EventArgs e)
    {
        if (!function)
        {
            sinus.Click -= Sinus_Click;
            sinus.Click += ASinus_Click;
            cosinus.Click -= Cosinus_Click;
            cosinus.Click += ACosinus_Click;
            tangens.Click -= Tangens_Click;
            tangens.Click += ATangens_Click;
            M.Click -= M_Click;
            M.Click += MC_Click;
            mp.Click -= mp_Click;
            mp.Click += mm_Click;
            factorial.Click -= Factorial_Click;
            factorial.Click += MarketValue_Click;
            square.Click += Pow_Click;
            square.Click -= Square_Click;

            sinus.Text = "arcsin";
            cosinus.Text = "arccos";
            tangens.Text = "arctan";
            factorial.Text = "1/x";
            square.Text = "x^n";
            M.Text = "MC";
            mp.Text = "M-";

            function = true;

            shift.BackColor = Color.Red;
        }

        else
        {
            sinus.Click += Sinus_Click;
            sinus.Click -= ASinus_Click;
            cosinus.Click += Cosinus_Click;
            cosinus.Click -= ACosinus_Click;
            tangens.Click += Tangens_Click;
            tangens.Click -= ATangens_Click;
            M.Click += M_Click;
            M.Click -= MC_Click;
            mp.Click += mp_Click;
            mp.Click -= mm_Click;
            factorial.Click += Factorial_Click;
            factorial.Click -= MarketValue_Click;
            square.Click += Square_Click;
            square.Click -= Pow_Click;
        
            sinus.Text = "sin";
            cosinus.Text = "cos";
            tangens.Text = "tan";
            M.Text = "M";
            factorial.Text = "x!";
            square.Text = "x²";
            mp.Text = "M+";

            function = false;

            shift.BackColor = SystemColors.Control;
        }
    }
//M Funktionen

    // Abspeichern des Inhaltes der Box 
    void M_Click(object sender, EventArgs e)
    {
        if (memory != 0)
            box.Text = memory.ToString(precision);
        new_operand = false;
    }

    //Löschen des Speichers
    void MC_Click(object sender, EventArgs e)
    {
        memory = 0;
        M.BackColor = Color.PaleVioletRed;
    }
    void mp_Click(object sender, EventArgs e)
    {
        memory += double.Parse(box.Text);
        if (memory != 0)
            M.BackColor = Color.PaleVioletRed;
        else
            M.BackColor = Color.Gray;
    }

    void mm_Click(object sender, EventArgs e)
    {
        memory -= double.Parse(box.Text);
        if (memory != 0)
            M.BackColor = Color.PaleVioletRed;
        else
            M.BackColor = Color.Gray;
    }


//Zahlen

    //Diese Methode reagiert auf den Klick auf den Ziffer 0 Button. Dieser erstellt, je nach
    //bisheriger Eingabe entweder eine 0 in der TextBox oder haengt eine '0' an den aktuellen
    //TextBox String an, erweitert somit die Eingabe um eine Zehnerpotenz.
    void Number0_Click(object sender, EventArgs e)
    {
        setOrAddNumber(0);
    }

    //Diese Methode reagiert auf den Klick auf den Ziffer 1 Button. Dieser erstellt, je nach
    //bisheriger Eingabe entweder eine '1' in der TextBox oder haengt eine '1' an den aktuellen
    //TextBox String an.
    void Number1_Click(object sender, EventArgs e)
    {
        setOrAddNumber(1);
    }

    //Diese Methode reagiert auf den Klick auf den Ziffer 2 Button. Dieser erstellt, je nach
    //bisheriger Eingabe entweder eine '2' in der TextBox oder haengt eine '2' an den aktuellen
    //TextBox String an.
    void Number2_Click(object sender, EventArgs e)
    {
        setOrAddNumber(2);
    }

    //Diese Methode reagiert auf den Klick auf den Ziffer 3 Button. Dieser erstellt, je nach
    //bisheriger Eingabe entweder eine '3' in der TextBox oder haengt eine '3' an den aktuellen
    //TextBox String an.
    void Number3_Click(object sender, EventArgs e)
    {
        setOrAddNumber(3);
    }

    //Diese Methode reagiert auf den Klick auf den Ziffer 4 Button. Dieser erstellt, je nach
    //bisheriger Eingabe entweder eine '4' in der TextBox oder haengt eine '4' an den aktuellen
    //TextBox String an.
    void Number4_Click(object sender, EventArgs e)
    {
        setOrAddNumber(4);
    }

    //Diese Methode reagiert auf den Klick auf den Ziffer 5 Button. Dieser erstellt, je nach
    //bisheriger Eingabe entweder eine '5' in der TextBox oder haengt eine '5' an den aktuellen
    //TextBox String an.
    void Number5_Click(object sender, EventArgs e)
    {
        setOrAddNumber(5);
    }

    //Diese Methode reagiert auf den Klick auf den Ziffer 6 Button. Dieser erstellt, je nach
    //bisheriger Eingabe entweder eine '6' in der TextBox oder haengt eine '6' an den aktuellen
    //TextBox String an.
    void Number6_Click(object sender, EventArgs e)
    {
        setOrAddNumber(6);
    }

    //Diese Methode reagiert auf den Klick auf den Ziffer 7 Button. Dieser erstellt, je nach
    //bisheriger Eingabe entweder eine '7' in der TextBox oder haengt eine '7' an den aktuellen
    //TextBox String an.
    void Number7_Click(object sender, EventArgs e)
    {
        setOrAddNumber(7);
    }

    //Diese Methode reagiert auf den Klick auf den Ziffer 8 Button. Dieser erstellt, je nach
    //bisheriger Eingabe entweder eine '8' in der TextBox oder haengt eine '8' an den aktuellen
    //TextBox String an.
    void Number8_Click(object sender, EventArgs e)
    {
        setOrAddNumber(8);
    }

    //Diese Methode reagiert auf den Klick auf den Ziffer 9 Button. Dieser erstellt, je nach
    //bisheriger Eingabe entweder eine '9' in der TextBox oder haengt eine '9' an den aktuellen
    //TextBox String an.
    void Number9_Click(object sender, EventArgs e)
    {
        setOrAddNumber(9);
    }

    //Diese Methode reagiert auf den Klick auf den Button der Konstante Pi. Sie setzt den String der
    //TextBox auf die Konstante Pi.
    void Pi_Click(object sender, EventArgs e)
    {
        box.Text = (Math.PI).ToString(precision);
        new_operand = false;
    }

    void E_Click(object sender, EventArgs e)
    {
        box.Text = (Math.E).ToString(precision);
        new_operand = false;
    }

//Vereinfacht und erweitern die Bedienung des Rechners

    //Diese Methode reagiert auf den Klick auf den Komma Button. Es muss von System zu System,
    //abhaengig von der Sprache, unterschieden werden, ob ein '.' oder ein ',' eingesetzt wird,
    //da Systeme verschieden auf die beiden Zeichen reagieren.
    void Comma_Click(object sender, EventArgs e)
    {
        if (system_language == "de")
        {
            if (!box.Text.Contains(","))
            {
                box.Text += ",";
                input_length += 1;
            }
        }
        else {
            if (!box.Text.Contains("."))
            {
                box.Text += ".";
                input_length += 1;
            }
        }
    }

    //Diese Methode reagiert auf den Klick auf den Clear Button, welcher saemtliche gespeicherten
    //Ergebnisse sowie die aktuelle Eingabe leert.
    void Clear_Click(object sender, EventArgs e)
    {
        box.Text = "0";
        sinus.Text = "sin";
        cosinus.Text = "cos";
        tangens.Text = "tan";
        M.Text = "M";
        mp.Text = "M+";
        shift.BackColor = SystemColors.Control;
        function = false;
        operand1 = 0;
        input_length = 0;
        new_operand = false;
        operation = "none";
    }

//Grundrechenarten

    //Diese Methode reagiert auf den Klick auf den Delete Button, welcher den zuletzt eingegebenen
    //Teil der TextBox entfernt (bspw. im Falle eines Vertippens).
    void Del_Click(object sender, EventArgs e)
    {
        if (!new_operand)
        {
            if (box.Text == "Error")
            {
                box.Text = "0";
                input_length = 0;
            }
            else if ((box.Text.Contains("-") && box.TextLength == 2))
            {
                box.Text = "0";
                input_length = 0;
            }
            else if (box.TextLength == 1)
            {
                box.Text = "0";
                input_length = 0;
            }
            else if (box.TextLength > 1)
            {
                box.Text = box.Text.Substring(0, (box.TextLength - 1));
                input_length -= 1;
            }
        }
    }

    //Diese Methode reagiert auf den Klick auf den Power Button, welcher die aktuelle Eingabe mit
    //einer nach dem Druecken des Buttons eingegebenen Zahl potenziert.
    void Pow_Click(object sender, EventArgs e)
    {
        if (!new_operand)
        {
            perform_current_operation();
        }

        update_operation("pow");
    }


    //Diese Methode reagiert auf den Klick auf den Add Button und bewirkt die Berechnung der Summe
    //der aktuellen Eingabe und einer nach dem Klick einzugebenen Zahl. Die Berechnung wird nach
    //einem weiteren Klick auf eine der Operations Buttons (Add, Subst, Mult, Div) oder den Equals
    //Button ausgefuehrt und angezeigt.
    void Add_Click(object sender, EventArgs e)
    {
        if (!new_operand)
        {
            perform_current_operation();
        }

        update_operation("add");
    }

    //Diese Methode reagiert auf den Klick auf den Subst Button und bewirkt die Berechnung der
    //Differenz der aktuellen Eingabe und einer nach dem Klick einzugebenen Zahl. Die Berechnung
    //wird nach einem weiteren Klick auf eine der Operations Buttons (Add, Subst, Mult, Div) oder
    //den Equals Button ausgefuehrt und angezeigt.
    void Subst_Click(object sender, EventArgs e)
    {
        if (!new_operand)
        {
            perform_current_operation();
        }

        update_operation("subst");
    }

    //Diese Methode reagiert auf den Klick auf den Mult Button und bewirkt die Berechnung des
    //Produkts der aktuellen Eingabe und einer nach dem Klick einzugebenen Zahl. Die Berechnung wird
    //nach einem weiteren Klick auf eine der Operations Buttons (Add, Subst, Mult, Div) oder den
    //Equals Button ausgefuehrt und angezeigt.
    void Mult_Click(object sender, EventArgs e)
    {
        if (!new_operand)
        {
            perform_current_operation();
        }

        update_operation("mult");
    }

    //Diese Methode reagiert auf den Klick auf den Div Button und bewirkt die Berechnung des
    //Quotienten der aktuellen Eingabe und einer nach dem Klick einzugebenen Zahl. Die Berechnung
    //wird nach einem weiteren Klick auf eine der Operations Buttons (Add, Subst, Mult, Div) oder
    //den Equals Button ausgefuehrt und angezeigt.
    void Div_Click(object sender, EventArgs e)
    {
        if (!new_operand)
        {
            perform_current_operation();
        }

        update_operation("div");
    }

//Winkelfunktionen

     //Diese Methode reagiert auf den Klick auf den GradRad Button und schaltet zwischen dem
    //Grad und dem Radian Modus von Winkelfunktionen (0°-360°/0-2*Pi) um.
    void GradRad_Click(object sender, EventArgs e)
    {
        if (gradrad.Text == "Rad")
            gradrad.Text = "Grad"; //Ist noch nicht fertig eingebunden nur der Button steht schon
        else
            gradrad.Text = "Rad";
    }

    //Diese Methode reagiert auf den Klick auf den Sinus Button und bewirkt eine Berechnung des
    //Sinus fuer die aktuelle Eingabe.
    void Sinus_Click(object sender, EventArgs e)
    {
        check_for_error_or_inf();

        if (gradrad.Text == "Rad")
        {
            operand1 = (Math.Sin(double.Parse(box.Text)));
            box.Text = operand1.ToString(precision);
        }
        else if (gradrad.Text == "Grad")
        {
            var temp = double.Parse(box.Text);
            temp *= (Math.PI / 180);
            operand1 = Math.Sin(temp);
            box.Text = operand1.ToString(precision);
        }
        else
        {
            box.Text = "Error";
            operand1 = 0;
            input_length = 0;
        }

        new_operand = true;
    }

    //Diese Methode reagiert auf den Klick auf den Sinush Button und bewirkt eine Berechnung des
    //Sinush fuer die aktuelle Eingabe.
    void Sinush_Click(object sender, EventArgs e)
    {
        check_for_error_or_inf();

        if (gradrad.Text == "Rad")
        {
            operand1 = (Math.Sinh(double.Parse(box.Text)));
            box.Text = operand1.ToString(precision);
        }
        else if (gradrad.Text == "Grad")
        {
            var temp = double.Parse(box.Text);
            temp *= (Math.PI / 180);
            operand1 = Math.Sinh(temp);
            box.Text = operand1.ToString(precision);
        }
        else
        {
            box.Text = "Error";
        }

        new_operand = true;
    }

    //Diese Methode reagiert auf den Klick auf den Cosinus Button und bewirkt eine Berechnung des
    //Cosinus fuer die aktuelle Eingabe.
    void Cosinus_Click(object sender, EventArgs e)
    {
        check_for_error_or_inf();

        if (gradrad.Text == "Rad")
        {
            operand1 = (Math.Cos(double.Parse(box.Text)));
            box.Text = operand1.ToString(precision);
        }
        else if (gradrad.Text == "Grad")
        {
            var temp = double.Parse(box.Text);
            temp *= (Math.PI / 180);
            operand1 = Math.Cos(temp);
            box.Text = operand1.ToString(precision);
        }
        else
        {
            box.Text = "Error";
            operand1 = 0;
            input_length = 0;
        }

        new_operand = true;
    }

    //Diese Methode reagiert auf den Klick auf den Cosinush Button und bewirkt eine Berechnung des
    //Cosinush fuer die aktuelle Eingabe.
    void Cosinush_Click(object sender, EventArgs e)
    {
        check_for_error_or_inf();

        if (gradrad.Text == "Rad")
        {
            operand1 = (Math.Cosh(double.Parse(box.Text)));
            box.Text = operand1.ToString(precision);
        }
        else if (gradrad.Text == "Grad")
        {
            var temp = double.Parse(box.Text);
            temp *= (Math.PI / 180);
            operand1 = Math.Cosh(temp);
            box.Text = operand1.ToString(precision);
        }
        else
        {
            box.Text = "Error";
        }

        new_operand = true;
    }

    //Diese Methode reagiert auf den Klick auf den Tangens Button und bewirkt eine Berechnung des
    //Tangens fuer die aktuelle Eingabe.
    void Tangens_Click(object sender, EventArgs e)
    {
        check_for_error_or_inf();

        if (gradrad.Text == "Rad")
        {
            operand1 = (Math.Tan(double.Parse(box.Text)));
            box.Text = operand1.ToString(precision);
        }
        else if (gradrad.Text == "Grad")
        {
            var temp = double.Parse(box.Text);
            temp *= (Math.PI / 180);
            operand1 = Math.Tan(temp);
            box.Text = operand1.ToString(precision);
        }
        else
        {
            box.Text = "Error";
            operand1 = 0;
            input_length = 0;
        }

        new_operand = true;
    }

    //Diese Methode reagiert auf den Klick auf den ASinus Button und bewirkt eine Berechnung des
    //ArcSinus fuer die aktuelle Eingabe.
    void ASinus_Click(object sender, EventArgs e)
    {
        check_for_error_or_inf();

        if (gradrad.Text == "Rad")
        {
            operand1 = (Math.Asin(double.Parse(box.Text)));
            box.Text = operand1.ToString(precision);
        }
        else if (gradrad.Text == "Grad")
        {
            operand1 = Math.Asin(double.Parse(box.Text)) * 180 / Math.PI;
            box.Text = operand1.ToString(precision);
        }
        else
        {
            box.Text = "Error";
            operand1 = 0;
            input_length = 0;
        }

        new_operand = true;
    }

    //Diese Methode reagiert auf den Klick auf den ACosinus Button und bewirkt eine Berechnung des
    //ArcCosinus fuer die aktuelle Eingabe.
    void ACosinus_Click(object sender, EventArgs e)
    {
        check_for_error_or_inf();

        if (gradrad.Text == "Rad")
        {
            operand1 = (Math.Acos(double.Parse(box.Text)));
            box.Text = operand1.ToString(precision);
        }
        else if (gradrad.Text == "Grad")
        {
            operand1 = Math.Acos(double.Parse(box.Text)) * 180 / Math.PI;
            box.Text = operand1.ToString(precision);
        }
        else
        {
            box.Text = "Error";
            operand1 = 0;
            input_length = 0;
        }

        new_operand = true;
    }

    //Diese Methode reagiert auf den Klick auf den ATangens Button und bewirkt eine Berechnung des
    //ArcTangens fuer die aktuelle Eingabe.
    void ATangens_Click(object sender, EventArgs e)
    {
        check_for_error_or_inf();

        if (gradrad.Text == "Rad")
        {
            operand1 = (Math.Atan(double.Parse(box.Text)));
            box.Text = operand1.ToString(precision);
        }
        else if (gradrad.Text == "Grad")
        {
            operand1 = Math.Atan(double.Parse(box.Text)) * 180 / Math.PI;
            box.Text = operand1.ToString(precision);
        }
        else
        {
            box.Text = "Error";
            operand1 = 0;
            input_length = 0;
        }

        new_operand = true;
    }


//Weitere mathematische Optionen

    //Diese Methode reagiert auf den Klick auf den Factorial Button und bewirkt die Berechnung der
    //Fakultaet (Produkt saemtlicher ganzer Zahlen kleiner gleich der Eingabe). Dabei ist zu
    //beachten, dass die Fakultaet nur fuer natuerliche Zahlen und '0' definiert ist. 
    void Factorial_Click(object sender, EventArgs e)
    {
        check_for_error_or_inf();
        
        double EPSILON = 0.0000000000000001f;
        double temp_max = double.Parse(box.Text);

        if (Math.Abs((temp_max % 1)) < EPSILON)
        {
            double temp = 1;
            for (int i = 1; i <= temp_max; i++)
                temp *= i;

            operand1 = temp;
            box.Text = operand1.ToString(precision);
            new_operand = true;
        }
        else 
        {
            box.Text = "Error";
            new_operand = true;
        }
    }

    //Diese Methode reagiert auf den Klick auf den Factorial Button wenn SHIFT zuvorgedrückt wurde und bewirkt die Berechnung des
    //Kehrwertes. Dabei ist darauf zu achten, dass der Wert ungleich 0 ist.
    void MarketValue_Click(object sender, EventArgs e)
    {
        check_for_error_or_inf();

        double X = double.Parse(box.Text);
        double EPSILON = 0.0000000000000001f;
        if (Math.Abs(X) < EPSILON)
        {
            box.Text = "Error";
            new_operand = true;
        }
        else
        {
            double x = 0;
            x = 1 / X;
            operand1 = x;
            box.Text = operand1.ToString(precision);
            new_operand = true;
        }
    }

    //Diese Methode reagiert auf den Klick auf den Square Button und bewirkt die Quadrierung der
    //aktuellen Eingabe.
    void Square_Click(object sender, EventArgs e)
    {
        check_for_error_or_inf();

        operand1 = double.Parse(box.Text) * double.Parse(box.Text);
        box.Text = operand1.ToString(precision);
        input_length = 0;
        new_operand = true;
    }

    //Diese Methode reagiert auf den Klick auf den Ln Button und bewirkt die Berechnung des
    //natuerlichen Logarithmus der aktuellen Eingabe. Dieser ist nur fuer positive Zahlen
    //definiert.
    void Ln_Click(object sender, EventArgs e)
    {
        check_for_error_or_inf();

        double ln_value = double.Parse(box.Text);

        if (ln_value > 0)
        {
            operand1 = Math.Log(ln_value);
            box.Text = operand1.ToString(precision);
            input_length = 0;
        }
        else
        {
            box.Text = "Error";
            operand1 = 0;
            input_length = 0;
        }
        new_operand = true;
    }

    //Diese Methode reagiert auf den Klick auf den Sqrt Button und berechnet die Quadratwurzel
    //des aktuell eingegebenen Wertes. Ist dieser negativ wird ein Error ausgegeben.
    void Sqrt_Click(object sender, EventArgs e)
    {
        check_for_error_or_inf();

        double sqrt_value = Math.Sqrt(double.Parse(box.Text));

        if (sqrt_value > 0)
        {
            operand1 = Math.Sqrt(double.Parse(box.Text));
            box.Text = operand1.ToString(precision);
        }
        else
        {
            box.Text = "Error";
            operand1 = 0;
            input_length = 0;
        }
        new_operand = true;
    }

    //Diese Methode reagiert auf den Klick auf den Equals Button und bewirkt die Berechnung der
    //aktuelle Operation.
    void Equals_Click(object sender, EventArgs e)
    {
        if (!new_operand)
        {
            perform_current_operation();
        }

        update_operation("none");
    }

//Änderung des Layout und Einbindung weiterer Funktionen

    void Comma_Precision_Click(object sender, EventArgs e)
    {
        setNewPrecision(precision);
    }

    private void perform_current_operation()
    {
        switch (operation)
        {
            case "add":
                operand1 = (operand1 + double.Parse(box.Text));
                box.Text = operand1.ToString(precision);
                break;
            case "subst":
                operand1 = (operand1 - double.Parse(box.Text));
                box.Text = operand1.ToString(precision);
                break;
            case "mult":
                operand1 = (operand1 * double.Parse(box.Text));
                box.Text = operand1.ToString(precision);
                break;
            case "div":
                operand1 = (operand1 / double.Parse(box.Text));
                box.Text = operand1.ToString(precision);
                break;
            case "pow":
                operand1 = (Math.Pow(operand1, double.Parse(box.Text)));
                box.Text = operand1.ToString(precision);
                break;
            case "none":
                operand1 = double.Parse(box.Text);
                break;
        }
    }

    private void update_operation(string new_operation)
    {
        new_operand = true;
        operation = new_operation;
        input_length = 0;
    }

    private void check_for_error_or_inf()
    {
        if (box.Text == "Error" || box.Text == "∞")
            return;
    }

    private void setNewPrecision(string newPrecision)
    {
        if (newPrecision != "g8")
        {
            int newPrecisionInt = int.Parse(newPrecision.Substring(1, 1));
            newPrecisionInt += 1;
            precision = "g" + newPrecisionInt.ToString();
        }
        else
            precision = "g0";

        if (precision == "g1")
            comma_precision.Text = precision.Substring(1, 1) + " Dgt";
        else
            comma_precision.Text = precision.Substring(1, 1) + " Dgts";
    }

    private void setOrAddNumber(int number)
    {
        if (input_length == 0 && box.Text == "0" && number == 0)
        { }
        else if (input_length == 0 || new_operand || box.Text == "∞" || box.Text == "Error")
        {
            box.Text = number.ToString();
            input_length = 1;
        }
        else {
            box.Text += number.ToString();
            input_length += 1;
        }
        new_operand = false;
    }

    private void setCurrentLanguage()
    {
        system_language = 
            System.Globalization.CultureInfo.InstalledUICulture.ToString().Substring(0, 2);
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
