using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kutuphaneOtomasyon
{
    public partial class frmKiyapListele : Form
    {
        private DataBase db = new DataBase();

        public frmKiyapListele()
        {
            InitializeComponent();
        }


        private void frmKiyapListele_Load(object sender, EventArgs e)
        {
            veriGetir();
        }

        private void veriGetir()
        {
            db.Open();
            string command = @"select kitap.kitap_id, kitap.kitap_adi as 'Adı',yazar.yazar_adi_soyadi as 'Yazar',kitap.kitap_sayfa_sayisi as 'Sayfa Sayısı' 
                    from kitap inner join yazar on kitap.yazar_id = yazar.yazar_id";
            var adapter = db.Adapter(command);
            try
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["kitap_id"].Visible = false;
                dataGridView1.Sort(this.dataGridView1.Columns["Adı"], ListSortDirection.Ascending);

            }
            catch (MySqlException myEx)
            {
                string hata = string.Format("Kayıtlar listelenirken bir hata oluştu.\n{0}", myEx.Message);
                MessageBox.Show(hata);
                this.Close();
            }
            finally { db.Close(); }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Hiçbir kitap seçilmedi.");
                return;
            }
            int index = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selected = dataGridView1.Rows[index];
            int kitapId = (int)selected.Cells["kitap_id"].Value;
            string kitapAdi = selected.Cells["Adı"].Value.ToString();

            DialogResult cevap = MessageBox.Show("\"" + kitapAdi + "\" adlı kitabı silmek istediğinizden emin misiniz?",
                "Onay", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                db.Open();
                try
                {
                    var cmd = db.Command();
                    cmd.CommandText = "delete from kitap where kitap_id =" + kitapId;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Silme işlemi başarılı.");
                    veriGetir();
                }
                catch (MySqlException myEx)
                {

                    string hata = string.Format("Kayıt silinirken bir hata oluştu.\n{0}", myEx.Message);
                    MessageBox.Show(hata);
                }
                finally { db.Close(); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            veriGetir();
        }

    }
}
