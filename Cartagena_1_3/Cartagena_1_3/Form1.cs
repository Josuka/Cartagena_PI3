using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartagenaServer;
using System.Windows.Forms;

namespace Cartagena_1_3
{

    public partial class Form1 : Form
    {
        Lobby lobby = new Lobby();

        Image chave = Properties.Resources.Chave;
        Image esqueleto = Properties.Resources.Esqueleto;
        Image faca = Properties.Resources.Faca;
        Image garrafa = Properties.Resources.Garrafa;
        Image pistola = Properties.Resources.Pistola;
        Image tricornio = Properties.Resources.Triconio;

        Image vermelho = Properties.Resources.Vermelho;
        Image verde = Properties.Resources.Verde;
        Image azul = Properties.Resources.Azul;
        Image amarelo = Properties.Resources.Amarelo;
        Image marrom = Properties.Resources.Marrom;

        public Form1()
        {
            InitializeComponent();
            lobby.Formulario_Text(txtCorJogador, txtCorJogador.Name);
            lobby.ComandoBloqueado(txtIdJogador, txtIdJogador.Name);
            lobby.ComandoBloqueado(txtIdPartida, txtIdPartida.Name);
            lobby.Formulario_Text(txtSenhaPartida, txtSenhaPartida.Name);
            lobby.ComandoBloqueado(txtPosicao, txtPosicao.Name);
            lobby.Formulario_Text(txtSenhaJogador, txtSenhaJogador.Name);
            cboPartida.Text = "Todas";
            cboSimbolo.Text = "Esqueleto";
        }

        public void DesenharPiratas()
        {
            string quebraTexto = lobby.VerificarVez(txtIdPartida.Text);
            
            string posicao;
            string[] words = new string[200];
            words = quebraTexto.Replace("\r\n", ",").Split(',');
            int j = 1;
            for (int i = 3; i <= 130; i = i + 3)
            {
                posicao = words[i];
                this.pictureBox2.Image = vermelho;
                this.pictureBox2.Location = new System.Drawing.Point(
                        ((PictureBox)this.Controls.Find("pic" + posicao.ToString(), true)[0]).Location.X,
                        ((PictureBox)this.Controls.Find("pic" + posicao.ToString(), true)[0]).Location.Y);
                this.pictureBox2.Name = "pirate" + j.ToString();
                this.pictureBox2.Size = new System.Drawing.Size(15, 15);
                this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                this.pictureBox2.TabIndex = 122;
                this.pictureBox2.TabStop = false;
                MessageBox.Show(words[i]);
                j++;
            }
        }

        public void DesenharTabuleiro()
        {
            string quebraTexto = lobby.ExibirTabuleiro(txtIdPartida.Text);
            string simbolo;
            string posicao;
            string[] words = new string[190];
            if (quebraTexto != "Erro ao mostrar tabuleiro")
            {
                words = quebraTexto.Replace("\r\n", ",").Split(',');
                int j = 1;
                for (int i = 2; i <= 72; i = i + 2)
                {
                    posicao = words[i];
                    simbolo = words[i + 1];
                    if (simbolo == "C")
                        ((PictureBox)this.Controls.Find("pic" + j.ToString(), true)[0]).Image = chave;
                    else if (simbolo == "E")
                        ((PictureBox)this.Controls.Find("pic" + j.ToString(), true)[0]).Image = esqueleto;
                    else if (simbolo == "F")
                        ((PictureBox)this.Controls.Find("pic" + j.ToString(), true)[0]).Image = faca;
                    else if (simbolo == "T")
                        ((PictureBox)this.Controls.Find("pic" + j.ToString(), true)[0]).Image = tricornio;
                    else if (simbolo == "P")
                        ((PictureBox)this.Controls.Find("pic" + j.ToString(), true)[0]).Image = pistola;
                    else if (simbolo == "G")
                        ((PictureBox)this.Controls.Find("pic" + j.ToString(), true)[0]).Image = garrafa;
                    j++;
                }
            }

        }

            

        private void btnListarPartida_Click(object sender, EventArgs e)
        {

            txtExibePartida.Text = lobby.ListarPartidas(cboPartida.Text);
            
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            txtIdPartida.Text = lobby.CriarPartida(txtNomePartida.Text,
                txtSenhaPartida.Text).ToString();
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            lobby.EntrarPartida(txtIdPartida.Text, txtNomeJogador.Text, txtSenhaPartida.Text);
            txtIdJogador.Text = lobby.IDJogador.ToString();
            txtSenhaJogador.Text = lobby.SenhaJogador;
            txtCorJogador.Text = lobby.CorJogador;
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {

            txtExibeHistorico.Text = lobby.IniciarPartida(txtIdJogador.Text, txtSenhaJogador.Text);
        }

        private void btnExibirMao_Click(object sender, EventArgs e)
        {
            txtExibeMao.Text = lobby.ExibirMao(txtIdJogador.Text,
                txtSenhaJogador.Text);
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            txtExibeJogadores.Text = lobby.ListarJogadores(txtIdPartida.Text);
        }

        private void btnJogarFrente_Click(object sender, EventArgs e)
        {

            txtExibeHistorico.Text = lobby.MoverPirata(cboSimbolo.Text, txtPosicao.Text);

        }
        private void btnJogarTras_Click(object sender, EventArgs e)
        {
            txtExibeHistorico.Text = lobby.MoverPirata(txtIdJogador.Text, txtSenhaJogador.Text,
                txtPosicao.Text);
        }

        private void btnExibirTabuleiro_Click(object sender, EventArgs e)
        {
            //txtExibetabuleiro.Text = lobby.ExibirTabuleiro(txtIdPartida.Text);
            DesenharTabuleiro();
        }

        private void btnPularJogada_Click(object sender, EventArgs e)
        {
            txtExibeHistorico.Text = lobby.PularJogada(txtIdJogador.Text, txtSenhaJogador.Text);
        }

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            txtExibeVez.Text = lobby.VerificarVez(txtIdPartida.Text);
            DesenharPiratas();
        }

        private void btnExibirHistorico_Click(object sender, EventArgs e)
        {
            txtExibeHistorico.Text = lobby.ExibeHistorico(txtIdPartida.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
