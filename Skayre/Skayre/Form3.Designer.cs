namespace Skayre
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btSatis = new System.Windows.Forms.Button();
            this.btSatisMalzemeleri = new System.Windows.Forms.Button();
            this.btStokGirisi = new System.Windows.Forms.Button();
            this.btStokMalzemeleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSatis
            // 
            this.btSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btSatis.Location = new System.Drawing.Point(55, 105);
            this.btSatis.Margin = new System.Windows.Forms.Padding(2);
            this.btSatis.Name = "btSatis";
            this.btSatis.Size = new System.Drawing.Size(499, 41);
            this.btSatis.TabIndex = 8;
            this.btSatis.Text = "Satış (F7)";
            this.btSatis.UseVisualStyleBackColor = true;
            // 
            // btSatisMalzemeleri
            // 
            this.btSatisMalzemeleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btSatisMalzemeleri.Location = new System.Drawing.Point(387, 169);
            this.btSatisMalzemeleri.Margin = new System.Windows.Forms.Padding(2);
            this.btSatisMalzemeleri.Name = "btSatisMalzemeleri";
            this.btSatisMalzemeleri.Size = new System.Drawing.Size(157, 67);
            this.btSatisMalzemeleri.TabIndex = 7;
            this.btSatisMalzemeleri.Text = "kapı satış  malzemeleri";
            this.btSatisMalzemeleri.UseVisualStyleBackColor = true;
            // 
            // btStokGirisi
            // 
            this.btStokGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btStokGirisi.Location = new System.Drawing.Point(226, 169);
            this.btStokGirisi.Margin = new System.Windows.Forms.Padding(2);
            this.btStokGirisi.Name = "btStokGirisi";
            this.btStokGirisi.Size = new System.Drawing.Size(157, 67);
            this.btStokGirisi.TabIndex = 6;
            this.btStokGirisi.Text = "kapı giriş";
            this.btStokGirisi.UseVisualStyleBackColor = true;
            // 
            // btStokMalzemeleri
            // 
            this.btStokMalzemeleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btStokMalzemeleri.Location = new System.Drawing.Point(55, 169);
            this.btStokMalzemeleri.Margin = new System.Windows.Forms.Padding(2);
            this.btStokMalzemeleri.Name = "btStokMalzemeleri";
            this.btStokMalzemeleri.Size = new System.Drawing.Size(157, 67);
            this.btStokMalzemeleri.TabIndex = 5;
            this.btStokMalzemeleri.Text = "stokı kapı malzemeleri";
            this.btStokMalzemeleri.UseVisualStyleBackColor = true;
            this.btStokMalzemeleri.Click += new System.EventHandler(this.btStokMalzemeleri_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(607, 278);
            this.Controls.Add(this.btSatis);
            this.Controls.Add(this.btSatisMalzemeleri);
            this.Controls.Add(this.btStokGirisi);
            this.Controls.Add(this.btStokMalzemeleri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSatis;
        private System.Windows.Forms.Button btSatisMalzemeleri;
        private System.Windows.Forms.Button btStokGirisi;
        private System.Windows.Forms.Button btStokMalzemeleri;
    }
}