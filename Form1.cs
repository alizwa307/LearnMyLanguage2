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
    public partial class stage1 : Form
    {
        public stage1()
        {
            InitializeComponent();
          
        }
        public void InputCheck()
        {
            if(textBox2.Text == "inja".ToUpper())
            {
                Correct.Checked = true;
               
            }
            else 
                Correct.Checked=false;
              //   button4.Click = MessageBox.Show("Correct");
        }

        public void Hint()
        {
            textBox3.Text = "I--A";
        
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
        public void Name1()
        {
            textBox4.Text = "NJAI";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         //   textBox1.Text = "Name the Animal In Isixhosa Language";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Correct.Text = "Correct";
            InputCheck();
            Nextbtn();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.Text = "Name The Animal in Isixhosa";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InputCheck();
            Answer();

          //  button4.Click = 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hint();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            stage2 button1 = new stage2();
            button1.Show();
            button1.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
           
           // button1.Hide();
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

        private void button3_MouseHover(object sender, EventArgs e)
        {
            this.button3.BackColor = Color.DarkGoldenrod;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.BackColor = Color.Gold;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }

