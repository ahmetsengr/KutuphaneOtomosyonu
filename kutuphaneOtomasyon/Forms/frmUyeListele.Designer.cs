namespace kutuphaneOtomasyon
{
    partial class frmUyeListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCikis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUyeDuzenle = new System.Windows.Forms.Button();
            this.btnUyeSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 137);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(454, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCikis.Location = new System.Drawing.Point(367, 400);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(99, 35);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button1.Image = global::kutuphaneOtomasyon.Properties.Resources.refresh;
            this.button1.Location = new System.Drawing.Point(371, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 105);
            this.button1.TabIndex = 7;
            this.button1.Text = "Yenile";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUyeDuzenle
            // 
            this.btnUyeDuzenle.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnUyeDuzenle.Image = global::kutuphaneOtomasyon.Properties.Resources.user_pencil;
            this.btnUyeDuzenle.Location = new System.Drawing.Point(113, 12);
            this.btnUyeDuzenle.Name = "btnUyeDuzenle";
            this.btnUyeDuzenle.Size = new System.Drawing.Size(95, 105);
            this.btnUyeDuzenle.TabIndex = 3;
            this.btnUyeDuzenle.Text = "Üye Düzenle";
            this.btnUyeDuzenle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUyeDuzenle.UseVisualStyleBackColor = true;
            this.btnUyeDuzenle.Click += new System.EventHandler(this.btnUyeDuzenle_Click);
            // 
            // btnUyeSil
            // 
            this.btnUyeSil.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnUyeSil.Image = global::kutuphaneOtomasyon.Properties.Resources.user_close;
            this.btnUyeSil.Location = new System.Drawing.Point(12, 12);
            this.btnUyeSil.Name = "btnUyeSil";
            this.btnUyeSil.Size = new System.Drawing.Size(95, 105);
            this.btnUyeSil.TabIndex = 2;
            this.btnUyeSil.Text = "Üye Sil";
            this.btnUyeSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUyeSil.UseVisualStyleBackColor = true;
            this.btnUyeSil.Click += new System.EventHandler(this.btnUyeSil_Click);
            // 
            // frmUyeListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(478, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnUyeDuzenle);
            this.Controls.Add(this.btnUyeSil);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmUyeListele";
            this.Text = "frmUyeListele";
            this.Load += new System.EventHandler(this.frmUyeListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUyeSil;
        private System.Windows.Forms.Button btnUyeDuzenle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button button1;
    }
}