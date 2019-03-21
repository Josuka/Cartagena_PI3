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
        //@Higor//Lobby Teste = new Lobby();
        private void bntListar_Click(object sender, EventArgs e)
        {
            

            textBox1.Text = Jogo.ListarPartidas("T");
            
        }


        private void bntCriarPartida_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.CriarPartida("TESTE6", "XXXX");
            //@Higor//Teste.CriarJogadores()3;
            MessageBox.Show(retorno);

        }

        private void EntrarNaPartida_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.EntrarPartida(9, "lucas4", "XXXX");
            MessageBox.Show(retorno);
            
        }

        private void IniciarPartida_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.IniciarPartida(24, "8F0399");
            MessageBox.Show(retorno);

        }
    }
}
