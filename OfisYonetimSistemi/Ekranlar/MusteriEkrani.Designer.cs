
namespace OfisYonetimSistemi.Ekranlar
{
    partial class MusteriEkrani
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.clmnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAktif = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Arama";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(12, 122);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 0;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvMusteriler);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 362);
            this.panel1.TabIndex = 1;
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnId,
            this.clmnAktif,
            this.clmnAd,
            this.clmnSoyad,
            this.clmnEmail});
            this.dgvMusteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMusteriler.Location = new System.Drawing.Point(0, 44);
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.ReadOnly = true;
            this.dgvMusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusteriler.Size = new System.Drawing.Size(800, 318);
            this.dgvMusteriler.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Controls.Add(this.btnDuzenle);
            this.panel2.Controls.Add(this.btnYeni);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 44);
            this.panel2.TabIndex = 1;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(399, 11);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(147, 23);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Seçileni/Seçilenleri Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(103, 11);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(106, 23);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "Bilgileri Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(12, 11);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(85, 23);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // clmnId
            // 
            this.clmnId.HeaderText = "Id";
            this.clmnId.Name = "clmnId";
            this.clmnId.ReadOnly = true;
            this.clmnId.Visible = false;
            // 
            // clmnAktif
            // 
            this.clmnAktif.HeaderText = "Aktif";
            this.clmnAktif.Name = "clmnAktif";
            this.clmnAktif.ReadOnly = true;
            this.clmnAktif.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnAktif.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmnAktif.Width = 50;
            // 
            // clmnAd
            // 
            this.clmnAd.HeaderText = "Ad";
            this.clmnAd.Name = "clmnAd";
            this.clmnAd.ReadOnly = true;
            // 
            // clmnSoyad
            // 
            this.clmnSoyad.HeaderText = "Soyad";
            this.clmnSoyad.Name = "clmnSoyad";
            this.clmnSoyad.ReadOnly = true;
            // 
            // clmnEmail
            // 
            this.clmnEmail.HeaderText = "Email";
            this.clmnEmail.Name = "clmnEmail";
            this.clmnEmail.ReadOnly = true;
            // 
            // MusteriEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MusteriEkrani";
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.MusteriEkrani_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnAktif;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmail;
    }
}