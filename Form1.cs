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
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();


        public static string testString = "Back";
        public Form1()
        {
            InitializeComponent();

            f2.Owner = this;
            f3.Owner = this;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void Tutorial_Click(object sender, EventArgs e)
        {
 

            f3.StartPosition = FormStartPosition.Manual;

            f3.Location = this.Location;

            f3.Show();

            this.Hide();
        }

        private void ContactHelp_Click(object sender, EventArgs e)
        {
            f2.StartPosition = FormStartPosition.Manual;

            f2.Location = this.Location;

            f2.Show();

            this.Hide();
        }
    }
}
