using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EjaaduinoBoardAdder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadNewFile();
        }
        private void LoadNewFile()
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                string sr = System.IO.File.ReadAllText(path);
                {
                    if (sr.IndexOf("Ejaaduino") == -1)
                    {
                        using (StreamWriter sw = File.AppendText(path))
                        {
                            string ejaaduino = "\n###############################################################\nEjaaduino.name=Ejaaduino(ATmega8)\nEjaaduino.upload.protocol=usbasp\nEjaaduino.upload.maximum_size=6144\nEjaaduino.upload.speed=115200\nEjaaduino.upload.disable_flushing=true\nEjaaduino.bootloader.low_fuses=0x1F\nEjaaduino.bootloader.high_fuses=0xC0\nEjaaduino.build.mcu=atmega8\nEjaaduino.build.f_cpu=16000000L\nEjaaduino.build.core=arduino\nEjaaduino.build.variant=standard\n###############################################################";
                            sw.WriteLine(ejaaduino);
                        }	
                    }
                }   
            }
        }
    }
}