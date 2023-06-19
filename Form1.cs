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
            SqlCommand sqlCommand = new SqlCommand("Select * From TBLDERSLER",sqlConnection);
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
                            item.OgrID,
                            item.DersID,
                            item.Sinav1,
                            item.Sinav2,
                            item.Sinav3,
                            item.Ortalama,
                            item.Durum
                        };
            dataGridView1.DataSource = query.ToList();
        }
    }
}
