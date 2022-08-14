using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        double a, b, c, ans1, ans2; // Initialize variables for the use of the calculation.

        void Error() //Error provider!
        {
            MessageBox.Show("Would you kindly enter only negative or positive numbers greater or smaller than 999 and -999.", "Instruction", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button_Click(object sender, EventArgs e) // We use this event for all the number and "-" buttons as a way to give input into the arguments (without having the user to type any manually), this is in a way to control so that only numbers go in.
        {
            Button b = (Button)sender; //So we dont repeat code we just use this "b" to send data to the box, also when we clik on any number and "-" button the text that is in the number or "-" button goes into the box (later on we convert it into a integer for calculation.)
            if (click == 0)
            {
                BOXA.Text = BOXA.Text + b.Text;
            }
            else if (click == 1)
            {
                BOXB.Text = BOXB.Text + b.Text;
            }
            else if (click == 2)
            {
                BOXC.Text = BOXC.Text + b.Text;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button14_Click(object sender, EventArgs e) // Backspace use for deleting the last input that we made in the chosen box.
        {
            if (click == 0)
            {
                int length = BOXA.TextLength - 1;
                string text = BOXA.Text;
                BOXA.Clear();
                for (int i = 0; i < length; i++)
                {
                    BOXA.Text = BOXA.Text + text[i];
                }
            }

            if (click == 1)
            {
                int length = BOXB.TextLength - 1;
                string text = BOXB.Text;
                BOXB.Clear();
                for (int i = 0; i < length; i++)
                {
                    BOXB.Text = BOXB.Text + text[i];
                }
            }

            if (click == 2)
            {
                int length = BOXC.TextLength - 1;
                string text = BOXC.Text;
                BOXC.Clear();
                for (int i = 0; i < length; i++)
                {
                    BOXC.Text = BOXC.Text + text[i];
                }
            }
        }

        private void DeleteHistory_Click(object sender, EventArgs e) // Delete History
        {
            rtsHistory.Clear();
            MessageBox.Show("History has been deleted!", "Instruction", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            if (rtsHistory.Text == "")
            {
                rtsHistory.Text = "There is no history yet!";

                DeleteHistory.Visible = false;
            }


        }

        private void pressMeForInstructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Would you kindly enter integers between 999 and -999 and press the button 'Fix Problem' below to solve the quadratic equation!", "Instruction", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button2_Click(object sender, EventArgs e)  // Clear function so we rest the program.
        {
            BOXA.Text = "";
            BOXB.Text = "";
            BOXC.Text = "";
            Result.Text = "";
            click = 0;
            sw.Text = "";

        }

        int click = 0; // Helping variable for switching between the boxes.
        private void buttonnext_Click(object sender, EventArgs e) // We use a switch here so that we can make a cycle between the boxes.
        {
            click++;
            click %= 3;
            switch (click)
            {
                case 0:
                    BOXA.Select();
                    break;
                case 1:
                    BOXB.Select();
                    break;
                case 2:
                    BOXC.Select();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e) // The start of the solution.
        {
            var watch = System.Diagnostics.Stopwatch.StartNew(); // I wanted to see how long it would take to calculate so I just made a simple variable watch, it uses the stopwatch function and at the end it converts the result into a string so we can read it.

            double d;

            if (BOXA.Text == "0") // Checking the input of the user.
            {
                if (BOXB.Text == "0" && BOXC.Text == "0")
                    MessageBox.Show("The coefficient x², x and the free character are a must. Would you kindly enter them!", "Instruction", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    MessageBox.Show("The coefficient x² must not equal 0.", "Instruction", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);



            }

            int x, x2, x3;                    // To check the input we must convert them to integers.
            Int32.TryParse(BOXA.Text, out x);
            Int32.TryParse(BOXB.Text, out x2);
            Int32.TryParse(BOXC.Text, out x3);

            if (BOXA.Text == "" || x > 999 || x < -999 || BOXB.Text == "" || x2 > 999 || x2 < -999 || BOXB.Text == "" || x3 > 999 || x3 < -999 || x == 0 || x2 == 0 || x3 == 0)
            {
                Error();
            }
            else
            {

                a = double.Parse(BOXA.Text);
                b = double.Parse(BOXB.Text);
                c = double.Parse(BOXC.Text);

                d = Math.Pow(b, 2) - 4 * a * c;

                if (d > 0)
                {
                    ans1 = (-b + Math.Sqrt(d)) / (2 * a);
                    ans2 = (-b - Math.Sqrt(d)) / (2 * a);

                    Result.Text = " A:" + x + " B:" + x2 + " C:" + x3 + "\n" + "The answer for X is:" + ans1.ToString("n2") + " or X:" + ans2.ToString("n2");
                }
                else if (d == 0)
                {
                    ans1 = (-b + Math.Sqrt(d)) / (2 * a);

                    Result.Text = " A:" + x + " B:" + x2 + " C:" + x3 + "\n" + "The answer for X is:" + ans1.ToString("n2");

                }
                else if (d < 0)
                {
                    ans1 = -b / (2 * a);
                    ans2 = -b / (2 * a);

                    double i = Math.Sqrt(-d) / (2 * a);

                    Result.Text = " A:" + x + " B:" + x2 + " C:" + x3 + "\n" + "The answer for X is:" + ans1.ToString("n2") + " + " + i.ToString("n2") + " i " + " or X:" + ans2.ToString("n2") + " - " + i.ToString("n2") + " i ";
                }

                DeleteHistory.Visible = true;

                rtsHistory.AppendText(Result.Text + "                                    ");

                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;

                sw.Text = "Program Excecuted in : " + elapsedMs.ToString("n2") + " ms.";
            }

        }
    }
}


