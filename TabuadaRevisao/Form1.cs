using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabuadaRevisao
{
    public partial class Form1 : Form
    {
        //Aceitar somente números inteiros
        //Validar se o número são maiores que 0 e menores que 100
        //Exibir mensagem alertando o usuário
        //Validar se o segundo número é maior que o primeiro
        //Exibir mensagem alertando
        //Utilizar o comando for para exibir o resultado
        public Form1()
        {
            InitializeComponent();
        }

        //Primeiro irei preparar todos os métodos e funções

        //Função que retorna se uma string é somente num inteiros
        //Ela ira retornar um verdadeiro ou falso
        //se possuir somente num inteiro é verdadeiro
        //se possuir qualquer caracter diferente é falso
        bool IsNumeroInteiro(string valor)
        {
            //Preciso validar se o parametro não está valizio

            //Iremo utilizar o estilo de programação
            //FirstValidation
            //Onde primeiro validamos o conteudo
            //e se tudo correto executamos a rotina
            //se tiver algo errado abortamos a execução
            //e retornamos falso

            //O uso de chaves {} não se faz nescessario
            //quando a execuação for de apenas uma unica linha
            //pois o demilitador (;) servira
            //como encerramento da execução
            if (valor == "")
                return false; //aborta a execução

            //Se chegou até aqui o parametro não está vazio
            //e posso valida-lo

            //Criar um lopp que passara por cada caracter
            //validar se é um numero inteiro
            //no primeiro caracter diferente ja irei abortar 
            //a execução e retornar falso não terminando o loop
            //pois basta um caracter errado para condenar toda
            //a string

            //Validar se o caracter atual 
            //é um num inteiro
            //Só para se for falso
            //portant vou utilizar negação

            for (int i = 0; i < valor.Length; i++)                
                if (!char.IsDigit(valor[i]))
                    return false;

            //Se chegou até aqui a string possui apenas
            //num inteiros e posso retornar true
            return true;
        }

        //Função para validar o intervalor
        bool IsIntervaloValido(int valor)
        {
            //Retorna diretamente o resultado da condição
            //verificar se o valor esta no intervalo valido
            return (valor > 0 && valor < 100);
        }

        //Método para padronizar a mensagem de retorno
        //Message.Show();
        void MsgAlerta(string mensagem)
        {
            MessageBox.Show(
                mensagem, //conteudo
                "Atenção", //titulo
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning); //icone amarelo
        }

        //Função para retornar se o campos estão validos
        //Irei validor o valor inicial e final
        bool IsCamposValidos(string vInicial, string vFinal)
        {
            //Iremos centralizar todas as validações

            //Usaremos negação (!) pois só exibiremos 
            //a mensagem caso cada retorno for falso

            //Utilizando validação separada
            //para informar ao usuário exatamente
            //qual o campo problematico
            if(!IsNumeroInteiro(vInicial))
            {
                MsgAlerta("Informe um número Inicial válido");
                return false;
            }

            if(!IsNumeroInteiro(vFinal))
            {
                MsgAlerta("Informe um número Final válido");
                return false;
            }

            //Após as validações de numeros inteiros
            //posso converte os valores de string para int
            //sem medo

            int inicial = int.Parse(vInicial);
            int final = int.Parse(vFinal);

            //Validar se os valores estão no intervalo correto
            if(!IsIntervaloValido(inicial))
            {
                MsgAlerta("Informe um número Inicial " +
                    "maior que zero (0) e menor que cem (100).");
                return false;
            }

            if (!IsIntervaloValido(final))
            {
                MsgAlerta("Informe um número Final " +
                    "maior que zero (0) e menor que cem (100).");
                return false;
            }

            //Validar se num final é maior que q o num inicial
            if(final <= inicial)
            {
                MsgAlerta("O númeero Final deve " +
                    "ser maior que o número Inicial.");
                return false;
            }

            //Se chegou até aqui, é pq os valores informados
            //são válidos e posso retornar verdadeiro
            return true;
        }
        
        //Método que irá calcular a tabuada
        void CalcularTabuada(int vInicial, int vFinal)
        {
            //Primeiro limpamos a ListBox
            lstResultado.Items.Clear();

            //Criar um loop principal para cada valor do intervalo
            //Ou seja um intervalo entre 2 e 4
            //Teremos que passar pela tabua completa do 2, 3 e 4
            //Completa = valor x 1 até valor x 10
            for(int i = vInicial; i <= vFinal; i++)
            {
                //A cada passado do intervalo iremos
                //calcular a tabuada do 1 ao 10
                //Criar um loop para os valores da tabuada
                //1 ao 10
                for(int j = 1; j <= 10; j++)
                {
                    //Criar uma variavel que ira armazenar
                    //a concatenação dos valores e resultado
                    //Ex: 2 x 1 = 2
                    //Um recurso legal do Método ToString é que podemos
                    //adicionar um formatação do texto
                    //neste caso estamso adiciona ndo zero a esquerda
                    //para manter o valor no padrão de pelo menos 2 digitos
                    //Ex: 5 -> 05
                    //EX: 100 -> 100
                    //Para isto para adicionar dentro dos parenteces () a
                    //a formatação desejada
                    //EX: valor.ToString("00");
                    string resultado =
                        i.ToString("00") + " x " + j.ToString("00") +
                            " = " + (i * j).ToString("00");

                    //A cada calculo da tabuada iremos adicionar o resultado
                    //dentro da listBox
                    //Neste caso podemos passar a variavel de concatenação direto 
                    lstResultado.Items.Add(resultado);
                }//Fim do Loop J

                //A cada intervalo será adiciona uma linha
                //para separação dos intervalos
                lstResultado.Items.Add("-------------");
            }//Fim do Loop I
        }
    }
}
