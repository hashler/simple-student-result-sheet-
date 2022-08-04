using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secondApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;

            sum = sum + GetTotal();

            label21.Text = Convert.ToString(sum);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label22.Text = Convert.ToString(GetAverage());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            label20.Text = "";
            label13.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label21.Text = "";
            label22.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sinhala = Int32.Parse(textBox3.Text);
            int history = Int32.Parse(textBox4.Text);
            int english = Int32.Parse(textBox5.Text);
            int maths = Int32.Parse(textBox6.Text);
            int science = Int32.Parse(textBox7.Text);

            label20.Text = Convert.ToString(GetGrade(sinhala));
            label13.Text = Convert.ToString(GetGrade(history));
            label15.Text = Convert.ToString(GetGrade(english));
            label16.Text = Convert.ToString(GetGrade(maths));
            label17.Text = Convert.ToString(GetGrade(science));

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string message = "Student Name: " + textBox1.Text + "; Student No: " + textBox2.Text + "; Total: " + label21.Text + "; Average: " + label22.Text;
            string title = "Student Result Report";
            MessageBox.Show(message, title);
        }

        //get Average
        public int GetAverage()
        {
            int avearge = GetTotal() / 5;
            return avearge;
        }

        //get Total
        public int GetTotal()
        {
            int sinhala = Int32.Parse(textBox3.Text);
            int history = Int32.Parse(textBox4.Text);
            int english = Int32.Parse(textBox5.Text);
            int maths = Int32.Parse(textBox6.Text);
            int science = Int32.Parse(textBox7.Text);

            int total = sinhala + history + english + maths + science;
            return total;
        }

        //get Grade
        public char GetGrade(int marks)
        {
            char grade = 'v';

            if (marks >= 75) grade = 'A';
            else if ((marks < 75) && (marks >= 65)) grade = 'B';
            else if ((marks < 65) && (marks >= 55)) grade = 'C';
            else if ((marks < 55) && (marks >= 35)) grade = 'S';
            else if (marks < 35) grade =  'F';

            return grade;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
