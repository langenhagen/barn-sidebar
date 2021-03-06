﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Sidebar
{
    partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        #region Assemblyattributaccessoren

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        /// <summary>
        /// Forbids the window to be shown in the "Alt+Tab"-Window
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle &= ~0x10000; // WS_EX_CONTROLPARENT - hide in Alt+Tab - window
                return param;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            string text = System.Reflection.Assembly.GetExecutingAssembly().ToString();

            // version - string
            string assVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            // set values of the controls
            this.Text = "Barn's " + this.AssemblyTitle + " - About";
            lblAbout.Text = "Barn's " + this.AssemblyTitle + " v" + assVersion;
            lblAssembly.Text = text;

            txtLicence.Text =
                "Copyright (c) " + DateTime.Now.Year.ToString() + " Andreas Langenhagen\r\n\r\n" +
                "Permission is hereby granted, free of charge, to any person obtaining " +
                "a copy of this software and associated documentation files (the \"Software\"), " +
                "to deal in the Software without restriction, including without limitation " +
                "the rights to use, copy, modify, merge, publish, distribute, sublicense, " +
                "and/or sell copies of the Software, and to permit persons to whom the " +
                "Software is furnished to do so, subject to the following conditions:\r\n\r\n" +
                "The above copyright notice and this permission notice shall be included in " +
                "all copies or substantial portions of the Software.\r\n\r\n" +
                "THE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR " +
                "IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, " +
                "FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE " +
                "AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER " +
                "LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM," +
                "OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE" +
                "SOFTWARE.";


        }
    }
}