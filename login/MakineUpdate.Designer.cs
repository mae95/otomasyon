﻿namespace login
{
    partial class MakineUpdate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbakim = new System.Windows.Forms.ComboBox();
            this.bbilgi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bupdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tmbakim = new System.Windows.Forms.TextBox();
            this.tmid = new System.Windows.Forms.TextBox();
            this.tmalim = new System.Windows.Forms.TextBox();
            this.tmadi = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bexit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.blogout = new System.Windows.Forms.Button();
            this.binfo = new System.Windows.Forms.Button();
            this.bhome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.bexit);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 590);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(50, 565);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 25);
            this.panel2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label4.Location = new System.Drawing.Point(213, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(364, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Makine Güncelleme Paneli";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(304, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "ModaVizyon";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MintCream;
            this.panel5.Controls.Add(this.cmbakim);
            this.panel5.Controls.Add(this.bbilgi);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.bupdate);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.tmbakim);
            this.panel5.Controls.Add(this.tmid);
            this.panel5.Controls.Add(this.tmalim);
            this.panel5.Controls.Add(this.tmadi);
            this.panel5.Location = new System.Drawing.Point(69, 122);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(490, 426);
            this.panel5.TabIndex = 24;
            // 
            // cmbakim
            // 
            this.cmbakim.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbakim.FormattingEnabled = true;
            this.cmbakim.Items.AddRange(new object[] {
            "Çalışıyor",
            "Çalışmıyor"});
            this.cmbakim.Location = new System.Drawing.Point(43, 285);
            this.cmbakim.Name = "cmbakim";
            this.cmbakim.Size = new System.Drawing.Size(232, 33);
            this.cmbakim.TabIndex = 45;
            // 
            // bbilgi
            // 
            this.bbilgi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(193)))), ((int)(((byte)(82)))));
            this.bbilgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bbilgi.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bbilgi.ForeColor = System.Drawing.Color.White;
            this.bbilgi.Location = new System.Drawing.Point(290, 26);
            this.bbilgi.Name = "bbilgi";
            this.bbilgi.Size = new System.Drawing.Size(188, 33);
            this.bbilgi.TabIndex = 44;
            this.bbilgi.Text = "Bilgilerini Getir";
            this.bbilgi.UseVisualStyleBackColor = false;
            this.bbilgi.Click += new System.EventHandler(this.bbilgi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.label3.Location = new System.Drawing.Point(40, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "arama kısmından ulaşabilirsiniz.";
            // 
            // bupdate
            // 
            this.bupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(193)))), ((int)(((byte)(82)))));
            this.bupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bupdate.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bupdate.ForeColor = System.Drawing.Color.White;
            this.bupdate.Location = new System.Drawing.Point(352, 350);
            this.bupdate.Name = "bupdate";
            this.bupdate.Size = new System.Drawing.Size(126, 54);
            this.bupdate.TabIndex = 32;
            this.bupdate.Text = "Güncelle";
            this.bupdate.UseVisualStyleBackColor = false;
            this.bupdate.Click += new System.EventHandler(this.bupdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(39, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Güncelleyeceğiniz makinenin id\'sine";
            // 
            // tmbakim
            // 
            this.tmbakim.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tmbakim.ForeColor = System.Drawing.Color.Silver;
            this.tmbakim.Location = new System.Drawing.Point(42, 228);
            this.tmbakim.MaxLength = 10;
            this.tmbakim.Name = "tmbakim";
            this.tmbakim.Size = new System.Drawing.Size(342, 33);
            this.tmbakim.TabIndex = 26;
            this.tmbakim.Text = "Sonraki bakım tarihi";
            // 
            // tmid
            // 
            this.tmid.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tmid.ForeColor = System.Drawing.Color.Silver;
            this.tmid.Location = new System.Drawing.Point(42, 26);
            this.tmid.Name = "tmid";
            this.tmid.Size = new System.Drawing.Size(233, 33);
            this.tmid.TabIndex = 41;
            this.tmid.Text = "Makine ID";
            this.tmid.Enter += new System.EventHandler(this.tmid_Enter);
            // 
            // tmalim
            // 
            this.tmalim.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tmalim.ForeColor = System.Drawing.Color.Silver;
            this.tmalim.Location = new System.Drawing.Point(43, 174);
            this.tmalim.Name = "tmalim";
            this.tmalim.Size = new System.Drawing.Size(342, 33);
            this.tmalim.TabIndex = 25;
            this.tmalim.Text = "Alım Tarihi";
            // 
            // tmadi
            // 
            this.tmadi.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tmadi.ForeColor = System.Drawing.Color.Silver;
            this.tmadi.Location = new System.Drawing.Point(42, 118);
            this.tmadi.Name = "tmadi";
            this.tmadi.Size = new System.Drawing.Size(342, 33);
            this.tmadi.TabIndex = 24;
            this.tmadi.Text = "Makine Adı";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::login.Properties.Resources.logo;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(75, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(138, 77);
            this.panel4.TabIndex = 14;
            // 
            // bexit
            // 
            this.bexit.BackgroundImage = global::login.Properties.Resources.Exit;
            this.bexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bexit.Location = new System.Drawing.Point(555, 0);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(25, 25);
            this.bexit.TabIndex = 4;
            this.bexit.UseVisualStyleBackColor = true;
            this.bexit.Click += new System.EventHandler(this.bexit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(156)))), ((int)(((byte)(236)))));
            this.panel3.Controls.Add(this.blogout);
            this.panel3.Controls.Add(this.binfo);
            this.panel3.Controls.Add(this.bhome);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(50, 590);
            this.panel3.TabIndex = 12;
            // 
            // blogout
            // 
            this.blogout.BackgroundImage = global::login.Properties.Resources.Shutdown;
            this.blogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blogout.Location = new System.Drawing.Point(0, 270);
            this.blogout.Name = "blogout";
            this.blogout.Size = new System.Drawing.Size(50, 50);
            this.blogout.TabIndex = 2;
            this.blogout.UseVisualStyleBackColor = true;
            this.blogout.Click += new System.EventHandler(this.blogout_Click);
            // 
            // binfo
            // 
            this.binfo.BackgroundImage = global::login.Properties.Resources.Info;
            this.binfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.binfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.binfo.Location = new System.Drawing.Point(0, 214);
            this.binfo.Name = "binfo";
            this.binfo.Size = new System.Drawing.Size(50, 50);
            this.binfo.TabIndex = 1;
            this.binfo.UseVisualStyleBackColor = true;
            this.binfo.Click += new System.EventHandler(this.binfo_Click);
            // 
            // bhome
            // 
            this.bhome.BackgroundImage = global::login.Properties.Resources.Home;
            this.bhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bhome.Location = new System.Drawing.Point(0, 158);
            this.bhome.Name = "bhome";
            this.bhome.Size = new System.Drawing.Size(50, 50);
            this.bhome.TabIndex = 0;
            this.bhome.UseVisualStyleBackColor = false;
            this.bhome.Click += new System.EventHandler(this.bhome_Click);
            // 
            // MakineUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 590);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MakineUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakineUpdate";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bexit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bupdate;
        private System.Windows.Forms.TextBox tmbakim;
        private System.Windows.Forms.TextBox tmalim;
        private System.Windows.Forms.TextBox tmadi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button blogout;
        private System.Windows.Forms.Button binfo;
        private System.Windows.Forms.Button bhome;
        private System.Windows.Forms.Button bbilgi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tmid;
        private System.Windows.Forms.ComboBox cmbakim;
    }
}