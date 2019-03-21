using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartagenaServer;
//@Higor
namespace Cartagena_PI
{
    class Lobby
    {
        CartagenaServer.Jogo Jogo;
        private string _PartidaNome;
        private string _PartidaSenha;
        private int _PartidaID;
        private string _Partida;
        private string[] _Jogadores;

        public string Partida 
        {
            get
            {
                return _Partida;
            }
        }

        public Lobby()
        {
            Jogo = new Jogo();
            if (Jogo.ListarPartidas("A") == null)
            {
                _PartidaNome = "King K. Rool";
                _PartidaSenha = "HJL2100";
                _Partida = Jogo.CriarPartida(_PartidaNome,_PartidaSenha);
                string[] QuebraTexto = _Partida.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                _PartidaID = Convert.ToInt32(QuebraTexto.Length);
                System.Windows.Forms.MessageBox.Show(_PartidaID.ToString());
            }
            else
            {
                _Partida = Jogo.ListarPartidas("A");
                _PartidaNome = "Rock";
                _PartidaSenha = "123456";
                _PartidaID = 15;
                //_ItensPartida = new char[4];
                //string[] QuebraTexto = _Partida.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                //for (int i = 0; i < 4; i++) _ItensPartida[i] = Convert.ToChar(QuebraTexto.Length);
                System.Windows.Forms.MessageBox.Show(_PartidaID.ToString());

            }
        }

        public void CriarJogadores()
        {
            _Jogadores = new string[6];
            _Jogadores[0] = Jogo.EntrarPartida(_PartidaID, _PartidaNome, _PartidaSenha);
            System.Windows.Forms.MessageBox.Show(_Jogadores[0].ToString());
        }

        public string ListarPartidas(string filtro)
        {
            switch(filtro)
            {
                case "Todas":
                    return Jogo.ListarPartidas("T");
                case "Aberta":
                    return Jogo.ListarPartidas("A");
                case "Jogando":
                    return Jogo.ListarPartidas("J");
                case "Encerrada":
                    return Jogo.ListarPartidas("E");
            }
        }       
    }
}
