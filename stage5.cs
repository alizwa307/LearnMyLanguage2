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
    public partial class stage5 : Form
    {
        public stage5()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            stage4 button5 = new stage4();
            button5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //    this.Close();
            //   stage6 button3 = new stage6();
            //    button3.Show();
        }

        private void stage5_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.DarkKhaki;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Khaki;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            this.button5.BackColor = Color.DarkGoldenrod;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            this.button5.BackColor = Color.Gold;
        }


        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            this.textBox1.BackColor = Color.DarkGreen;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.textBox1.BackColor = Color.Black;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            this.button3.BackColor = Color.DarkGoldenrod;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.BackColor = Color.Gold;
        }
       
    }
}
