namespace EnglishPractice
{
    partial class kelime_b2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_yanlis = new System.Windows.Forms.Label();
            this.lbl_dogru = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_kontrol = new System.Windows.Forms.Button();
            this.Btn_kelimever = new System.Windows.Forms.Button();
            this.txt_karsilik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kelime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(13, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 31);
            this.button1.TabIndex = 44;
            this.button1.Text = "←";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(525, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 31);
            this.button2.TabIndex = 43;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_yanlis
            // 
            this.lbl_yanlis.AutoSize = true;
            this.lbl_yanlis.ForeColor = System.Drawing.Color.Red;
            this.lbl_yanlis.Location = new System.Drawing.Point(458, 106);
            this.lbl_yanlis.Name = "lbl_yanlis";
            this.lbl_yanlis.Size = new System.Drawing.Size(56, 23);
            this.lbl_yanlis.TabIndex = 42;
            this.lbl_yanlis.Text = "NULL";
            // 
            // lbl_dogru
            // 
            this.lbl_dogru.AutoSize = true;
            this.lbl_dogru.ForeColor = System.Drawing.Color.Green;
            this.lbl_dogru.Location = new System.Drawing.Point(458, 60);
            this.lbl_dogru.Name = "lbl_dogru";
            this.lbl_dogru.Size = new System.Drawing.Size(56, 23);
            this.lbl_dogru.TabIndex = 41;
            this.lbl_dogru.Text = "NULL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 40;
            this.label4.Text = "Yanlış:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(388, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Doğru:";
            // 
            // Btn_kontrol
            // 
            this.Btn_kontrol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_kontrol.Location = new System.Drawing.Point(207, 207);
            this.Btn_kontrol.Name = "Btn_kontrol";
            this.Btn_kontrol.Size = new System.Drawing.Size(139, 34);
            this.Btn_kontrol.TabIndex = 38;
            this.Btn_kontrol.Text = "Kontrol";
            this.Btn_kontrol.UseVisualStyleBackColor = true;
            this.Btn_kontrol.Click += new System.EventHandler(this.Btn_kontrol_Click);
            // 
            // Btn_kelimever
            // 
            this.Btn_kelimever.Location = new System.Drawing.Point(207, 167);
            this.Btn_kelimever.Name = "Btn_kelimever";
            this.Btn_kelimever.Size = new System.Drawing.Size(139, 34);
            this.Btn_kelimever.TabIndex = 37;
            this.Btn_kelimever.Text = "Kelime Ver";
            this.Btn_kelimever.UseVisualStyleBackColor = true;
            this.Btn_kelimever.Click += new System.EventHandler(this.Btn_kelimever_Click);
            // 
            // txt_karsilik
            // 
            this.txt_karsilik.Location = new System.Drawing.Point(207, 120);
            this.txt_karsilik.Name = "txt_karsilik";
            this.txt_karsilik.Size = new System.Drawing.Size(139, 31);
            this.txt_karsilik.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Türkçe Karşılığı:";
            // 
            // txt_kelime
            // 
            this.txt_kelime.Enabled = false;
            this.txt_kelime.Location = new System.Drawing.Point(207, 60);
            this.txt_kelime.Name = "txt_kelime";
            this.txt_kelime.Size = new System.Drawing.Size(139, 31);
            this.txt_kelime.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Kelimeniz:";
            // 
            // kelime_b2
            // 
            this.AcceptButton = this.Btn_kontrol;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(566, 277);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_yanlis);
            this.Controls.Add(this.lbl_dogru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_kontrol);
            this.Controls.Add(this.Btn_kelimever);
            this.Controls.Add(this.txt_karsilik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_kelime);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "kelime_b2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kelime_b2";
            this.Load += new System.EventHandler(this.kelime_b2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_yanlis;
        private System.Windows.Forms.Label lbl_dogru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_kontrol;
        private System.Windows.Forms.Button Btn_kelimever;
        private System.Windows.Forms.TextBox txt_karsilik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kelime;
        private System.Windows.Forms.Label label1;
    }
}