using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataBase db = new DataBase();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKitapEkle form = new frmKitapEkle();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUyeEkle form = new frmUyeEkle();
            form.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmUyeListele form = new frmUyeListele();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmKiyapListele form = new frmKiyapListele();
            form.ShowDialog();
        }

        
    }
}
