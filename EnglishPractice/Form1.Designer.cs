namespace EnglishPractice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btna1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btna2 = new System.Windows.Forms.Button();
            this.btnb1 = new System.Windows.Forms.Button();
            this.btnb2 = new System.Windows.Forms.Button();
            this.btnc1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btna1
            // 
            this.btna1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btna1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btna1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btna1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btna1.Location = new System.Drawing.Point(311, 60);
            this.btna1.Name = "btna1";
            this.btna1.Size = new System.Drawing.Size(135, 50);
            this.btna1.TabIndex = 2;
            this.btna1.Text = "A1";
            this.btna1.UseVisualStyleBackColor = false;
            this.btna1.Click += new System.EventHandler(this.btna1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lütfen seviyenizi seçiniz";
            // 
            // btna2
            // 
            this.btna2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btna2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btna2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btna2.Location = new System.Drawing.Point(311, 116);
            this.btna2.Name = "btna2";
            this.btna2.Size = new System.Drawing.Size(135, 50);
            this.btna2.TabIndex = 4;
            this.btna2.Text = "A2";
            this.btna2.UseVisualStyleBackColor = false;
            this.btna2.Click += new System.EventHandler(this.btna2_Click);
            // 
            // btnb1
            // 
            this.btnb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnb1.Location = new System.Drawing.Point(311, 172);
            this.btnb1.Name = "btnb1";
            this.btnb1.Size = new System.Drawing.Size(135, 50);
            this.btnb1.TabIndex = 5;
            this.btnb1.Text = "B1";
            this.btnb1.UseVisualStyleBackColor = false;
            this.btnb1.Click += new System.EventHandler(this.btnb1_Click);
            // 
            // btnb2
            // 
            this.btnb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnb2.Location = new System.Drawing.Point(311, 228);
            this.btnb2.Name = "btnb2";
            this.btnb2.Size = new System.Drawing.Size(135, 50);
            this.btnb2.TabIndex = 6;
            this.btnb2.Text = "B2";
            this.btnb2.UseVisualStyleBackColor = false;
            this.btnb2.Click += new System.EventHandler(this.btnb2_Click);
            // 
            // btnc1
            // 
            this.btnc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnc1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnc1.Location = new System.Drawing.Point(311, 284);
            this.btnc1.Name = "btnc1";
            this.btnc1.Size = new System.Drawing.Size(135, 50);
            this.btnc1.TabIndex = 7;
            this.btnc1.Text = "C1";
            this.btnc1.UseVisualStyleBackColor = false;
            this.btnc1.Click += new System.EventHandler(this.btnc1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(433, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Info";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(497, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 31);
            this.button2.TabIndex = 10;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(34, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "English Word Practise";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(535, 359);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnc1);
            this.Controls.Add(this.btnb2);
            this.Controls.Add(this.btnb1);
            this.Controls.Add(this.btna2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btna1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btna1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btna2;
        private System.Windows.Forms.Button btnb1;
        private System.Windows.Forms.Button btnb2;
        private System.Windows.Forms.Button btnc1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}

