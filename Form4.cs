using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Original1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            textBox1.Multiline = true;

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            textBox1.BackColor = Color.LightYellow;
            textBox3.BackColor = Color.LightYellow;
            textBox1.Text  = "A variable is a like container that we can store data in." + Environment.NewLine + "" + Environment.NewLine + "" + Environment.NewLine +
            "In C#, there are different types of variables (defined with different keywords), for example:" + Environment.NewLine + "" + Environment.NewLine +
            "int -stores integers(whole numbers), without decimals, such as 123 or - 123" + Environment.NewLine + "" + Environment.NewLine +         
            "string - use stores text, such as Hello World.String values are surrounded by double quotes" + Environment.NewLine + "" + Environment.NewLine +
            "bool - use stores values with two states: true or false " + Environment.NewLine + "" + Environment.NewLine + "Here is an example for variable that use to stored number" + Environment.NewLine + "" + Environment.NewLine +
            "string name = \"John\";"  + Environment.NewLine + "Console.WriteLine(name);"
            + Environment.NewLine + "" + Environment.NewLine + "Result: John";

            textBox3.Text = "Question 1" + Environment.NewLine + "" + Environment.NewLine + "The variable \"Number\" below is assigned the value of 10" + Environment.NewLine + "int Number = 10;" +
            Environment.NewLine + "Console.WriteLine(??);" + Environment.NewLine + "Result: 10" + Environment.NewLine + "" + Environment.NewLine + "What should be put in ??  for the result to be 10?";
        }
        private void BackTutorial1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Hide();
        }






        private void btnGo_Click(object sender, EventArgs e)
        {
            string trimmed = textBox2.Text.Trim(); // Remove leading/trailing spaces

            if (trimmed != "Number")
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
        private void Btn5Go_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Owner = this.Owner;  
            this.Hide();
            f6.Show();

        }


    }
}

    

