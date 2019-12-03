﻿using System;
using System.Windows.Forms;
using System.Xml;
using PSI10_iNETE;
namespace iNETEapp
{
    public partial class Form1 : Form
    {
        XmlDocument doc = new XmlDocument();
        iNETE iNETE = new iNETE();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            //carregar dados iniciais guardados no ficheiro xml (playlists e musicas)

            doc.Load("..\\..\\iNETE.xml");

            //percorrer playlists
            foreach (XmlNode _playlist in doc.SelectSingleNode("iNETE"))
            {
                int id = Convert.ToInt32(_playlist.Attributes[0].Value);
                string n = _playlist.Attributes[1].Value;
                Playlist playlist = new Playlist(n, id, DateTime.Today);

                //percorrer musicas
                foreach (XmlNode _musica in _playlist)
                {
                    string a = _musica.Attributes[0].Value;
                    string t = _musica.Attributes[1].Value;
                    genero g = (genero)Enum.Parse(typeof(genero), _musica.Attributes[2].Value);
                    int s = Convert.ToInt32(_musica.Attributes[3].Value);

                    Musica musica = new Musica(t, a, s, g);
                    playlist.musicas.AddMusica(musica);

                }
                iNETE.playlists.AddPlaylist(playlist);
            }

            //adicionar playlists e musicas às list views
            foreach (Playlist p in iNETE.playlists)
            {
                lsvAddPlaylist(p.IdPlaylist, p.Nome, p.musicas.Count);
                foreach (Musica m in p.musicas)
                {
                    lsvAddMusica(m.Artista, p.Nome, m.Titulo, m.Genero, m.Duracao);
                }
            }
        }
        private void PlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbcControl.SelectedTab = tbcControl.TabPages[0];
        }

        private void MúsicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbcControl.SelectedTab = tbcControl.TabPages[1];
            lsvMusicas.GridLines = true;
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            doc.Save("..\\..\\iNETE.xml");
        }
        /// <summary>
        /// Adiciona um item à listview das playlists
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="cnt"></param>
        private void lsvAddPlaylist(int code, string nome, int cnt)
        {
            ListViewItem lvi = new ListViewItem();

            lvi.Text = nome;
            lvi.Tag = code;
            ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();

            lvsi.Text = cnt.ToString();
            lvi.SubItems.Add(lvsi);

            lsvPlaylists.Items.Add(lvi);
        }
        /// <summary>
        /// Adiciona um item à listview das músicas
        /// </summary>
        /// <param name="artista"></param>
        /// <param name="playlist"></param>
        /// <param name="titulo"></param>
        /// <param name="genero"></param>
        /// <param name="duracao"></param>
        private void lsvAddMusica(string artista, string playlist, string titulo, genero genero, int duracao)
        {
            ListViewItem lvi = new ListViewItem();

            lvi.Text = artista;

            ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();

            lvsi.Text = playlist;
            lvi.SubItems.Add(lvsi);

            lvsi = new ListViewItem.ListViewSubItem();

            lvsi.Text = titulo;
            lvi.SubItems.Add(lvsi);

            lvsi = new ListViewItem.ListViewSubItem();

            lvsi.Text = genero.ToString();
            lvi.SubItems.Add(lvsi);

            lvsi = new ListViewItem.ListViewSubItem();

            int min = duracao / 60;
            lvsi.Text = min.ToString() + ":" + (duracao - min * 60).ToString("00");
            lvi.SubItems.Add(lvsi);

            lsvMusicas.Items.Add(lvi);
        }
        private void lsvEditPlaylist(int idx, string nome, string qtd)
        {
            lsvPlaylists.Items[idx].Text = nome;
            lsvPlaylists.Items[idx].SubItems[1].Text = qtd;
        }

        private void BtnNewPlaylist_Click(object sender, EventArgs e)
        {
            FormAddPlaylist formPlaylist = new FormAddPlaylist(iNETE, null);

            if (formPlaylist.ShowDialog() == DialogResult.OK)
            {
                iNETE.playlists.AddPlaylist(formPlaylist.Playlist);
                lsvAddPlaylist(formPlaylist.Playlist.IdPlaylist, formPlaylist.Playlist.Nome, formPlaylist.Playlist.musicas.Count);
            }


        }

        private void btnEditPlaylist_Click(object sender, EventArgs e)
        {
            if (lsvPlaylists.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nenhuma playlist selecionada", "iNETE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormAddPlaylist formPlaylist = new FormAddPlaylist(iNETE, iNETE.playlists[lsvPlaylists.SelectedIndices[0]]);

                if (formPlaylist.ShowDialog() == DialogResult.OK)
                {
                    iNETE.playlists[lsvPlaylists.SelectedIndices[0]] = formPlaylist.Playlist;
                    lsvEditPlaylist(lsvPlaylists.SelectedIndices[0], formPlaylist.Playlist.Nome, formPlaylist.Playlist.musicas.Count.ToString());
                }
            }
        }

        private void btnDeletePlaylist_Click(object sender, EventArgs e)
        {
            if (lsvPlaylists.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nenhuma playlist selecionada", "iNETE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult res = MessageBox.Show("Quer mesmo apagar a playlist selecionada?", "iNETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Cancel)
                return;


            iNETE.playlists.RemovePlaylist(Convert.ToInt32(lsvPlaylists.Items[lsvPlaylists.SelectedIndices[0]].Tag));
            lsvPlaylists.Items.RemoveAt(lsvPlaylists.SelectedIndices[0]);

        }

        private void lsvPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvMusicas.Items.Clear();

            if (lsvPlaylists.SelectedItems.Count != 0)
            foreach (Playlist p in iNETE.playlists)
            {
                if (p.IdPlaylist == Convert.ToInt32(lsvPlaylists.SelectedItems[0].Tag))
                foreach (Musica m in p.musicas)
                {
                    lsvAddMusica(m.Artista, p.Nome, m.Titulo, m.Genero, m.Duracao);
                }
            }
        }

      
    }
}
