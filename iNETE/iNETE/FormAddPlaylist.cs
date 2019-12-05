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
        public FormAddPlaylist(iNETE iNETE, Playlist playlist)
        {
            InitializeComponent();
             inete = iNETE;
            if (playlist!= null)
            {
                txtCode.Text = playlist.IdPlaylist.ToString();
                txtCode.ReadOnly = true;
                txtNome.Text = playlist.Nome;
                dtDataCriacao.Value = playlist.DataCriacao;
                Playlist = playlist;
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (Playlist==null)
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
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                if (Playlist == null)
                    Playlist = new Playlist(txtNome.Text, Convert.ToInt32(txtCode.Text), dtDataCriacao.Value);
                else
                {
                    Playlist.Nome = txtNome.Text;
                    Playlist.DataCriacao = dtDataCriacao.Value;
                }

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

        private void FormAddPlaylist_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            if (this.DialogResult != DialogResult.OK)
            {
                r = MessageBox.Show("Quer mesmo fechar o form?", "Adicionar playlist", MessageBoxButtons.OKCancel);

                if (r != DialogResult.OK)
                    e.Cancel = true;
            }
        }
    }
}
