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
    public partial class MusteritemsilcisiAlim : Form
    {
        public MusteritemsilcisiAlim()
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
            GC.Collect();
            GC.WaitForPendingFinalizers();
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
            MusteritemsilcisiMain nextForm = new MusteritemsilcisiMain();
            nextForm.Show();
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ASiparisAdd  nextForm = new ASiparisAdd();
            nextForm.Show();
            this.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TedarikciAdd nextForm = new TedarikciAdd();
            nextForm.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SSiparisUpdate nextForm = new SSiparisUpdate();
            nextForm.Show();
            this.Dispose();
        }
    }
}
