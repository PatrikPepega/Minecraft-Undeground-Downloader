using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Underground_Downloader
{
    public partial class fluxb3911dev : Form
    {
        public fluxb3911dev()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://www.mediafire.com/file/f5xr71trl7plw63/Flux_Latest.rar/file"; // Replace with your desired URL
            Process.Start(url);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
