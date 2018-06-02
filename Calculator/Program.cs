﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Calculator
{
    static class Program
    {
        [DllImport("user32")]
        private static extern void SetProcessDPIAware();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}