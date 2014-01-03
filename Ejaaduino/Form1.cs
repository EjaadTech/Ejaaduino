using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Ejaaduino
{

    public partial class Form1 : Form
    {
        Process myProcess = new Process();
        public static string commandData = "";

        public static void getData(string data)
        {
            commandData+=data;

        }
        
        public Form1()
        {
            InitializeComponent();
           // Win32.AllocConsole();  //Allocates a new console for current process.
        }
       
        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string v;
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
            StartProcess();
        }

        private void btn_programmer_Click(object sender, EventArgs e)
        {
            //Ejaaduino.Echo h = new Ejaaduino.Echo("Hello my 1st C# object !");
            //h.Tell();
            string v="-c usbasp -p m8 -U flash:w:programmer.hex";
      // System.Diagnostics.Process.Start("cmd.exe", "/k avrdude.exe -c usbasp -p m8 -U flash:w:programmer.hex");
           // System.Diagnostics.myProcess.Start("avrdude.exe", "hey");
       StartProcess();
           // var processStartInfo = new ProcessStartInfo("cmd.exe");
            // Instantiate the writer
          //  _writer = new TextBoxStreamWriter(txtConsole);
            // Redirect the out Console stream
          //  Console.SetOut(_writer);
      
          //  Console.WriteLine("Now redirecting output to the text box");
           // System.Diagnostics.Process.Start("");

      // string input = System.Console.ReadLine();
       //richTextBox1.Text = input;
        }
        private void StartProcess()
        {
            try
            {
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.RedirectStandardOutput = true;
                myProcess.StartInfo.RedirectStandardError = true;
                myProcess.OutputDataReceived += new DataReceivedEventHandler(ProcessOutputDataHandler);
                myProcess.ErrorDataReceived += new DataReceivedEventHandler(ProcessErrorDataHandler);
                myProcess.StartInfo.FileName = "avrdude.exe";
                myProcess.StartInfo.Arguments = "-c usbasp -p m8 -U flash:w:programmer.hex";
                myProcess.StartInfo.CreateNoWindow = false;
                myProcess.Start();
                myProcess.BeginOutputReadLine();
                myProcess.BeginErrorReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void ProcessOutputDataHandler(object sendingProcess,
    DataReceivedEventArgs outLine)
        {
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                getData(outLine.Data);
            }
        }

        private static void ProcessErrorDataHandler(object sendingProcess,
DataReceivedEventArgs outLine)
        {
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                getData(outLine.Data);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            richTextBox1.Text = commandData;
        }

        private void btn_usbSerial_Click(object sender, System.EventArgs e)
        {
            //System.Diagnostics.Process.Start("cmd.exe", "/k avrdude.exe -c usbasp -p m8 -U flash:w:serial.hex");
            StartProcess();
        }

        private void btn_custom_Click(object sender, EventArgs e)
        {
           // Console.WriteLine(richTextBox1.Text+"\n"); // write RTB text to console
           // Console.ReadLine(output);
           // richTextBox1.Text = output;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          //  Win32.FreeConsole(); // Free the console.
        }

    }
    //public class Win32
   // {
        /// <summary>
        /// Allocates a new console for current process.
        /// </summary>
      //  [DllImport("kernel32.dll")]
      //  public static extern Boolean AllocConsole();

        /// <summary>
        /// Frees the console.
        /// </summary>
     //   [DllImport("kernel32.dll")]
      //  public static extern Boolean FreeConsole();
  //  }
}

