using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using teboweb;

namespace UpdateMe
{
    public partial class UpdateMe : Form
    {

        public const string updaterPrefix = "M1234_";
        private static string processToEnd = "UpdateMe";
        private static string postProcess = Application.StartupPath + @"\" + processToEnd + ".exe";
        public static string updater = Application.StartupPath + @"\update.exe";

        public const string updateSuccess = "UpdateMe has been successfully updated";
        public const string updateCurrent = "No updates available for UpdateMe";
        public const string updateInfoError = "Error in retrieving UpdateMe information";
        
        public static List<string> info = new List<string>();
       
        public UpdateMe()
        {
            InitializeComponent();
        }

        private void UpdateMe_Load(object sender, EventArgs e)
        {
            update.updateMe(updaterPrefix, Application.StartupPath + @"\");
            updateResult.Visible = false;
            update_bttn.Visible = false;
            unpackCommandline();

        }
        private void update_bttn_Click(object sender, EventArgs e)
        {
            update.installUpdateRestart(info[3], info[4], "\"" + Application.StartupPath + "\\", processToEnd, postProcess, "updated", updater);
            Close();
        }
        private void unpackCommandline()
        {

            bool commandPresent = false;
            string tempStr = "";

            foreach (string arg in Environment.GetCommandLineArgs())
            {

                if (!commandPresent)
                {

                    commandPresent = arg.Trim().StartsWith("/");

                }

                if (commandPresent)
                {

                    tempStr += arg;

                }

            }


            if (commandPresent)
            {

                if (tempStr.Remove(0, 2) == "updated")
                {

                    updateResult.Visible = true;
                    updateResult.Text = updateSuccess;

                }

            }


        }
       

        private void checkForUpdate_bttn_Click(object sender, EventArgs e)
        {

            info = update.getUpdateInfo("http://nasirjumani.com/", "a.txt", Application.StartupPath + @"\", 1);
         
            if (info == null)
            {

                update_bttn.Visible = false;
                updateResult.Text = updateInfoError;
                updateResult.Visible = true;

            }
            else
            {

                if (decimal.Parse(info[1]) > decimal.Parse("1.001"))
                {

                    update_bttn.Visible = true;
                    updateResult.Visible = false;

                }
                else
                {

                    update_bttn.Visible = false;
                    updateResult.Visible = true;
                    updateResult.Text = updateCurrent;

                }
            }
        }

        
    }
}
