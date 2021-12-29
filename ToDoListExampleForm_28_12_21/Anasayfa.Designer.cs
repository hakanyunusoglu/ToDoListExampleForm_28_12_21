namespace ToDoListExampleForm_28_12_21
{
    partial class Anasayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelsol = new System.Windows.Forms.Panel();
            this.gbislemlistesi = new System.Windows.Forms.GroupBox();
            this.btnkapat = new System.Windows.Forms.Button();
            this.btnkayitlist = new System.Windows.Forms.Button();
            this.btnyenikayit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblsaat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelsol.SuspendLayout();
            this.gbislemlistesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelsol
            // 
            this.panelsol.Controls.Add(this.gbislemlistesi);
            this.panelsol.Controls.Add(this.pictureBox1);
            this.panelsol.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelsol.Location = new System.Drawing.Point(0, 0);
            this.panelsol.Name = "panelsol";
            this.panelsol.Size = new System.Drawing.Size(200, 450);
            this.panelsol.TabIndex = 1;
            // 
            // gbislemlistesi
            // 
            this.gbislemlistesi.Controls.Add(this.btnkapat);
            this.gbislemlistesi.Controls.Add(this.btnkayitlist);
            this.gbislemlistesi.Controls.Add(this.btnyenikayit);
            this.gbislemlistesi.Location = new System.Drawing.Point(11, 207);
            this.gbislemlistesi.Name = "gbislemlistesi";
            this.gbislemlistesi.Size = new System.Drawing.Size(178, 126);
            this.gbislemlistesi.TabIndex = 3;
            this.gbislemlistesi.TabStop = false;
            this.gbislemlistesi.Text = "İşlem Listesi";
            // 
            // btnkapat
            // 
            this.btnkapat.Location = new System.Drawing.Point(6, 90);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(166, 23);
            this.btnkapat.TabIndex = 0;
            this.btnkapat.Text = "Uygulama Kapat";
            this.btnkapat.UseVisualStyleBackColor = true;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // btnkayitlist
            // 
            this.btnkayitlist.Location = new System.Drawing.Point(6, 61);
            this.btnkayitlist.Name = "btnkayitlist";
            this.btnkayitlist.Size = new System.Drawing.Size(166, 23);
            this.btnkayitlist.TabIndex = 0;
            this.btnkayitlist.Text = "Kayıt Liste";
            this.btnkayitlist.UseVisualStyleBackColor = true;
            this.btnkayitlist.Click += new System.EventHandler(this.btnkayitlist_Click);
            // 
            // btnyenikayit
            // 
            this.btnyenikayit.Location = new System.Drawing.Point(6, 32);
            this.btnyenikayit.Name = "btnyenikayit";
            this.btnyenikayit.Size = new System.Drawing.Size(166, 23);
            this.btnyenikayit.TabIndex = 0;
            this.btnyenikayit.Text = "Yeni Kayıt";
            this.btnyenikayit.UseVisualStyleBackColor = true;
            this.btnyenikayit.Click += new System.EventHandler(this.btnyenikayit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ToDoListExampleForm_28_12_21.Properties.Resources.list_icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblsaat);
            this.panel1.Location = new System.Drawing.Point(884, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 41);
            this.panel1.TabIndex = 4;
            // 
            // lblsaat
            // 
            this.lblsaat.AutoSize = true;
            this.lblsaat.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsaat.Location = new System.Drawing.Point(16, 6);
            this.lblsaat.Name = "lblsaat";
            this.lblsaat.Size = new System.Drawing.Size(185, 28);
            this.lblsaat.TabIndex = 0;
            this.lblsaat.Text = "28/12/2021 11:40";
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelsol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Anasayfa";
            this.Text = "To-Do-Uygulaması";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.panelsol.ResumeLayout(false);
            this.gbislemlistesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelsol;
        private GroupBox gbislemlistesi;
        private Button btnkapat;
        private Button btnkayitlist;
        private Button btnyenikayit;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblsaat;
        private System.Windows.Forms.Timer timer1;
    }
}