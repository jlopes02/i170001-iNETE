namespace iNETEapp
{
    partial class FormAddMusica
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
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.cbbGenero = new System.Windows.Forms.ComboBox();
            this.numDuracao = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracao)).BeginInit();
            this.SuspendLayout();
            // 
            // txtArtista
            // 
            this.txtArtista.Location = new System.Drawing.Point(23, 44);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(128, 20);
            this.txtArtista.TabIndex = 0;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(157, 44);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(130, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // cbbGenero
            // 
            this.cbbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGenero.FormattingEnabled = true;
            this.cbbGenero.Location = new System.Drawing.Point(293, 44);
            this.cbbGenero.Name = "cbbGenero";
            this.cbbGenero.Size = new System.Drawing.Size(106, 21);
            this.cbbGenero.TabIndex = 2;
            // 
            // numDuracao
            // 
            this.numDuracao.Location = new System.Drawing.Point(405, 44);
            this.numDuracao.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDuracao.Name = "numDuracao";
            this.numDuracao.Size = new System.Drawing.Size(72, 20);
            this.numDuracao.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Artista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Género";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Duracão (s)";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(540, 79);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(483, 43);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(132, 20);
            this.txtFile.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ficheiro";
            // 
            // FormAddMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 114);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDuracao);
            this.Controls.Add(this.cbbGenero);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtArtista);
            this.Name = "FormAddMusica";
            this.Text = "FormAddMusica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddMusica_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numDuracao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ComboBox cbbGenero;
        private System.Windows.Forms.NumericUpDown numDuracao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label label5;
    }
}