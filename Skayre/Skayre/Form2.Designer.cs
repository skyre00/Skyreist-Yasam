namespace Skayre
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tbYeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btIptal = new System.Windows.Forms.Button();
            this.btSifreDegistir = new System.Windows.Forms.Button();
            this.tbYeniSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEskiSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbYeniSifreTekrar
            // 
            this.tbYeniSifreTekrar.Location = new System.Drawing.Point(147, 74);
            this.tbYeniSifreTekrar.Margin = new System.Windows.Forms.Padding(2);
            this.tbYeniSifreTekrar.Name = "tbYeniSifreTekrar";
            this.tbYeniSifreTekrar.PasswordChar = '&';
            this.tbYeniSifreTekrar.Size = new System.Drawing.Size(121, 20);
            this.tbYeniSifreTekrar.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Yeni Şifreniz(tekrar):";
            // 
            // btIptal
            // 
            this.btIptal.Image = ((System.Drawing.Image)(resources.GetObject("btIptal.Image")));
            this.btIptal.Location = new System.Drawing.Point(15, 132);
            this.btIptal.Margin = new System.Windows.Forms.Padding(2);
            this.btIptal.Name = "btIptal";
            this.btIptal.Size = new System.Drawing.Size(86, 54);
            this.btIptal.TabIndex = 13;
            this.btIptal.UseVisualStyleBackColor = true;
            // 
            // btSifreDegistir
            // 
            this.btSifreDegistir.Image = ((System.Drawing.Image)(resources.GetObject("btSifreDegistir.Image")));
            this.btSifreDegistir.Location = new System.Drawing.Point(142, 132);
            this.btSifreDegistir.Margin = new System.Windows.Forms.Padding(2);
            this.btSifreDegistir.Name = "btSifreDegistir";
            this.btSifreDegistir.Size = new System.Drawing.Size(86, 54);
            this.btSifreDegistir.TabIndex = 12;
            this.btSifreDegistir.UseVisualStyleBackColor = true;
            this.btSifreDegistir.Click += new System.EventHandler(this.btSifreDegistir_Click);
            // 
            // tbYeniSifre
            // 
            this.tbYeniSifre.Location = new System.Drawing.Point(147, 38);
            this.tbYeniSifre.Margin = new System.Windows.Forms.Padding(2);
            this.tbYeniSifre.Name = "tbYeniSifre";
            this.tbYeniSifre.PasswordChar = '&';
            this.tbYeniSifre.Size = new System.Drawing.Size(121, 20);
            this.tbYeniSifre.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Yeni Şifreniz:";
            // 
            // tbEskiSifre
            // 
            this.tbEskiSifre.Location = new System.Drawing.Point(147, 7);
            this.tbEskiSifre.Margin = new System.Windows.Forms.Padding(2);
            this.tbEskiSifre.Name = "tbEskiSifre";
            this.tbEskiSifre.PasswordChar = '&';
            this.tbEskiSifre.Size = new System.Drawing.Size(121, 20);
            this.tbEskiSifre.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Eski şifreniz:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbYeniSifreTekrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btIptal);
            this.Controls.Add(this.btSifreDegistir);
            this.Controls.Add(this.tbYeniSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEskiSifre);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbYeniSifreTekrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btIptal;
        private System.Windows.Forms.Button btSifreDegistir;
        private System.Windows.Forms.TextBox tbYeniSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEskiSifre;
        private System.Windows.Forms.Label label1;
    }
}