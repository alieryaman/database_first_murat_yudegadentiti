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

namespace EntityOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbSinavOgrenciEntities con = new DbSinavOgrenciEntities();
        private void button4_Click(object sender, EventArgs e)
        {
            var ogrenci = con.TBLOGRENCIs.Where(x=>x.AD==TxtOgrenciad.Text).ToList();

            dataGridView1.DataSource = ogrenci;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void BtnDersListesi_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-NV0GSA0\SQLEXPRESS;Initial Catalog=DbSinavOgrenci;Integrated Security=True");
            SqlCommand komut = new SqlCommand("select * from tbldersler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void NotListesi_Click(object sender, EventArgs e)
        {
            var query = from item in con.TBLNOTLARs
                        select new
                        {
                            item.NOID,
                            item.DERS,
                            item.TBLOGRENCI.AD,
                            item.SINAV1,
                            item.SINAV2,
                            item.SINAV3,
                            item.ORTALAMA,
                            item.DURUM
                        };

            dataGridView1.DataSource = query.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLOGRENCI ogrenci = new TBLOGRENCI();
            ogrenci.AD = TxtOgrenciad.Text;
            ogrenci.SOYAD = TxtOgrenciSoyad.Text;
            con.TBLOGRENCIs.Add(ogrenci);
            con.SaveChanges();
            MessageBox.Show("success");
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.TBLOGRENCIs.ToList();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(OgrenciId.Text);

            var x = con.TBLOGRENCIs.Find(id);
            con.TBLOGRENCIs.Remove(x);
            con.SaveChanges();
            MessageBox.Show("ogrenci  silimndi");

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(OgrenciId.Text);
            var ogrenci = con.TBLOGRENCIs.Find(id);

            ogrenci.AD = TxtOgrenciad.Text;
            ogrenci.SOYAD = TxtOgrenciSoyad.Text;
            ogrenci.FOTOGRAF = TxtOgrenciFoto.Text;
            con.SaveChanges();
            MessageBox.Show("succes");

        }

        private void BtnProcedure_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.NOTLISTESI();
        }

        private void TxtOgrenciad_TextChanged(object sender, EventArgs e)
        {
            string arana = TxtOgrenciad.Text;
            var degerler = from item in con.TBLOGRENCIs
                           where item.AD.Contains(arana)
                           select item;
            dataGridView1.DataSource = degerler.ToList();

        }
    }
}