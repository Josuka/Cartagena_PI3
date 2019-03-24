using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;

namespace Cartagena_PI
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();


        }
        Lobby Teste = new Lobby();

        private void bntListar_Click(object sender, EventArgs e)
        {
            textBox1.Text = Lobby.ListarPartidas(cbxFiltros.Text);


        }

        private void bntCriarPartida_Click(object sender, EventArgs e)
        {
            txtID.Text = Lobby.CriarPartida(txtNomePartida.Text, txtSenhaPartida.Text).ToString();
        }

        private void EntrarNaPartida_Click(object sender, EventArgs e)
        {
            Lobby.EntrarPartida(Convert.ToInt32(txtID.Text), txtNomeJogador.Text, txtSenhaPartida.Text);

            txtSenhaJogador.Text = Lobby.SenhaJogador;
            txtIDJogador.Text = Lobby.IDJogador;
            txtCor.Text = Lobby.CorJogador;
        }

        private void IniciarPartida_Click(object sender, EventArgs e)
        {
            txtTurno.Text = Lobby.IniciarPartida();
        }
    }
}