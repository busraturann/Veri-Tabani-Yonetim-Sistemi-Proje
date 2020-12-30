using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Vtys_Proje
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        string baglanti = "Server=localhost;User ID=postgres;password=f;Database=proje";
        NpgsqlConnection conn;
        private string sql = null;
        private NpgsqlCommand cmd;
        private DataTable dt;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(baglanti);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"SELECT * from GirisKontrol(:mail, :sifre)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("mail", textBox1.Text);
                cmd.Parameters.AddWithValue("sifre", textBox2.Text);

                int result = (int)cmd.ExecuteScalar();

                conn.Close();

                if (result == 1)
                {
                    //Form1 formKapa = new Form1();
                    //formKapa.Close();
                    //Form2 form2 = new Form2();
                    //form2.Show();
                }
                else
                {
                    MessageBox.Show("Bilgilerinizi kontrol edip tekrar giriş yapiniz!");
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();

                //MessageBox.Show("Hata!");
            }

            Form1 formKapa = new Form1();
            formKapa.Close();
            Form2 form2 = new Form2();
            form2.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"SELECT * from GirisKontrol(:mail, :sifre)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("mail", textBox1.Text);
                cmd.Parameters.AddWithValue("sifre", textBox2.Text);

                int result = (int)cmd.ExecuteScalar();

                conn.Close();

                if (result == 1)
                {
                    //Form1 formKapa = new Form1();
                    //formKapa.Close();
                    //Form2 form2 = new Form2();
                    //form2.Show();
                }
                else
                {
                    MessageBox.Show("Bilgilerinizi kontrol edip tekrar giriş yapiniz!");
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();

                //MessageBox.Show("Hata!");
            }

            Form1 formKapa = new Form1();
            formKapa.Close();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Select()
        {

        }

    }
}
