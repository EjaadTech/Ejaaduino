using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System;

namespace Ejaaduino
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TextWriter _writer = null;
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

        private void lnk_EjaadTech_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited. 
            this.lnk_EjaadTech.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("http://ejaad.com.pk/");
        }

        private void btn_arduino_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = Path.Combine(Application.StartupPath, "C:\\Program Files (x86)\\Arduino\\arduino.exe");
            p.Start();
           
        }

        private void btn_programmer_Click(object sender, EventArgs e)
        {
            //Ejaaduino.Echo h = new Ejaaduino.Echo("Hello my 1st C# object !");
            //h.Tell();

          // var processStartInfo = System.Diagnostics.Process.Start("cmd.exe", "/k avrdude.exe -c usbasp -p m8 -U flash:w:programmer.hex");
            var processStartInfo = new ProcessStartInfo("cmd.exe");
            // Instantiate the writer
            _writer = new TextBoxStreamWriter(txtConsole);
            // Redirect the out Console stream
            Console.SetOut(_writer);

            Console.WriteLine("Now redirecting output to the text box");
           // System.Diagnostics.Process.Start("");
             

        }

        private void btn_usbSerial_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/k avrdude.exe -c usbasp -p m8 -U flash:w:serial.hex");
           
        }

    }
}