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

namespace FragmentServerWV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Config.Load();
            Log.InitLogs(rtb1);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startToolStripMenuItem.Enabled = false;
            stopToolStripMenuItem.Enabled = true;
            Server.Start();
        }

       
        private void level1AllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.LogLevel = 0;
            level3MediumToolStripMenuItem.Checked =
            level5FewToolStripMenuItem.Checked = false;
            level1AllToolStripMenuItem.Checked = true;
        }

        private void level3MediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.LogLevel = 2;
            level1AllToolStripMenuItem.Checked =
            level5FewToolStripMenuItem.Checked = false;
            level3MediumToolStripMenuItem.Checked = true;
        }

        private void level5FewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.LogLevel = 4;
            level1AllToolStripMenuItem.Checked =
            level3MediumToolStripMenuItem.Checked = false;
            level5FewToolStripMenuItem.Checked = true;
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startToolStripMenuItem.Enabled = true;
            stopToolStripMenuItem.Enabled = false;
            Server.Stop();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Server.Stop();
        }

        private void dumpDecoderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DumpDecoder d = new DumpDecoder();
            d.ShowDialog();
        }
    }
}
