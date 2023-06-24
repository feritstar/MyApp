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

            if (radioButtonGetByTextBox.Checked == true)
            {
                var text = textBoxGetByNameOrSurname.Text;
                var query = dbSinavOgrenciEntities.TBLOGRENCI.Where(
                                                                        x => x.Ad == text | 
                                                                        x.Soyad == text | 
                                                                        x.Ad.Contains(text) | 
                                                                        x.Soyad.Contains(text)
                                                                    );
                dataGridView1.DataSource = query.ToList();
            }
        }
    }
}
