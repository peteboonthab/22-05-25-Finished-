using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Original1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void Form6_Load_1(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            textBox1.BackColor = Color.LightYellow;
            textBox3.BackColor = Color.LightYellow;
            textBox1.Text = "This lesson is about using \"If Else Statement \"" + Environment.NewLine + "" + Environment.NewLine +
            "An if-else statement is like making a decision, it tells the computer:" + Environment.NewLine + "" + Environment.NewLine +
            "if it is true, do this" + Environment.NewLine +
            "else (if it is not true) do this" + Environment.NewLine + "" + Environment.NewLine +
            "Example:" + Environment.NewLine + "" + Environment.NewLine +
            "int number = 10;" + Environment.NewLine +
            "if (number > 5) {" + Environment.NewLine +
            "    Console.WriteLine(\"The number is greater than 5\");" + Environment.NewLine +
            "} else {" + Environment.NewLine +
            "    Console.WriteLine(\"The number is not greater than 5\");" + Environment.NewLine +
            "}" + Environment.NewLine + "" + Environment.NewLine +"Result: The number is greater than 5";
            textBox3.Text = "Question 1" + Environment.NewLine + Environment.NewLine +
    "What will be printed to the screen?" + Environment.NewLine +
    "int number = 7;" + Environment.NewLine +
    "if (number > 10)" + Environment.NewLine +
    "{" + Environment.NewLine +
    "    Console.WriteLine(\"Greater than 10\");" + Environment.NewLine +
    "}" + Environment.NewLine +
    "else" + Environment.NewLine +
    "{" + Environment.NewLine +
    "    Console.WriteLine(\"10 or less\");" + Environment.NewLine +
    "}" + Environment.NewLine + Environment.NewLine +
    "Answer:";
        }


       
             private void button1_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();  // Show Form3
                this.Hide();        // Hide Form6
            }
            else
            {
                MessageBox.Show("Form3 is not set as owner.");
            }
        }


        private void btnGo_Click(object sender, EventArgs e)
        {
            string trimmed = textBox2.Text.Trim(); // Remove leading/trailing spaces

            if (trimmed != "10 or less")
            {
                lblCheckResult.Text = "Incorrect!";
                lblCheckResult.ForeColor = Color.Red;
            }
            else
            {
                lblCheckResult.Text = "Correct!";
                lblCheckResult.ForeColor = Color.Green;
            }
        }
    }


    }

