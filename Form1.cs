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

namespace MyApp
{
    public partial class Form1 : Form
    {
        public DbSinavOgrenciEntities dbSinavOgrenciEntities = new DbSinavOgrenciEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDersListesi_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-DOPHLKN;Initial Catalog=DbSinavOgrenci;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("Select * From TBLDERSLER", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void btnOgrenciListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbSinavOgrenciEntities.TBLOGRENCI.ToList();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void btnNotListesi_Click(object sender, EventArgs e)
        {
            var query = from item in dbSinavOgrenciEntities.TBLNOTLAR
                        select new
                        {
                            item.NotID,
                            item.TBLOGRENCI.Ad,
                            item.TBLOGRENCI.Soyad,
                            item.TBLDERSLER.AD,
                            item.Sinav1,
                            item.Sinav2,
                            item.Sinav3,
                            item.Ortalama,
                            item.Durum
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLOGRENCI newStudent = new TBLOGRENCI();
            newStudent.Ad = textBoxOgrenciAdi.Text;
            newStudent.Soyad = textBoxOgrenciSoyAd.Text;
            dbSinavOgrenciEntities.TBLOGRENCI.Add(newStudent);
            dbSinavOgrenciEntities.SaveChanges();
            MessageBox.Show(newStudent.Ad + " " + newStudent.Soyad + " isimli öğrenci listeye eklenmiştir.", "Öğrenci Kayıt Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            TBLDERSLER newLesson = new TBLDERSLER();
            newLesson.AD = textBoxDersAdi.Text;
            dbSinavOgrenciEntities.TBLDERSLER.Add(newLesson);
            dbSinavOgrenciEntities.SaveChanges();
            MessageBox.Show(newLesson.AD + " isimli ders listeye eklenmiştir.", "Ders Ekleme Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxOgrenciId.Text);
            var deletedObject = dbSinavOgrenciEntities.TBLOGRENCI.Find(id);
            dbSinavOgrenciEntities.TBLOGRENCI.Remove(deletedObject);
            dbSinavOgrenciEntities.SaveChanges();
            MessageBox.Show(textBoxOgrenciId.Text + " ID numaralı öğrenci listeden silindi.", "Öğrenci Silme Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxOgrenciId.Text);
            var updatedObject = dbSinavOgrenciEntities.TBLOGRENCI.Find(id);
            updatedObject.Ad = textBoxOgrenciAdi.Text;
            updatedObject.Soyad = textBoxOgrenciSoyAd.Text;
            updatedObject.Fotograf = textBoxOgrenciFotoPath.Text;
            dbSinavOgrenciEntities.SaveChanges();
            MessageBox.Show(updatedObject.Ad + " " + updatedObject.Soyad + " isimli öğrenci listede güncellendi.", "Öğrenci Bilgisi Güncelleme Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnProsedur_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbSinavOgrenciEntities.NOTLISTESI();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbSinavOgrenciEntities.TBLOGRENCI.Where(x => x.Ad == textBoxOgrenciAdi.Text | x.Soyad == textBoxOgrenciSoyAd.Text).ToList();
        }

        private void textBoxOgrenciAdi_TextChanged(object sender, EventArgs e)
        {
            string searchString = textBoxOgrenciAdi.Text;
            var queryValues = from item in dbSinavOgrenciEntities.TBLOGRENCI
                              where item.Ad.Contains(searchString)
                              select item;

            dataGridView1.DataSource = queryValues.ToList();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == radioBtnIsmeGoreSirala)
            {
                // Asc -- Ascending Order
                var TBLOGRENCIList = dbSinavOgrenciEntities.TBLOGRENCI.OrderBy(p => p.Ad).ToList();
                dataGridView1.DataSource = TBLOGRENCIList;
            }

            if (rb == radioBtnIsmeGoreTersSirala)
            {
                // Desc -- Descending Order
                var TBLOGRENCIList = dbSinavOgrenciEntities.TBLOGRENCI.OrderByDescending(p => p.Ad).ToList();
                dataGridView1.DataSource = TBLOGRENCIList;
            }

            if (rb == radioBtnIlk3KaydiGöster)
            {
                var TBLOGRENCIList = dbSinavOgrenciEntities.TBLOGRENCI.OrderBy(p => p.Ad).Take(3).ToList();
                dataGridView1.DataSource = TBLOGRENCIList;
            }

            if (rb == radioBtnGetByID)
            {
                var IDNum = Convert.ToInt32(textBoxGeByID.Text);
                var TBLOGRENCIList = dbSinavOgrenciEntities.TBLOGRENCI.Where(p => p.ID == IDNum).ToList();
                dataGridView1.DataSource = TBLOGRENCIList;
            }

            if (rb == radioButtonGetByFirstChar)
            {
                var firstChar = textBoxGetByFirstChar.Text;
                var TBLOGRENCIList = dbSinavOgrenciEntities.TBLOGRENCI.Where(p => p.Ad.StartsWith(firstChar)).ToList();
                dataGridView1.DataSource = TBLOGRENCIList;
            }

            if (rb == radioButtonGetByLastChar)
            {
                var firstChar = textBoxGetByFirstChar.Text;
                var TBLOGRENCIList = dbSinavOgrenciEntities.TBLOGRENCI.Where(p => p.Ad.EndsWith(firstChar)).ToList();
                dataGridView1.DataSource = TBLOGRENCIList;
            }
        }

        private void btnGetByJoin_Click(object sender, EventArgs e)
        {
            var query = from db1 in dbSinavOgrenciEntities.TBLNOTLAR
                        join db2 in dbSinavOgrenciEntities.TBLOGRENCI
                        on db1.OgrID equals db2.ID
                        join db3 in dbSinavOgrenciEntities.TBLDERSLER
                        on db1.DersID equals db3.ID
                        select new
                        {
                            Name = db2.Ad + " " + db2.Soyad,
                            Course = db3.AD,
                            Exam1 = db1.Sinav1,
                            Exam2 = db1.Sinav2,
                            Exam3 = db1.Sinav3
                        };

            dataGridView1.DataSource = query.ToList();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBoxGetByFirstChar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
