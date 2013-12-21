using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ejaaduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_Exit_MouseEnter(object sender, EventArgs e)
        {
            lbl_Exit.ForeColor = Color.White;
            lbl_Exit.BackColor = Color.Red;
        }

        private void lbl_Exit_MouseLeave(object sender, EventArgs e)
        {
            lbl_Exit.ForeColor = Color.Gray;
            lbl_Exit.BackColor = Color.White;
        }

        private void lbl_Exit_MouseDown(object sender, MouseEventArgs e)
        {
            lbl_Exit.ForeColor = Color.White;
            lbl_Exit.BackColor = Color.DarkRed;
        }

    }
}
