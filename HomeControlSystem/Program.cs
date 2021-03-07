﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc.Ua;
using Opc.Ua.Configuration;

namespace HomeControlSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            ApplicationInstance application = new ApplicationInstance();
            application.ApplicationType = ApplicationType.Server;
            application.ConfigSectionName = "HomeControlSystemServer";

            try
            {
                //process and command line arguments.
                if (application.ProcessCommandLine())
                {
                    return;
                }

                //check if running a service.
                if (!Environment.UserInteractive)
                {
                    application.StartAsService(new HomeControlSystemServer());
                    return;
                }

                //load the application configuration.
                application.LoadApplicationConfiguration("C:/Users/Vince/source/repos/HomeControlSystem/HomeControlSystem/HomeControlSystemServer.Config.xml", false).Wait();

                //check the application certificate.
                application.CheckApplicationInstanceCertificate(false, 0).Wait();

                //start the server
                application.Start(new HomeControlSystemServer()).Wait();

                Application.Run(new Form1(application));
            }
            catch (Exception e)
            {
                string text = "Exception: " + e.Message;
                if(e.InnerException != null)
                {
                    text += "\r\nInnerException: ";
                    text += e.InnerException.Message;
                }
                MessageBox.Show(text, application.ApplicationName);
            }
        }
    }
}
