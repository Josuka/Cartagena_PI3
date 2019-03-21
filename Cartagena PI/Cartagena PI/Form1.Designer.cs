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
            this.SuspendLayout();
            // 
            // bntListar
            // 
            this.bntListar.Location = new System.Drawing.Point(12, 12);
            this.bntListar.Name = "bntListar";
            this.bntListar.Size = new System.Drawing.Size(152, 23);
            this.bntListar.TabIndex = 0;
            this.bntListar.Text = "Listar Partidas";
            this.bntListar.UseVisualStyleBackColor = true;
            this.bntListar.Click += new System.EventHandler(this.bntListar_Click);
            // 
            // bntCriarPartida
            // 
            this.bntCriarPartida.Location = new System.Drawing.Point(223, 12);
            this.bntCriarPartida.Name = "bntCriarPartida";
            this.bntCriarPartida.Size = new System.Drawing.Size(75, 23);
            this.bntCriarPartida.TabIndex = 1;
            this.bntCriarPartida.Text = "Criar Partida";
            this.bntCriarPartida.UseVisualStyleBackColor = true;
            this.bntCriarPartida.Click += new System.EventHandler(this.bntCriarPartida_Click);
            // 
            // EntrarNaPartida
            // 
            this.EntrarNaPartida.Location = new System.Drawing.Point(347, 12);
            this.EntrarNaPartida.Name = "EntrarNaPartida";
            this.EntrarNaPartida.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EntrarNaPartida.Size = new System.Drawing.Size(146, 23);
            this.EntrarNaPartida.TabIndex = 2;
            this.EntrarNaPartida.Text = "Entrar na Partida";
            this.EntrarNaPartida.UseVisualStyleBackColor = true;
            this.EntrarNaPartida.Click += new System.EventHandler(this.EntrarNaPartida_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 100);
            this.textBox1.TabIndex = 3;
            // 
            // IniciarPartida
            // 
            this.IniciarPartida.Location = new System.Drawing.Point(528, 12);
            this.IniciarPartida.Name = "IniciarPartida";
            this.IniciarPartida.Size = new System.Drawing.Size(113, 23);
            this.IniciarPartida.TabIndex = 4;
            this.IniciarPartida.Text = "Iniciar Partida";
            this.IniciarPartida.UseVisualStyleBackColor = true;
            this.IniciarPartida.Click += new System.EventHandler(this.IniciarPartida_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

