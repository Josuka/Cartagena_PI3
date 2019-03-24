namespace Cartagena_PI
{
    partial class Form1
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
            this.bntListar = new System.Windows.Forms.Button();
            this.bntCriarPartida = new System.Windows.Forms.Button();
            this.EntrarNaPartida = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IniciarPartida = new System.Windows.Forms.Button();
            this.cbxFiltros = new System.Windows.Forms.ComboBox();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.lblSenhaPartida = new System.Windows.Forms.Label();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblIdPartida = new System.Windows.Forms.Label();
            this.txtIDJogador = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.lblIDJogador = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntListar
            // 
            this.bntListar.Location = new System.Drawing.Point(12, 45);
            this.bntListar.Name = "bntListar";
            this.bntListar.Size = new System.Drawing.Size(100, 23);
            this.bntListar.TabIndex = 0;
            this.bntListar.Text = "Listar Partidas";
            this.bntListar.UseVisualStyleBackColor = true;
            this.bntListar.Click += new System.EventHandler(this.bntListar_Click);
            // 
            // bntCriarPartida
            // 
            this.bntCriarPartida.Location = new System.Drawing.Point(221, 77);
            this.bntCriarPartida.Name = "bntCriarPartida";
            this.bntCriarPartida.Size = new System.Drawing.Size(188, 23);
            this.bntCriarPartida.TabIndex = 1;
            this.bntCriarPartida.Text = "Criar Partida";
            this.bntCriarPartida.UseVisualStyleBackColor = true;
            this.bntCriarPartida.Click += new System.EventHandler(this.bntCriarPartida_Click);
            // 
            // EntrarNaPartida
            // 
            this.EntrarNaPartida.Location = new System.Drawing.Point(420, 77);
            this.EntrarNaPartida.Name = "EntrarNaPartida";
            this.EntrarNaPartida.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EntrarNaPartida.Size = new System.Drawing.Size(194, 23);
            this.EntrarNaPartida.TabIndex = 2;
            this.EntrarNaPartida.Text = "Entrar na Partida";
            this.EntrarNaPartida.UseVisualStyleBackColor = true;
            this.EntrarNaPartida.Click += new System.EventHandler(this.EntrarNaPartida_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 74);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 128);
            this.textBox1.TabIndex = 3;
            // 
            // IniciarPartida
            // 
            this.IniciarPartida.Location = new System.Drawing.Point(347, 131);
            this.IniciarPartida.Name = "IniciarPartida";
            this.IniciarPartida.Size = new System.Drawing.Size(194, 23);
            this.IniciarPartida.TabIndex = 4;
            this.IniciarPartida.Text = "Iniciar Partida";
            this.IniciarPartida.UseVisualStyleBackColor = true;
            this.IniciarPartida.Click += new System.EventHandler(this.IniciarPartida_Click);
            // 
            // cbxFiltros
            // 
            this.cbxFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltros.Items.AddRange(new object[] {
            "Todas",
            "Aberta",
            "Jogando",
            "Encerrada"});
            this.cbxFiltros.Location = new System.Drawing.Point(118, 47);
            this.cbxFiltros.MaxDropDownItems = 4;
            this.cbxFiltros.Name = "cbxFiltros";
            this.cbxFiltros.Size = new System.Drawing.Size(71, 21);
            this.cbxFiltros.TabIndex = 5;
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Location = new System.Drawing.Point(558, 131);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(94, 13);
            this.lblNomeJogador.TabIndex = 6;
            this.lblNomeJogador.Text = "Nome do Jogador:";
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Location = new System.Drawing.Point(218, 48);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(88, 13);
            this.lblNomePartida.TabIndex = 7;
            this.lblNomePartida.Text = "Nome da partida:";
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.AutoSize = true;
            this.lblSenhaPartida.Location = new System.Drawing.Point(417, 48);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(91, 13);
            this.lblSenhaPartida.TabIndex = 8;
            this.lblSenhaPartida.Text = "Senha da partida:";
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Location = new System.Drawing.Point(661, 161);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(94, 13);
            this.lblSenhaJogador.TabIndex = 9;
            this.lblSenhaJogador.Text = "Senha do jogador:";
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(312, 45);
            this.txtNomePartida.Multiline = true;
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(97, 21);
            this.txtNomePartida.TabIndex = 10;
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(514, 44);
            this.txtSenhaPartida.Multiline = true;
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(97, 21);
            this.txtSenhaPartida.TabIndex = 11;
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Location = new System.Drawing.Point(658, 181);
            this.txtSenhaJogador.Multiline = true;
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.ReadOnly = true;
            this.txtSenhaJogador.Size = new System.Drawing.Size(97, 21);
            this.txtSenhaJogador.TabIndex = 13;
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(658, 128);
            this.txtNomeJogador.Multiline = true;
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(97, 21);
            this.txtNomeJogador.TabIndex = 12;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(698, 44);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(57, 21);
            this.txtID.TabIndex = 15;
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.Location = new System.Drawing.Point(635, 47);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(57, 13);
            this.lblIdPartida.TabIndex = 14;
            this.lblIdPartida.Text = "ID Partida:";
            // 
            // txtIDJogador
            // 
            this.txtIDJogador.Location = new System.Drawing.Point(698, 233);
            this.txtIDJogador.Multiline = true;
            this.txtIDJogador.Name = "txtIDJogador";
            this.txtIDJogador.ReadOnly = true;
            this.txtIDJogador.Size = new System.Drawing.Size(57, 21);
            this.txtIDJogador.TabIndex = 16;
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(698, 295);
            this.txtCor.Multiline = true;
            this.txtCor.Name = "txtCor";
            this.txtCor.ReadOnly = true;
            this.txtCor.Size = new System.Drawing.Size(57, 21);
            this.txtCor.TabIndex = 17;
            // 
            // txtTurno
            // 
            this.txtTurno.Location = new System.Drawing.Point(347, 188);
            this.txtTurno.Multiline = true;
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(194, 128);
            this.txtTurno.TabIndex = 18;
            // 
            // lblIDJogador
            // 
            this.lblIDJogador.AutoSize = true;
            this.lblIDJogador.Location = new System.Drawing.Point(693, 217);
            this.lblIDJogador.Name = "lblIDJogador";
            this.lblIDJogador.Size = new System.Drawing.Size(62, 13);
            this.lblIDJogador.TabIndex = 19;
            this.lblIDJogador.Text = "ID Jogador:";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(688, 279);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(67, 13);
            this.lblCor.TabIndex = 20;
            this.lblCor.Text = "Cor Jogador:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblIDJogador);
            this.Controls.Add(this.txtTurno);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtIDJogador);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblIdPartida);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.lblSenhaJogador);
            this.Controls.Add(this.lblSenhaPartida);
            this.Controls.Add(this.lblNomePartida);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.cbxFiltros);
            this.Controls.Add(this.IniciarPartida);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EntrarNaPartida);
            this.Controls.Add(this.bntCriarPartida);
            this.Controls.Add(this.bntListar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntListar;
        private System.Windows.Forms.Button bntCriarPartida;
        private System.Windows.Forms.Button EntrarNaPartida;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button IniciarPartida;
        private System.Windows.Forms.ComboBox cbxFiltros;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Label lblSenhaPartida;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblIdPartida;
        private System.Windows.Forms.TextBox txtIDJogador;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.Label lblIDJogador;
        private System.Windows.Forms.Label lblCor;
    }
}

