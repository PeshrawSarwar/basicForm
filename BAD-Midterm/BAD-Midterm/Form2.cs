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
    public partial class Form2 : Form
    {
        public String name, age, dateOfBirth;
        public Form2(String name, String age, String dateOfBirth)
        {
            InitializeComponent();
            this.name = name;
            this.age = age;
            this.dateOfBirth = dateOfBirth;

            this.nameLbl.Text = name;
            this.ageLbl.Text = age;
            this.dateOfBirthLbl.Text = dateOfBirth;

          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.HeightTxt.Text = this.Size.Height.ToString();
            this.WidthTxt.Text = this.Size.Width.ToString();
            this.xTxt.Text = this.Location.X.ToString();
            this.yTxt.Text = this.Location.Y.ToString();

            this.MinimumSize = new Size(300,300);
            this.MaximumSize = new Size(600,600);

           

        }

        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            this.HeightTxt.Text = this.Size.Height.ToString();
            this.WidthTxt.Text = this.Size.Width.ToString();
        }

        private void Form2_LocationChanged(object sender, EventArgs e)
        {
            this.xTxt.Text = this.Location.X.ToString();
            this.yTxt.Text = this.Location.Y.ToString();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form2_MouseHover(object sender, EventArgs e)
        {
            var a = Cursor.Position.X;
            var b = Cursor.Position.Y;
            var c = a - b;
            if (a > 255 || a < 0) {
                a = 255;
            }
            if (c > 255 || c < 0) {
                c = 0;
            }
            if (b > 255 || b < 0) {
                b = 50;
            }
            this.BackColor = Color.FromArgb(a, b, c);
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (redCheck.Checked) {
                this.BackColor = Color.FromArgb(255, 0, 0);
            } else if (BlueCheck.Checked) {
                this.BackColor = Color.FromArgb(0, 0, 255);
            } else if (greenCheck.Checked) {
                this.BackColor = Color.FromArgb(0, 255, 0);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
