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
    public static class Erros
    {
        
        public static void MensagemErro(string tipoErro)
        {
            tipoErro.ToLower();
            tipoErro.Trim();
            switch (tipoErro)
            {
                case "nomepartida":
                    MessageBox.Show("Você não informou o nome da partida.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "senhapartida":
                    MessageBox.Show("Você não informou a senha da partida.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "idpartida":
                    MessageBox.Show("Você não informou corretamente o ID da partida.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "nomejogador":
                    MessageBox.Show("Você não informou o nome do jogador.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "senhajogador":
                    MessageBox.Show("Você não informou a senha do jogador.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "idjogador":
                    MessageBox.Show("Você não informou corretamente o ID do jogador.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "limite20caracteres":
                    MessageBox.Show("Você ultrapassou o limite de 20 caracteres.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "limite50caracteres":
                    MessageBox.Show("Você ultrapassou o limite de 50 caracteres.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "nomeexistente":
                    MessageBox.Show("Já existe uma partida com este nome.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "limitejogadores":
                    MessageBox.Show("Quantidade máxima de jogadores atingida.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "partidainexistente":
                    MessageBox.Show("Não existe partida com ID informado.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "posicaoinvalida":
                    MessageBox.Show("A posição fornecida é inválida", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "cartanaoinformada":
                    MessageBox.Show("Escolha uma carta antes de mover um pirata.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "jogadorjaexiste":
                    MessageBox.Show("Já existe um jogador com este nome na partida.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "senhaincorreta":
                    MessageBox.Show("A senha fornecida está incorreta.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "partidainiciada":
                    MessageBox.Show("A partida já foi iniciada.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "partidaaberta":
                    MessageBox.Show("A partida não foi iniciada.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "partidaencerrada":
                    MessageBox.Show("A partida foi encerrada.", "Erro",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "vezinvalida":
                    MessageBox.Show("Agora é a vez de outro jogador.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            MessageBox.Show("Ops! Você esqueceu de fornecer os dados corretos. Por favor, " +
                "corrija-os e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void MensagemSucesso(string tipoSucesso)
        {
            tipoSucesso.ToLower();
            tipoSucesso.Trim();
            switch (tipoSucesso)
            {
                case "partidacriada":
                    MessageBox.Show("Partida criada!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                case "jogadorcriado":
                    MessageBox.Show("Seu jogador foi criado!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                case "partidainiciada":
                    MessageBox.Show("Partida começou!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
            }
            MessageBox.Show("Tudo OK!",
               "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
