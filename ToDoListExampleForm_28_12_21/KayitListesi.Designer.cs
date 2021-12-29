namespace ToDoListExampleForm_28_12_21
{
    partial class KayitListesi
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
            this.gbislemListesi = new System.Windows.Forms.GroupBox();
            this.btnbeklemede = new System.Windows.Forms.Button();
            this.btnertelendi = new System.Windows.Forms.Button();
            this.btniptaledildi = new System.Windows.Forms.Button();
            this.btntamamlanamadi = new System.Windows.Forms.Button();
            this.btntamamlandi = new System.Windows.Forms.Button();
            this.btntumListe = new System.Windows.Forms.Button();
            this.gbListe = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.gbislemListesi.SuspendLayout();
            this.gbListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // gbislemListesi
            // 
            this.gbislemListesi.Controls.Add(this.btnbeklemede);
            this.gbislemListesi.Controls.Add(this.btnertelendi);
            this.gbislemListesi.Controls.Add(this.btniptaledildi);
            this.gbislemListesi.Controls.Add(this.btntamamlanamadi);
            this.gbislemListesi.Controls.Add(this.btntamamlandi);
            this.gbislemListesi.Controls.Add(this.btntumListe);
            this.gbislemListesi.Location = new System.Drawing.Point(12, 12);
            this.gbislemListesi.Name = "gbislemListesi";
            this.gbislemListesi.Size = new System.Drawing.Size(125, 234);
            this.gbislemListesi.TabIndex = 0;
            this.gbislemListesi.TabStop = false;
            this.gbislemListesi.Text = "İşlem Listesi";
            // 
            // btnbeklemede
            // 
            this.btnbeklemede.Location = new System.Drawing.Point(6, 167);
            this.btnbeklemede.Name = "btnbeklemede";
            this.btnbeklemede.Size = new System.Drawing.Size(108, 23);
            this.btnbeklemede.TabIndex = 5;
            this.btnbeklemede.Text = "Beklemede";
            this.btnbeklemede.UseVisualStyleBackColor = true;
            this.btnbeklemede.Click += new System.EventHandler(this.btnbeklemede_Click);
            // 
            // btnertelendi
            // 
            this.btnertelendi.Location = new System.Drawing.Point(6, 138);
            this.btnertelendi.Name = "btnertelendi";
            this.btnertelendi.Size = new System.Drawing.Size(108, 23);
            this.btnertelendi.TabIndex = 4;
            this.btnertelendi.Text = "Ertelendi";
            this.btnertelendi.UseVisualStyleBackColor = true;
            this.btnertelendi.Click += new System.EventHandler(this.btnertelendi_Click);
            // 
            // btniptaledildi
            // 
            this.btniptaledildi.Location = new System.Drawing.Point(6, 109);
            this.btniptaledildi.Name = "btniptaledildi";
            this.btniptaledildi.Size = new System.Drawing.Size(108, 23);
            this.btniptaledildi.TabIndex = 3;
            this.btniptaledildi.Text = "İptal Edildi";
            this.btniptaledildi.UseVisualStyleBackColor = true;
            this.btniptaledildi.Click += new System.EventHandler(this.btniptaledildi_Click);
            // 
            // btntamamlanamadi
            // 
            this.btntamamlanamadi.Location = new System.Drawing.Point(6, 80);
            this.btntamamlanamadi.Name = "btntamamlanamadi";
            this.btntamamlanamadi.Size = new System.Drawing.Size(108, 23);
            this.btntamamlanamadi.TabIndex = 2;
            this.btntamamlanamadi.Text = "Tamamlanamadı";
            this.btntamamlanamadi.UseVisualStyleBackColor = true;
            this.btntamamlanamadi.Click += new System.EventHandler(this.btntamamlanamadi_Click);
            // 
            // btntamamlandi
            // 
            this.btntamamlandi.Location = new System.Drawing.Point(6, 51);
            this.btntamamlandi.Name = "btntamamlandi";
            this.btntamamlandi.Size = new System.Drawing.Size(108, 23);
            this.btntamamlandi.TabIndex = 1;
            this.btntamamlandi.Text = "Tamamlandı";
            this.btntamamlandi.UseVisualStyleBackColor = true;
            this.btntamamlandi.Click += new System.EventHandler(this.btntamamlandi_Click);
            // 
            // btntumListe
            // 
            this.btntumListe.Location = new System.Drawing.Point(6, 22);
            this.btntumListe.Name = "btntumListe";
            this.btntumListe.Size = new System.Drawing.Size(108, 23);
            this.btntumListe.TabIndex = 0;
            this.btntumListe.Text = "Tüm Liste";
            this.btntumListe.UseVisualStyleBackColor = true;
            this.btntumListe.Click += new System.EventHandler(this.btntumListe_Click);
            // 
            // gbListe
            // 
            this.gbListe.Controls.Add(this.dgv);
            this.gbListe.Location = new System.Drawing.Point(143, 12);
            this.gbListe.Name = "gbListe";
            this.gbListe.Size = new System.Drawing.Size(656, 234);
            this.gbListe.TabIndex = 1;
            this.gbListe.TabStop = false;
            this.gbListe.Text = "Liste";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 19);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(650, 212);
            this.dgv.TabIndex = 0;
            // 
            // KayitListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 249);
            this.Controls.Add(this.gbListe);
            this.Controls.Add(this.gbislemListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KayitListesi";
            this.Text = "ToDo - Kayıt Listesi";
            this.Load += new System.EventHandler(this.KayitListesi_Load);
            this.gbislemListesi.ResumeLayout(false);
            this.gbListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbislemListesi;
        private Button btniptaledildi;
        private Button btntamamlanamadi;
        private Button btntamamlandi;
        private Button btntumListe;
        private GroupBox gbListe;
        private DataGridView dgv;
        private Button btnbeklemede;
        private Button btnertelendi;
    }
}