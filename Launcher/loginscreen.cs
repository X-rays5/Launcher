using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Threading;
using System.Diagnostics;
using System.Xml;
using System.IO;
using System.Net;
using static Launcher.login;

namespace Launcher
{
    public partial class Launcherwindow : Form
    {
        public Launcherwindow()
        {
            InitializeComponent();
        }
        // Global vars
        bool authed = false;

        private void githublink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/X-rays5");
        }

        private void login_Click(object sender, EventArgs e)
        {
            authed = Auth(usernametextbox.Text, passwordtextbox.Text);
            if (authed)
            {
                MessageBox.Show("You have logged in.", "success!");
                this.Hide();
                authedscreen f2 = new authedscreen();
                f2.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Login failed please check your details", "Failed!");
            }
        }
    }
}
