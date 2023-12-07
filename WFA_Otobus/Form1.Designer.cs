namespace WFA_Otobus
{
    partial class Form1
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
            flp_koltuk = new FlowLayoutPanel();
            gb_kisiselBilgiler = new GroupBox();
            btn_kaydet = new Button();
            rdb_kadin = new RadioButton();
            rdb_erkek = new RadioButton();
            txt_koltuk = new TextBox();
            txt_telefon = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            txt_soyad = new TextBox();
            label2 = new Label();
            txt_ad = new TextBox();
            label1 = new Label();
            listBox1 = new ListBox();
            gb_kisiselBilgiler.SuspendLayout();
            SuspendLayout();
            // 
            // flp_koltuk
            // 
            flp_koltuk.Location = new Point(34, 32);
            flp_koltuk.Name = "flp_koltuk";
            flp_koltuk.Size = new Size(288, 721);
            flp_koltuk.TabIndex = 0;
            // 
            // gb_kisiselBilgiler
            // 
            gb_kisiselBilgiler.Controls.Add(btn_kaydet);
            gb_kisiselBilgiler.Controls.Add(rdb_kadin);
            gb_kisiselBilgiler.Controls.Add(rdb_erkek);
            gb_kisiselBilgiler.Controls.Add(txt_koltuk);
            gb_kisiselBilgiler.Controls.Add(txt_telefon);
            gb_kisiselBilgiler.Controls.Add(label4);
            gb_kisiselBilgiler.Controls.Add(label5);
            gb_kisiselBilgiler.Controls.Add(label3);
            gb_kisiselBilgiler.Controls.Add(txt_soyad);
            gb_kisiselBilgiler.Controls.Add(label2);
            gb_kisiselBilgiler.Controls.Add(txt_ad);
            gb_kisiselBilgiler.Controls.Add(label1);
            gb_kisiselBilgiler.Location = new Point(345, 32);
            gb_kisiselBilgiler.Name = "gb_kisiselBilgiler";
            gb_kisiselBilgiler.Size = new Size(448, 323);
            gb_kisiselBilgiler.TabIndex = 1;
            gb_kisiselBilgiler.TabStop = false;
            gb_kisiselBilgiler.Text = "Kişisel Bilgiler";
            // 
            // btn_kaydet
            // 
            btn_kaydet.Location = new Point(245, 267);
            btn_kaydet.Name = "btn_kaydet";
            btn_kaydet.Size = new Size(174, 29);
            btn_kaydet.TabIndex = 7;
            btn_kaydet.Text = "Kaydet";
            btn_kaydet.UseVisualStyleBackColor = true;
            btn_kaydet.Click += btn_kaydet_Click;
            // 
            // rdb_kadin
            // 
            rdb_kadin.AutoSize = true;
            rdb_kadin.Location = new Point(285, 212);
            rdb_kadin.Name = "rdb_kadin";
            rdb_kadin.Size = new Size(68, 24);
            rdb_kadin.TabIndex = 5;
            rdb_kadin.Text = "Kadın";
            rdb_kadin.UseVisualStyleBackColor = true;
            // 
            // rdb_erkek
            // 
            rdb_erkek.AutoSize = true;
            rdb_erkek.Checked = true;
            rdb_erkek.Location = new Point(148, 212);
            rdb_erkek.Name = "rdb_erkek";
            rdb_erkek.Size = new Size(65, 24);
            rdb_erkek.TabIndex = 4;
            rdb_erkek.TabStop = true;
            rdb_erkek.Text = "Erkek";
            rdb_erkek.UseVisualStyleBackColor = true;
            // 
            // txt_koltuk
            // 
            txt_koltuk.Enabled = false;
            txt_koltuk.Location = new Point(133, 267);
            txt_koltuk.Name = "txt_koltuk";
            txt_koltuk.Size = new Size(81, 27);
            txt_koltuk.TabIndex = 6;
            // 
            // txt_telefon
            // 
            txt_telefon.Location = new Point(133, 154);
            txt_telefon.Name = "txt_telefon";
            txt_telefon.PlaceholderText = "555-XXX-XX-XX";
            txt_telefon.Size = new Size(286, 27);
            txt_telefon.TabIndex = 3;
            txt_telefon.Tag = "Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 270);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 0;
            label4.Text = "Koltuk No:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 214);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 0;
            label5.Text = "Cinsiyet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 157);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 0;
            label3.Text = "Telefon:";
            // 
            // txt_soyad
            // 
            txt_soyad.Location = new Point(133, 101);
            txt_soyad.Name = "txt_soyad";
            txt_soyad.Size = new Size(286, 27);
            txt_soyad.TabIndex = 2;
            txt_soyad.Tag = "Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 104);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 0;
            label2.Text = "Soyad:";
            // 
            // txt_ad
            // 
            txt_ad.Location = new Point(133, 44);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(286, 27);
            txt_ad.TabIndex = 1;
            txt_ad.Tag = "Ad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 47);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(345, 361);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(448, 384);
            listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 765);
            Controls.Add(listBox1);
            Controls.Add(gb_kisiselBilgiler);
            Controls.Add(flp_koltuk);
            Name = "Form1";
            Text = "Otobüs Bilet Satışı";
            Load += Form1_Load;
            gb_kisiselBilgiler.ResumeLayout(false);
            gb_kisiselBilgiler.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flp_koltuk;
        private GroupBox gb_kisiselBilgiler;
        private TextBox txt_ad;
        private Label label1;
        private TextBox txt_koltuk;
        private TextBox txt_telefon;
        private Label label4;
        private Label label5;
        private Label label3;
        private TextBox txt_soyad;
        private Label label2;
        private RadioButton rdb_kadin;
        private RadioButton rdb_erkek;
        private Button btn_kaydet;
        private ListBox listBox1;
    }
}
