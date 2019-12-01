namespace iNETEapp
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
            this.btnDeletePlaylist = new System.Windows.Forms.Button();
            this.btnEditPlaylist = new System.Windows.Forms.Button();
            this.btnNewPlaylist = new System.Windows.Forms.Button();
            this.lsvPlaylists = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQtd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpMusic = new System.Windows.Forms.TabPage();
            this.btnDeleteMusica = new System.Windows.Forms.Button();
            this.btnEditMusica = new System.Windows.Forms.Button();
            this.btnNewMusica = new System.Windows.Forms.Button();
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
            this.músicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duraçãoPorGéneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tbcControl.Size = new System.Drawing.Size(731, 411);
            this.tbcControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcControl.TabIndex = 0;
            // 
            // tpPlaylist
            // 
            this.tpPlaylist.Controls.Add(this.btnDeletePlaylist);
            this.tpPlaylist.Controls.Add(this.btnEditPlaylist);
            this.tpPlaylist.Controls.Add(this.btnNewPlaylist);
            this.tpPlaylist.Controls.Add(this.lsvPlaylists);
            this.tpPlaylist.Location = new System.Drawing.Point(4, 5);
            this.tpPlaylist.Name = "tpPlaylist";
            this.tpPlaylist.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlaylist.Size = new System.Drawing.Size(723, 402);
            this.tpPlaylist.TabIndex = 1;
            this.tpPlaylist.Text = "Playlist";
            this.tpPlaylist.UseVisualStyleBackColor = true;
            // 
            // btnDeletePlaylist
            // 
            this.btnDeletePlaylist.Location = new System.Drawing.Point(599, 120);
            this.btnDeletePlaylist.Name = "btnDeletePlaylist";
            this.btnDeletePlaylist.Size = new System.Drawing.Size(118, 23);
            this.btnDeletePlaylist.TabIndex = 3;
            this.btnDeletePlaylist.Text = "Apagar Playlist";
            this.btnDeletePlaylist.UseVisualStyleBackColor = true;
            // 
            // btnEditPlaylist
            // 
            this.btnEditPlaylist.Location = new System.Drawing.Point(599, 70);
            this.btnEditPlaylist.Name = "btnEditPlaylist";
            this.btnEditPlaylist.Size = new System.Drawing.Size(118, 23);
            this.btnEditPlaylist.TabIndex = 2;
            this.btnEditPlaylist.Text = "Alterar Playlist";
            this.btnEditPlaylist.UseVisualStyleBackColor = true;
            // 
            // btnNewPlaylist
            // 
            this.btnNewPlaylist.Location = new System.Drawing.Point(599, 20);
            this.btnNewPlaylist.Name = "btnNewPlaylist";
            this.btnNewPlaylist.Size = new System.Drawing.Size(118, 23);
            this.btnNewPlaylist.TabIndex = 1;
            this.btnNewPlaylist.Text = "Criar Playlist";
            this.btnNewPlaylist.UseVisualStyleBackColor = true;
            this.btnNewPlaylist.Click += new System.EventHandler(this.BtnNewPlaylist_Click);
            // 
            // lsvPlaylists
            // 
            this.lsvPlaylists.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chQtd});
            this.lsvPlaylists.HideSelection = false;
            this.lsvPlaylists.Location = new System.Drawing.Point(6, 6);
            this.lsvPlaylists.Name = "lsvPlaylists";
            this.lsvPlaylists.Size = new System.Drawing.Size(580, 366);
            this.lsvPlaylists.TabIndex = 0;
            this.lsvPlaylists.UseCompatibleStateImageBehavior = false;
            this.lsvPlaylists.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Nome";
            this.chName.Width = 485;
            // 
            // chQtd
            // 
            this.chQtd.Text = "Nº músicas";
            this.chQtd.Width = 89;
            // 
            // tpMusic
            // 
            this.tpMusic.Controls.Add(this.btnDeleteMusica);
            this.tpMusic.Controls.Add(this.btnEditMusica);
            this.tpMusic.Controls.Add(this.btnNewMusica);
            this.tpMusic.Controls.Add(this.lsvMusicas);
            this.tpMusic.Location = new System.Drawing.Point(4, 5);
            this.tpMusic.Name = "tpMusic";
            this.tpMusic.Size = new System.Drawing.Size(723, 402);
            this.tpMusic.TabIndex = 2;
            this.tpMusic.Text = "Músicas";
            this.tpMusic.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMusica
            // 
            this.btnDeleteMusica.Location = new System.Drawing.Point(599, 120);
            this.btnDeleteMusica.Name = "btnDeleteMusica";
            this.btnDeleteMusica.Size = new System.Drawing.Size(118, 23);
            this.btnDeleteMusica.TabIndex = 6;
            this.btnDeleteMusica.Text = "Apagar Música";
            this.btnDeleteMusica.UseVisualStyleBackColor = true;
            // 
            // btnEditMusica
            // 
            this.btnEditMusica.Location = new System.Drawing.Point(599, 70);
            this.btnEditMusica.Name = "btnEditMusica";
            this.btnEditMusica.Size = new System.Drawing.Size(118, 23);
            this.btnEditMusica.TabIndex = 5;
            this.btnEditMusica.Text = "Alterar Música";
            this.btnEditMusica.UseVisualStyleBackColor = true;
            // 
            // btnNewMusica
            // 
            this.btnNewMusica.Location = new System.Drawing.Point(599, 20);
            this.btnNewMusica.Name = "btnNewMusica";
            this.btnNewMusica.Size = new System.Drawing.Size(118, 23);
            this.btnNewMusica.TabIndex = 4;
            this.btnNewMusica.Text = "Inserir Música";
            this.btnNewMusica.UseVisualStyleBackColor = true;
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
            this.lsvMusicas.Location = new System.Drawing.Point(6, 6);
            this.lsvMusicas.Name = "lsvMusicas";
            this.lsvMusicas.Size = new System.Drawing.Size(580, 366);
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
            this.chPlaylist.Width = 109;
            // 
            // chTitulo
            // 
            this.chTitulo.Text = "Título";
            this.chTitulo.Width = 142;
            // 
            // chGenero
            // 
            this.chGenero.Text = "Género";
            this.chGenero.Width = 117;
            // 
            // chDuration
            // 
            this.chDuration.Text = "Duração";
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
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
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
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.playlistToolStripMenuItem.Text = "Playlist";
            this.playlistToolStripMenuItem.Click += new System.EventHandler(this.PlaylistToolStripMenuItem_Click);
            // 
            // músicasToolStripMenuItem
            // 
            this.músicasToolStripMenuItem.Name = "músicasToolStripMenuItem";
            this.músicasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.músicasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.músicasToolStripMenuItem.Text = "Músicas";
            this.músicasToolStripMenuItem.Click += new System.EventHandler(this.MúsicasToolStripMenuItem_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aaaToolStripMenuItem,
            this.duraçãoPorGéneroToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // aaaToolStripMenuItem
            // 
            this.aaaToolStripMenuItem.Name = "aaaToolStripMenuItem";
            this.aaaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aaaToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.aaaToolStripMenuItem.Text = "Músicas do Artista";
            // 
            // duraçãoPorGéneroToolStripMenuItem
            // 
            this.duraçãoPorGéneroToolStripMenuItem.Name = "duraçãoPorGéneroToolStripMenuItem";
            this.duraçãoPorGéneroToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.duraçãoPorGéneroToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.duraçãoPorGéneroToolStripMenuItem.Text = "Duração por género";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 435);
            this.Controls.Add(this.tbcControl);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbcControl.ResumeLayout(false);
            this.tpPlaylist.ResumeLayout(false);
            this.tpMusic.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem aaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duraçãoPorGéneroToolStripMenuItem;
        private System.Windows.Forms.Button btnDeletePlaylist;
        private System.Windows.Forms.Button btnEditPlaylist;
        private System.Windows.Forms.Button btnNewPlaylist;
        private System.Windows.Forms.ListView lsvPlaylists;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chQtd;
        private System.Windows.Forms.Button btnDeleteMusica;
        private System.Windows.Forms.Button btnEditMusica;
        private System.Windows.Forms.Button btnNewMusica;
        private System.Windows.Forms.ListView lsvMusicas;
        private System.Windows.Forms.ColumnHeader chArtista;
        private System.Windows.Forms.ColumnHeader chPlaylist;
        private System.Windows.Forms.ColumnHeader chTitulo;
        private System.Windows.Forms.ColumnHeader chGenero;
        private System.Windows.Forms.ColumnHeader chDuration;
    }
}

