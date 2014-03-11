using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updater_demo_wybuild
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           // if (!automaticUpdater1.ClosingForInstall)
            //    LoadSettings();
        }

        private void automaticUpdater1_Click(object sender, EventArgs e)
        {

        }
       // void LoadSettings()
       // { 
        //TODO
       // }
        
        private void automaticUpdater1_ClosingAborted(object sender, EventArgs e)
        {
            //LoadSettings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
