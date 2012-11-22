using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Security.Principal;

namespace SkinViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btUsername_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;

            pictureBox1.Image = new System.Drawing.Bitmap(new System.IO.MemoryStream(new System.Net.WebClient().DownloadData("http://s3.amazonaws.com/MinecraftSkins/" + username + ".png")));
        }

        private void dlSkin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string winUsername = Convert.ToString(WindowsIdentity.GetCurrent());

            WebClient webClient = new WebClient();
            webClient.DownloadFile("http://s3.amazonaws.com/MinecraftSkins/" + username + ".png", username + "_skin.png");
            MessageBox.Show("Successfully downloaded " + username + "_skin.png in filepath: " + Application.StartupPath);
        }  
    }
}
