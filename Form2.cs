using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DbSinavOgrenciEntities dbSinavOgrenciEntities = new DbSinavOgrenciEntities();
        private void btnGetByLinq_Click(object sender, EventArgs e)
        {
            if (radioButtonGetSmallerGrades.Checked == true)
            {
                var query = dbSinavOgrenciEntities.TBLNOTLAR.Where(x => x.Sinav1 < 50);
                dataGridView1.DataSource = query.ToList();
            }

            if (radioButtonGetByName.Checked == true)
            {
                var query = dbSinavOgrenciEntities.TBLOGRENCI.Where(x => x.Ad == "Ferit");
                dataGridView1.DataSource = query.ToList();
            }

            // LinQ Get Data by Name and Surname from TextBox, added with contains search
            if (radioButtonGetByTextBox.Checked == true)
            {
                var text = textBoxGetByNameOrSurname.Text;
                var query = dbSinavOgrenciEntities.TBLOGRENCI.Where(
                                                                        x => x.Ad == text ||
                                                                        x.Soyad == text ||
                                                                        x.Ad.Contains(text) ||
                                                                        x.Soyad.Contains(text)
                                                                    );
                dataGridView1.DataSource = query.ToList();
            }

            // LinQ Select restriction with one anonymous type
            if (radioButtonGetBySurname.Checked == true)
            {
                var query = dbSinavOgrenciEntities.TBLOGRENCI.Select(q => new { SurName = q.Soyad });
                dataGridView1.DataSource = query.ToList();
            }

            // LinQ Select restriction with two anonymous type
            if (radioButtonGetByBiggerNameSmallSurname.Checked == true)
            {
                var query = dbSinavOgrenciEntities.TBLOGRENCI.Select(x => new { Name = x.Ad.ToUpper(), SurName = x.Soyad.ToLower() });
                //var query = dbSinavOgrenciEntities.TBLOGRENCI.Select(x => new { Name = x.Ad.ToUpper() + " " + x.Soyad.ToLower() });
                dataGridView1.DataSource = query.ToList();
            }

            // LinQ Conditional Select with two anonymous type
            if (radioButtonConditionalSelect.Checked == true)
            {
                var query = dbSinavOgrenciEntities.TBLOGRENCI.Select(p => new
                {
                    Name = p.Ad.ToUpper(),
                    SurName = p.Soyad.ToLower()
                }).Where(x => x.Name == "Ferit");
                dataGridView1.DataSource = query.ToList();
            }

            // LinQ Conditional Select with two anonymous type and one anonymous type with extra pass/fail condition
            if (radioButtonPassOrFail.Checked == true)
            {
                var query = dbSinavOgrenciEntities.TBLNOTLAR.Select(x => new
                {
                    StudentID = x.OgrID,
                    Average = x.Ortalama,
                    PassOrFail = x.Durum == true ? "Geçti" : "Kaldı"
                });
                dataGridView1.DataSource = query.ToList();
            }

            // LinQ SelectMany Projection Usage with two tables
            if (radioButtonJoin.Checked == true)
            {
                var query = dbSinavOgrenciEntities.TBLNOTLAR.SelectMany(
                                x=> dbSinavOgrenciEntities.TBLOGRENCI.Where(
                                    y=> y.ID == x.OgrID),
                                        (x,y)=> 
                                            new 
                                            {
                                                Name = y.Ad,
                                                Surname = y.Soyad,
                                                Average = x.Ortalama,
                                                PassOrFail = x.Durum == true ? "Geçti" : "Kaldı"
                                            });
                dataGridView1.DataSource = query.ToList();
            }
        }
    }
}
