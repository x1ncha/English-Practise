using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EnglishPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btna1_Click(object sender, EventArgs e)
        {
            kelime_a1 fr=new kelime_a1();
            fr.Show();
            Hide();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btna2_Click(object sender, EventArgs e)
        {
            kelime_a2 fr2= new kelime_a2();
            fr2.Show();
            Hide();
        }

        private void btnb1_Click(object sender, EventArgs e)
        {
            kelime_b1 fr3= new kelime_b1();
            fr3.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            info fr4= new info();
            fr4.Show();
        }

        private void btnb2_Click(object sender, EventArgs e)
        {
            kelime_b2 fr5= new kelime_b2();
            fr5.Show();
            Hide();
        }

        private void btnc1_Click(object sender, EventArgs e)
        {
            kelime_c1 fr6= new kelime_c1();
            fr6.Show();
            Hide();
        }
    }
}
