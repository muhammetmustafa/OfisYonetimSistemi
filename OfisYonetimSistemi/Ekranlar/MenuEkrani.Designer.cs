
namespace OfisYonetimSistemi.Ekranlar
{
    partial class MenuEkrani
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
            this.btnMusteri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMusteri
            // 
            this.btnMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnMusteri.Location = new System.Drawing.Point(47, 45);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(192, 42);
            this.btnMusteri.TabIndex = 0;
            this.btnMusteri.Text = "Müşteriler";
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 345);
            this.Controls.Add(this.btnMusteri);
            this.Name = "MenuEkrani";
            this.Text = "Ofis Yönetim Sistemi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusteri;
    }
}

