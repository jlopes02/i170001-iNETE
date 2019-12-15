﻿using System;
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
    public partial class FormAddMusica : Form
    {
        MusicCollection ColMusicas;
        public Musica Musica { get; set; }
        public FormAddMusica(MusicCollection musicas, Musica musica)
        {
            InitializeComponent();

            // preencher combo box com os generos
            genero g;
            for (int idx = 0; idx < Enum.GetNames(typeof(genero)).Count(); idx++)
            {
                cbbGenero.Items.Add(((genero)idx).ToString());
            }

            ColMusicas = musicas;
            
            this.Text = "Adicionar Música";
            if (musica != null)
            {
                Musica = musica;
                txtArtista.Text = Musica.Artista;
                txtArtista.ReadOnly = true;
                txtTitulo.Text = Musica.Titulo;
                cbbGenero.Text= Musica.Genero.ToString();
                numDuracao.Value = Musica.Duracao;
                this.Text = "Alterar Música";
            }
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (Musica==null)
                foreach (Musica m in ColMusicas)
                {
                    if (txtArtista.Text == m.Artista && txtTitulo.Text == m.Titulo && numDuracao.Value == m.Duracao)
                        msg = "Música repetida";
                }

            if (string.IsNullOrWhiteSpace(txtArtista.Text))
                msg = "Campo artista vazio";
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
                msg = "Campo título vazio";
            if (cbbGenero.Text == "")
                msg = "Campo género vazio";
            if (numDuracao.Value == 0)
                msg = "Duracao inválida";

            if (msg!="")
            {
                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult = DialogResult.OK;
                if (Musica == null)
                {
                    Musica = new Musica(txtTitulo.Text, txtArtista.Text, (int)numDuracao.Value, (genero)cbbGenero.SelectedIndex);
                }
                else
                {
                    Musica.Titulo = txtTitulo.Text;
                    Musica.Genero = (genero)cbbGenero.SelectedIndex;
                    Musica.Duracao = (int)numDuracao.Value;
                }
            }
        }

        private void FormAddMusica_FormClosing(object sender, FormClosingEventArgs e)
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
