using System;
using System.Threading;

using System.Collections.Generic;
using System.Windows.Forms;
using CrashReporterDotNET;


namespace Ejaaduino
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.ThreadException += ApplicationThreadException;

            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs unhandledExceptionEventArgs)
        {
            ReportCrash((Exception)unhandledExceptionEventArgs.ExceptionObject);
            Environment.Exit(0);
        }

        private static void ApplicationThreadException(object sender, ThreadExceptionEventArgs e)
        {
            ReportCrash(e.Exception);
        }

        private static void ReportCrash(Exception exception)
        {
            var reportCrash = new ReportCrash
            {
                FromEmail = "'nasirazizjumani@gmail.com",
                ToEmail = "nasirazizjumani@gmail.com",
                SmtpHost = "smtp.gmail.com",
                Port = 587,
                UserName = "nasirazizjumani@gmail.com",
                Password = "klavikancube",
                EnableSSL = true,
            };

            reportCrash.Send(exception);
        }
    }
    }
