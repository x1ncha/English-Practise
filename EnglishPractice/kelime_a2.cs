using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishPractice
{
    public partial class kelime_a2 : Form
    {
        public kelime_a2()
        {
            InitializeComponent();
        }
        SqlConnection bagla = new SqlConnection("Data Source=YIGIT;Initial Catalog=EnglishPractice;Integrated Security=True");
        Random rnd1 = new Random();
        string dogru;
        int a, b;

        void getir1()
        {


            int sayi1 = rnd1.Next(1, 50);
            bagla.Open();
            SqlCommand cm2 = new SqlCommand("SELECT * from a2kelime where kelimeid=@p1", bagla);
            cm2.Parameters.AddWithValue("@p1", sayi1);
            SqlDataReader dr2 = cm2.ExecuteReader();
            while (dr2.Read())
            {
                txt_kelime.Text = dr2[1].ToString();
                dogru = dr2[2].ToString().ToLower();
            }
            bagla.Close();
        }



        private void kelime_a2_Load(object sender, EventArgs e)
        {
            lbl_dogru.Text = a.ToString("0");
            lbl_yanlis.Text = b.ToString("0");
            Btn_kontrol.Enabled = false;

        }

        private void Btn_kontrol_Click(object sender, EventArgs e)
        {
            {
                if (txt_karsilik.Text == dogru)
                {
                    a++;
                    lbl_dogru.Text = a.ToString("0");
                    MessageBox.Show("Cevabınız doğru!");
                    txt_karsilik.Clear();
                    getir1();
                }
                else
                {
                    b++;
                    lbl_yanlis.Text = b.ToString("0");
                    MessageBox.Show("Cevabınız yanlış!   Doğru cevap:" + dogru, "Yanlış Cevap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_karsilik.Clear();
                    getir1();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr5= new Form1();
            fr5.Show();
            Hide();
        }

        private void Btn_kelimever_Click_1(object sender, EventArgs e)
        {


            getir1();
            Btn_kontrol.Enabled = true;


        }

    }
}
