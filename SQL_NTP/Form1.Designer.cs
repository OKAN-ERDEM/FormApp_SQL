namespace SQL_NTP
{
    partial class Form1
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
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblNumara = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSfrla = new System.Windows.Forms.Button();
            this.lblBul = new System.Windows.Forms.Label();
            this.txtBul = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.cmbSiniflar = new System.Windows.Forms.ComboBox();
            this.lblSec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(137, 112);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(31, 17);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "AD:";
            this.lblAd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(108, 140);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(60, 17);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "SOYAD:";
            this.lblSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Location = new System.Drawing.Point(97, 168);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(71, 17);
            this.lblNumara.TabIndex = 2;
            this.lblNumara.Text = "NUMARA:";
            this.lblNumara.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(113, 196);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(55, 17);
            this.lblTC.TabIndex = 3;
            this.lblTC.Text = "TC NO:";
            this.lblTC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(190, 109);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(196, 22);
            this.txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(190, 137);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(196, 22);
            this.txtSoyad.TabIndex = 6;
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(190, 165);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(196, 22);
            this.txtNumara.TabIndex = 7;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(190, 193);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(196, 22);
            this.txtTC.TabIndex = 8;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LawnGreen;
            this.btnKaydet.Location = new System.Drawing.Point(285, 251);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(101, 30);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSfrla
            // 
            this.btnSfrla.BackColor = System.Drawing.Color.DarkRed;
            this.btnSfrla.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSfrla.Location = new System.Drawing.Point(190, 251);
            this.btnSfrla.Name = "btnSfrla";
            this.btnSfrla.Size = new System.Drawing.Size(78, 30);
            this.btnSfrla.TabIndex = 11;
            this.btnSfrla.Text = "SIFIRLA";
            this.btnSfrla.UseVisualStyleBackColor = false;
            this.btnSfrla.Click += new System.EventHandler(this.btnSfrla_Click);
            // 
            // lblBul
            // 
            this.lblBul.AutoSize = true;
            this.lblBul.Location = new System.Drawing.Point(94, 342);
            this.lblBul.Name = "lblBul";
            this.lblBul.Size = new System.Drawing.Size(74, 17);
            this.lblBul.TabIndex = 12;
            this.lblBul.Text = "No Giriniz:";
            this.lblBul.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBul
            // 
            this.txtBul.Location = new System.Drawing.Point(190, 339);
            this.txtBul.Name = "txtBul";
            this.txtBul.Size = new System.Drawing.Size(140, 22);
            this.txtBul.TabIndex = 13;
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBul.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBul.Location = new System.Drawing.Point(336, 335);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(50, 30);
            this.btnBul.TabIndex = 14;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // cmbSiniflar
            // 
            this.cmbSiniflar.FormattingEnabled = true;
            this.cmbSiniflar.Location = new System.Drawing.Point(190, 221);
            this.cmbSiniflar.Name = "cmbSiniflar";
            this.cmbSiniflar.Size = new System.Drawing.Size(196, 24);
            this.cmbSiniflar.TabIndex = 15;
            this.cmbSiniflar.SelectedIndexChanged += new System.EventHandler(this.Form1_Load);
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(92, 224);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(76, 17);
            this.lblSec.TabIndex = 16;
            this.lblSec.Text = "SINIF SEÇ:";
            this.lblSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 450);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.cmbSiniflar);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtBul);
            this.Controls.Add(this.lblBul);
            this.Controls.Add(this.btnSfrla);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lblNumara);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSfrla;
        private System.Windows.Forms.Label lblBul;
        private System.Windows.Forms.TextBox txtBul;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.ComboBox cmbSiniflar;
        private System.Windows.Forms.Label lblSec;
    }
}

