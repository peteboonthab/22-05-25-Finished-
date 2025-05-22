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
    public partial class Form3 : Form
    {
        Form4 f4 = new Form4();
        Form5 f5 = new Form5();
        Form6 f6 = new Form6();
        public Form3()
        {
            InitializeComponent();
            button1.Text = Form1.testString;
            f4.Owner = this;
            f5.Owner = this;
            f6.Owner = this;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void BackTutorial_Click(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Hide();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            f4.StartPosition = FormStartPosition.Manual;
            f4.Location = this.Location;
            this.Hide();
            f4.Show();
        }
        private void Next2_Click(object sender, EventArgs e)
        {
            f5.StartPosition = FormStartPosition.Manual;
            f5.Location = this.Location;
            this.Hide();
            f5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f6.StartPosition = FormStartPosition.Manual;
            f6.Location = this.Location;
            this.Hide();
            f6.Show();
        }
    }

}
