using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Original1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Console.WriteLine(\"input\") What is the result of this code?";
            textBox2.Text = "Which one is a type of variable? (Hint: Choose two answer)";
            textBox3.Text = "int score = 85;" + Environment.NewLine +
"if (score >= 90)" + Environment.NewLine +
"{" + Environment.NewLine +
"    Console.WriteLine(\"Excellent!\");" + Environment.NewLine +
"}" + Environment.NewLine +
"else if (score >= 75)" + Environment.NewLine +
"{" + Environment.NewLine +
"    Console.WriteLine(\"Good job!\");" + Environment.NewLine +
"}" + Environment.NewLine +
"else" + Environment.NewLine +
"{" + Environment.NewLine +
"    Console.WriteLine(\"Try again.\");" + Environment.NewLine +
"}" + Environment.NewLine + Environment.NewLine +
"What will be printed if score = 85?";
        }

        private void CorrectBtn1_Click(object sender, EventArgs e)
        {
            lblCheckResult1.Text = "Correct!";
            lblCheckResult1.ForeColor = Color.Green;
            CorrectButton1.BackColor = Color.Green;
        }
        private void WrongBtn1_Click(object sender, EventArgs e)
        {
            lblCheckResult1.Text = "Incorrect!";
            lblCheckResult1.ForeColor = Color.Red;
        }

        public bool btn1C = false;
        public bool btn2C = false;
        private void CorrectBtn2_Click(object sender, EventArgs e)
        {


            RightButton.BackColor = Color.Green;

            btn1C = true;

            blCheck();
        }

        private void CorrectButton_Click(object sender, EventArgs e)
        {

            CorrectButton.BackColor = Color.Green;
            btn2C = true;
            blCheck();
        }
        public void blCheck()
        {

            if (btn1C == true && btn2C == true)
            {
                lblCheckResult2.Text = "Correct";

                lblCheckResult2.ForeColor = Color.Green;

            }
            else
            {

            }
        }
        private void CorrectBtn3_Click(object sender, EventArgs e)
        {
            Right3Button.BackColor = Color.Green;
            lblCheckResult3.Text = "Correct!";
            lblCheckResult3.ForeColor = Color.Green;
            lblCheckResult3.ForeColor = Color.Green;
        }
        private void WrongBtn3_Click(object sender, EventArgs e)
        {
            lblCheckResult3.Text = "Incorrect!";
            lblCheckResult3.ForeColor = Color.Red;
            lblCheckResult3.ForeColor = Color.Red;
        }



        private void Back5_Click(object sender, EventArgs e)
        {
            Form3 f3 = (Form3)Application.OpenForms["Form3"];
            this.Owner = f3;
            this.Owner.Show();
            this.Hide();
        }
        private void BtnGo6_Click(object sender, EventArgs e)
        {
            Form3 f3 = (Form3)Application.OpenForms["Form3"];
            this.Owner = f3;
            this.Owner.Show();
            this.Hide();
        }
    }
}

