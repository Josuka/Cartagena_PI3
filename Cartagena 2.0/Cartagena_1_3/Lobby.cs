using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartagenaServer;

namespace Cartagena_1_3
{
    
    class Lobby
    {
        private int _idJogador; //Armazena ID do jogador. Apenas a Classe pode fazer uso
        private int _idPartida; //Armazena ID da partida. Apenas a Classe pode fazer uso
        private int _posicao; //Armazena posição do jogar para a proxima jogada.

        private string _senhaJogador; //Armazena senha do jogador. Apenas a Classe pode fazer uso.
        private string _senhaPartida; //Armazena senha da partida. Apenas a Classe pode fazer uso.
        private string _nomeJogador; //Armazena nome do jogador. Apenas a Classe pode fazer uso.
        private string _corJogador; //Armazena cor do jogador. Apenas a Classe pode fazer uso.
        private string _movimento; //Armazena movimento em uma partida. Apenas a Classe pode fazer uso.
         
        /// <summary>
        ///Propriedade responsável por retornar e setar ID da partida. Apenas a Classe pode fazer uso
        /// <summary>
        public int IDPartida { get { return _idPartida; } }

        /// <summary>
        ///Propriedade responsável por retornar e setar ID do jogador. Apenas a Classe pode fazer uso
        /// <summary>
        public int IDJogador { get { return _idJogador; } }

        /// <summary>
        ///Propriedade responsável por retornar e setar senha do jogador. Apenas a Classe pode fazer uso
        /// <summary>
        public string SenhaJogador { get { return _senhaJogador; } }

        /// <summary>
        ///Propriedade responsável por retornar e setar senha da partida. Apenas a Classe pode fazer uso
        /// <summary>
        public string SenhaPartida { get { return _senhaPartida; } }

        /// <summary>
        ///Propriedade responsável por retornar e setar cor do jogador. Apenas a Classe pode fazer uso
        /// <summary>
        public string CorJogador { get { return _corJogador; } }

        public void ComandoBloqueado(Control control, string nomeControle)
        {
            control.KeyPress += new KeyPressEventHandler(controle_filho_keypress);
            void controle_filho_keypress(object sender, KeyPressEventArgs e)
            {
                if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter)
                    && !(e.KeyChar == (char)Keys.Back))
                    e.Handled = true;
            }
            Formulario_Text(control, nomeControle);
        }

        public void Formulario_Text(Control controleFilho, string nomeControle)
        {
            Image chave = Properties.Resources.Chave;
            controleFilho.TextChanged += new EventHandler(ControleFilho_TxtChanged);
            void ControleFilho_TxtChanged(object sender, EventArgs e)
            {
                switch (nomeControle)
                {
                    case "txtSenhaPartida":
                        _senhaPartida = ((TextBox)sender).Text;
                        return;
                    case "txtIdPartida":
                        if (((TextBox)sender).Text == "") _idPartida = 0;
                        else _idPartida = Convert.ToInt32(((TextBox)sender).Text);
                        return;
                    case "txtIdJogador":
                        if (((TextBox)sender).Text == "") _idJogador = 0;
                        else _idJogador = Convert.ToInt32(((TextBox)sender).Text);
                        return;
                    case "txtSenhaJogador":
                        _senhaJogador = ((TextBox)sender).Text;
                        return;
                    case "txtCorJogador":
                        _corJogador = ((TextBox)sender).Text;
                        return;
                    case "txtPosicao":
                        if (((TextBox)sender).Text == "") _posicao = 0;
                        else _posicao = Convert.ToInt32(((TextBox)sender).Text);
                        return;
                }
                return;
            }
        }

        /// <summary>
        /// Método responsável por listar partidas através de um filtro. Apenas a Classe pode fazer uso.
        /// </summary>
        /// <param name="filtro">Nomes das partidas</param>
        /// <returns></returns>
        public string ListarPartidas(string filtro)
        {
            switch (filtro)
            {
                case "Aberta":
                    return Jogo.ListarPartidas("A");
                case "Encerrada":
                    return Jogo.ListarPartidas("E");
                case "Jogando":
                    return Jogo.ListarPartidas("J");
            }
            return Jogo.ListarPartidas("T");
        }

        /// <summary>
        /// Método responsável por entrar em uma partida através do ID e senha da partida e nome do jogador.
        /// Apenas a Classe pode fazer uso
        /// </summary>
        /// <param name="nome">Nome da partida a ser criada</param>
        /// <returns></returns>
        public string EntrarPartida(/*string nome*/string idPartida, string nomeJogador, string senhaPartida)
        {
            if (idPartida == string.Empty)
            {
                Erros.MensagemErro("idpartida");
                return "Erro";
            }

            else if (nomeJogador == string.Empty)
            {
                Erros.MensagemErro("nomejogador");
                return "Erro";
            }
            else if (senhaPartida == string.Empty)
            {
                Erros.MensagemErro("senhapartida");
                return "Erro";
            }
            _idPartida = Convert.ToInt32(idPartida);
            _nomeJogador = nomeJogador;
            _senhaPartida = senhaPartida;
            string quebraTexto = Jogo.EntrarPartida(_idPartida, _nomeJogador, _senhaPartida);

            if (quebraTexto == "ERRO:Quantidade máxima de jogadores atingida!\r\n")
            {
                Erros.MensagemErro("limitejogadores");
                return "Limite de jogadores atingido.";
            }
            else if (quebraTexto == "ERRO:Já existe um jogador com este nome na partida\r\n")
            {
                Erros.MensagemErro("jogadorjaexiste");
                return "Por favor, tente entrar com um nome diferente.";
            }
            else if (quebraTexto == "ERRO:Senha Incorreta!\r\n")
            {
                Erros.MensagemErro("senhaincorreta");
                return "Por favor, digite a senha correta.";
            }
            else if (quebraTexto == "ERRO:Id ou Senha da partida está vazio")
            {
                Erros.MensagemErro("");
                return "Erro";
            }
            else if (quebraTexto == "ERRO:Partida já iniciada!\r\n")
            {
                Erros.MensagemErro("partidainiciada");
                return "Não é possível entrar em uma partida que não está aberta.";
            }
            else if(quebraTexto == "ERRO:Nome com mais de 50 caracteres")
            {
                Erros.MensagemErro("limite50caracteres");
                return "O limite é de 50 caracteres.";
            }
            string[] words = new string[3];
            words = quebraTexto.Split(',');
            _idJogador = Convert.ToInt32(words[0]);
            _senhaJogador = words[1];
            _corJogador = words[2];
            Erros.MensagemSucesso("jogadorcriado");
            return _idJogador.ToString() + "," + _senhaJogador + "," + _corJogador;
        }

        /// <summary>
        /// Método responsável por criar partidas através de nome e senha. Apenas a Classe pode fazer uso
        /// </summary>
        /// <param name="nomePartida">Nome da Partida a ser criada.</param>
        /// <param name="senhaPartida">Senha a ser utilizada da partida.</param>
        /// <returns>Retorna o ID da partida.</returns>
        public int CriarPartida(string nomePartida, string senhaPartida)
        {
            if (nomePartida == string.Empty)
            {
                Erros.MensagemErro("nomepartida");
                return 0;
            }
            else if (senhaPartida == string.Empty)
            {
                Erros.MensagemErro("senhapartida");
                return 0;
            }

            _senhaPartida = senhaPartida;
            string partida = Jogo.CriarPartida(nomePartida, _senhaPartida);

            if (partida == "ERRO: Partida já existente")
            {
                Erros.MensagemErro("nomeexistente");
                return 0;
            }
            else if (partida == "ERRO:Nome da partida com mais que 20 caracteres")
            {
                Erros.MensagemErro("limite20caracteres");
                return 0;
            }
            _idPartida = Convert.ToInt32(partida);
            Erros.MensagemSucesso("partidacriada");
            return _idPartida;
        }

        /// <summary>
        /// Método responsável por iniciar uma partidas. Apenas a Classe pode fazer uso
        /// </summary>
        /// <param name="idJogador">Nome da Partida a ser criada.</param>
        /// <param name="senhaJogador">Senha a ser utilizada da partida.</param>
        /// <returns>Retorna os dados da partida.</returns>
        public string IniciarPartida(string idJogador, string senhaJogador)
        {
            if (idJogador == string.Empty)
            {
                Erros.MensagemErro("idjogador");
                return "Erro ao iniciar partida";
            }
            else if (senhaJogador == string.Empty)
            {
                Erros.MensagemErro("senhajogador");
                return "Erro ao iniciar partida";
            }
            _idJogador = Convert.ToInt32(idJogador);
            _senhaJogador = senhaJogador;
            Erros.MensagemSucesso("partidainiciada");
            return Jogo.IniciarPartida(_idJogador, _senhaJogador);
        }

        /// <summary>
        /// Método responsável por Exibir o que tem disponivel de cartas.
        /// Apenas a Classe pode fazer uso
        /// </summary>
        /// <param name="idJogador">ID do jogador</param>
        /// <param name="senhaJogador">Senha do jogador</param>
        /// <returns>Retorna informações de cartas do Jogo.</returns>
        public string ExibirMao(string idJogador, string senhaJogador)
        {
            if (idJogador == string.Empty)
            {
                Erros.MensagemErro("idjogador");
                return "Erro ao exibir mão do jogador";
            }

            else if (senhaJogador == string.Empty)
            {
                Erros.MensagemErro("senhajogador");
                return "Erro ao exibir mão do jogador";
            }
            _idJogador = Convert.ToInt32(idJogador);
            _senhaJogador = senhaJogador;
            return Jogo.ConsultarMao(_idJogador, _senhaJogador);
        }

        /// <summary>
        /// Método responsável por listar os jogadores de uma partida através de seu ID.
        /// Apenas a Classe pode fazer uso.
        /// </summary>
        /// <param name="idPartida">ID da partida</param>
        /// <returns>Retorna informações sobre jogadores</returns>
        public string ListarJogadores(string idPartida)
        {
            if (_idPartida == 0 || idPartida.Equals(""))
            {
                Erros.MensagemErro("idpartida");
                return "Erro ao listar jogadores";
            }
            _idPartida = Convert.ToInt32(idPartida);
            return Jogo.ListarJogadores(_idPartida);
        }

        /// <summary>
        /// Método responsável por mover o pirata para trás, caso tenha até 2 piratas na posição
        ///  mais próxima e a posição não seja a inicial.
        /// Apenas a Classe pode fazer uso.
        /// </summary>
        /// <param name="idJogador">ID da partida</param>
        /// <param name="senhaJogador">ID da partida</param>
        /// <param name="posicao">ID da partida</param>
        /// <returns>Retorna informações sobre jogadores</returns>
        public string MoverPirata(string idJogador, string senhaJogador, string posicao)
        {
            if (idJogador == string.Empty)
            {
                Erros.MensagemErro("idjogador");
                return "";
            }

            else if (senhaJogador == string.Empty)
            {
                Erros.MensagemErro("senhajogador");
                return "";
            }
            else if (posicao == string.Empty)
            {
                Erros.MensagemErro("posicaoinvalida");
                return "Posição invalida";
            }

            _idJogador = Convert.ToInt32(idJogador);
            _senhaJogador = senhaJogador;
            _posicao = Convert.ToInt32(posicao);
            _movimento = Jogo.Jogar(_idJogador, _senhaJogador, _posicao);

            if (_movimento == "ERRO:Jogador não tem piratas na posição informada\r\n")
            {
                Erros.MensagemErro("posicaoinvalida");
                return "Posição invalida";
            }
            else if (_movimento == "ERRO:Senha incorreta")
            {
                Erros.MensagemErro("senhaincorreta");
                return "Por favor, digite a senha correta.";
            }
            return _movimento;
        }

        /// <summary>
        /// Move um pirata para a frente.
        /// </summary>
        /// <param name="carta">Qual o tipo de objeto vai utilizar o jogador.</param>
        /// <param name="posicao">Posição numerica do mapa.</param>
        /// <returns>Retorna a posição jogada.</returns>
        public string MoverPirata(string carta, string posicao)
        {
            if (posicao == string.Empty)
            {
                Erros.MensagemErro("posicaoinvalida");
                return "Erro ao mover pirata.";
            }
            _posicao = Convert.ToInt32(posicao);
            switch (carta)
            {
                case "Esqueleto":
                    return Jogo.Jogar(_idJogador, _senhaJogador, _posicao, "E");
                case "Chave":
                    return Jogo.Jogar(_idJogador, _senhaJogador, _posicao, "C");
                case "Garrafa":
                    return Jogo.Jogar(_idJogador, _senhaJogador, _posicao, "G");
                case "Pistola":
                    return Jogo.Jogar(_idJogador, _senhaJogador, _posicao, "P");
                case "Tricórnio":
                    return Jogo.Jogar(_idJogador, _senhaJogador, _posicao, "T");
                case "Faca":
                    return Jogo.Jogar(_idJogador, _senhaJogador, _posicao, "F");
            }
            Erros.MensagemErro("cartanaoinformada");
            return "Erro ao mover pirara.";
        }

        public string Jooj(string x, int idj, string senha, int p)
        {
            _idJogador = idj;
            _senhaJogador = senha;
            _posicao = p;
            switch (x)
            {
                case "E":
                    return Jogo.Jogar(_idJogador, _senhaJogador, _posicao, "E");
                case "C":
                    return Jogo.Jogar(_idJogador, _senhaJogador, _posicao, "C");
                case "G":
                    return Jogo.Jogar(_idJogador, _senhaJogador, _posicao, "G");
                case "P":
                    return Jogo.Jogar(_idJogador, _senhaJogador, _posicao, "P");
                case "T":
                    return Jogo.Jogar(_idJogador, _senhaJogador, _posicao, "T");
                case "F":
                    return Jogo.Jogar(_idJogador, _senhaJogador, _posicao, "F");
            }
            return "Erro";
        }

        /// <summary>
        /// Exibe o tabuleiro.
        /// </summary>
        /// <returns>Retorna o tabuleiro.</returns>
        public string ExibirTabuleiro(string idPartida)
        {
            if (idPartida.Equals("") || (_idPartida = Convert.ToInt32(idPartida)) == 0)
            {
                Erros.MensagemErro("idpartida");
                return "Erro ao mostrar tabuleiro";
            }

            string quebraTexto = Jogo.ExibirTabuleiro(Convert.ToInt32(idPartida));

            if (quebraTexto == "ERRO:Partida não está em Jogo\r\n")
            {
                Erros.MensagemErro("partidaaberta");
                return "Erro ao mostrar tabuleiro";
            }
            else if (quebraTexto == "ERRO:Partida Inexistente\r\n")
            {
                Erros.MensagemErro("partidainexistente");
                return "Erro ao mostrar tabuleiro";
            }

            string[] words = new string[36];
            words = quebraTexto.Split(',');
            return Jogo.ExibirTabuleiro(_idPartida);
        }

        /// <summary>
        /// Pula a jogada.
        /// </summary>
        /// <returns>Retorna a jogada.</returns>
        public string PularJogada(string idJogador, string senhaJogador)
        {
            if (idJogador == string.Empty)
            {
                Erros.MensagemErro("idjogador");
                return "Erro ao pular jogada.";
            }
            else if (senhaJogador == string.Empty)
            {
                Erros.MensagemErro("senhajogador");
                return "Erro ao pular jogada.";
            }
            _idJogador = Convert.ToInt32(idJogador);
            _senhaJogador = senhaJogador;
            _movimento = Jogo.Jogar(_idJogador, _senhaJogador);

            if (_movimento == "ERRO:Não é a vez deste jogador")
            {
                Erros.MensagemErro("vezinvalida");
                return "Só é possível jogar quando for sua vez!";
            }
            else if (_movimento == "ERRO:Senha do jogador inválida")
            {
                Erros.MensagemErro("senhaincorreta");
                return "Por favor, digite a senha correta.";
            }
            return _movimento;
        }

        /// <summary>
        /// Verifica a vez do jogador.
        /// </summary>
        /// <returns>Retorna a vez do jogador.</returns>
        public string VerificarVez(string idPartida)
        {
            if (_idPartida == 0 || idPartida.Equals(""))
            {
                Erros.MensagemErro("idpartida");
                return "Erro ao verificar vez";
            }
            _idPartida = Convert.ToInt32(idPartida);
            return Jogo.VerificarVez(_idPartida);
        }

        /// <summary>
        /// Exibe o historico de jogadas.
        /// </summary>
        /// <returns>Retorna o historico de jogadas.</returns>
        public string ExibeHistorico(string idPartida)
        {
            if (idPartida.Equals("") || (_idPartida = Convert.ToInt32(idPartida)) == 0 || idPartida.Equals("Erro"))
            {
                Erros.MensagemErro("idpartida");
                return "Erro exibir histórico";
            }
            //string historico =  (_idPartida);
            //if (historico == "ERRO:Partida não está em andamento")
            //{
            //    Erros.MensagemErro("partidaaberta");
            //    return "Erro ao exibir histórico";
            //}

            return Jogo.ExibirHistorico(_idPartida);
        }
        /// <summary>
        /// Retorna o status da partida do jogo para que o jogo posso continuar rodando ou não
        /// </summary>
        /// <param name="idPartida">ID da partida em questao</param>
        /// <returns>Verdadeiro para jogo em andamento, falso para qualquer outra coisa.</returns>
        public bool statusJogo(string idPartida)
        {
            Queue<string> fila = new Queue<string>(this.ListarPartidas("T").Replace("\r\n", ",").Split(','));
            for (; fila.First() != idPartida && fila.Count != 0; fila.Dequeue()) { }
            if (fila.Count == 1) return false;
            for (int i = 0; i < 3; i++)
                fila.Dequeue();
            return fila.First() == "J";
        }
        public bool statusJogador(string idpartida,string idJogador)
        {
            Queue<string> fila = new Queue<string>(this.VerificarVez(idpartida).Replace("\r\n", ",").Split(','));
            fila.Dequeue();
            if (idJogador == null) {
                Erros.MensagemErro("idjogador");
                return false; }
            return fila.Dequeue()==idJogador;
        }
        public bool PrimeiraVezJogador(string idP, string idJ)
        {
            Stack<string> Pilha = new Stack<string>(this.ExibeHistorico(idP).Replace("\r\n", ",").Split(','));
            for (; Pilha.Count != 0 && Pilha.First() != idJ; Pilha.Pop()) ;
            return Pilha.Count == 0;
        }

       
    }
}