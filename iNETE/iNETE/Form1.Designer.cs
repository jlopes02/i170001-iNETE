﻿namespace iNETEapp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcControl = new System.Windows.Forms.TabControl();
            this.tpPlaylist = new System.Windows.Forms.TabPage();
            this.lsvPlaylists = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQtd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpMusic = new System.Windows.Forms.TabPage();
            this.cbbGenero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvMusicas = new System.Windows.Forms.ListView();
            this.chArtista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPlaylist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiViewPlaylists = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiCriarPlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAlterarPlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiDeletePlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.músicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiViewMusicas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiInserirMusica = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAlterarMusica = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiApagarMusica = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiMusicasArtista = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiDuracaoGenero = new System.Windows.Forms.ToolStripMenuItem();
            this.tbcControl.SuspendLayout();
            this.tpPlaylist.SuspendLayout();
            this.tpMusic.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcControl
            // 
            this.tbcControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbcControl.Controls.Add(this.tpPlaylist);
            this.tbcControl.Controls.Add(this.tpMusic);
            this.tbcControl.ItemSize = new System.Drawing.Size(0, 1);
            this.tbcControl.Location = new System.Drawing.Point(12, 27);
            this.tbcControl.Name = "tbcControl";
            this.tbcControl.SelectedIndex = 0;
            this.tbcControl.Size = new System.Drawing.Size(860, 411);
            this.tbcControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcControl.TabIndex = 0;
            // 
            // tpPlaylist
            // 
            this.tpPlaylist.Controls.Add(this.lsvPlaylists);
            this.tpPlaylist.Location = new System.Drawing.Point(4, 5);
            this.tpPlaylist.Name = "tpPlaylist";
            this.tpPlaylist.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlaylist.Size = new System.Drawing.Size(852, 402);
            this.tpPlaylist.TabIndex = 1;
            this.tpPlaylist.Text = "Playlist";
            this.tpPlaylist.UseVisualStyleBackColor = true;
            // 
            // lsvPlaylists
            // 
            this.lsvPlaylists.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chQtd});
            this.lsvPlaylists.HideSelection = false;
            this.lsvPlaylists.Location = new System.Drawing.Point(-4, 3);
            this.lsvPlaylists.MultiSelect = false;
            this.lsvPlaylists.Name = "lsvPlaylists";
            this.lsvPlaylists.Size = new System.Drawing.Size(840, 390);
            this.lsvPlaylists.TabIndex = 0;
            this.lsvPlaylists.UseCompatibleStateImageBehavior = false;
            this.lsvPlaylists.View = System.Windows.Forms.View.Details;
            this.lsvPlaylists.SelectedIndexChanged += new System.EventHandler(this.lsvPlaylists_SelectedIndexChanged);
            // 
            // chName
            // 
            this.chName.Text = "Nome";
            this.chName.Width = 735;
            // 
            // chQtd
            // 
            this.chQtd.Text = "Nº músicas";
            this.chQtd.Width = 89;
            // 
            // tpMusic
            // 
            this.tpMusic.Controls.Add(this.cbbGenero);
            this.tpMusic.Controls.Add(this.label1);
            this.tpMusic.Controls.Add(this.lsvMusicas);
            this.tpMusic.Location = new System.Drawing.Point(4, 5);
            this.tpMusic.Name = "tpMusic";
            this.tpMusic.Size = new System.Drawing.Size(852, 402);
            this.tpMusic.TabIndex = 2;
            this.tpMusic.Text = "Músicas";
            this.tpMusic.UseVisualStyleBackColor = true;
            // 
            // cbbGenero
            // 
            this.cbbGenero.FormattingEnabled = true;
            this.cbbGenero.Location = new System.Drawing.Point(717, 29);
            this.cbbGenero.Name = "cbbGenero";
            this.cbbGenero.Size = new System.Drawing.Size(121, 21);
            this.cbbGenero.TabIndex = 2;
            this.cbbGenero.TextChanged += new System.EventHandler(this.cbbGenero_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(717, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar por género";
            // 
            // lsvMusicas
            // 
            this.lsvMusicas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chArtista,
            this.chPlaylist,
            this.chTitulo,
            this.chGenero,
            this.chDuration});
            this.lsvMusicas.HideSelection = false;
            this.lsvMusicas.Location = new System.Drawing.Point(-4, 3);
            this.lsvMusicas.Name = "lsvMusicas";
            this.lsvMusicas.Size = new System.Drawing.Size(715, 393);
            this.lsvMusicas.TabIndex = 0;
            this.lsvMusicas.UseCompatibleStateImageBehavior = false;
            this.lsvMusicas.View = System.Windows.Forms.View.Details;
            // 
            // chArtista
            // 
            this.chArtista.Text = "Artista";
            this.chArtista.Width = 148;
            // 
            // chPlaylist
            // 
            this.chPlaylist.Text = "Playlist";
            this.chPlaylist.Width = 170;
            // 
            // chTitulo
            // 
            this.chTitulo.Text = "Título";
            this.chTitulo.Width = 174;
            // 
            // chGenero
            // 
            this.chGenero.Text = "Género";
            this.chGenero.Width = 147;
            // 
            // chDuration
            // 
            this.chDuration.Text = "Duração";
            this.chDuration.Width = 70;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.playlistToolStripMenuItem,
            this.músicasToolStripMenuItem,
            this.ferramentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.FecharToolStripMenuItem_Click);
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiViewPlaylists,
            this.tsiCriarPlaylist,
            this.tsiAlterarPlaylist,
            this.tsiDeletePlaylist});
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.playlistToolStripMenuItem.Text = "Playlist";
            // 
            // tsiViewPlaylists
            // 
            this.tsiViewPlaylists.Name = "tsiViewPlaylists";
            this.tsiViewPlaylists.Size = new System.Drawing.Size(152, 22);
            this.tsiViewPlaylists.Text = "Visualizar";
            this.tsiViewPlaylists.Click += new System.EventHandler(this.tsiViewPlaylists_Click);
            // 
            // tsiCriarPlaylist
            // 
            this.tsiCriarPlaylist.Name = "tsiCriarPlaylist";
            this.tsiCriarPlaylist.Size = new System.Drawing.Size(152, 22);
            this.tsiCriarPlaylist.Text = "Criar Playlist";
            this.tsiCriarPlaylist.Click += new System.EventHandler(this.criarPlaylistToolStripMenuItem_Click);
            // 
            // tsiAlterarPlaylist
            // 
            this.tsiAlterarPlaylist.Name = "tsiAlterarPlaylist";
            this.tsiAlterarPlaylist.Size = new System.Drawing.Size(152, 22);
            this.tsiAlterarPlaylist.Text = "Alterar Playlist";
            this.tsiAlterarPlaylist.Click += new System.EventHandler(this.alterarPlaylistToolStripMenuItem_Click);
            // 
            // tsiDeletePlaylist
            // 
            this.tsiDeletePlaylist.Name = "tsiDeletePlaylist";
            this.tsiDeletePlaylist.Size = new System.Drawing.Size(152, 22);
            this.tsiDeletePlaylist.Text = "Apagar Playlist";
            this.tsiDeletePlaylist.Click += new System.EventHandler(this.apagarPlaylistToolStripMenuItem_Click);
            // 
            // músicasToolStripMenuItem
            // 
            this.músicasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiViewMusicas,
            this.tsiPlay,
            this.tsiInserirMusica,
            this.tsiAlterarMusica,
            this.tsiApagarMusica});
            this.músicasToolStripMenuItem.Name = "músicasToolStripMenuItem";
            this.músicasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.músicasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.músicasToolStripMenuItem.Text = "Músicas";
            // 
            // tsiViewMusicas
            // 
            this.tsiViewMusicas.Name = "tsiViewMusicas";
            this.tsiViewMusicas.Size = new System.Drawing.Size(196, 22);
            this.tsiViewMusicas.Text = "Visualizar";
            this.tsiViewMusicas.Click += new System.EventHandler(this.tsiViewMusicas_Click);
            // 
            // tsiInserirMusica
            // 
            this.tsiInserirMusica.Name = "tsiInserirMusica";
            this.tsiInserirMusica.Size = new System.Drawing.Size(196, 22);
            this.tsiInserirMusica.Text = "Inserir Música";
            this.tsiInserirMusica.Click += new System.EventHandler(this.tsiInserirMusica_Click);
            // 
            // tsiAlterarMusica
            // 
            this.tsiAlterarMusica.Name = "tsiAlterarMusica";
            this.tsiAlterarMusica.Size = new System.Drawing.Size(196, 22);
            this.tsiAlterarMusica.Text = "Alterar Música";
            this.tsiAlterarMusica.Click += new System.EventHandler(this.tsiAlterarMusica_Click);
            // 
            // tsiApagarMusica
            // 
            this.tsiApagarMusica.Name = "tsiApagarMusica";
            this.tsiApagarMusica.Size = new System.Drawing.Size(196, 22);
            this.tsiApagarMusica.Text = "Apagar Música";
            this.tsiApagarMusica.Click += new System.EventHandler(this.tsiApagarMusica_Click);
            // 
            // tsiPlay
            // 
            this.tsiPlay.Name = "tsiPlay";
            this.tsiPlay.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsiPlay.Size = new System.Drawing.Size(153, 22);
            this.tsiPlay.Text = "Reproduzir";
            this.tsiPlay.Click += new System.EventHandler(this.tsiPlay_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiMusicasArtista,
            this.tsiDuracaoGenero});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // tsiMusicasArtista
            // 
            this.tsiMusicasArtista.Name = "tsiMusicasArtista";
            this.tsiMusicasArtista.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsiMusicasArtista.Size = new System.Drawing.Size(221, 22);
            this.tsiMusicasArtista.Text = "Músicas do Artista";
            this.tsiMusicasArtista.Click += new System.EventHandler(this.tsiMusicasArtista_Click);
            // 
            // tsiDuracaoGenero
            // 
            this.tsiDuracaoGenero.Name = "tsiDuracaoGenero";
            this.tsiDuracaoGenero.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.tsiDuracaoGenero.Size = new System.Drawing.Size(221, 22);
            this.tsiDuracaoGenero.Text = "Duração por género";
            this.tsiDuracaoGenero.Click += new System.EventHandler(this.tsiDuracaoGenero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 448);
            this.Controls.Add(this.tbcControl);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "iNETE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbcControl.ResumeLayout(false);
            this.tpPlaylist.ResumeLayout(false);
            this.tpMusic.ResumeLayout(false);
            this.tpMusic.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcControl;
        private System.Windows.Forms.TabPage tpPlaylist;
        private System.Windows.Forms.TabPage tpMusic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem músicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsiMusicasArtista;
        private System.Windows.Forms.ToolStripMenuItem tsiDuracaoGenero;
        private System.Windows.Forms.ListView lsvPlaylists;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chQtd;
        private System.Windows.Forms.ListView lsvMusicas;
        private System.Windows.Forms.ColumnHeader chArtista;
        private System.Windows.Forms.ColumnHeader chPlaylist;
        private System.Windows.Forms.ColumnHeader chTitulo;
        private System.Windows.Forms.ColumnHeader chGenero;
        private System.Windows.Forms.ColumnHeader chDuration;
        private System.Windows.Forms.ToolStripMenuItem tsiCriarPlaylist;
        private System.Windows.Forms.ToolStripMenuItem tsiAlterarPlaylist;
        private System.Windows.Forms.ToolStripMenuItem tsiDeletePlaylist;
        private System.Windows.Forms.ToolStripMenuItem tsiInserirMusica;
        private System.Windows.Forms.ToolStripMenuItem tsiAlterarMusica;
        private System.Windows.Forms.ToolStripMenuItem tsiApagarMusica;
        private System.Windows.Forms.ToolStripMenuItem tsiViewPlaylists;
        private System.Windows.Forms.ToolStripMenuItem tsiViewMusicas;
        private System.Windows.Forms.ComboBox cbbGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem tsiPlay;
    }
}

