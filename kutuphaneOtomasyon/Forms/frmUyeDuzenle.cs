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
    public partial class frmUyeDuzenle : Form
    {
        public string UyeAdi { get; set; }
        public string UyeSoyAdi { get; set; }
        public int UyeId { get; set; }
        private DataBase db = new DataBase();

        public frmUyeDuzenle()
        {
            InitializeComponent();
        }

        private void frmUyeDuzenle_Load(object sender, EventArgs e)
        {
            txtUyeAdi.Text = UyeAdi;
            txtUyeSoyadi.Text = UyeSoyAdi;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            db.Open();
            var cmd = db.Command();
            try
            {
                cmd.CommandText = "update uye set uye_adi = @uyeAdi, uye_soyadi = @uyeSoyadi where uye_id = @uyeId";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@uyeAdi", txtUyeAdi.Text);
                cmd.Parameters.AddWithValue("@uyeSoyadi", txtUyeSoyadi.Text);
                cmd.Parameters.AddWithValue("@uyeId", UyeId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Düzenleme başarılı.");
                this.Close();
            }
            catch (MySqlException myEx)
            {
                string hata = string.Format("Kayıt silinirken bir hata oluştu.\n{0}", myEx.Message);
                MessageBox.Show(hata);
            }
            finally { db.Close(); }


        }

    }
}
