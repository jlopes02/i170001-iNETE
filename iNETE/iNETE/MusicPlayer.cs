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
             lblArtista.Text = m.Artista;
            lblTitulo.Text = m.Titulo;
            lblGenero.Text = m.Genero.ToString();
            string path = System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();
            wmp = new WindowsMediaPlayer();
            wmp.URL = path + "/musicas/" + m.FileName;
        }
       
        private void btnPlay_Click(object sender, EventArgs e)
        {
            wmp.controls.play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            wmp.controls.pause();
        }

        private void MusicPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            wmp.close();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            wmp.settings.volume = tcbVolume.Value;
        }


    }
}
