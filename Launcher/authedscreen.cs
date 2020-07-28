using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class authedscreen : Form
    {
        public authedscreen()
        {
            InitializeComponent();
        }

        private void launch_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe");
        }
    }
}
