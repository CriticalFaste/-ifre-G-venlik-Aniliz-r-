namespace Şifre_Güvenlik_Analizörü
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnAnaliz = new System.Windows.Forms.Button();
            this.pbGuc = new System.Windows.Forms.ProgressBar();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(316, 237);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(148, 22);
            this.txtSifre.TabIndex = 0;
            // 
            // btnAnaliz
            // 
            this.btnAnaliz.Location = new System.Drawing.Point(343, 286);
            this.btnAnaliz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnaliz.Name = "btnAnaliz";
            this.btnAnaliz.Size = new System.Drawing.Size(112, 28);
            this.btnAnaliz.TabIndex = 1;
            this.btnAnaliz.Text = "Analiz Et";
            this.btnAnaliz.UseVisualStyleBackColor = true;
            this.btnAnaliz.Click += new System.EventHandler(this.btnAnaliz_Click);
            // 
            // pbGuc
            // 
            this.pbGuc.Location = new System.Drawing.Point(314, 168);
            this.pbGuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbGuc.Name = "pbGuc";
            this.pbGuc.Size = new System.Drawing.Size(150, 28);
            this.pbGuc.TabIndex = 2;
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(311, 48);
            this.lblsonuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(0, 16);
            this.lblsonuc.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.pbGuc);
            this.Controls.Add(this.btnAnaliz);
            this.Controls.Add(this.txtSifre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnAnaliz;
        private System.Windows.Forms.ProgressBar pbGuc;
        private System.Windows.Forms.Label lblsonuc;
    }
}

