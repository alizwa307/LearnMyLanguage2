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
    public partial class stage7 : Form
    {
        public stage7()
        {
            InitializeComponent();
        }
        public void InputCheck()
        {
            if (textBox2.Text == "intloko".ToUpper())
            {
                Correct.Checked = true;

            }
            else
                Correct.Checked = false;
      
        }
        public void Hint()
        {
            textBox3.Text = "-N--K-";

        }
  
        public void Answer()
        {
            if (Correct.Checked == true)
            {
                MessageBox.Show("Your Answer is correct");
            }
            else
                MessageBox.Show("Use your hint for a Correct Answer");
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

        private void stage7_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            InputCheck();
            Answer();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            stage8 button1 = new stage8();
            button1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            stage6 button5 = new stage6();
            button5.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void Correct_CheckedChanged(object sender, EventArgs e)
        {
            Correct.Text = "Correct";
            InputCheck();
            Nextbtn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hint();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.button2.BackColor = Color.DarkGoldenrod;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.BackColor = Color.Gold;
        }
        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            this.textBox2.BackColor = Color.DarkGreen;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            this.textBox2.BackColor = Color.LightGreen;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
