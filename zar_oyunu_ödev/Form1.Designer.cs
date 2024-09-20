namespace zar_oyunu_ödev
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpoyuncu = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.o1rdb = new System.Windows.Forms.RadioButton();
            this.o2rdb = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtzar1 = new System.Windows.Forms.TextBox();
            this.txtzar2 = new System.Windows.Forms.TextBox();
            this.btnzarlarıat = new System.Windows.Forms.Button();
            this.btnskoraekle = new System.Windows.Forms.Button();
            this.txto1skor = new System.Windows.Forms.TextBox();
            this.txto2skor = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.grpoyuncu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpoyuncu
            // 
            this.grpoyuncu.Controls.Add(this.txto2skor);
            this.grpoyuncu.Controls.Add(this.txto1skor);
            this.grpoyuncu.Controls.Add(this.listBox2);
            this.grpoyuncu.Controls.Add(this.listBox1);
            this.grpoyuncu.Controls.Add(this.o2rdb);
            this.grpoyuncu.Controls.Add(this.o1rdb);
            this.grpoyuncu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpoyuncu.Location = new System.Drawing.Point(39, 12);
            this.grpoyuncu.Name = "grpoyuncu";
            this.grpoyuncu.Size = new System.Drawing.Size(332, 249);
            this.grpoyuncu.TabIndex = 0;
            this.grpoyuncu.TabStop = false;
            this.grpoyuncu.Text = "Oyuncular";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pb2);
            this.groupBox2.Controls.Add(this.pb1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(45, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 186);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zarlar";
            // 
            // o1rdb
            // 
            this.o1rdb.AutoSize = true;
            this.o1rdb.Location = new System.Drawing.Point(6, 21);
            this.o1rdb.Name = "o1rdb";
            this.o1rdb.Size = new System.Drawing.Size(100, 22);
            this.o1rdb.TabIndex = 0;
            this.o1rdb.TabStop = true;
            this.o1rdb.Text = "Oyuncu 1";
            this.o1rdb.UseVisualStyleBackColor = true;
            // 
            // o2rdb
            // 
            this.o2rdb.AutoSize = true;
            this.o2rdb.Location = new System.Drawing.Point(170, 21);
            this.o2rdb.Name = "o2rdb";
            this.o2rdb.Size = new System.Drawing.Size(100, 22);
            this.o2rdb.TabIndex = 1;
            this.o2rdb.TabStop = true;
            this.o2rdb.Text = "Oyuncu 2";
            this.o2rdb.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 148);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(170, 47);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 148);
            this.listBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(420, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "1. Zarın Değeri:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(420, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "2. Zarın Değeri:";
            // 
            // txtzar1
            // 
            this.txtzar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtzar1.ForeColor = System.Drawing.Color.Red;
            this.txtzar1.Location = new System.Drawing.Point(545, 119);
            this.txtzar1.Name = "txtzar1";
            this.txtzar1.Size = new System.Drawing.Size(74, 24);
            this.txtzar1.TabIndex = 4;
            // 
            // txtzar2
            // 
            this.txtzar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtzar2.ForeColor = System.Drawing.Color.Red;
            this.txtzar2.Location = new System.Drawing.Point(545, 171);
            this.txtzar2.Name = "txtzar2";
            this.txtzar2.Size = new System.Drawing.Size(74, 24);
            this.txtzar2.TabIndex = 5;
            // 
            // btnzarlarıat
            // 
            this.btnzarlarıat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnzarlarıat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnzarlarıat.Location = new System.Drawing.Point(476, 321);
            this.btnzarlarıat.Name = "btnzarlarıat";
            this.btnzarlarıat.Size = new System.Drawing.Size(134, 50);
            this.btnzarlarıat.TabIndex = 6;
            this.btnzarlarıat.Text = "ZARLARI AT";
            this.btnzarlarıat.UseVisualStyleBackColor = false;
            this.btnzarlarıat.Click += new System.EventHandler(this.btnzarlarıat_Click);
            // 
            // btnskoraekle
            // 
            this.btnskoraekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnskoraekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnskoraekle.Location = new System.Drawing.Point(476, 396);
            this.btnskoraekle.Name = "btnskoraekle";
            this.btnskoraekle.Size = new System.Drawing.Size(134, 48);
            this.btnskoraekle.TabIndex = 7;
            this.btnskoraekle.Text = "SKORA EKLE";
            this.btnskoraekle.UseVisualStyleBackColor = false;
            this.btnskoraekle.Click += new System.EventHandler(this.btnskoraekle_Click);
            // 
            // txto1skor
            // 
            this.txto1skor.ForeColor = System.Drawing.Color.DarkViolet;
            this.txto1skor.Location = new System.Drawing.Point(6, 211);
            this.txto1skor.Name = "txto1skor";
            this.txto1skor.Size = new System.Drawing.Size(120, 24);
            this.txto1skor.TabIndex = 6;
            this.txto1skor.Text = "0";
            // 
            // txto2skor
            // 
            this.txto2skor.ForeColor = System.Drawing.Color.DarkViolet;
            this.txto2skor.Location = new System.Drawing.Point(170, 211);
            this.txto2skor.Name = "txto2skor";
            this.txto2skor.Size = new System.Drawing.Size(120, 24);
            this.txto2skor.TabIndex = 7;
            this.txto2skor.Text = "0";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "zar_1.jpg");
            this.ımageList1.Images.SetKeyName(1, "zar_2.jpg");
            this.ımageList1.Images.SetKeyName(2, "zar_3.jpg");
            this.ımageList1.Images.SetKeyName(3, "zar_4.jpg");
            this.ımageList1.Images.SetKeyName(4, "zar_5.jpg");
            this.ımageList1.Images.SetKeyName(5, "zar_6.jpg");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(21, 35);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(128, 133);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(170, 35);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(140, 133);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(713, 485);
            this.Controls.Add(this.btnskoraekle);
            this.Controls.Add(this.btnzarlarıat);
            this.Controls.Add(this.txtzar2);
            this.Controls.Add(this.txtzar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpoyuncu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ZAR OYUNU";
            this.grpoyuncu.ResumeLayout(false);
            this.grpoyuncu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpoyuncu;
        private System.Windows.Forms.TextBox txto2skor;
        private System.Windows.Forms.TextBox txto1skor;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton o2rdb;
        private System.Windows.Forms.RadioButton o1rdb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtzar1;
        private System.Windows.Forms.TextBox txtzar2;
        private System.Windows.Forms.Button btnzarlarıat;
        private System.Windows.Forms.Button btnskoraekle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Timer timer1;
    }
}

