using System;
using System.Windows.Forms;
using System.Drawing;

class calculator : Form
{
    int string_length = 0;
    bool new_operand = false;
    bool set_new_operand = false;
    float operand1 = 0;
    float operand2 = 0;
    string operation;

    //Erstellt Form
    private Form calc;

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
    private Button comma;
    private Button clear;
    private Button add;
    private Button subst;
    private Button mult;
    private Button div;
    private Button equals;
    private Button ToggleLang;

    //Erstellt TextBox
    private TextBox box;


    public calculator ()
    {
        calc = new Form ();

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
        comma = new Button ();
        clear = new Button ();
        add = new Button ();
        subst = new Button ();
        mult = new Button ();
        div = new Button ();
        equals = new Button ();
        ToggleLang = new Button ();

        box = new TextBox ();

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
        comma.Text = (",");
        clear.Text = ("C");
        add.Text = ("+");
        subst.Text = ("-");
        mult.Text = ("*");
        div.Text = ("/");
        equals.Text = ("=");
        ToggleLang.Text = ("EN");

        //Legt Hoehe und Breite der Buttons fest
        number0.Height = 30;
        number0.Width = 30;
        number1.Height = 30;
        number1.Width = 30;
        number2.Height = 30;
        number2.Width = 30;
        number3.Height = 30;
        number3.Width = 30;
        number4.Height = 30;
        number4.Width = 30;
        number5.Height = 30;
        number5.Width = 30;
        number6.Height = 30;
        number6.Width = 30;
        number7.Height = 30;
        number7.Width = 30;
        number8.Height = 30;
        number8.Width = 30;
        number9.Height = 30;
        number9.Width = 30;
        comma.Height = 30;
        comma.Width = 30;
        clear.Height = 30;
        clear.Width = 30;
        add.Height = 30;
        add.Width = 30;
        subst.Height = 30;
        subst.Width = 30;
        mult.Height = 30;
        mult.Width = 30;
        div.Height = 30;
        div.Width = 30;
        equals.Height = 30;
        equals.Width = 30;
        ToggleLang.Height = 30;
        ToggleLang.Width = 30;

        //Legt Hoehe und Breite der Ergebnis-Box fest
        box.Height = 30;
        box.Width = 190;

        //Position der Ergebnis-Box
        box.Location = new Point (10, 10);

        //Positionen der Buttons, zweilenweise
        number7.Location = new Point (10, 100);
        number8.Location = new Point (number7.Left + number8.Width + 10, number7.Top);
        number9.Location = new Point (number8.Left + number9.Width + 10, number7.Top);
        div.Location = new Point (number9.Left + number9.Width + 50, number7.Top);

        number4.Location = new Point (number7.Left, number7.Top + number7.Height + 10);
        number5.Location = new Point (number8.Left, number8.Top + number8.Height + 10);
        number6.Location = new Point (number9.Left, number9.Top + number9.Height + 10);
        mult.Location = new Point (number6.Left + number6.Width + 50, number4.Top);

        number1.Location = new Point (number4.Left, number4.Top + number4.Height + 10);
        number2.Location = new Point (number5.Left, number5.Top + number5.Height + 10);
        number3.Location = new Point (number6.Left, number6.Top + number6.Height + 10);
        subst.Location = new Point (number3.Left + number3.Width + 50, number1.Top);

        number0.Location = new Point (number1.Left, number1.Top + number1.Height + 10);
        comma.Location = new Point (number2.Left, number2.Top + number2.Height + 10);
        equals.Location = new Point (number3.Left, number3.Top + number3.Height + 10);
        clear.Location = new Point (equals.Left + equals.Width + 10, equals.Top);
        add.Location = new Point (equals.Left + clear.Width + 50, number0.Top);

        ToggleLang.Location = new Point (box.Left + box.Width + 10, box.Top);

        //Erstelle EventHandler
        number0.Click += new EventHandler (this.Number0_Click);
        number1.Click += new EventHandler (this.Number1_Click);
        number2.Click += new EventHandler (this.Number2_Click);
        number3.Click += new EventHandler (this.Number3_Click);
        number4.Click += new EventHandler (this.Number4_Click);
        number5.Click += new EventHandler (this.Number5_Click);
        number6.Click += new EventHandler (this.Number6_Click);
        number7.Click += new EventHandler (this.Number7_Click);
        number8.Click += new EventHandler (this.Number8_Click);
        number9.Click += new EventHandler (this.Number9_Click);
        comma.Click += new EventHandler (this.Comma_Click);
        clear.Click += new EventHandler (this.Clear_Click);
        add.Click += new EventHandler (this.Add_Click);
        subst.Click += new EventHandler (this.Subst_Click);
        mult.Click += new EventHandler (this.Mult_Click);
        div.Click += new EventHandler (this.Div_Click);
        equals.Click += new EventHandler (this.Equals_Click);
        ToggleLang.Click += new EventHandler (this.ToggleLang_Click);

        //Setze Ergebnis auf 0
        box.Text = "0";

        //Füge Controls für die Buttons hinzu
        calc.Controls.Add (number0);
        calc.Controls.Add (number1);
        calc.Controls.Add (number2);
        calc.Controls.Add (number3);
        calc.Controls.Add (number4);
        calc.Controls.Add (number5);
        calc.Controls.Add (number6);
        calc.Controls.Add (number7);
        calc.Controls.Add (number8);
        calc.Controls.Add (number9);
        calc.Controls.Add (comma);
        calc.Controls.Add (clear);
        calc.Controls.Add (add);
        calc.Controls.Add (subst);
        calc.Controls.Add (mult);
        calc.Controls.Add (div);
        calc.Controls.Add (box);
        calc.Controls.Add (equals);
        calc.Controls.Add (ToggleLang);

        calc.Text = ("My little calculator");
        calc.FormBorderStyle = FormBorderStyle.FixedDialog;

        calc.ShowDialog ();
    }

    public void change_operation (string new_operation)
    {
        this.operation = new_operation;
    }

    private void Number0_Click (object sender, System.EventArgs e)
    {
        if (string_length == 0)
            string_length += 1;
        else if (new_operand) {
            string_length = 0;
        }
        else {
            box.Text += "0";
            string_length += 1;
        }
        new_operand = false;
    }
    private void Number1_Click (object sender, System.EventArgs e)
    {
        if (string_length == 0 || new_operand) {
            box.Text = "1";
            string_length += 1;
        } else {
            box.Text += "1";
            string_length += 1;
        }
        new_operand = false;
    }
    private void Number2_Click (object sender, System.EventArgs e)
    {
        if (string_length == 0 || new_operand) {
            box.Text = "2";
            string_length += 1;
        } else {
            box.Text += "2";
            string_length += 1;
        }
        new_operand = false;
    }
    private void Number3_Click (object sender, System.EventArgs e)
    {
        if (string_length == 0 || new_operand) {
            box.Text = "3";
            string_length += 1;
        } else {
            box.Text += "3";
            string_length += 1;
        }
        new_operand = false;
    }
    private void Number4_Click (object sender, System.EventArgs e)
    {
        if (string_length == 0 || new_operand) {
            box.Text = "4";
            string_length += 1;
        } else {
            box.Text += "4";
            string_length += 1;
        }
        new_operand = false;
    }
    private void Number5_Click (object sender, System.EventArgs e)
    {
        if (string_length == 0 || new_operand) {
            box.Text = "5";
            string_length += 1;
        } else {
            box.Text += "5";
            string_length += 1;
        }
        new_operand = false;
    }
    private void Number6_Click (object sender, System.EventArgs e)
    {
        if (string_length == 0 || new_operand) {
            box.Text = "6";
            string_length += 1;
        } else {
            box.Text += "6";
            string_length += 1;
        }
        new_operand = false;
    }
    private void Number7_Click (object sender, System.EventArgs e)
    {
        if (string_length == 0 || new_operand) {
            box.Text = "7";
            string_length += 1;
        } else {
            box.Text += "7";
            string_length += 1;
        }
        new_operand = false;
    }
    private void Number8_Click (object sender, System.EventArgs e)
    {
        if (string_length == 0 || new_operand) {
            box.Text = "8";
            string_length += 1;
        } else {
            box.Text += "8";
            string_length += 1;
        }
        new_operand = false;
    }
    private void Number9_Click (object sender, System.EventArgs e)
    {
        if (string_length == 0 || new_operand) {
            box.Text = "9";
            string_length += 1;
        } else {
            box.Text += "9";
            string_length += 1;
        }
        new_operand = false;
    }
    private void Comma_Click (object sender, System.EventArgs e)
    {
        if (ToggleLang.Text == "DE")
            box.Text += ",";
        else
            box.Text += ".";
    }
    private void Clear_Click (object sender, System.EventArgs e)
    {
        box.Text = "0";
        operand1 = 0;
        string_length = 0;
    }
    private void Add_Click (object sender, System.EventArgs e)
    {
        operand1 = float.Parse (box.Text);
        operation = "add";
        new_operand = true;
        set_new_operand = true;
    }
    private void Subst_Click (object sender, System.EventArgs e)
    {
        operand1 = float.Parse (box.Text);
        operation = "subst";
        new_operand = true;
        set_new_operand = true;
    }
    private void Mult_Click (object sender, System.EventArgs e)
    {
        operand1 = float.Parse (box.Text);
        operation = "mult";
        new_operand = true;
        set_new_operand = true;
    }
    private void Div_Click (object sender, System.EventArgs e)
    {
        operand1 = float.Parse (box.Text);
        operation = "div";
        new_operand = true;
        set_new_operand = true;
    }
    private void Equals_Click (object sender, System.EventArgs e)
    {
        if (set_new_operand) {
            operand2 = float.Parse (box.Text);
        } else {
            operand1 = float.Parse (box.Text);
        }

        switch (operation) {
        case "add":
            box.Text = (operand1 + operand2).ToString ();
            break;
        case "subst":
            box.Text = (operand1 - operand2).ToString ();
            break;
        case "mult":
            box.Text = (operand1 * operand2).ToString ();
            break;
        case "div":
            box.Text = (operand1 / operand2).ToString ();
            break;
        }

        set_new_operand = false;
        new_operand = true;
    }
    private void ToggleLang_Click (object sender, System.EventArgs e)
    {
        if (ToggleLang.Text == "EN")
            ToggleLang.Text = "DE";
        else
            ToggleLang.Text = "EN";
    }
}
class MainClass
{
    public static void Main (string [] args)
    {
        Application.Run (new calculator ());
        var language = System.Threading.Thread.CurrentThread.CurrentCulture;
    }
}