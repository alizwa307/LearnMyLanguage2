using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnMyLanguage2
{
    public partial class stage6 : Form
    {
        public stage6()
        {
            InitializeComponent();
        }
        public void InputCheck()
        {

            if (textBox2.Text == "bomvu".ToUpper()&& textBox13.Text == "mnyama".ToUpper()
                && textBox12.Text == "bhelu".ToUpper()
                && textBox11.Text == "luhlaza".ToUpper()&& textBox10.Text == "luhlaza".ToUpper()&&
                textBox3.Text == "mhlophe".ToUpper())
            {
                    this.textBox2.BackColor = Color.DarkRed;
                    this.textBox13.BackColor = Color.DarkGray;
                    this.textBox12.BackColor = Color.DarkKhaki;
                    this.textBox11.BackColor = Color.DarkBlue;
                    this.textBox10.BackColor = Color.DarkGreen;
                    this.textBox3.BackColor = Color.Gray;

                  Correct.Checked = true;
           
            }
            else
                Correct.Checked = false;
           
        }

     
     
        public void Answer()
        {
            if (Correct.Checked == true)
            {
                MessageBox.Show("You Have Managed to Name All The Colors");
            }
            else
                MessageBox.Show("Correctly Name All The Colors");
        }
        public void Nextbtn()
        {
            if (Correct.Checked == false)
            {
                button1.Hide();
            }
            else
                button1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            stage5 button5 = new stage5();
            button5.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            stage7 button1 = new stage7();
            button1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Correct_CheckedChanged(object sender, EventArgs e)
        {
            Correct.Text = "Correct";
            InputCheck();
            Nextbtn();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InputCheck();
             Answer();
        }
        private void button3_MouseHover(object sender, EventArgs e)
        {
            this.button3.BackColor = Color.DarkGoldenrod;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.BackColor = Color.Gold;
        }
        private void button5_MouseHover(object sender, EventArgs e)
        {
            this.button5.BackColor = Color.DarkGoldenrod;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            this.button5.BackColor = Color.Gold;
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.DarkKhaki;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Khaki;
        }
        private void button4_MouseHover(object sender, EventArgs e)
        {
            this.button4.BackColor = Color.DarkGoldenrod;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            this.button4.BackColor = Color.Gold;
        }
    }
}
