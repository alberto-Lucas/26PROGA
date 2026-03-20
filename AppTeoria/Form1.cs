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

        private void btnMetodo_Click(object sender, EventArgs e)
        {
            MetodoSomar();
        }

        //Método somar dois valores
        //Não possui retorno, portanto 
        //é do tipo VOID
        void MetodoSomar()
        {
            //Este método, irá recuperar
            //os valores informados pelo usuario
            //converter os valores para int
            //Somar os dois valores
            //Exibir o resultado para o usuário

            //Criar as variaveis nescessarias
            int v1, v2, resultado;

            //Iremos recuperar os valores do textBox
            //Converter para int e atribuir a variavel

            //Para converter um valor numerico
            //é preciso informar o tipo de dados
            //desejado e chamar a função Parse(Converter)
            //e passar o valor a ser convertido em formato
            //string
            //Ou seja o parse converte apenas
            //string em numero
            //EX: int.Parse('1');
            //o resultado da conversão é o numero int 1

            v1 = int.Parse(txtValor1.Text);
            v2 = int.Parse(txtValor2.Text);

            //Agora iremos realizar a soma das variaveis
            //v1 e v2 e armazenar o resultado na operação
            //na variavel resultado

            resultado = v1 + v2;

            //Iremos exibir o conteudo de resultado
            //no textBox, para isso preciso converter 
            //resultado int em string
            //utilizando á função ToString();

            txtResultadoMF.Text = resultado.ToString();
        }

        private void btnFuncao_Click(object sender, EventArgs e)
        {
            //Alternativa 1
            //Como estamos usando função
            //é preciso preparar o terreno
            //antes da chamada da função

            //Seguindo o principio do metodoSomar
            //vamos criar as variaveis
            int v1, v2, resultado;

            //Atribuir o valor informado
            //as variaveis
            //v1 = int.Parse(txtValor1.Text)
            v1 = StringParaInt(txtValor1.Text);
            v2 = StringParaInt(txtValor2.Text);

            //Iremos chamar a funcaoSomar
            //e atribuir o resultado a variavel

            resultado = FuncaoSomar(v1, v2);

            //agora exibir o resultado

            txtResultadoMF.Text = resultado.ToString();

        }

        //Iremos criar um função
        //que ira apenas somar 2 valores
        //e retornar o resultado da soma

        int FuncaoSomar(int v1, int v2)
        {
            //A função irá executar um
            //bloco de código e retornar
            //um valor do mesmo tipo da função
            //ou seja um função int
            //só retorna um unico valor int

            return v1 + v2;
        }

        //Criar um função para converter
        //string em int
        int StringParaInt(string valor)
        {
            //Convertendo diretamente
            //Pode ocosarionar erros
            //caso o valor informado não seja 
            //um numero
            //Exemplo conversão direta
            //return int.Parse(valor);

            //Nessesario realizar a validação
            //e definir um numero padrão
            //caso não seja possivel a versão

            //Para isso iremos trocar o Parse
            //pelo TryParse, onde ele ira
            //retornar se a conversão foi possivel 
            //ou não, caso possivel
            //ja retorna o valor convertido

            //Usaremos um if ternario para definir
            //um valor padrão
            //usaremos o valor padrão zero (0)

            //Iremos tentar converter
            //TryParse retorna um bool
            //Se possivel retorna true e na variavel out
            //retorna o resultado da conversao
            //se não apenas retorna false
            return
                int.TryParse(valor, out int resultado) ?
                resultado : //Se True
                0; //Se False

            //if ternario
            // dividido em 3 partes
            //condicao
            //resultado true
            //resultado false
            //? significa if
            //: significa else
            //ou seja
            //idade >= 18 ? "Pode beber" : "Não pode beber"
            //mesma coisa que
            //if(idade >= 18)
            //  "Pode beber"
            //else
            //  "Não pode beber"
        }

        private void btnFuncaoAlt_Click(object sender, EventArgs e)
        {
            //Alternativa 2
            //Realizar chamdas de função direto
            //nos parametros
            //iremos realizar o mesmo processo
            //do btnFuncao, porém apenas em uma linha

            txtResultadoMF.Text =
                FuncaoSomar(
                    StringParaInt(txtValor1.Text),
                    StringParaInt(txtValor2.Text)).ToString();
        }
    }
}
