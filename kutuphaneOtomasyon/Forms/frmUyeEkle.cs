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
    public partial class frmUyeEkle : Form
    {
        public frmUyeEkle()
        {
            InitializeComponent();
        }

        private void frmUyeEkle_Load(object sender, EventArgs e)
        {

        }

        private DataBase db = new DataBase();

        private void bntEkle_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            db.Open();
            try
            {
                var cmd = db.Command();
                cmd.CommandText = "insert into uye (uye_adi,uye_soyadi,uye_kayit_tarihi) values(@uyeAdi,@uyeSoyadi,@today)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@uyeAdi", txtUyeAdi.Text);
                cmd.Parameters.AddWithValue("@uyeSoyadi", txtUyeSoyadi.Text);
                cmd.Parameters.AddWithValue("@today", today);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Uye kaydı başarılı.");
            }
            catch (MySqlException myEx)
            {
                string hata = string.Format("Kayıt veritabanına eklenirken bir hata oluştu.\n{0}", myEx.Message);
                MessageBox.Show(hata);
            }
            finally { db.Close(); }
            txtUyeAdi.Text = "";
            txtUyeSoyadi.Text = "";

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
