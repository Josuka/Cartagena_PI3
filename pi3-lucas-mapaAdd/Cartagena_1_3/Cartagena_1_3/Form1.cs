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
        private int indice;
        Lobby lobby = new Lobby();
        public Form1()
        {
            InitializeComponent();
            indice = 0;
            lobby.Formulario_Text(txtCorJogador, txtCorJogador.Name);
            lobby.ComandoBloqueado(txtIdJogador, txtIdJogador.Name);
            lobby.ComandoBloqueado(txtIdPartida, txtIdPartida.Name);
            lobby.Formulario_Text(txtSenhaPartida, txtSenhaPartida.Name);
            lobby.ComandoBloqueado(txtPosicao, txtPosicao.Name);
            lobby.Formulario_Text(txtSenhaJogador, txtSenhaJogador.Name);
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
            txtExibetabuleiro.Text = lobby.ExibirTabuleiro(txtIdPartida.Text);
        }

        private void btnPularJogada_Click(object sender, EventArgs e)
        {
            txtExibeHistorico.Text = lobby.PularJogada(txtIdJogador.Text, txtSenhaJogador.Text);
        }

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            txtExibeVez.Text = lobby.VerificarVez(txtIdPartida.Text);
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
    }
}
