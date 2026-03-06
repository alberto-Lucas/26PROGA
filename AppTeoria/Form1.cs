using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTeoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIF_Click(object sender, EventArgs e)
        {
            //Aplicar a teoria do IF
            //Ou seja, iremos realizar uma cascata
            //de validações

            //O objeto é identificar a opção selecionada
            //e apresentar ao usuario

            //Criar uma variavel para armazenar o texto
            string opcao;

            //Utilizar o if quando podemos
            //ter condições diferentes
            //Vou validar se a opção selecionada
            //condiz com a opção defenida
            if (cbbOpcoes.Text == "APARTAMENTO")
                opcao = "Opção Apartamento";
            else if (cbbOpcoes.Text == "SUITE")
                opcao = "Opção Suite";
            else if (cbbOpcoes.Text == "MASTER")
                opcao = "Opção Master";
            else if (cbbOpcoes.Text == "DIAMANTE")
                opcao = "Opção Diamente";
            else if (cbbOpcoes.Text == "EXECUTIVA")
                opcao = "Opção Executiva";
            else
                opcao = "Opção Desconhecida";

            //Apresentar a mensagem ao usuário
            MessageBox.Show(opcao);
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            //A utilização do switch se da qunado temos
            //uma variação de um tipo de dados

            //OU seja no IF, temos variação de validações
            //podendo ter outros dados no meio
            //ja no switch, tem apenas a variação de um 
            //tipo de dado
            //neste caso nosso tipo de dados
            //são quartos de Motel

            //criar a variavel opcao

            string opcao;

            //aplicar o switch
            switch(cbbOpcoes.SelectedIndex)
            {
                case 0: opcao = "Opção 1";
                    break; //Obrigado utilizar o break
                case 1: opcao = "Opção 2";
                    break;
                case 2: opcao = "Opção 3";
                    break; //Obrigado utilizar o break
                case 3: opcao = "Opção 4";
                    break;
                case 4: opcao = "Opção 5";
                    break;
                default: opcao = "Opção Diamante";
                    break;
            }

            MessageBox.Show(opcao);
        }

        private void btnExemplo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção: " + cbbOpcoes.Text);
        }
    }
}
