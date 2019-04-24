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

        Timer T = new Timer();

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
            label2.Text = Jogo.Versao;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor,true);
        }

        public void DesenharPiratas()
        {
            string verificaVez = lobby.VerificarVez(txtIdPartida.Text);
            string jogadores = lobby.ListarJogadores(txtIdPartida.Text);
            string posicao;
            string cor = "Vermelho";

            string[] posicaoJogador = new string[verificaVez.Length / 3];
            string[] idJogador = new string[verificaVez.Length / 3];
            int[] qntPiratas = new int[verificaVez.Length / 3];

            string[] idJogadoresPartida = new string[5];
            int[] nPiratas = { 0, 0, 0, 0, 0 };
            int numPirata = 0;

            string[] corJogador = { "Vermelho", "Verde", "Amarelo", "Azul", "Marrom" };
            string[] idJogadorListado = new string[jogadores.Length / 3];

            string[] palavras = new string[200];

            palavras = verificaVez.Replace("\r\n", ",").Split(',');
            string[] recebeVerificaVez = new string[palavras.Length];
            recebeVerificaVez = palavras;

            palavras = jogadores.Replace("\r\n", ",").Split(',');
            string[] recebeListarJogadores = new string[palavras.Length];
            recebeListarJogadores = palavras;

            int nextX = 0;
            int nextY = 0;

            int zero = 0;
            int um = 1;
            int dois = 2;
            int tres = 3;
            int quatro = 4;
            int cinco = 5;

            for (int i = 0; i < (recebeVerificaVez.Length - 4) / 3; i++)
            {
                posicaoJogador[i] = recebeVerificaVez[tres];
                idJogador[i] = recebeVerificaVez[quatro];
                tres += 3;
                quatro += 3;
                cinco += 3;
            }

            string[] idDosJogadores = new string[idJogador.Length];

            idDosJogadores = idJogador;

            Array.Sort(idDosJogadores);

            for (int i = 1; i < idDosJogadores.Length; i++)
            {
                int number;
                bool isNumber = Int32.TryParse(idDosJogadores[i], out number);
                if (idDosJogadores[i - 1] != idDosJogadores[i] && isNumber)
                {
                    idJogadoresPartida[zero] = idDosJogadores[i];

                    zero++;
                }
            }

            quatro = 4;
            for (int i = 0; i < (recebeVerificaVez.Length - 4) / 3; i++)
            {
                idJogador[i] = recebeVerificaVez[quatro];

                quatro += 3;
            }
            zero = 0;

            for (int e = 1; e <= /*(idJogadoresPartida.Length-1)*6*/ 30; e++)
            {
                if (nextX > 45) nextX = 0;
                if (nextY > 30) nextY = 0;
                ((PictureBox)this.Controls.Find("pirata" + corJogador[zero] + um.ToString(), true)[0]).Location =
                    new Point(pic0.Location.X + (nextX += 15), pic0.Location.Y + (nextY += 10));
                ((PictureBox)this.Controls.Find("pirata" + corJogador[zero] + um.ToString(), true)[0]).Visible = false;

                um++;
                if (um > 6)
                {
                    um = 1;
                    zero++;
                }


            }

            zero = 0;
            um = 1;
            dois = 2;
            tres = 3;
            quatro = 4;
            cinco = 5;

            for (; tres < recebeVerificaVez.Length - 1; tres += 3)
            {
                int h = 0;
                for (int i = 0; i < idJogadorListado.Length; i++)
                {
                    if (idJogadoresPartida[i] == idJogador[um - 1])
                    {
                        cor = corJogador[i];
                        nPiratas[h]++;
                        numPirata = nPiratas[h];
                        break;
                    }
                    h++;
                }
                posicao = recebeVerificaVez[tres];
                if (nextX > 45) nextX = 0;
                if (nextY > 30) nextY = 0;
                ((PictureBox)this.Controls.Find("pirata" + cor + numPirata.ToString(), true)[0]).Visible = true;
                ((PictureBox)this.Controls.Find("pirata" + cor + numPirata.ToString(), true)[0]).Location = new Point(
                        ((PictureBox)this.Controls.Find("pic" + posicao, true)[0]).Location.X + (nextX += 15),
                        ((PictureBox)this.Controls.Find("pic" + posicao, true)[0]).Location.Y + (nextY += 10));

                um++;
            }
        }

        //public void DesenharPiratas()
        //{
        //    Stack<string> idJogadores = new Stack<string>(lobby.ListarJogadores(txtIdPartida.Text).Replace(("\r\n"),(",")).Split(','));
        //    idJogadores.Pop();
        //    string[] ids = new string[idJogadores.Count()/3];
        //    int i = idJogadores.Count();
        //    for(; idJogadores.Count != 0;)
        //    {
        //        for (int j = 0; j<2; j++) idJogadores.Pop();
        //        i = i - 3;
        //        ids[i/3] = idJogadores.Pop();
        //    }
        //    //MessageBox.Show(ids.Count().ToString());
        //    Queue<string>  piratas = new Queue<string>(lobby.ExibeHistorico(txtIdPartida.Text).Replace(("\r\n"),(",")).Split(','));

        //    //MessageBox.Show(piratas.Dequeue());
        //    /*string posicao;
        //    string[] words = new string[200];
        //    words = quebraTexto.Replace("\r\n", ",").Split(',');
        //    int j = 1;
        //    for (int i = 3; i <= 130; i = i + 3)
        //    {
        //        posicao = words[i];
        //        this.pictureBox2.Image = vermelho;
        //        this.pictureBox2.Location = new System.Drawing.Point(
        //                ((PictureBox)this.Controls.Find("pic" + posicao.ToString(), true)[0]).Location.X,
        //                ((PictureBox)this.Controls.Find("pic" + posicao.ToString(), true)[0]).Location.Y);
        //        this.pictureBox2.Name = "pirate" + j.ToString();
        //        this.pictureBox2.Size = new System.Drawing.Size(15, 15);
        //        this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        //        this.pictureBox2.TabIndex = 122;
        //        this.pictureBox2.TabStop = false;
        //        MessageBox.Show(words[i]);
        //        j++;
        //    }
        //    */
        //}

        public void DesenharTabuleiro()
        {
            string quebraTexto = lobby.ExibirTabuleiro(txtIdPartida.Text);
            if (quebraTexto.Equals("ERRO:Partida não está em jogo\r\n"))
            {
                Erros.MensagemErro("partidaaberta");
                return;
            }
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
                    ((PictureBox)this.Controls.Find("pic" + j.ToString(), true)[0]).BackColor = Color.FromArgb(210, 187, 137);
                    ((PictureBox)this.Controls.Find("pic" + j.ToString(), true)[0]).Visible = true;
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
            txtExibetabuleiro.Text = lobby.ExibirTabuleiro(txtIdPartida.Text);
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

       

        private void btnSistema_Click(object sender, EventArgs e)
        {
            
            string idpartida = txtIdPartida.Text;
            if (lobby.statusJogo(idpartida) && lobby.ExibirMao(txtIdJogador.Text, txtSenhaJogador.Text)!="")
            {
                T.Enabled = true;
                
            }
            else
            {
                T.Enabled = false;
                return;
            }
            T.Interval = 2000;
            T.Tick += new System.EventHandler(t_Timer);
            void t_Timer(object o, EventArgs x)
            {
                if (lobby.statusJogador(idpartida, txtIdJogador.Text))
                {
                    btnSistema.Text = "Rodando";
                    string mao = lobby.ExibirMao(txtIdJogador.Text, txtSenhaJogador.Text);

                    if (mao == "Erro ao exibir mão do jogador")
                    {
                        Erros.MensagemErro("");
                        btnSistema.Text = "Automatizar";
                        return;
                    }
                    if (mao == "")
                    {
                        MessageBox.Show("Jogo manual, falta cartas");
                        T.Enabled = false;
                        btnSistema.Text = "Automatizar";
                        return;
                    }

                    Stack<string> words = new Stack<string>(mao.Replace("\r\n", ",").Split(','));
                    words.Pop();
                    words.Pop();
                    if (lobby.PrimeiraVezJogador(txtIdPartida.Text, txtIdJogador.Text))
                    {
                        lobby.Jooj(words.First(), Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text, 0);
                    }
                    Queue<string> fila = new Queue<string>(lobby.ExibeHistorico(txtIdPartida.Text).Replace("\r\n", ",").Split(','));
                    for (; fila.First() != txtIdJogador.Text && fila.Count != 1; fila.Dequeue()) { }
                    if (fila.Count == 1)
                    {
                        T.Enabled = false;
                        return;
                    }
                    for (int i = 0; i < 3; i++) { fila.Dequeue(); }
                    while (fila.First() == "" && fila.Count <= 6)
                    {
                        for (; fila.First() != txtIdJogador.Text && fila.Count != 1; fila.Dequeue()) { }
                        if (fila.Count == 1)
                        {
                            T.Enabled = false;
                            return;
                        }
                        for (int i = 0; i < 3; i++) { fila.Dequeue(); }
                        //MessageBox.Show(fila.First());
                    }
                    while (fila.First() == "37" && fila.Count <= 6)
                    {
                        for (; fila.First() != txtIdJogador.Text && fila.Count != 1; fila.Dequeue()) { }
                        if (fila.Count == 1)
                        {
                            T.Enabled = false;
                            return;
                        }
                        for (int i = 0; i < 3; i++) { fila.Dequeue(); }
                        //MessageBox.Show(fila.First());
                    }
                    if (fila.First() == "")
                    {
                        lobby.MoverPirata(words.First(), "0");
                    }
                    if (fila.First() == "37")
                    {
                        T.Enabled = false;
                        MessageBox.Show("Todos os piratas estão no Barco");
                        btnSistema.Text = "Encerrado";
                        return;
                    }
                    lobby.Jooj(words.Pop(), Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text, Convert.ToInt32(fila.Dequeue()));
                    btnExibirHistorico_Click(null, null);
                    btnExibirMao_Click(null, null);
                    btnExibirTabuleiro_Click(null, null);
                    btnVerificarVez_Click(null, null);
                }
                else
                {
                    btnSistema.Text = "Em espera";
                    btnExibirHistorico_Click(null, null);
                    btnExibirMao_Click(null, null);
                    btnExibirTabuleiro_Click(null, null);
                    btnVerificarVez_Click(null, null);
                }
            }
        }

        private void txtExibeVez_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExibeHistorico_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExibeMao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExibetabuleiro_TextChanged(object sender, EventArgs e)
        {

        }
    }    
}
