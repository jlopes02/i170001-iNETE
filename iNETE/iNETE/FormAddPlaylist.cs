using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSI10_iNETE;
namespace iNETEapp
{
    public partial class FormAddPlaylist : Form
    {
        iNETE inete;
        public Playlist Playlist { get; set; }
        public FormAddPlaylist(iNETE iNETE)
        {
            InitializeComponent();
             inete = iNETE;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            string msg = "";
            foreach (Playlist p in inete.playlists)
            {
                if (txtCode.Text == p.IdPlaylist.ToString())
                {
                    msg = "Código Repetido";
                }
            }
            if (string.IsNullOrWhiteSpace(txtCode.Text))
                msg = "Código inválido";
            if (string.IsNullOrWhiteSpace(txtNome.Text))
                msg = "Nome inválido";

            if (dtDataCriacao.Value > DateTime.Today)
                msg = "Data inválida";


            if (msg != "")
            {
                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                Playlist = new Playlist(txtNome.Text, Convert.ToInt32(txtCode.Text));

            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch!=8)
            {
                e.Handled = true;
            }
        }
    }
}
