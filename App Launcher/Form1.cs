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

namespace App_Launcher
{
    public partial class AppLauncher : Form
    {
        public AppLauncher()
        {
            InitializeComponent();
        }

        private void Tittle_Click(object sender, EventArgs e)
        {

        }

        private void MIXButton_Click(object sender, EventArgs e)
        {
            //check if the directory of mix exists
            String MixPath = @"C:\Users\Public\Documents\MIX\MIX 2.0";
            if (Directory.Exists(MixPath))
            {
                Process.Start(MixPath + @"\MIX.exe");
            }
            else
            {
                //sino redirigimos a la pagina de github
                Process.Start("https://github.com/SoftLord/MIX");
            }
        }

        private void WordFinderButton_Click(object sender, EventArgs e)
        {
            String WordFinderPath = @"C:\Program Files (x86)\Álvaro Roca, Inc\Word Finder";
            if (Directory.Exists(WordFinderPath))
            {
                Process.Start(WordFinderPath + @"\Word Finder 1.0.exe");
            }
            else
            {
                Process.Start("https://github.com/SoftLord/Word-Finder");
            }
        }

        private void RaspiButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/SoftLord/RaspiConnection");
        }

        private void ConchiButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/SoftLord/Conchi");
        }
    }
}
