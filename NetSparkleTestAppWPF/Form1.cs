﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppLimit.NetSparkle;

namespace NetSparkleTestAppWPF
{
    public partial class Form1 : Form
    {
        private Sparkle _sparkle = new Sparkle("http://update.applimit.com/netsparkle/versioninfo.xml"); 

        public Form1()
        {
            InitializeComponent();

            _sparkle.StartLoop(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}