﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunWithCHarpAsync
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void btnCallMethod_Click(object sender, EventArgs e)
        {
            this.Text = await DoWork();
        }

        private Task<string> DoWork()
        {
            return Task.Run(() =>
            {
                Thread.Sleep(10000);
                return "Done with work!";
            });
        }
    }
}
