namespace ListaRamais
{
    partial class ListaRamais
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaRamais));
            this.txtPesquisa = new MaterialSkin.Controls.MaterialTextBox();
            this.teste = new MaterialSkin.Controls.MaterialCheckbox();
            this.teste3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtTela = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.Notificacao = new System.Windows.Forms.NotifyIcon(this.components);
            this.pbSobre = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSobre)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.AnimateReadOnly = false;
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisa.Depth = 0;
            this.txtPesquisa.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPesquisa.LeadingIcon = null;
            this.txtPesquisa.Location = new System.Drawing.Point(8, 82);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisa.MaxLength = 50;
            this.txtPesquisa.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPesquisa.Multiline = false;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(397, 50);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.Text = "";
            this.txtPesquisa.TrailingIcon = null;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // teste
            // 
            this.teste.Depth = 0;
            this.teste.Location = new System.Drawing.Point(0, 0);
            this.teste.Margin = new System.Windows.Forms.Padding(0);
            this.teste.MouseLocation = new System.Drawing.Point(-1, -1);
            this.teste.MouseState = MaterialSkin.MouseState.HOVER;
            this.teste.Name = "teste";
            this.teste.ReadOnly = false;
            this.teste.Ripple = true;
            this.teste.Size = new System.Drawing.Size(104, 37);
            this.teste.TabIndex = 0;
            this.teste.Text = "9534 - Jonnas";
            this.teste.UseVisualStyleBackColor = true;
            // 
            // teste3
            // 
            this.teste3.Depth = 0;
            this.teste3.Location = new System.Drawing.Point(0, 0);
            this.teste3.Margin = new System.Windows.Forms.Padding(0);
            this.teste3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.teste3.MouseState = MaterialSkin.MouseState.HOVER;
            this.teste3.Name = "teste3";
            this.teste3.ReadOnly = false;
            this.teste3.Ripple = true;
            this.teste3.Size = new System.Drawing.Size(104, 37);
            this.teste3.TabIndex = 0;
            this.teste3.Text = "9538 - TI Paulo";
            this.teste3.UseVisualStyleBackColor = true;
            // 
            // txtTela
            // 
            this.txtTela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTela.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTela.Depth = 0;
            this.txtTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTela.Location = new System.Drawing.Point(8, 151);
            this.txtTela.Margin = new System.Windows.Forms.Padding(4);
            this.txtTela.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTela.Name = "txtTela";
            this.txtTela.Size = new System.Drawing.Size(397, 395);
            this.txtTela.TabIndex = 1;
            this.txtTela.Text = "";
            // 
            // Notificacao
            // 
            this.Notificacao.BalloonTipText = "ListaRamais";
            this.Notificacao.BalloonTipTitle = "ListaRamais";
            this.Notificacao.Icon = ((System.Drawing.Icon)(resources.GetObject("Notificacao.Icon")));
            this.Notificacao.Text = "ListaRamais - Dê um duplo clique para fechar";
            this.Notificacao.Visible = true;
            this.Notificacao.Click += new System.EventHandler(this.Notificacao_Click);
            this.Notificacao.DoubleClick += new System.EventHandler(this.Notificacao_DoubleClick);
            // 
            // pbSobre
            // 
            this.pbSobre.BackColor = System.Drawing.Color.Transparent;
            this.pbSobre.Image = global::ListaRamais.Properties.Resources.icons8_sobre_24__1_;
            this.pbSobre.Location = new System.Drawing.Point(369, 39);
            this.pbSobre.Margin = new System.Windows.Forms.Padding(4);
            this.pbSobre.Name = "pbSobre";
            this.pbSobre.Size = new System.Drawing.Size(32, 30);
            this.pbSobre.TabIndex = 2;
            this.pbSobre.TabStop = false;
            this.pbSobre.Click += new System.EventHandler(this.pbSobre_Click);
            // 
            // ListaRamais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 554);
            this.Controls.Add(this.pbSobre);
            this.Controls.Add(this.txtTela);
            this.Controls.Add(this.txtPesquisa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ListaRamais";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Lista de Ramais";
            this.Deactivate += new System.EventHandler(this.JonnasPhone_Deactivate);
            this.Load += new System.EventHandler(this.JonnasPhone_Load);
            this.Resize += new System.EventHandler(this.JonnasPhone_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbSobre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtPesquisa;
        private MaterialSkin.Controls.MaterialCheckbox teste;
        private MaterialSkin.Controls.MaterialCheckbox teste3;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtTela;
        private System.Windows.Forms.NotifyIcon Notificacao;
        private System.Windows.Forms.PictureBox pbSobre;
    }
}

