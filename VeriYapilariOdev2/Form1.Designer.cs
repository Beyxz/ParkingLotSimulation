namespace VeriYapilariOdev2
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
            this.btnArabaEkle = new System.Windows.Forms.Button();
            this.btnArabaCikar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArabaEkle
            // 
            this.btnArabaEkle.Location = new System.Drawing.Point(171, 51);
            this.btnArabaEkle.Name = "btnArabaEkle";
            this.btnArabaEkle.Size = new System.Drawing.Size(167, 127);
            this.btnArabaEkle.TabIndex = 0;
            this.btnArabaEkle.Text = "Araba Ekle";
            this.btnArabaEkle.UseVisualStyleBackColor = true;
            this.btnArabaEkle.Click += new System.EventHandler(this.btnArabaEkle_Click);
            // 
            // btnArabaCikar
            // 
            this.btnArabaCikar.Location = new System.Drawing.Point(171, 210);
            this.btnArabaCikar.Name = "btnArabaCikar";
            this.btnArabaCikar.Size = new System.Drawing.Size(175, 110);
            this.btnArabaCikar.TabIndex = 1;
            this.btnArabaCikar.Text = "Araba Çıkar";
            this.btnArabaCikar.UseVisualStyleBackColor = true;
            this.btnArabaCikar.Visible = false;
            this.btnArabaCikar.Click += new System.EventHandler(this.btnArabaCikar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 482);
            this.Controls.Add(this.btnArabaCikar);
            this.Controls.Add(this.btnArabaEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArabaEkle;
        private System.Windows.Forms.Button btnArabaCikar;
    }
}

