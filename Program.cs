using System;
using System.Windows.Forms;
using System.Drawing;

class MainClass
{
    public static void Main (string [] args)
    {
        //Erstellt Buttons
        Form calc = new Form ();
        Button number0 = new Button ();
        Button number1 = new Button ();
        Button number2 = new Button ();
        Button number3 = new Button ();
        Button number4 = new Button ();
        Button number5 = new Button ();
        Button number6 = new Button ();
        Button number7 = new Button ();
        Button number8 = new Button ();
        Button number9 = new Button ();
        Button comma = new Button ();
        Button clear = new Button ();
        Button add = new Button ();
        Button subst = new Button ();
        Button mult = new Button ();
        Button div = new Button ();

        //Erstellt Ergebnis-Box
        TextBox box = new TextBox ();
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
        clear.Location = new Point (number3.Left, number3.Top + number3.Height + 10);
        add.Location = new Point (clear.Left + clear.Width + 50, number0.Top);

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

        calc.Text = ("My little calculator");
        calc.FormBorderStyle = FormBorderStyle.FixedDialog;

        box.Text = "50";

        calc.ShowDialog ();
    }
}