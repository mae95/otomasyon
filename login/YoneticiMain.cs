﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class YoneticiMain : Form
    {
        public YoneticiMain()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.BorderSize = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MakineMain nextForm = new MakineMain();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            /*hakkında sayfası yaz oraya aktar*/
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IKMain nextForm = new IKMain();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BolumsefiMain nextForm = new BolumsefiMain();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void rapor_Click(object sender, EventArgs e)
        {
            MusteritemsilcisiMain nextForm = new MusteritemsilcisiMain();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StokMain nextForm = new StokMain();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // modellemeden operasyon ara formunu cek
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ModellemeMain nextForm = new ModellemeMain();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
