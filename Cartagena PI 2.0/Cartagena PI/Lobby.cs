using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartagenaServer;
namespace Cartagena_PI
{
    class Lobby
    {
        private static string _IDJogador; //Armazena ID do jogador. Apenas a Classe pode fazer uso
        private static string _senhaJogador; //Armazena senha do jogador. Apenas a Classe pode fazer uso
        private static string _corJogador; //Armazena cor do jogador. Apenas a Classe pode fazer uso
        private static string _nomeJogador; //Armazena nome do jogador. Apenas a Classe pode fazer uso

        private static string _partidaSenha; //Armazena senha da partida. Apenas a Classe pode fazer uso
        private static int _partidaID; //Armazena ID da partida. Apenas a Classe pode fazer uso

        //Propriedade responsável por retornar ID do jogador. Apenas a Classe pode fazer uso
        public static string IDJogador
        {
            get
            {
                return _IDJogador;
            }
        }

        //Propriedade responsável por retornar senha do jogador. Apenas a Classe pode fazer uso
        public static string SenhaJogador
        {
            get
            {
                return _senhaJogador;
            }
        }

        //Propriedade responsável por retornar cor do jogador. Apenas a Classe pode fazer uso
        public static string CorJogador
        {
            get
            {
                return _corJogador;
            }
        }

        //Método responsável por listar partidas através de um filtro. Apenas a Classe pode fazer uso
        public static string ListarPartidas(string filtro)
        {
            switch (filtro)
            {
                case "Todas":
                    return Jogo.ListarPartidas("T");
                case "Encerrada":
                    return Jogo.ListarPartidas("E");
                case "Jogando":
                    return Jogo.ListarPartidas("J");

            }
            return Jogo.ListarPartidas("A");
        }

        /*Método responsável por entrar em uma partida através do ID e senha da
        partida e nome do jogador. Apenas a Classe pode fazer uso*/
        public static void EntrarPartida(int idPartida, string nomeJogador, string senhaPartida)
        {
            _partidaID = idPartida;
            _nomeJogador = nomeJogador;
            _partidaSenha = senhaPartida;

            string quebraTexto = Jogo.EntrarPartida(_partidaID, _nomeJogador, _partidaSenha);
            string[] words = new string[3];
            words = quebraTexto.Split(',');

            _IDJogador = words[0];
            _senhaJogador = words[1];
            _corJogador = words[2];
        }

        //Método responsável por criar partidas através de nome e senha. Apenas a Classe pode fazer uso
        public static int CriarPartida(string nomePartida, string senhaPartida)
        {
            int ID = Convert.ToInt32(Jogo.CriarPartida(nomePartida, senhaPartida));
            return ID;
        }

        //Método responsável por iniciar uma partidas. Apenas a Classe pode fazer uso
        public static string IniciarPartida()
        {
            return Jogo.IniciarPartida(Convert.ToInt32(_IDJogador), _senhaJogador);
        }
    }
}