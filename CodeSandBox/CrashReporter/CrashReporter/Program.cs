using System;
using System.Threading;
using System.Windows.Forms;
using CrashReporterDotNET;

namespace CrashReporter
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
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
                FromEmail = "Your Gmail address",
                ToEmail = "Email address where you want to receive crash reports",
                SmtpHost = "Your SMTP server address for example smtp.gmail.com",
                Port = 587,
                UserName = "Your Gmail address ",
                Password = "Your Gmail password",
                EnableSSL = true,
            };

            reportCrash.Send(exception);
        }
    }
}