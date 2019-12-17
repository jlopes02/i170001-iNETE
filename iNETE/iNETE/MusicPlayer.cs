using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using PSI10_iNETE;
namespace iNETEapp
{
    public partial class MusicPlayer : Form
    {
        WindowsMediaPlayer wmp;
        public MusicPlayer(Musica m)
        {
            InitializeComponent();
            wmp = new WindowsMediaPlayer();
            //string exePath = System.IO.Path.GetDirectoryName(
            //System.Reflection.Assembly.GetEntryAssembly().Location);

            string path = System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();
            wmp.URL = path + "/musicas/Kalimba.mp3";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            wmp.controls.play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            wmp.controls.pause();
            wmp.settings.volume = 50;
        }

        private void MusicPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            wmp.close();
        }
    }
}
