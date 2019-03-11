namespace Mini_Paint
{
    partial class miniPaint
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyczyćGrafikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cofnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_opcje = new System.Windows.Forms.GroupBox();
            this.change_b = new System.Windows.Forms.Button();
            this.gb_trans = new System.Windows.Forms.GroupBox();
            this.b_negatyw = new System.Windows.Forms.Button();
            this.b_szarosc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_binaryzacja = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_jasnosc = new System.Windows.Forms.TrackBar();
            this.gb_rysuj = new System.Windows.Forms.GroupBox();
            this.nud_widthpen = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kolor_b = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cofnijToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wyczyśćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gb_opcje.SuspendLayout();
            this.gb_trans.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_binaryzacja)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_jasnosc)).BeginInit();
            this.gb_rysuj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_widthpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cofnijToolStripMenuItem1,
            this.wyczyśćToolStripMenuItem,
            this.zapiszToolStripMenuItem1,
            this.zapiszJakoToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 92);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem,
            this.nowyToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako";
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.zapiszJakoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyczyćGrafikeToolStripMenuItem,
            this.cofnijToolStripMenuItem});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // wyczyćGrafikeToolStripMenuItem
            // 
            this.wyczyćGrafikeToolStripMenuItem.Name = "wyczyćGrafikeToolStripMenuItem";
            this.wyczyćGrafikeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wyczyćGrafikeToolStripMenuItem.Text = "Wyczyść";
            this.wyczyćGrafikeToolStripMenuItem.Click += new System.EventHandler(this.wyczyćGrafikeToolStripMenuItem_Click);
            // 
            // cofnijToolStripMenuItem
            // 
            this.cofnijToolStripMenuItem.Name = "cofnijToolStripMenuItem";
            this.cofnijToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cofnijToolStripMenuItem.Text = "Cofnij";
            this.cofnijToolStripMenuItem.Click += new System.EventHandler(this.cofnijToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            this.pomocToolStripMenuItem.Click += new System.EventHandler(this.pomocToolStripMenuItem_Click);
            // 
            // gb_opcje
            // 
            this.gb_opcje.Controls.Add(this.change_b);
            this.gb_opcje.Controls.Add(this.gb_trans);
            this.gb_opcje.Controls.Add(this.gb_rysuj);
            this.gb_opcje.Dock = System.Windows.Forms.DockStyle.Right;
            this.gb_opcje.Location = new System.Drawing.Point(677, 24);
            this.gb_opcje.Name = "gb_opcje";
            this.gb_opcje.Size = new System.Drawing.Size(214, 485);
            this.gb_opcje.TabIndex = 2;
            this.gb_opcje.TabStop = false;
            this.gb_opcje.Text = "Opcje";
            // 
            // change_b
            // 
            this.change_b.Location = new System.Drawing.Point(21, 19);
            this.change_b.Name = "change_b";
            this.change_b.Size = new System.Drawing.Size(181, 24);
            this.change_b.TabIndex = 11;
            this.change_b.Text = "Transformacje";
            this.change_b.UseVisualStyleBackColor = true;
            this.change_b.Click += new System.EventHandler(this.change_b_Click);
            // 
            // gb_trans
            // 
            this.gb_trans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_trans.Controls.Add(this.b_negatyw);
            this.gb_trans.Controls.Add(this.b_szarosc);
            this.gb_trans.Controls.Add(this.groupBox2);
            this.gb_trans.Controls.Add(this.groupBox1);
            this.gb_trans.Location = new System.Drawing.Point(8, 49);
            this.gb_trans.Name = "gb_trans";
            this.gb_trans.Size = new System.Drawing.Size(200, 430);
            this.gb_trans.TabIndex = 1;
            this.gb_trans.TabStop = false;
            this.gb_trans.Text = "Transformacje";
            this.gb_trans.Visible = false;
            // 
            // b_negatyw
            // 
            this.b_negatyw.Location = new System.Drawing.Point(13, 218);
            this.b_negatyw.Name = "b_negatyw";
            this.b_negatyw.Size = new System.Drawing.Size(181, 23);
            this.b_negatyw.TabIndex = 3;
            this.b_negatyw.Text = "Negatyw";
            this.b_negatyw.UseVisualStyleBackColor = true;
            this.b_negatyw.Click += new System.EventHandler(this.b_negatyw_Click);
            // 
            // b_szarosc
            // 
            this.b_szarosc.Location = new System.Drawing.Point(13, 189);
            this.b_szarosc.Name = "b_szarosc";
            this.b_szarosc.Size = new System.Drawing.Size(181, 23);
            this.b_szarosc.TabIndex = 2;
            this.b_szarosc.Text = "Skala szarości";
            this.b_szarosc.UseVisualStyleBackColor = true;
            this.b_szarosc.Click += new System.EventHandler(this.b_szarosc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_binaryzacja);
            this.groupBox2.Location = new System.Drawing.Point(7, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Binatyzacja";
            this.groupBox2.Enter += new System.EventHandler(this.mouse_MouseEnter);
            // 
            // tb_binaryzacja
            // 
            this.tb_binaryzacja.Location = new System.Drawing.Point(6, 20);
            this.tb_binaryzacja.Maximum = 255;
            this.tb_binaryzacja.Name = "tb_binaryzacja";
            this.tb_binaryzacja.Size = new System.Drawing.Size(175, 45);
            this.tb_binaryzacja.TabIndex = 0;
            this.tb_binaryzacja.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tb_binaryzacja_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_jasnosc);
            this.groupBox1.Location = new System.Drawing.Point(7, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jasność";
            // 
            // tb_jasnosc
            // 
            this.tb_jasnosc.Location = new System.Drawing.Point(6, 20);
            this.tb_jasnosc.Maximum = 200;
            this.tb_jasnosc.Minimum = -200;
            this.tb_jasnosc.Name = "tb_jasnosc";
            this.tb_jasnosc.Size = new System.Drawing.Size(175, 45);
            this.tb_jasnosc.TabIndex = 0;
            this.tb_jasnosc.MouseEnter += new System.EventHandler(this.mouse_MouseEnter);
            this.tb_jasnosc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tb_jasnosc_MouseUp);
            // 
            // gb_rysuj
            // 
            this.gb_rysuj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_rysuj.Controls.Add(this.nud_widthpen);
            this.gb_rysuj.Controls.Add(this.label2);
            this.gb_rysuj.Controls.Add(this.label1);
            this.gb_rysuj.Controls.Add(this.kolor_b);
            this.gb_rysuj.Location = new System.Drawing.Point(8, 49);
            this.gb_rysuj.Name = "gb_rysuj";
            this.gb_rysuj.Size = new System.Drawing.Size(200, 424);
            this.gb_rysuj.TabIndex = 0;
            this.gb_rysuj.TabStop = false;
            this.gb_rysuj.Text = "Rysowanie";
            // 
            // nud_widthpen
            // 
            this.nud_widthpen.Location = new System.Drawing.Point(119, 36);
            this.nud_widthpen.Name = "nud_widthpen";
            this.nud_widthpen.Size = new System.Drawing.Size(75, 20);
            this.nud_widthpen.TabIndex = 9;
            this.nud_widthpen.ValueChanged += new System.EventHandler(this.nud_widthpen_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Szerokość pióra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wybierz kolor:";
            // 
            // kolor_b
            // 
            this.kolor_b.BackColor = System.Drawing.Color.Black;
            this.kolor_b.Location = new System.Drawing.Point(119, 11);
            this.kolor_b.Name = "kolor_b";
            this.kolor_b.Size = new System.Drawing.Size(75, 23);
            this.kolor_b.TabIndex = 5;
            this.kolor_b.UseVisualStyleBackColor = false;
            this.kolor_b.Click += new System.EventHandler(this.kolor_b_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 24);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(677, 485);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // cofnijToolStripMenuItem1
            // 
            this.cofnijToolStripMenuItem1.Name = "cofnijToolStripMenuItem1";
            this.cofnijToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.cofnijToolStripMenuItem1.Text = "Cofnij";
            this.cofnijToolStripMenuItem1.Click += new System.EventHandler(this.cofnijToolStripMenuItem_Click);
            // 
            // wyczyśćToolStripMenuItem
            // 
            this.wyczyśćToolStripMenuItem.Name = "wyczyśćToolStripMenuItem";
            this.wyczyśćToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.wyczyśćToolStripMenuItem.Text = "Wyczyść";
            this.wyczyśćToolStripMenuItem.Click += new System.EventHandler(this.wyczyćGrafikeToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem1
            // 
            this.zapiszToolStripMenuItem1.Name = "zapiszToolStripMenuItem1";
            this.zapiszToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.zapiszToolStripMenuItem1.Text = "Zapisz";
            this.zapiszToolStripMenuItem1.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // zapiszJakoToolStripMenuItem1
            // 
            this.zapiszJakoToolStripMenuItem1.Name = "zapiszJakoToolStripMenuItem1";
            this.zapiszJakoToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.zapiszJakoToolStripMenuItem1.Text = "Zapisz jako";
            this.zapiszJakoToolStripMenuItem1.Click += new System.EventHandler(this.zapiszJakoToolStripMenuItem_Click);
            // 
            // miniPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 509);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.gb_opcje);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "miniPaint";
            this.Text = "Mini Paint";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_opcje.ResumeLayout(false);
            this.gb_trans.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_binaryzacja)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_jasnosc)).EndInit();
            this.gb_rysuj.ResumeLayout(false);
            this.gb_rysuj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_widthpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyczyćGrafikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cofnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.GroupBox gb_opcje;
        private System.Windows.Forms.GroupBox gb_trans;
        private System.Windows.Forms.Button b_negatyw;
        private System.Windows.Forms.Button b_szarosc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar tb_binaryzacja;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar tb_jasnosc;
        private System.Windows.Forms.GroupBox gb_rysuj;
        private System.Windows.Forms.Button kolor_b;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_widthpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.Button change_b;
        private System.Windows.Forms.ToolStripMenuItem cofnijToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wyczyśćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem1;
    }
}

