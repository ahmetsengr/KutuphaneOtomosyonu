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
    public partial class frmUyeListele : Form
    {
        private DataBase db = new DataBase();

        public frmUyeListele()
        {
            InitializeComponent();
        }

        private void frmUyeListele_Load(object sender, EventArgs e)
        {
            veriGetir();
        }


        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Hiçbir üye seçilmedi.");
                return;
            }
            int index = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selected = dataGridView1.Rows[index];
            int uyeId = (int)selected.Cells["uye_id"].Value;
            string uyeAdi = selected.Cells["Adı"].Value.ToString();

            DialogResult cevap = MessageBox.Show("\"" + uyeAdi + "\" adlı üyeyi silmek istediğinizden emin misiniz?",
                "Onay", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                db.Open();
                try
                {
                    var cmd = db.Command();
                    cmd.CommandText = "delete from uye where uye_id =" + uyeId;
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

        private void veriGetir()
        {
            db.Open();
            string command = @"select uye_id, uye_adi as 'Adı', uye_soyadi as 'Soyadı',uye_okunan_kitap as 'Okuduğu Kitap Sayısı', 
                uye_kayit_tarihi as 'Kayıt Tarihi' from uye";
            var adapter = db.Adapter(command);
            try
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["uye_id"].Visible = false;
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

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnUyeDuzenle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Hiçbir üye seçilmedi.");
                return;
            }

            int index = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selected = dataGridView1.Rows[index];

            frmUyeDuzenle form = new frmUyeDuzenle();
            form.UyeAdi = selected.Cells["Adı"].Value.ToString();
            form.UyeSoyAdi = selected.Cells["Soyadı"].Value.ToString();
            form.UyeId = (int)selected.Cells["uye_id"].Value;
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            veriGetir();
        }


    }
}
