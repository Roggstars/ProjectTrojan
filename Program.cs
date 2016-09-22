using System;
using System.Windows.Forms;
using System.Drawing;

class calculator : Form
{
    int input_length = 0;
    bool new_operand = false;
    float operand1 = 0;
    string operation = "none";

    //Erstellt Buttons
    private Button number0;
    private Button number1;
    private Button number2;
    private Button number3;
    private Button number4;
    private Button number5;
    private Button number6;
    private Button number7;
    private Button number8;
    private Button number9;
    private Button pi;
    private Button E;
    private Button comma;
    private Button clear;
    private Button add;
    private Button subst;
    private Button mult;
    private Button div;
    private Button square;
    private Button sqrt;
    private Button pow;
    private Button equals;
    private Button ToggleLang;
    private Button Exit;
    private Button del;
    private Button plus_minus;
    private Button faculty;
    private Button ln;
    private Button sinus;
    private Button cosinus;
    private Button tangens;
    private Button gradrad;

    private CheckBox math;

    //Erstellt TextBox
    private TextBox box;

    public calculator()
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
        E = new Button();
        comma = new Button();
        clear = new Button();
        add = new Button();
        subst = new Button();
        mult = new Button();
        div = new Button();
        square = new Button();
        sqrt = new Button();
        pow = new Button();
        equals = new Button();
        ToggleLang = new Button();
        Exit = new Button();
        del = new Button();
        plus_minus = new Button();
        faculty = new Button();
        ln = new Button();
        sinus = new Button();
        cosinus = new Button();
        tangens = new Button();
        gradrad = new Button();

        math = new CheckBox();

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
        pow.Text = ("x^n");
        sqrt.Text = ("√¯x");
        equals.Text = ("=");
        ToggleLang.Text = ("EN");
        Exit.Text = ("ESC");
        del.Text = ("DEL");
        plus_minus.Text = ("+/-");
        faculty.Text = ("x!");
        ln.Text = ("ln");
        math.Text = (" ");
        sinus.Text = ("sin");
        cosinus.Text = ("cos");
        tangens.Text = ("tan");
        gradrad.Text = ("Rad");

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
        pow.Height = 50;
        pow.Width = 50;
        sqrt.Height = 50;
        sqrt.Width = 50;
        equals.Height = 50;
        equals.Width = 50;
        ToggleLang.Height = 50;
        ToggleLang.Width = 50;
        Exit.Height = 50;
        Exit.Width = 50;
        del.Height = 50;
        del.Width = 50;
        plus_minus.Height = 50;
        plus_minus.Width = 50;
        faculty.Height = 50;
        faculty.Width = 50;
        ln.Height = 50;
        ln.Width = 50;
        sinus.Height = 50;
        sinus.Width = 50;
        cosinus.Height = 50;
        cosinus.Width = 50;
        tangens.Width = 50;
        tangens.Height = 50;
        gradrad.Height = 50;
        gradrad.Width = 50;


        math.Height = 50;
        math.Width = 50;

        //Legt Hoehe und Breite der Ergebnis-Box fest
        box.Height = 50;
        box.Width = 300;

        //Position der Ergebnis-Box
        box.Location = new Point(5, 5);

        //Positionen der Buttons
        square.Location = new Point(box.Left, box.Top + box.Height + 50);
        pow.Location = new Point(square.Left + pow.Width, square.Top);
        sqrt.Location = new Point(pow.Left + sqrt.Width, square.Top);
        faculty.Location = new Point(sqrt.Left + 10 + faculty.Width, sqrt.Top);
        ln.Location = new Point(faculty.Left + ln.Width, faculty.Top);

        number7.Location = new Point(box.Left, box.Top + box.Height + 110);
        number8.Location = new Point(number7.Left + number8.Width, number7.Top);
        number9.Location = new Point(number8.Left + number9.Width, number7.Top);

        number4.Location = new Point(number7.Left, number7.Top + number7.Height);
        number5.Location = new Point(number8.Left, number8.Top + number8.Height);
        number6.Location = new Point(number9.Left, number9.Top + number9.Height);

        number1.Location = new Point(number4.Left, number4.Top + number4.Height);
        number2.Location = new Point(number5.Left, number5.Top + number5.Height);
        number3.Location = new Point(number6.Left, number6.Top + number6.Height);

        number0.Location = new Point(number1.Left, number1.Top + number1.Height);
        comma.Location = new Point(number2.Left, number2.Top + number2.Height);
        plus_minus.Location = new Point(comma.Left + plus_minus.Width, comma.Top);
        equals.Location = new Point(comma.Left + comma.Height + comma.Height + 10, comma.Top);
        add.Location = new Point(number3.Left + number3.Width + 10, number3.Top);
        subst.Location = new Point(add.Left + add.Width, add.Top);
        mult.Location = new Point(number6.Left + number6.Width + 10, number6.Top);
        div.Location = new Point(mult.Left + mult.Width, mult.Top);

        pi.Location = new Point(div.Left + div.Width + 10, div.Top);
        E.Location = new Point(pi.Left, pi.Top + pi.Height);
        del.Location = new Point(number9.Left + del.Width + 10, number9.Top);
        clear.Location = new Point(del.Left + clear.Width, del.Top);
        Exit.Location = new Point(box.Left + box.Width + 10, box.Top);
        ToggleLang.Location = new Point(Exit.Left, Exit.Top + Exit.Height);
        sinus.Location = new Point(10, 8);
        cosinus.Location = new Point(10, 8);
        tangens.Location = new Point(10, 8);
        gradrad.Location = new Point(10, 8);

        math.Location = new Point(ToggleLang.Left, ToggleLang.Top + ToggleLang.Height);

        //Erstelle EventHandler
        number0.Click += new EventHandler(this.Number0_Click);
        number1.Click += new EventHandler(this.Number1_Click);
        number2.Click += new EventHandler(this.Number2_Click);
        number3.Click += new EventHandler(this.Number3_Click);
        number4.Click += new EventHandler(this.Number4_Click);
        number5.Click += new EventHandler(this.Number5_Click);
        number6.Click += new EventHandler(this.Number6_Click);
        number7.Click += new EventHandler(this.Number7_Click);
        number8.Click += new EventHandler(this.Number8_Click);
        number9.Click += new EventHandler(this.Number9_Click);
        pi.Click += new EventHandler(this.Pi_Click);
        E.Click += new EventHandler(this.E_Click);
        comma.Click += new EventHandler(this.Comma_Click);
        clear.Click += new EventHandler(this.Clear_Click);
        add.Click += new EventHandler(this.Add_Click);
        subst.Click += new EventHandler(this.Subst_Click);
        mult.Click += new EventHandler(this.Mult_Click);
        div.Click += new EventHandler(this.Div_Click);
        square.Click += new EventHandler(this.Square_Click);
        pow.Click += new EventHandler(this.Pow_Click);
        sqrt.Click += new EventHandler(this.Sqrt_Click);
        equals.Click += new EventHandler(this.Equals_Click);
        ToggleLang.Click += new EventHandler(this.ToggleLang_Click);
        del.Click += new EventHandler(this.Del_Click);
        Exit.Click += new EventHandler(this.Exit_Click);
        plus_minus.Click += new EventHandler(this.Plus_Minus_Click);
        faculty.Click += new EventHandler(this.Factorial_Click);
        ln.Click += new EventHandler(this.Ln_Click);
        sinus.Click += new EventHandler(this.Sinus_Click);
        cosinus.Click += new EventHandler(this.Cosinus_Click);
        tangens.Click += new EventHandler(this.Tangens_Click);
        gradrad.Click += new EventHandler(this.GradRad_Click);

        math.Click += new EventHandler(this.math_Click);

        //Setze Ergebnis auf 0
        box.Text = "0";
        //Füge Controls für die Buttons hinzu
        this.Controls.Add(number0);
        this.Controls.Add(number1);
        this.Controls.Add(number2);
        this.Controls.Add(number3);
        this.Controls.Add(number4);
        this.Controls.Add(number5);
        this.Controls.Add(number6);
        this.Controls.Add(number7);
        this.Controls.Add(number8);
        this.Controls.Add(number9);
        this.Controls.Add(pi);
        this.Controls.Add(E);
        this.Controls.Add(comma);
        this.Controls.Add(clear);
        this.Controls.Add(add);
        this.Controls.Add(subst);
        this.Controls.Add(mult);
        this.Controls.Add(div);
        this.Controls.Add(square);
        this.Controls.Add(pow);
        this.Controls.Add(sqrt);
        this.Controls.Add(box);
        this.Controls.Add(equals);
        this.Controls.Add(ToggleLang);
        this.Controls.Add(Exit);
        this.Controls.Add(del);
        this.Controls.Add(plus_minus);
        this.Controls.Add(faculty);
        this.Controls.Add(ln);
        this.Controls.Add(sinus);
        this.Controls.Add(cosinus);
        this.Controls.Add(tangens);
        this.Controls.Add(gradrad);


        this.Controls.Add(math);

        this.Text = ("My little calculator");
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MinimizeBox = false;
        this.MaximizeBox = false;

        this.Size = new System.Drawing.Size(390, 400);

        //Farben
        Exit.BackColor = Color.IndianRed;
        box.Font = new System.Drawing.Font("Arial", 30, FontStyle.Bold);
        box.TextAlign = HorizontalAlignment.Right;
        box.ForeColor = Color.WhiteSmoke;
        box.BackColor = Color.Black;
        add.BackColor = Color.Orange;
        subst.BackColor = Color.Orange;
        mult.BackColor = Color.Orange;
        div.BackColor = Color.Orange;
        square.BackColor = Color.Gray;
        pow.BackColor = Color.Gray;
        sqrt.BackColor = Color.Gray;
        faculty.BackColor = Color.Gray;
        equals.BackColor = Color.Orange;
        ln.BackColor = Color.Gray;

        E.BackColor = Color.Gray;
        pi.BackColor = Color.Gray;

        sinus.BackColor = Color.Gray;
        cosinus.BackColor = Color.Gray;
        tangens.BackColor = Color.Gray;
        gradrad.BackColor = Color.Gray;

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

        del.BackColor = Color.Red;
        clear.BackColor = Color.Red;
    }

    private void Number0_Click(object sender, System.EventArgs e)
    {
        if (box.Text == "Error")
        {
            box.Text = "0";
            input_length = 0;
        }      
        else if (input_length == 0 && box.Text == "0")
        { }
        else if (input_length == 0 && box.Text != "0" || box.Text == "∞")
        {
            box.Text = "0";
        }
        else if (new_operand)
        {
            input_length = 0;
        }
        else {
            box.Text += "0";
            input_length += 1;
        }
        new_operand = false;
    }

    private void Number1_Click(object sender, System.EventArgs e)
    {
        if (box.Text == "Error")
        {
            box.Text = "1";
            input_length = 1;
        }
        else if (input_length == 0 || new_operand || box.Text == "∞")
        {
            box.Text = "1";
            input_length = 1;
        }
        else {
            box.Text += "1";
            input_length += 1;
        }
        new_operand = false;
    }

    private void Number2_Click(object sender, System.EventArgs e)
    {
        if (box.Text == "Error")
        {
            box.Text = "2";
            input_length = 1;
        }
        else if (input_length == 0 || new_operand || box.Text == "∞")
        {
            box.Text = "2";
            input_length = 1;
        }
        else {
            box.Text += "2";
            input_length += 1;
        }
        new_operand = false;
    }

    private void Number3_Click(object sender, System.EventArgs e)
    {
        if (box.Text == "Error")
        {
            box.Text = "3";
            input_length = 1;
        }
        else if (input_length == 0 || new_operand || box.Text == "∞")
        {
            box.Text = "3";
            input_length = 1;
        }
        else {
            box.Text += "3";
            input_length += 1;
        }
        new_operand = false;
    }

    private void Number4_Click(object sender, System.EventArgs e)
    {
        if (box.Text == "Error")
        {
            box.Text = "4";
            input_length = 1;
        }
        else if (input_length == 0 || new_operand || box.Text == "∞")
        {
            box.Text = "4";
            input_length = 1;
        }
        else {
            box.Text += "4";
            input_length += 1;
        }
        new_operand = false;
    }

    private void Number5_Click(object sender, System.EventArgs e)
    {
        if (box.Text == "Error")
        {
            box.Text = "5";
            input_length = 1;
        }
        else if (input_length == 0 || new_operand || box.Text == "∞")
        {
            box.Text = "5";
            input_length = 1;
        }
        else {
            box.Text += "5";
            input_length += 1;
        }
        new_operand = false;
    }

    private void Number6_Click(object sender, System.EventArgs e)
    {
        if (box.Text == "Error")
        {
            box.Text = "6";
            input_length = 1;
        }
        else if (input_length == 0 || new_operand || box.Text == "∞")
        {
            box.Text = "6";
            input_length = 1;
        }
        else {
            box.Text += "6";
            input_length += 1;
        }
        new_operand = false;
    }

    private void Number7_Click(object sender, System.EventArgs e)
    {
        if (box.Text == "Error")
        {
            box.Text = "7";
            input_length = 1;
        }
        else if (input_length == 0 || new_operand || box.Text == "∞")
        {
            box.Text = "7";
            input_length = 1;
        }
        else {
            box.Text += "7";
            input_length += 1;
        }
        new_operand = false;
    }

    private void Number8_Click(object sender, System.EventArgs e)
    {
        if (box.Text == "Error")
        {
            box.Text = "8";
            input_length = 1;
        }
        else if (input_length == 0 || new_operand || box.Text == "∞")
        {
            box.Text = "8";
            input_length = 1;
        }
        else {
            box.Text += "8";
            input_length += 1;
        }
        new_operand = false;
    }

    private void Number9_Click(object sender, System.EventArgs e)
    {
        if (box.Text == "Error")
        {
            box.Text = "9";
            input_length = 1;
        }
        else if (input_length == 0 || new_operand || box.Text == "∞")
        {
            box.Text = "9";
            input_length = 1;
        }
        else {
            box.Text += "9";
            input_length += 1;
        }
        new_operand = false;
    }

      private void Pi_Click (object sender, System.EventArgs e)
    {
        box.Text = (Math.PI).ToString();
    }
    private void E_Click(object sender, System.EventArgs e)
    {
        box.Text = (Math.E).ToString();
    }

    private void Comma_Click(object sender, System.EventArgs e)
    {
        if (ToggleLang.Text == "DE")
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
    private void Del_Click(object sender, System.EventArgs e)
    {
        if (new_operand == false)
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

    private void Clear_Click(object sender, System.EventArgs e)
    {
        box.Text = "0";
        operand1 = 0;
        input_length = 0;
        new_operand = false;
        operation = "none";
    }

    private void Pow_Click(object sender, System.EventArgs e)
    {
        if (!new_operand)
        {
            switch (operation)
            {
                case "add":
                    box.Text = (operand1 + float.Parse(box.Text)).ToString();
                    break;
                case "subst":
                    box.Text = (operand1 - float.Parse(box.Text)).ToString();
                    break;
                case "mult":
                    box.Text = (operand1 * float.Parse(box.Text)).ToString();
                    break;
                case "div":
                    box.Text = (operand1 / float.Parse(box.Text)).ToString();
                    break;
                case "pow":
                    box.Text = (Math.Pow(operand1, float.Parse(box.Text))).ToString();
                    break;
            }
        }
        operand1 = float.Parse(box.Text);
        operation = "pow";
        input_length = 0;
        new_operand = true;
    }

    private void Plus_Minus_Click(object sender, System.EventArgs e)
    {
        if (box.Text != "0" && !box.Text.Contains("-"))
            box.Text = "-" + box.Text;
        else if (box.Text != "0" && box.Text.Contains("-"))
            box.Text = box.Text.TrimStart('-');
    }
    private void GradRad_Click(object sender, System.EventArgs e)
    {
        if (gradrad.Text == "Rad")
            gradrad.Text = "Grad";
        else
            gradrad.Text = "Rad";
    }

    private void Sinus_Click(object sender, System.EventArgs e)
    {
        box.Text = (Math.Sin(float.Parse(box.Text))).ToString();
        input_length = 0;
    }
    private void Cosinus_Click(object sender, System.EventArgs e)
    {
        box.Text = (Math.Cos(float.Parse(box.Text))).ToString();
        input_length = 0;
    }
    private void Tangens_Click(object sender, System.EventArgs e)
    {
        box.Text = (Math.Tan(float.Parse(box.Text))).ToString();
        input_length = 0;
    }

    private void Factorial_Click(object sender, System.EventArgs e)
    {
        float temp_max = float.Parse(box.Text);
        float temp = 1;
        for (int i = 1; i <= temp_max; i++)
            temp *= i;

        int fac_max = (int)temp_max;
        int fac = 1;
        for (int i = 1; i <= fac_max; i++)
            fac *= i;

        int temp_int = (int)temp;
        if (temp_int == fac)
        {
            box.Text = temp.ToString();
            input_length = 0;
        }
        else {
            box.Text = "Error";
            input_length = 0;
        }
    }
        
    private void Add_Click(object sender, System.EventArgs e)
    {
        if (!new_operand)
        {
            switch (operation)
            {
                case "add":
                    box.Text = (operand1 + float.Parse(box.Text)).ToString();
                    break;
                case "subst":
                    box.Text = (operand1 - float.Parse(box.Text)).ToString();
                    break;
                case "mult":
                    box.Text = (operand1 * float.Parse(box.Text)).ToString();
                    break;
                case "div":
                    box.Text = (operand1 / float.Parse(box.Text)).ToString();
                    break;
                case "pow":
                    box.Text = (Math.Pow(operand1, float.Parse(box.Text))).ToString();
                    break;
            }
        }

        operand1 = float.Parse(box.Text);
        operation = "add";
        input_length = 0;
        new_operand = true;
    }

    private void Subst_Click(object sender, System.EventArgs e)
    {
        if (!new_operand)
        {
            switch (operation)
            {
                case "add":
                    box.Text = (operand1 + float.Parse(box.Text)).ToString();
                    break;
                case "subst":
                    box.Text = (operand1 - float.Parse(box.Text)).ToString();
                    break;
                case "mult":
                    box.Text = (operand1 * float.Parse(box.Text)).ToString();
                    break;
                case "div":
                    box.Text = (operand1 / float.Parse(box.Text)).ToString();
                    break;
                case "pow":
                    box.Text = (Math.Pow(operand1, float.Parse(box.Text))).ToString();
                    break;
            }
        }

        operand1 = float.Parse(box.Text);
        operation = "subst";
        input_length = 0;
        new_operand = true;
    }

    private void Mult_Click(object sender, System.EventArgs e)
    {
        if (!new_operand)
        {
            switch (operation)
            {
                case "add":
                    box.Text = (operand1 + float.Parse(box.Text)).ToString();
                    break;
                case "subst":
                    box.Text = (operand1 - float.Parse(box.Text)).ToString();
                    break;
                case "mult":
                    box.Text = (operand1 * float.Parse(box.Text)).ToString();
                    break;
                case "div":
                    box.Text = (operand1 / float.Parse(box.Text)).ToString();
                    break;
                case "pow":
                    box.Text = (Math.Pow(operand1, float.Parse(box.Text))).ToString();
                    break;
            }
        }

        operand1 = float.Parse(box.Text);
        operation = "mult";
        input_length = 0;
        new_operand = true;
    }

    private void Div_Click(object sender, System.EventArgs e)
    {
        if (!new_operand)
        {
            switch (operation)
            {
                case "add":
                    box.Text = (operand1 + float.Parse(box.Text)).ToString();
                    break;
                case "subst":
                    box.Text = (operand1 - float.Parse(box.Text)).ToString();
                    break;
                case "mult":
                    box.Text = (operand1 * float.Parse(box.Text)).ToString();
                    break;
                case "div":
                    box.Text = (operand1 / float.Parse(box.Text)).ToString();
                    break;
                case "pow":
                    box.Text = (Math.Pow(operand1, float.Parse(box.Text))).ToString();
                    break;
            }
        }

        operand1 = float.Parse(box.Text);
        operation = "div";
        input_length = 0;
        new_operand = true;
    }

    private void Square_Click(object sender, System.EventArgs e)
    {
        box.Text = (float.Parse(box.Text) * float.Parse(box.Text)).ToString();
        input_length = 0;
    }
    private void Ln_Click(object sender, System.EventArgs e)
    {
      double ln_value = float.Parse(box.Text);

        if (ln_value > 0)
        {
            box.Text = (Math.Log(ln_value)).ToString();
            input_length = 0;
        }
        else box.Text = "Error";
    }

    private void Sqrt_Click(object sender, System.EventArgs e)
    {
        box.Text = (Math.Sqrt(float.Parse(box.Text))).ToString();
        input_length = 0;
    }

    private void Equals_Click(object sender, System.EventArgs e)
    {
        if (!new_operand)
        {
            switch (operation)
            {
                case "add":
                    box.Text = (operand1 + float.Parse(box.Text)).ToString();
                    break;
                case "subst":
                    box.Text = (operand1 - float.Parse(box.Text)).ToString();
                    break;
                case "mult":
                    box.Text = (operand1 * float.Parse(box.Text)).ToString();
                    break;
                case "div":
                    box.Text = (operand1 / float.Parse(box.Text)).ToString();
                    break;
                case "pow":
                    box.Text = (Math.Pow(operand1, float.Parse(box.Text))).ToString();
                    break;
                case "none":
                    break;
            }
        }

        new_operand = true;
        operation = "none";
        input_length = 0;
    }
    private void math_Click(object sender, System.EventArgs e)
    {
        if (math.Checked)
        {
            this.Size = new System.Drawing.Size(390, 450);
            square.Location = new Point(box.Left, box.Top + box.Height + 60);
            pow.Location = new Point(square.Left + pow.Width, square.Top);
            sqrt.Location = new Point(pow.Left + sqrt.Width, square.Top);
            faculty.Location = new Point(sqrt.Left + 10 + faculty.Width, sqrt.Top);
            ln.Location = new Point(faculty.Left + ln.Width, faculty.Top);

            number7.Location = new Point(box.Left, box.Top + box.Height + 130);
            number8.Location = new Point(number7.Left + number8.Width, number7.Top);
            number9.Location = new Point(number8.Left + number9.Width, number7.Top);

            number4.Location = new Point(number7.Left, number7.Top + number7.Height);
            number5.Location = new Point(number8.Left, number8.Top + number8.Height);
            number6.Location = new Point(number9.Left, number9.Top + number9.Height);

            number1.Location = new Point(number4.Left, number4.Top + number4.Height);
            number2.Location = new Point(number5.Left, number5.Top + number5.Height);
            number3.Location = new Point(number6.Left, number6.Top + number6.Height);

            number0.Location = new Point(number1.Left, number1.Top + number1.Height);
            comma.Location = new Point(number2.Left, number2.Top + number2.Height);
            plus_minus.Location = new Point(comma.Left + plus_minus.Width, comma.Top);
            equals.Location = new Point(comma.Left + comma.Height + comma.Height + 10, comma.Top);
            add.Location = new Point(number3.Left + number3.Width + 10, number3.Top);
            subst.Location = new Point(add.Left + add.Width, add.Top);
            mult.Location = new Point(number6.Left + number6.Width + 10, number6.Top);
            div.Location = new Point(mult.Left + mult.Width, mult.Top);
            del.Location = new Point(number9.Left + del.Width + 10, number9.Top);
            clear.Location = new Point(del.Left + clear.Width, del.Top);
            pi.Location = new Point(div.Left + div.Width + 10, div.Top);
            E.Location = new Point(pi.Left, pi.Top + pi.Height);


            sinus.Location = new Point(box.Left, box.Top + box.Height + 10);
            cosinus.Location = new Point(sinus.Left + sinus.Height, sinus.Top);
            tangens.Location = new Point(cosinus.Left + cosinus.Height, sinus.Top);
            gradrad.Location = new Point(tangens.Left + tangens.Height + 10, sinus.Top);
        }
        else {
            this.Size = new System.Drawing.Size(390, 400);

            square.Location = new Point(box.Left, box.Top + box.Height + 10);
            pow.Location = new Point(square.Left + pow.Width, square.Top);
            sqrt.Location = new Point(pow.Left + sqrt.Width, square.Top);
            faculty.Location = new Point(sqrt.Left + 10 + faculty.Width, sqrt.Top);
            ln.Location = new Point(faculty.Left + ln.Width, faculty.Top);

            number7.Location = new Point(box.Left, box.Top + box.Height + 70);
            number8.Location = new Point(number7.Left + number8.Width, number7.Top);
            number9.Location = new Point(number8.Left + number9.Width, number7.Top);

            number4.Location = new Point(number7.Left, number7.Top + number7.Height);
            number5.Location = new Point(number8.Left, number8.Top + number8.Height);
            number6.Location = new Point(number9.Left, number9.Top + number9.Height);

            number1.Location = new Point(number4.Left, number4.Top + number4.Height);
            number2.Location = new Point(number5.Left, number5.Top + number5.Height);
            number3.Location = new Point(number6.Left, number6.Top + number6.Height);

            number0.Location = new Point(number1.Left, number1.Top + number1.Height);
            comma.Location = new Point(number2.Left, number2.Top + number2.Height);
            plus_minus.Location = new Point(comma.Left + plus_minus.Width, comma.Top);
            equals.Location = new Point(comma.Left + comma.Height + comma.Height + 10, comma.Top);
            add.Location = new Point(number3.Left + number3.Width + 10, number3.Top);
            subst.Location = new Point(add.Left + add.Width, add.Top);
            mult.Location = new Point(number6.Left + number6.Width + 10, number6.Top);
            div.Location = new Point(mult.Left + mult.Width, mult.Top);
            del.Location = new Point(number9.Left + del.Width + 10, number9.Top);
            clear.Location = new Point(del.Left + clear.Width, del.Top);
            pi.Location = new Point(div.Left + div.Width + 10, div.Top);
            E.Location = new Point(pi.Left, pi.Top + pi.Height);

            sinus.Location = new Point(10,8);
            cosinus.Location = new Point(10,8);
            tangens.Location = new Point(10,8);
            gradrad.Location = new Point(10,8);
        }
    }

    private void ToggleLang_Click(object sender, System.EventArgs e)
    {
        if (ToggleLang.Text == "EN")
            ToggleLang.Text = "DE";
        else
            ToggleLang.Text = "EN";
    }

    private void Exit_Click(object sender, System.EventArgs e)
    {
        Environment.Exit(0);
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Application.Run(new calculator());
        return;
	}
}
