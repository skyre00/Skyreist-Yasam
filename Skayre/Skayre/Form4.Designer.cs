namespace Skayre
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.gvMalzemeler = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMarkasi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBirim = new System.Windows.Forms.ComboBox();
            this.tbMalzemeAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvMalzemeler)).BeginInit();
            this.SuspendLayout();
            // 
            // gvMalzemeler
            // 
            this.gvMalzemeler.AllowUserToOrderColumns = true;
            this.gvMalzemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMalzemeler.Location = new System.Drawing.Point(87, 168);
            this.gvMalzemeler.Margin = new System.Windows.Forms.Padding(2);
            this.gvMalzemeler.Name = "gvMalzemeler";
            this.gvMalzemeler.RowTemplate.Height = 24;
            this.gvMalzemeler.Size = new System.Drawing.Size(373, 128);
            this.gvMalzemeler.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(189, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Birimi";
            // 
            // tbMarkasi
            // 
            this.tbMarkasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMarkasi.Location = new System.Drawing.Point(294, 84);
            this.tbMarkasi.Margin = new System.Windows.Forms.Padding(2);
            this.tbMarkasi.Name = "tbMarkasi";
            this.tbMarkasi.Size = new System.Drawing.Size(167, 29);
            this.tbMarkasi.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(173, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Markası";
            // 
            // cbBirim
            // 
            this.cbBirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbBirim.FormattingEnabled = true;
            this.cbBirim.Items.AddRange(new object[] {
            "Kg",
            "Tepsi",
            "Adet"});
            this.cbBirim.Location = new System.Drawing.Point(294, 44);
            this.cbBirim.Margin = new System.Windows.Forms.Padding(2);
            this.cbBirim.Name = "cbBirim";
            this.cbBirim.Size = new System.Drawing.Size(167, 32);
            this.cbBirim.TabIndex = 16;
            // 
            // tbMalzemeAdi
            // 
            this.tbMalzemeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMalzemeAdi.Location = new System.Drawing.Point(294, 7);
            this.tbMalzemeAdi.Margin = new System.Windows.Forms.Padding(2);
            this.tbMalzemeAdi.Name = "tbMalzemeAdi";
            this.tbMalzemeAdi.Size = new System.Drawing.Size(167, 29);
            this.tbMalzemeAdi.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Malzeme Adı:";
            // 
            // btEkle
            // 
            this.btEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btEkle.Location = new System.Drawing.Point(87, 126);
            this.btEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btEkle.Name = "btEkle";
            this.btEkle.Size = new System.Drawing.Size(373, 37);
            this.btEkle.TabIndex = 13;
            this.btEkle.Text = "Ekle";
            this.btEkle.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(560, 319);
            this.Controls.Add(this.gvMalzemeler);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMarkasi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBirim);
            this.Controls.Add(this.tbMalzemeAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEkle);
            this.Name = "Form4";
            this.Text = "Stok Takip Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.gvMalzemeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvMalzemeler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMarkasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBirim;
        private System.Windows.Forms.TextBox tbMalzemeAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEkle;
    }
}