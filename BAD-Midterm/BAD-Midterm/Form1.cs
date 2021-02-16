using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAD_Midterm
{
    public partial class Form1 : Form
    {
        public bool z;

        public Form1()
        {
            InitializeComponent();
            
        }
        public Form1(bool x)
        {

            if (x == false) {
                button5 = new Button();
                button5.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button5.Enabled = true;
            this.Activate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ControlBox)
            {
                this.ControlBox = false;
            }
            else {
                this.ControlBox = true;
            }
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var year = dateOfBirthTxt.Text;
            var age = today.Year - int.Parse(year);
            ageTxt.Text = age.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var name = nameTxt.Text;
            var age = ageTxt.Text;
            var dateOfBirth = dateOfBirthTxt.Text;
            Form2 ob = new Form2(name, age, dateOfBirth);

            ob.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (
                MessageBox.Show(
                "Close The Form", 
                "My First App", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.No) 
            {
                e.Cancel = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
