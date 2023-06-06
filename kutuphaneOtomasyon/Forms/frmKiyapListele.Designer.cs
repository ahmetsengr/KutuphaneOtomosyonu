namespace kutuphaneOtomasyon
{
    partial class frmKiyapListele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnKitapDuzenle = new System.Windows.Forms.Button();
            this.btnKitapSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCikis.Location = new System.Drawing.Point(367, 396);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(99, 35);
            this.btnCikis.TabIndex = 10;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnKitapDuzenle
            // 
            this.btnKitapDuzenle.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnKitapDuzenle.Image = global::kutuphaneOtomasyon.Properties.Resources.book_pencil;
            this.btnKitapDuzenle.Location = new System.Drawing.Point(135, 8);
            this.btnKitapDuzenle.Name = "btnKitapDuzenle";
            this.btnKitapDuzenle.Size = new System.Drawing.Size(98, 105);
            this.btnKitapDuzenle.TabIndex = 9;
            this.btnKitapDuzenle.Text = "Kitap Düzenle";
            this.btnKitapDuzenle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitapDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnKitapSil
            // 
            this.btnKitapSil.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnKitapSil.Image = global::kutuphaneOtomasyon.Properties.Resources.book_close;
            this.btnKitapSil.Location = new System.Drawing.Point(12, 8);
            this.btnKitapSil.Name = "btnKitapSil";
            this.btnKitapSil.Size = new System.Drawing.Size(98, 105);
            this.btnKitapSil.TabIndex = 8;
            this.btnKitapSil.Text = "Kitap Sil";
            this.btnKitapSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitapSil.UseVisualStyleBackColor = true;
            this.btnKitapSil.Click += new System.EventHandler(this.btnKitapSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(454, 237);
            this.dataGridView1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button1.Image = global::kutuphaneOtomasyon.Properties.Resources.refresh;
            this.button1.Location = new System.Drawing.Point(371, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 105);
            this.button1.TabIndex = 11;
            this.button1.Text = "Yenile";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmKiyapListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKitapDuzenle);
            this.Controls.Add(this.btnKitapSil);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmKiyapListele";
            this.Text = "frmKiyapListele";
            this.Load += new System.EventHandler(this.frmKiyapListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnKitapDuzenle;
        private System.Windows.Forms.Button btnKitapSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}