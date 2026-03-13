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

        private void btnForIncremento_Click(object sender, EventArgs e)
        {
            //Laço de repetição FOR
            //Executa um loop de um valor que sabemos
            //a quantidade a ser executada

            //Executar 11 vezes
            for (int i = 0; i <= 10; i++)
                //Cada execução, irei adicionar
                //o valor de i, na listBox
                //para isso iremos converter o inteiro em texto
                lstLoop.Items.Add(i.ToString());
        }

        private void btnForDecremento_Click(object sender, EventArgs e)
        {
            //Teremos o mesmo principio do FOR
            //Mas utilizando decremento

            for(int i = 10; i >= 0; i--)
                lstLoop.Items.Add(i.ToString());
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            //Laço de repetição While
            //Utilizado quando não sabemos a quantidade de
            //repetições.
            //Primeiro ocorre a validação para depois executar
            //Ou seja se a primeira condição for satisfeita
            //não executa nenhum vez

            //Simular uma interação com o usuário
            //Iremos sortear um número randomico
            //para usar na validação do do-while

            //Chamar o método Randomico
            //criado uma varaivel sorteador
            Random sorteador = new Random();

            //Usando o método next para sortear o numero
            //Iremos sortear um numero entre 1 e 10
            int numeroSorteado = sorteador.Next(1, 10);

            while(numeroSorteado != 8)
            {
                lstLoop.Items.Add(numeroSorteado.ToString());
                numeroSorteado = sorteador.Next(1, 10);
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            //Iremos aplicar o mesmo principio de sorteio do While

            Random sorteador = new Random();

            //Criamos e iniciamos a variavel numeroSorteado;
            int numeroSorteado = 0;

            do
            {
                //Sorteamos um numero
                numeroSorteado = sorteador.Next(7, 9);
                //Adicionamos o numero a ListBox
                lstLoop.Items.Add(numeroSorteado.ToString());
            }
            //Valimos se o numéro sorteado é diferente de 8
            while (numeroSorteado != 8);
        }

        private void btnSoNumero_Click(object sender, EventArgs e)
        {
            //Iremos utilizar laço de repetição
            //para extrair somente os número de um conjunto
            //de caracteres

            //Para isso iremos validar caracter por caracter
            //e salvar apenas os números

            //Criar a variavel valor
            //e vamos preenche-la com o valor digitado
            //no textBox
            string valor = txtValor.Text;

            //Cria a variavel resultado
            //para preencher com o resultado da extração
            string resultado = "";

            //Criar o laço para percorrer cada caracter
            //Método Length retorna o tamanho de uma string 
            for (int i = 0; i < valor.Length; i++)
            {
                //Iremos verificar se o caracter atual
                //é um digito numerico
                //char é o tipo de dados
                //IsDigit é o método do tipo char
                //que retorna um verdadeiro ou falso
                //se o caracter é um digito numerico
                //preciso pegar a posição do caracter
                //na variavel valor de acordo com a posição
                //do i
                if (char.IsDigit(valor[i]))
                    //vou incrementar os numeros validos
                    //na variavel resultado
                    //valor[i] é o caracter atual
                    resultado += valor[i];
            }

            //Por ultimo iremos atribuir a variavel resultado
            //ao textBox Resultado
            txtResultado.Text = resultado;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Iremos limpar os itens da ListBox
            lstLoop.Items.Clear();
            //Lendo de tras pra frente
            //Limpar Itens ListBox
            //Ou seja
            //Limpas os itens da listBox
        }
    }
}
