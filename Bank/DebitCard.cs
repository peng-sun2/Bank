﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class DebitCard : Form
    {
        public DebitCard()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimeDeposit insert = new TimeDeposit();
            insert.Show();
            this.Hide();
        }
    }
}
