﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pemira_HME
{
    public partial class DialogTambahDPT : Form
    {
        public DialogTambahDPT()
        {
            InitializeComponent();
        }

       

        private void tambahButton_Click_1(object sender, EventArgs e)
        {
            new FormAdmin().Show();
            this.Close();
        }

        private void kembaliButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormAdmin().Show();
        }
    }
}
