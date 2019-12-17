namespace iNETEapp
{
    partial class MusicPlayer
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
            this.lblArtista = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.tcbVolume = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tcbVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.Location = new System.Drawing.Point(12, 9);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(35, 13);
            this.lblArtista.TabIndex = 0;
            this.lblArtista.Text = "label1";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(60, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "label2";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(108, 9);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(35, 13);
            this.lblGenero.TabIndex = 2;
            this.lblGenero.Text = "label3";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(15, 28);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(54, 26);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(75, 28);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(51, 26);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // tcbVolume
            // 
            this.tcbVolume.Location = new System.Drawing.Point(182, 9);
            this.tcbVolume.Maximum = 100;
            this.tcbVolume.Name = "tcbVolume";
            this.tcbVolume.Size = new System.Drawing.Size(104, 45);
            this.tcbVolume.TabIndex = 5;
            this.tcbVolume.Value = 100;
            this.tcbVolume.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 63);
            this.Controls.Add(this.tcbVolume);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblArtista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.Name = "MusicPlayer";
            this.Text = "MusicPlayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MusicPlayer_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tcbVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArtista;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.TrackBar tcbVolume;
    }
}