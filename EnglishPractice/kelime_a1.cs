using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishPractice
{
    public partial class kelime_a1 : Form
    {
        
        public kelime_a1()
        {
            InitializeComponent();
            
        }
        SqlConnection bagla = new SqlConnection("Data Source=YIGIT;Initial Catalog=EnglishPractice;Integrated Security=True");
        Random rnd=new Random();
        string dogru;
        int a, b;
        
        void getir()
        {
            
            
            int sayi = rnd.Next(1, 68);
            bagla.Open();
            SqlCommand cm1 = new SqlCommand("SELECT * from a1kelime where kelimeid=@p1", bagla);
            cm1.Parameters.AddWithValue("@p1", sayi);
            SqlDataReader dr1 = cm1.ExecuteReader();
            while (dr1.Read())
            {
                txt_kelime.Text = dr1[1].ToString();
                dogru = dr1[2].ToString().ToLower();
            }
            bagla.Close();
        }

        private void Btn_kelimever_Click(object sender, EventArgs e)
        {
            getir();
            Btn_kontrol.Enabled = true;
        }

        private void kelime_a1_Load(object sender, EventArgs e)
        {
            lbl_dogru.Text=a.ToString("0");
            lbl_yanlis.Text=b.ToString("0");
            Btn_kontrol.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr6=new Form1();
            fr6.Show();
            Hide();
        }

        private void Btn_kontrol_Click(object sender, EventArgs e)
        {
            if (txt_karsilik.Text==dogru)
            {
                a = a + 1;
                lbl_dogru.Text = a.ToString("0");
                MessageBox.Show("Doğru bildiniz!");
                txt_karsilik.Clear();
                getir();
            }
            else
            {
                b=b + 1;
                lbl_yanlis.Text = b.ToString("0");
                MessageBox.Show("Cevabınız yanlış!   Doğru cevap:" + dogru, "Yanlış Cevap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_karsilik.Clear();
                getir();
            }
            
        }


    }
}
