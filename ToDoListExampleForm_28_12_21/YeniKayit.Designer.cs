namespace ToDoListExampleForm_28_12_21
{
    partial class YeniKayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.txtKisaAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOnemDerecesi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbDurum = new System.Windows.Forms.ComboBox();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlık:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kısa Açıklama:";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(101, 6);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(171, 23);
            this.txtBaslik.TabIndex = 1;
            // 
            // txtKisaAciklama
            // 
            this.txtKisaAciklama.Location = new System.Drawing.Point(101, 35);
            this.txtKisaAciklama.Multiline = true;
            this.txtKisaAciklama.Name = "txtKisaAciklama";
            this.txtKisaAciklama.Size = new System.Drawing.Size(171, 73);
            this.txtKisaAciklama.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(101, 114);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(171, 135);
            this.txtAciklama.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Önem Derecesi:";
            // 
            // txtOnemDerecesi
            // 
            this.txtOnemDerecesi.Location = new System.Drawing.Point(101, 255);
            this.txtOnemDerecesi.Name = "txtOnemDerecesi";
            this.txtOnemDerecesi.Size = new System.Drawing.Size(171, 23);
            this.txtOnemDerecesi.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Durum:";
            // 
            // cbbDurum
            // 
            this.cbbDurum.FormattingEnabled = true;
            this.cbbDurum.Items.AddRange(new object[] {
            "Beklemede",
            "Tamamlandı",
            "Tamamlanmadı",
            "İptal Edildi",
            "Ertelendi"});
            this.cbbDurum.Location = new System.Drawing.Point(101, 284);
            this.cbbDurum.Name = "cbbDurum";
            this.cbbDurum.Size = new System.Drawing.Size(171, 23);
            this.cbbDurum.TabIndex = 2;
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(197, 313);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(75, 23);
            this.btnYeniKayit.TabIndex = 3;
            this.btnYeniKayit.Text = "Kaydet";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            // 
            // YeniKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 341);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.cbbDurum);
            this.Controls.Add(this.txtKisaAciklama);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtOnemDerecesi);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YeniKayit";
            this.Text = "ToDo - Yeni Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBaslik;
        private TextBox txtKisaAciklama;
        private Label label3;
        private TextBox txtAciklama;
        private Label label4;
        private TextBox txtOnemDerecesi;
        private Label label5;
        private ComboBox cbbDurum;
        private Button btnYeniKayit;
    }
}