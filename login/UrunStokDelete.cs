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
    public partial class UrunStokDelete : Form
    {
        public UrunStokDelete()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.BorderSize = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Stokurun nextForm = new Stokurun();
            nextForm.Show();
            this.Dispose();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String[] arr = new string[2];
                UrunStokClass myclass = new UrunStokClass();
                arr = myclass.UrunStokBilgiGetir(Convert.ToInt32(tuid.Text));
                tuad.Text = arr[0];
                tuadet.Text = arr[1];
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UrunStokClass myclass = new UrunStokClass();
                myclass.UrunStokSil(Convert.ToInt32(tuid.Text));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
