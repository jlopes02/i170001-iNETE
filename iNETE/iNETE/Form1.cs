using System;
using System.Windows.Forms;
using System.Xml;
using PSI10_iNETE;
namespace iNETEapp
{
    public partial class Form1 : Form
    {

        iNETE iNETE = new iNETE();
        bool changes = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            //carregar dados iniciais guardados no ficheiro xml (playlists e musicas)
            XmlDocument docPlaylists = new XmlDocument();
            docPlaylists.Load("..\\..\\playlists.xml");
            XmlDocument docMusicas = new XmlDocument();
            docMusicas.Load("..\\..\\musicas.xml");
            //percorrer musicas
            foreach (XmlNode m in docMusicas.SelectSingleNode("musicas"))
            {
                string a = m.Attributes[0].Value;
                string t = m.Attributes[1].Value;
                genero g = (genero)Enum.Parse(typeof(genero), m.Attributes[2].Value);
                int s = Convert.ToInt32(m.Attributes[3].Value);
                string f = m.Attributes[4].Value;
                Musica musica = new Musica(t, a, s, g, f);
                iNETE.musicas.AddMusica(musica);


            }
            //percorrer playlists
            foreach (XmlNode _playlist in docPlaylists.SelectSingleNode("playlists"))
            {
                int id = Convert.ToInt32(_playlist.Attributes[0].Value);
                string n = _playlist.Attributes[1].Value;
                int year, month;

                month = Convert.ToInt32(_playlist.Attributes[2].Value.Substring(0, 2));
                year = Convert.ToInt32(_playlist.Attributes[2].Value.Substring(3, 4));
                var date = new DateTime(year, month, 1);


                Playlist playlist = new Playlist(n, id, date);

                //percorrer musicas da playlist
                foreach (XmlNode _musica in _playlist)
                {
                    playlist.musicas.AddMusica(iNETE.musicas[Convert.ToInt32(_musica.Attributes[0].Value)]);
                }
                iNETE.playlists.AddPlaylist(playlist);
            }

            //adicionar playlists e musicas às list views
            foreach (Playlist p in iNETE.playlists)
            {
                lsvAddPlaylist(p.IdPlaylist, p.Nome, p.musicas.Count);
            }
            foreach (Musica m in iNETE.musicas)
            {
                lsvAddMusica(m.Artista, getPlaylists(m, -1), m.Titulo, m.Genero, m.Duracao);
            }


            // preencher combo box com os generos

            for (int idx = 0; idx < Enum.GetNames(typeof(genero)).Length; idx++)
            {
                cbbGenero.Items.Add(((genero)idx).ToString());
            }
        }
        /// <summary>
        /// Devolve uma string com os nomes das playlists que contêm a música indicada separados por vírgulas 
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        private string getPlaylists(Musica m, int id)
        {
            string playlists = "";
            foreach (Playlist p in iNETE.playlists)
            {
                if (p.musicas.ContainsMusica(m) && p.IdPlaylist != id)
                {
                    playlists += p.Nome + ',';
                }
            }
            if (playlists.Length != 0)
                return playlists.Substring(0, playlists.Length - 1);

            return playlists;
        }


        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToFile();
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
            if (genero.ToString() == cbbGenero.Text || cbbGenero.Text == "")
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
        }
        private void lsvEditPlaylist(int idx, string nome, string qtd)
        {
            lsvPlaylists.Items[idx].Text = nome;
            lsvPlaylists.Items[idx].SubItems[1].Text = qtd;
        }
        private void lsvEditMusica(int idx, string titulo, string genero, int duracao)
        {
            lsvMusicas.Items[idx].SubItems[2].Text = titulo;
            lsvMusicas.Items[idx].SubItems[3].Text = genero;
            int min = duracao / 60;
            lsvMusicas.Items[idx].SubItems[4].Text = min.ToString() + ":" + (duracao - min * 60).ToString("00");
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
                            lsvAddMusica(m.Artista, getPlaylists(m, p.IdPlaylist), m.Titulo, m.Genero, m.Duracao);
                        }
                }
            else
                foreach (Musica m in iNETE.musicas)
                    lsvAddMusica(m.Artista, getPlaylists(m, -1), m.Titulo, m.Genero, m.Duracao);
        }


        private void EditMusica(Musica musica, Musica newMusica)
        {
            foreach (Playlist p in iNETE.playlists)
            {
                foreach (Musica m in p.musicas)
                {
                    if (m == musica)
                    {
                        m.Artista = newMusica.Artista;
                        m.Titulo = newMusica.Titulo;
                        m.Genero = newMusica.Genero;
                        m.Duracao = newMusica.Duracao;
                        break;
                    }
                }
            }
            foreach (Musica m in iNETE.musicas)
            {
                if (m == musica)
                {
                    m.Artista = newMusica.Artista;
                    m.Titulo = newMusica.Titulo;
                    m.Genero = newMusica.Genero;
                    m.Duracao = newMusica.Duracao;
                    break;
                }
            }
        }

        private void DeleteMusica(Musica musica)
        {
            foreach (Playlist p in iNETE.playlists)
            {
                foreach (Musica m in p.musicas)
                {
                    if (m == musica)
                    {
                        p.musicas.RemoveMusica(m);
                        break;
                    }
                }
            }
            foreach (Musica m in iNETE.musicas)
            {
                if (m == musica)
                {
                    iNETE.musicas.RemoveMusica(m);
                    break;
                }
            }
        }
        private void tsiMusicasArtista_Click(object sender, EventArgs e)
        {
            if (lsvMusicas.SelectedItems.Count != 0)
            {
                int cnt = 0;
                string artista = lsvMusicas.SelectedItems[0].Text;
                foreach (Musica m in iNETE.musicas)
                {
                    if (m.Artista == lsvMusicas.SelectedItems[0].Text)
                        cnt++;
                }

                DialogResult res = MessageBox.Show("Musicas do artista " + artista + ": " + cnt.ToString()
                    + "\n\n Deseja criar uma playlist com todas as suas músicas?", "iNETE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (res == DialogResult.Yes)
                {

                    Playlist playlist = new Playlist(lsvMusicas.SelectedItems[0].Text + "-Musicas", getId(), DateTime.Today);

                    foreach (Musica m in iNETE.musicas)
                    {
                        if (m.Artista == lsvMusicas.SelectedItems[0].Text)
                            playlist.musicas.AddMusica(m);
                    }
                    for (int idx = 0; idx < iNETE.playlists.Count; idx++) // procurar playlist das musicas do artista
                    {
                        if (iNETE.playlists[idx].Nome == playlist.Nome)
                        {
                            int lsvIdx = 0;
                            for (; idx < lsvPlaylists.Items.Count; lsvIdx++)
                            {
                                if (lsvPlaylists.Items[lsvIdx].Text == playlist.Nome)
                                    break;
                            }
                            iNETE.playlists[idx].musicas = playlist.musicas;
                            lsvEditPlaylist(lsvIdx, playlist.Nome, playlist.musicas.Count.ToString());
                            return;
                        }
                    }
                    iNETE.playlists.AddPlaylist(playlist);
                    lsvAddPlaylist(playlist.IdPlaylist, playlist.Nome, playlist.musicas.Count);
                }
            }
        }
        /// <summary>
        /// Devolve o código de playlist mais baixo disponível
        /// </summary>
        /// <returns></returns>
        private int getId()
        {
            int cnt = 0;
            foreach (Playlist p in iNETE.playlists)
                if (p.IdPlaylist > cnt)
                    cnt = p.IdPlaylist;
            bool[] arr = new bool[cnt + 1];
            foreach (Playlist p in iNETE.playlists)
            {
                arr[p.IdPlaylist] = true;
            }
            for (int idx = 0; idx < cnt; idx++)
            {
                if (arr[idx] == false)
                    return idx;
            }
            return 0;
        }

        private void tsiDuracaoGenero_Click(object sender, EventArgs e)
        {
            int qtdgeneros = Enum.GetNames(typeof(genero)).Length;
            int[] duracao = new int[qtdgeneros];


            foreach (Musica m in iNETE.musicas)
            {
                duracao[(int)m.Genero] += m.Duracao;
            }

            string msg = "";
            for (int idx = 0; idx < qtdgeneros; idx++)
            {
                if (duracao[idx] != 0)
                {
                    int min = duracao[idx] / 60;

                    msg += (genero)idx + "- " + min.ToString() + ":" + (duracao[idx] - min * 60).ToString("00") + "\n";
                }
            }

            MessageBox.Show(msg, "Duração por género", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveToFile()
        {
            XmlDocument doc = new XmlDocument();

            XmlNode mainNode = doc.CreateElement("playlists");
            doc.AppendChild(mainNode);

            XmlNode playlist, musica;
            foreach (Playlist p in iNETE.playlists) //criação das nodes das playlists
            {
                //atributos da playlist
                playlist = doc.CreateElement("playlist");
                XmlAttribute id = doc.CreateAttribute("id");
                id.InnerXml = p.IdPlaylist.ToString();

                XmlAttribute nome = doc.CreateAttribute("nome");
                nome.InnerXml = p.Nome;

                XmlAttribute data = doc.CreateAttribute("dataCriacao");
                data.InnerXml = p.DataCriacao.Month.ToString("00") + '-' + p.DataCriacao.Year.ToString();

                playlist.Attributes.Append(id);
                playlist.Attributes.Append(nome);
                playlist.Attributes.Append(data);

                foreach (Musica m in p.musicas) // criação das nodes das músicas para cada playlist
                {
                    int idx;
                    musica = doc.CreateElement("musica");

                    XmlAttribute idxMusica = doc.CreateAttribute("idx");

                    for (idx = 0; idx < iNETE.musicas.Count; idx++)
                    {
                        if (m == iNETE.musicas[idx])
                            break;
                    }
                    idxMusica.InnerXml = idx.ToString();
                    musica.Attributes.Append(idxMusica);
                    // adicionar node da musica à node da playlist
                    playlist.AppendChild(musica);
                }

                mainNode.AppendChild(playlist);
            }
            doc.Save("..\\..\\playlists.xml");
            doc = new XmlDocument();
            mainNode = doc.CreateElement("musicas");
            doc.AppendChild(mainNode);
            foreach (Musica m in iNETE.musicas) // criação das nodes das músicas
            {
                musica = doc.CreateElement("musica");
                //atributos da musica
                XmlAttribute artista = doc.CreateAttribute("artista");
                artista.InnerXml = m.Artista;

                XmlAttribute titulo = doc.CreateAttribute("titulo");
                titulo.InnerXml = m.Titulo;

                XmlAttribute genero = doc.CreateAttribute("genero");
                genero.InnerXml = m.Genero.ToString();

                XmlAttribute duracao = doc.CreateAttribute("duracao");
                duracao.InnerXml = m.Duracao.ToString();

                XmlAttribute file = doc.CreateAttribute("file");
                file.InnerXml = m.FileName;

                musica.Attributes.Append(artista);
                musica.Attributes.Append(titulo);
                musica.Attributes.Append(genero);
                musica.Attributes.Append(duracao);
                musica.Attributes.Append(file);
                mainNode.AppendChild(musica);
            }
            doc.Save("..\\..\\musicas.xml");
            changes = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changes)
            {
                DialogResult res = MessageBox.Show("Deseja guardar as alterações?", "iNETE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (res == DialogResult.Yes) //guardar para os ficheiros
                    SaveToFile();

                if (res == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void criarPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddPlaylist formPlaylist = new FormAddPlaylist(iNETE, null);

            if (formPlaylist.ShowDialog() == DialogResult.OK)
            {
                iNETE.playlists.AddPlaylist(formPlaylist.Playlist);
                lsvAddPlaylist(formPlaylist.Playlist.IdPlaylist, formPlaylist.Playlist.Nome, formPlaylist.Playlist.musicas.Count);
                changes = true;
            }


        }

        private void alterarPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
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
                    changes = true;
                }
            }
        }

        private void apagarPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
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
            changes = true;
        }

        private void tsiInserirMusica_Click(object sender, EventArgs e)
        {
            MusicCollection musicas;
            if (lsvPlaylists.SelectedItems.Count != 0)
            {
                musicas = iNETE.playlists.CodeToPlaylist(Convert.ToInt32(lsvPlaylists.SelectedItems[0].Tag)).musicas;
            }
            else
                musicas = iNETE.musicas;
            FormAddMusica formNewMusica = new FormAddMusica(musicas, null);


            if (formNewMusica.ShowDialog() == DialogResult.OK)
            {
                if (lsvPlaylists.SelectedItems.Count != 0)
                {
                    iNETE.playlists.CodeToPlaylist(Convert.ToInt32(lsvPlaylists.SelectedItems[0].Tag)).musicas.AddMusica(formNewMusica.Musica);
                }
                if (iNETE.musicas.ContainsMusic(formNewMusica.Musica) == false)// se a musica ja existia
                    iNETE.musicas.AddMusica(formNewMusica.Musica);
                string a = formNewMusica.Musica.Artista;
                string t = formNewMusica.Musica.Titulo;
                genero g = formNewMusica.Musica.Genero;
                int d = formNewMusica.Musica.Duracao;
                string f = formNewMusica.Musica.FileName;
                int playlist = -1;
                if (lsvPlaylists.SelectedItems.Count != 0)
                {
                    playlist = Convert.ToInt32(lsvPlaylists.SelectedItems[0].Tag);
                    lsvEditPlaylist(lsvPlaylists.SelectedIndices[0], lsvPlaylists.SelectedItems[0].Text, (Convert.ToInt32(lsvPlaylists.SelectedItems[0].SubItems[1].Text) + 1).ToString());
                }
                lsvAddMusica(a, getPlaylists(formNewMusica.Musica, playlist), t, g, d);
                
                changes = true;
            }
        }

        private void tsiAlterarMusica_Click(object sender, EventArgs e)
        {
            if (lsvMusicas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nenhuma música selecionada", "iNETE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string a = lsvMusicas.SelectedItems[0].Text;
                string t = lsvMusicas.SelectedItems[0].SubItems[2].Text;
                int idx = lsvMusicas.SelectedItems[0].SubItems[4].Text.IndexOf(':');
                int m = Convert.ToInt32(lsvMusicas.SelectedItems[0].SubItems[4].Text.Substring(0, idx));
                int s = Convert.ToInt32(lsvMusicas.SelectedItems[0].SubItems[4].Text.Substring(idx+1, 2));
                int d = m*60 + s;
                FormAddMusica formNewMusica = new FormAddMusica(iNETE.musicas, iNETE.musicas.tituloToMusica(a, t, d));

                if (formNewMusica.ShowDialog() == DialogResult.OK)
                {
                    EditMusica(iNETE.musicas.tituloToMusica(a, t,d), formNewMusica.Musica);


                    lsvEditMusica(lsvMusicas.SelectedIndices[0], formNewMusica.Musica.Titulo, formNewMusica.Musica.Genero.ToString(), formNewMusica.Musica.Duracao);
                    changes = true;
                }
            }
        }

        private void tsiApagarMusica_Click(object sender, EventArgs e)
        {
            if (lsvMusicas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nenhuma música selecionada", "iNETE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult res = MessageBox.Show("Quer mesmo apagar a(s) musica(s) selecionada(s)?", "iNETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (res == DialogResult.Cancel)
                    return;


                foreach (ListViewItem lvi in lsvMusicas.SelectedItems)
                {
                    int idx = lvi.SubItems[4].Text.IndexOf(':');
                    int min = Convert.ToInt32(lvi.SubItems[4].Text.Substring(0, idx));
                    int s = Convert.ToInt32(lvi.SubItems[4].Text.Substring(idx + 1, 2));
                    int d = min * 60 + s;
                    DeleteMusica(iNETE.musicas.tituloToMusica(lvi.Text, lvi.SubItems[2].Text, d));
                    lsvMusicas.Items.Remove(lvi);
                }
                changes = true;
                UpdateQuantidade();
            }
        }
        private void UpdateQuantidade ()
        {
            foreach (ListViewItem lvi in lsvPlaylists.Items)
            {
                lvi.SubItems[1].Text = iNETE.playlists.CodeToPlaylist(Convert.ToInt32(lvi.Tag)).musicas.Count.ToString();
            }
        }
        private void tsiViewPlaylists_Click(object sender, EventArgs e)
        {
            tbcControl.SelectedTab = tbcControl.TabPages[0];
        }

        private void tsiViewMusicas_Click(object sender, EventArgs e)
        {
            tbcControl.SelectedTab = tbcControl.TabPages[1];
        }

        private void cbbGenero_TextChanged(object sender, EventArgs e)
        {
            lsvMusicas.Items.Clear();

            if (lsvPlaylists.SelectedItems.Count != 0)
                foreach (Playlist p in iNETE.playlists)
                {
                    if (p.IdPlaylist == Convert.ToInt32(lsvPlaylists.SelectedItems[0].Tag))
                        foreach (Musica m in p.musicas)
                        {
                            lsvAddMusica(m.Artista, getPlaylists(m, p.IdPlaylist), m.Titulo, m.Genero, m.Duracao);
                        }
                }
            else
                foreach (Musica m in iNETE.musicas)
                    lsvAddMusica(m.Artista, getPlaylists(m, -1), m.Titulo, m.Genero, m.Duracao);
        }

        private void tsiPlay_Click(object sender, EventArgs e)
        {
            if (lsvMusicas.SelectedItems.Count != 0)
            {
                int idx = lsvMusicas.SelectedItems[0].SubItems[4].Text.IndexOf(':');
                int min = Convert.ToInt32(lsvMusicas.SelectedItems[0].SubItems[4].Text.Substring(0, idx));
                int s = Convert.ToInt32(lsvMusicas.SelectedItems[0].SubItems[4].Text.Substring(idx + 1, 2));
                int d = min * 60 + s;
                Musica m = iNETE.musicas.tituloToMusica(lsvMusicas.SelectedItems[0].Text, lsvMusicas.SelectedItems[0].SubItems[2].Text, d);

                MusicPlayer mp = new MusicPlayer(m);

                mp.ShowDialog();
            }
        }
    }
}
