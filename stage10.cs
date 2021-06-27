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
    public partial class stage10 : Form
    {
        public stage10()
        {
            InitializeComponent();
        }

        private void stage10_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            stage9 button5 = new stage9();
            button5.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
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
      
    }
}
