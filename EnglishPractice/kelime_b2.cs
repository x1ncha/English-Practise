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
using System.Globalization;

namespace EnglishPractice
{
    public partial class kelime_b2 : Form
    {
        public kelime_b2()
        {
            InitializeComponent();
        }
        SqlConnection bagla = new SqlConnection("Data Source=YIGIT;Initial Catalog=EnglishPractice;Integrated Security=True");
        Random rnd1 = new Random();
        string dogru;
        int a, b;

        void getir()
        {
            int sayi=rnd1.Next(1,200);
            bagla.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from b2kelime where kelimeid=@p1", bagla);
            cmd.Parameters.AddWithValue("p1", sayi);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                txt_kelime.Text = rdr[1].ToString();
                dogru = rdr[2].ToString().ToLower();
            }
            bagla.Close();
            
        }
        private void Btn_kelimever_Click(object sender, EventArgs e)
        {
            getir();
            txt_kelime.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_kelime.Text);
            Btn_kontrol.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_kontrol_Click(object sender, EventArgs e)
        {
            if (txt_karsilik.Text==dogru)
            {
                a++;
                lbl_dogru.Text=a.ToString();
                MessageBox.Show("Cevabınız doğru!","Doğru Cevap",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                getir();
                txt_karsilik.Clear();
                txt_kelime.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_kelime.Text);
            }
            else
            {
                b++;
                lbl_yanlis.Text=b.ToString();
                MessageBox.Show("Cevabınız yanlış!   Doğru cevap:" + dogru, "Yanlış Cevap", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txt_karsilik.Clear();
                getir();
                txt_kelime.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_kelime.Text);


            }
        }

        private void kelime_b2_Load(object sender, EventArgs e)
        {
            lbl_dogru.Text = a.ToString("0");
            lbl_yanlis.Text = b.ToString("0");
            Btn_kontrol.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr= new Form1();
            fr.Show();
            Hide();
        }
    }
}
