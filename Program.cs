using System;
using System.Windows.Forms;
using System.Drawing;

class calculator : Form
{
	int input_length = 0;
	bool new_operand = false;
	bool set_new_operand = false;
	bool newoperand = false;
	bool setnewoperand = false;
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
	//private Button pi;
	private Button comma;
	private Button clear;
	private Button add;
	private Button subst;
	private Button mult;
	private Button div;
	private Button square;
	private Button sqrt;
	private Button equals;
	private Button ToggleLang;
    private Button Exit;

	//Erstellt TextBox
	private TextBox box;
	private TextBox checkbox;

	public calculator()
	{
		calc = new Form();

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
		//pi = new Button ();
		comma = new Button();
		clear = new Button();
		add = new Button();
		subst = new Button();
		mult = new Button();
		div = new Button();
		square = new Button();
		sqrt = new Button();
		equals = new Button();
		ToggleLang = new Button();
        Exit = new Button();

		box = new TextBox();
		checkbox = new TextBox();
		//Setzt Box auf ReadOnly
		box.ReadOnly = true;
		checkbox.ReadOnly = true;
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
		//pi.Text = ("pi");
		comma.Text = (",");
		clear.Text = ("C");
		add.Text = ("+");
		subst.Text = ("-");
		mult.Text = ("*");
		div.Text = ("/");
		square.Text = ("^2");
		sqrt.Text = ("√¯");
		equals.Text = ("=");
		ToggleLang.Text = ("EN");
        Exit.Text = ("ESC");

		//Legt Hoehe und Breite der Buttons fest
		number0.Height = 40;
		number0.Width = 40;
		number1.Height = 40;
		number1.Width = 40;
		number2.Height = 40;
		number2.Width = 40;
		number3.Height = 40;
		number3.Width = 40;
		number4.Height = 40;
		number4.Width = 40;
		number5.Height = 40;
		number5.Width = 40;
		number6.Height = 40;
		number6.Width = 40;
		number7.Height = 40;
		number7.Width = 40;
		number8.Height = 40;
		number8.Width = 40;
		number9.Height = 40;
		number9.Width = 40;
		//pi.Height = 40;
		//pi.Width = 40;
		comma.Height = 40;
		comma.Width = 40;
		clear.Height = 40;
		clear.Width = 40;
		add.Height = 40;
		add.Width = 40;
		subst.Height = 40;
		subst.Width = 40;
		mult.Height = 40;
		mult.Width = 40;
		div.Height = 40;
		div.Width = 40;
		square.Height = 40;
		square.Width = 40;
		sqrt.Height = 40;
		sqrt.Width = 40;
		equals.Height = 40;
		equals.Width = 40;
		ToggleLang.Height = 40;
		ToggleLang.Width = 40;
        Exit.Height = 40;
        Exit.Width = 40;

		//Legt Hoehe und Breite der Ergebnis-Box fest
		box.Height = 40;
		box.Width = 140;

		//legt Hoehe und Breite der Rechen-Box fest
		checkbox.Height = 40;
		checkbox.Width = 140;

		//Position der Ergebnis-Box
		box.Location = new Point(10, 10);

		//Position der Rechen-Box
		checkbox.Location = new Point(10, 40);

		//Positionen der Buttons, zweilenweise
		number7.Location = new Point(checkbox.Left, checkbox.Top + checkbox.Height + 10);
		number8.Location = new Point(number7.Left + number8.Width + 10, number7.Top);
		number9.Location = new Point(number8.Left + number9.Width + 10, number7.Top);
		div.Location = new Point(number9.Left + number9.Width + 50, number7.Top);

		number4.Location = new Point(number7.Left, number7.Top + number7.Height + 10);
		number5.Location = new Point(number8.Left, number8.Top + number8.Height + 10);
		number6.Location = new Point(number9.Left, number9.Top + number9.Height + 10);
		mult.Location = new Point(number6.Left + number6.Width + 50, number4.Top);

		number1.Location = new Point(number4.Left, number4.Top + number4.Height + 10);
		number2.Location = new Point(number5.Left, number5.Top + number5.Height + 10);
		number3.Location = new Point(number6.Left, number6.Top + number6.Height + 10);
		//pi.Location = new Point (number3.Left + number3.Width + 10, number3.Top);
		subst.Location = new Point(number3.Left + number3.Width + 50, number1.Top);
		sqrt.Location = new Point(number3.Left + number3.Width + subst.Width + 50, number1.Top);

		number0.Location = new Point(number1.Left, number1.Top + number1.Height + 10);
		comma.Location = new Point(number2.Left, number2.Top + number2.Height + 10);
		equals.Location = new Point(number3.Left, number3.Top + number3.Height + 10);
		clear.Location = new Point(equals.Left + equals.Width + 10, equals.Top);
		add.Location = new Point(equals.Left + clear.Width + 50, number0.Top);
		square.Location = new Point(equals.Left + clear.Width + add.Width + 50, number0.Top);

		ToggleLang.Location = new Point(box.Left + box.Width + 10, box.Top);
        Exit.Location = new Point(ToggleLang.Left + ToggleLang.Width + 10, ToggleLang.Top);

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
		//pi.Click += new EventHandler (this.Pi_Click);
		comma.Click += new EventHandler(this.Comma_Click);
		clear.Click += new EventHandler(this.Clear_Click);
		add.Click += new EventHandler(this.Add_Click);
		subst.Click += new EventHandler(this.Subst_Click);
		mult.Click += new EventHandler(this.Mult_Click);
		div.Click += new EventHandler(this.Div_Click);
		square.Click += new EventHandler(this.Square_Click);
		sqrt.Click += new EventHandler(this.Sqrt_Click);
		equals.Click += new EventHandler(this.Equals_Click);
		ToggleLang.Click += new EventHandler(this.ToggleLang_Click);
        Exit.Click += new EventHandler(this.Exit_Click);

		//Setze Ergebnis auf 0
		box.Text = "0";
		//Setzt Eingabe auf null
		checkbox.Text = "0";

		//Füge Controls für die Buttons hinzu
		calc.Controls.Add(number0);
		calc.Controls.Add(number1);
		calc.Controls.Add(number2);
		calc.Controls.Add(number3);
		calc.Controls.Add(number4);
		calc.Controls.Add(number5);
		calc.Controls.Add(number6);
		calc.Controls.Add(number7);
		calc.Controls.Add(number8);
		calc.Controls.Add(number9);
		//calc.Controls.Add (pi);
		calc.Controls.Add(comma);
		calc.Controls.Add(clear);
		calc.Controls.Add(add);
		calc.Controls.Add(subst);
		calc.Controls.Add(mult);
		calc.Controls.Add(div);
		calc.Controls.Add(square);
		calc.Controls.Add(sqrt);
		calc.Controls.Add(box);
		calc.Controls.Add(checkbox);
		calc.Controls.Add(equals);
		calc.Controls.Add(ToggleLang);
        calc.Controls.Add(Exit);

		calc.Text = ("My little calculator");
		calc.FormBorderStyle = FormBorderStyle.FixedDialog;
        calc.MinimizeBox = false;
        calc.MaximizeBox = false;

		calc.ShowDialog();
	}

	public void change_operation(string new_operation)
	{
		this.operation = new_operation;
	}

	private void Number0_Click(object sender, System.EventArgs e)
	{
		if (input_length == 0)
			input_length += 1;
		else if (new_operand)
		{
			input_length = 0;
		}
		else {
			box.Text += "0";
			checkbox.Text += "0";
			input_length += 1;
		}
		new_operand = false;
	}

	private void Number1_Click(object sender, System.EventArgs e)
	{
		if (input_length == 0 || new_operand)
		{
			box.Text = "1";
			input_length += 1;
		}
		else {
			box.Text += "1";
			input_length += 1;
		}
		if (input_length == 0)
		{
			checkbox.Text = "1";
			input_length += 1;
		}
		if (input_length != 0 || newoperand)
		{
			checkbox.Text += "1";
			input_length += 1;
		}
		new_operand = false;
		newoperand = true;
	}

	private void Number2_Click(object sender, System.EventArgs e)
	{
		if (input_length == 0 || new_operand)
		{
			box.Text = "2";
			input_length += 1;
		}
		else {
			box.Text += "2";
			input_length += 1;
		}
		if (input_length == 0)
		{
			checkbox.Text = "2";
			input_length += 1;
		}
		if (input_length != 0 || newoperand)
		{
			checkbox.Text += "2";
			input_length += 1;
		}
		new_operand = false;
		newoperand = false;
	}

	private void Number3_Click(object sender, System.EventArgs e)
	{
		if (input_length == 0 || new_operand)
		{
			box.Text = "3";
			input_length += 1;
		}
		else {
			box.Text += "3";
			input_length += 1;
		}
		if (input_length != 0 || newoperand)
		{
			checkbox.Text += "3";
			input_length += 1;
		}
		else {
			checkbox.Text = "3";
			input_length += 1;
		}
		new_operand = false;
		newoperand = false;
	}

	private void Number4_Click(object sender, System.EventArgs e)
	{
		if (input_length == 0 || new_operand)
		{
			box.Text = "4";
			input_length += 1;
		}
		else {
			box.Text += "4";
			input_length += 1;
		}
		if (input_length != 0 || newoperand)
		{
			checkbox.Text += "4";
			input_length += 1;
		}
		else {
			checkbox.Text = "4";
			input_length += 1;
		}
		new_operand = false;
		newoperand = false;
	}

	private void Number5_Click(object sender, System.EventArgs e)
	{
		if (input_length == 0 || new_operand)
		{
			box.Text = "5";
			input_length += 1;
		}
		else {
			box.Text += "5";
			input_length += 1;
		}
		if (input_length != 0 || newoperand)
		{
			checkbox.Text += "5";
			input_length += 1;
		}
		else {
			checkbox.Text = "5";
			input_length += 1;
		}
		new_operand = false;
		newoperand = false;
	}

	private void Number6_Click(object sender, System.EventArgs e)
	{
		if (input_length == 0 || new_operand)
		{
			box.Text = "6";
			input_length += 1;
		}
		else {
			box.Text += "6";
			input_length += 1;
		}
		if (input_length != 0 || newoperand)
		{
			checkbox.Text += "6";
			input_length += 1;
		}
		else {
			checkbox.Text = "6";
			input_length += 1;
		}
		new_operand = false;
		newoperand = false;
	}

	private void Number7_Click(object sender, System.EventArgs e)
	{
		if (input_length == 0 || new_operand)
		{
			box.Text = "7";
			input_length += 1;
		}
		else {
			box.Text += "7";
			input_length += 1;
		}
		if (input_length != 0 || newoperand)
		{
			checkbox.Text += "7";
			input_length += 1;
		}
		else {
			checkbox.Text = "7";
			input_length += 1;
		}
		new_operand = false;
		newoperand = false;
	}

	private void Number8_Click(object sender, System.EventArgs e)
	{
		if (input_length == 0 || new_operand)
		{
			box.Text = "8";
			input_length += 1;
		}
		else {
			box.Text += "8";
			input_length += 1;
		}
		if (input_length != 0 || newoperand)
		{
			checkbox.Text += "8";
			input_length += 1;
		}
		else {
			checkbox.Text = "8";
			input_length += 1;
		}
		new_operand = false;
		newoperand = false;
	}

	private void Number9_Click(object sender, System.EventArgs e)
	{
		if (input_length == 0 || new_operand)
		{
			box.Text = "9";
			input_length += 1;
		}
		else {
			box.Text += "9";
			input_length += 1;
		}
		if (input_length != 0 || newoperand)
		{
			checkbox.Text += "9";
			input_length += 1;
		}
		else {
			checkbox.Text = "9";
			input_length += 1;
		}
		new_operand = false;
		newoperand = false;
	}

	/*  private void Pi_Click (object sender, System.EventArgs e)
    {
        if (input_length == 0 || new_operand) {
            box.Text = "Pi";
            input_length += 1;
        }
        new_operand = false;
    } */

	private void Comma_Click(object sender, System.EventArgs e)
	{
		if (ToggleLang.Text == "DE")
		{
			box.Text += ",";
			checkbox.Text += ",";
		}
		else {
			box.Text += ".";
			checkbox.Text += ".";
		}
	}

	private void Clear_Click(object sender, System.EventArgs e)
	{
		box.Text = "0";
		checkbox.Text = "0";
		operand1 = 0;
		input_length = 0;
	}

	private void Add_Click(object sender, System.EventArgs e)
	{
		operand1 = float.Parse(box.Text);
		operation = "add";
		checkbox.Text += "+";
		input_length += 1;
		newoperand = true;
		setnewoperand = false;
		new_operand = true;
		set_new_operand = true;
	}

	private void Subst_Click(object sender, System.EventArgs e)
	{
		operand1 = float.Parse(box.Text);
		operation = "subst";
		checkbox.Text += "-";
		input_length += 1;
		newoperand = true;
		setnewoperand = true;
		new_operand = true;
		set_new_operand = true;
	}

	private void Mult_Click(object sender, System.EventArgs e)
	{
		operand1 = float.Parse(box.Text);
		operation = "mult";
		checkbox.Text += "*";
		input_length += 1;
		newoperand = true;
		setnewoperand = true;
		new_operand = true;
		set_new_operand = true;
	}

	private void Square_Click(object sender, System.EventArgs e)
	{
		operand1 = float.Parse(box.Text);
		operation = "square";
        box.Text = (operand1*operand1).ToString();
		new_operand = true;
		set_new_operand = true;

	}

	private void Sqrt_Click(object sender, System.EventArgs e)
	{
		operand1 = float.Parse(box.Text);
		operation = "sqrt";
        box.Text = (Math.Sqrt(operand1)).ToString();
		new_operand = true;
		set_new_operand = true;
	}

	private void Div_Click(object sender, System.EventArgs e)
	{
		operand1 = float.Parse(box.Text);
		operation = "div";
		checkbox.Text += "/";
		input_length += 1;
		newoperand = true;
		setnewoperand = true;
		new_operand = true;
		set_new_operand = true;
	}

    private void Equals_Click(object sender, System.EventArgs e)
    {
        if (set_new_operand)
        {
            operand2 = float.Parse(box.Text);
        }
        else {
            operand1 = float.Parse(box.Text);
        }

        switch (operation)
        {
            case "add":
                box.Text = (operand1 + operand2).ToString();
                break;
            case "subst":
                box.Text = (operand1 - operand2).ToString();
                break;
            case "mult":
                box.Text = (operand1 * operand2).ToString();
                break;
            case "div":
                box.Text = (operand1 / operand2).ToString();
                break;
            /*case "square":
				box.Text = (operand1 * operand1).ToString();
				break;
			case "sqrt":
				box.Text = (Math.Sqrt(operand1)).ToString();
				break;*/
		}

		set_new_operand = false;
		new_operand = true;
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
        Application.Exit();
    }

}
class MainClass
{
	public static void Main(string[] args)
	{
		Application.Run(new calculator());
	}
}