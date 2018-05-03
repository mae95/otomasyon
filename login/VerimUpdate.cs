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
    public partial class VerimUpdate : Form
    {
        public VerimUpdate()
        {
            InitializeComponent();
            button3.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
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

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            this.Dispose();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BolumsefiMain nextForm = new BolumsefiMain();
            nextForm.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                VerimClass myclass = new VerimClass();
                ttoplam.Text=myclass.BilgileriGetir(Convert.ToInt32(tuid.Text),Convert.ToInt32(toid.Text),Convert.ToInt32(tpid.Text),Convert.ToDateTime(ttarih.Text));
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                VerimClass myclass = new VerimClass();
                myclass.VerimGuncelle(Convert.ToInt32(ttoplam.Text));
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

            ttoplam.Text = (Convert.ToInt32(ttoplam.Text) - ( Convert.ToInt32(tadet1.Text) + Convert.ToInt32(tadet2.Text) + Convert.ToInt32(tadet3.Text))).ToString();
            tdemet1.ResetText(); tadet1.ResetText();
            tdemet2.ResetText(); tadet2.ResetText();
            tdemet3.ResetText(); tadet3.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ttoplam.Text = (Convert.ToInt32(ttoplam.Text) + Convert.ToInt32(tadet1.Text) + Convert.ToInt32(tadet2.Text) + Convert.ToInt32(tadet3.Text)).ToString();
            tdemet1.ResetText(); tadet1.ResetText();
            tdemet2.ResetText(); tadet2.ResetText();
            tdemet3.ResetText(); tadet3.ResetText();
        }

        private void tpid_Enter(object sender, EventArgs e)
        {
            var textbox = (TextBox)sender;
            if (textbox.ForeColor == Color.Silver)
            {
                textbox.ResetText();
                textbox.ForeColor = Color.Black;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Hakkında nextForm = new Hakkında();
            nextForm.Show();
        }
    }
}
