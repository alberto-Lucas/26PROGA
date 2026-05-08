using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCadastro
{
    public partial class frmManipulaArquivo : Form
    {
        public frmManipulaArquivo()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            //Utilizar o coponente FolderBrowserDialog
            //Responsavel por chamar a tela de seleção de pastas
            //padrão do windows
            //O usuário terá a possibilidade de selecionar a pasta desejada
            //e iremos recuperar o diretorio completa desta pasta
            //precisamos validar se uma pasta foi selecionada ou não 
            //utilizaremos o DialogResult, para identificar
            //se o usuario clicou em ok (selecionou a pasta) ou 
            //clicou em cancelar
            //retorno irá armazenar o botão clicado
            DialogResult retorno =
                folderBrowserDialog1.ShowDialog();

            //Após coleto o retorno, iremos validar os botões
            //e se botão OK, iremos recuperar o diretorio
            //folderBrowserDialog1.SelectedPath retorna o direotio
            if (retorno == DialogResult.OK &&
                !string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
            {
                //se tudo ok, preencho campo diretorio 
                txtDiretorio.Text = 
                    folderBrowserDialog1.SelectedPath;
            }            
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            //Validar se os dados estão preenchidos
            //Ou seja, o diretorio e o nome do arquivo
            if(string.IsNullOrEmpty(txtDiretorio.Text) ||
                string.IsNullOrEmpty(txtNomeArquivo.Text))
            {
                //Se um dos dois estiver em branco, notifico o usuario
                MessageBox.Show("Preencha os campos corretamente.");
                return; //abortar a execução
            }

            //Nescessario validar se o arquivo ja existe antes de cria-lo
            //pois se ja existir o mesmo será subistituido
            //Para validar o exsitencia do arquivo usaremos o recurso File
            //neste ponto é nescessario utilizar o try ctach
            //pois caso o usuario do windows não possua perissão
            //ira gerar erro ao tentar validar o arquivo
            //ou seja tentamos acessar, se não conseguir, notifica o usuario
            try
            {
                //gerar o caminho completo diretorio + nome arquivo + extensão
                // ao utilizar barra invertida \ no diretorio
                //é preciso adicionar 2 barras, o C# irá entender como apenas uma
                //isso é preciso pois a barra sozinha possui outr função

                //Forma manual de concatenação de diretorio
                //string dirCompleto = 
                //    txtDiretorio.Text + "\\" + txtNomeArquivo + ".txt";

                //Forma de concatenação de diretorio por componente
                //irá adicionar as barras automaticamente
                //Path compoenente para diretorios
                //Combine método de concatenação
                //o mais utilizado
                string dirCompleto =
                    Path.Combine(txtDiretorio.Text, txtNomeArquivo.Text + ".txt");

                //Validar a existencia do arquivo
                //File componenete de manipulação dearquivo
                //Exists método que retorna a existencia do arquivo
                if(File.Exists(dirCompleto))
                {
                    //Se ja existir irei notificar o usuário
                    //e neste caso aborto a rotina
                    //impedindo do usuário subistituir o arquivo
                    MessageBox.Show("O arquivo já existe.");
                    return; //abortar a rotina
                }

                //Se chegou até aqui, podemos criar o arquivo
                //iremos criar um arquivo de texto (.txt) vazio
                //WriteAllText método para escrever o arquivo
                File.WriteAllText(dirCompleto, "");
                //Notifica o usuario
                MessageBox.Show("Arquivo criado com sucesso!");
            }
            catch (Exception ex)
            {
                //Notificar o usuario do erro
                //gerealmente ocorre por probema de permissão de usuário
                MessageBox.Show(
                    "Ocorreu um erro ao criar o arquivo." + 
                    Environment.NewLine + //quebra de linha
                    "Erro original: " + ex.Message); //apresenta o erro cpturado pelo try
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Seguir praticamente o mesmo processo do botão criar
            //Montar o diretorio completo
            //Validar se o arquivo existe
            //Gravar o arquivo
            //Usar o try catch
            //A unica diferença é faremos tudo dentro do try catch
            try
            {
                string dirCompleto =
                    Path.Combine(txtDiretorio.Text, txtNomeArquivo.Text + ".txt");

                //Durante a gravação é preciso que o arquivo 
                //exista, neste caso iremos notificar o usuario
                //se o arquivo não existir
                if (!File.Exists(dirCompleto))
                {
                    MessageBox.Show("Arquivo não encontrado.");
                    return; //aborta a execução
                }

                //Agora podemos realizar a gravação
                //Todo o conteudo do arquivo será subistituido
                File.WriteAllText(dirCompleto, txtTexto.Text);
                MessageBox.Show("Dados gravados com sucesso!.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocorreu um erro ao gravar os dados no arquivo." + 
                    Environment.NewLine +
                    "Erro original: " + ex.Message);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Qual a diferença entre o gravar e o adicionar?
            //o Gravar ele sempre vai subistituir o conteudo atual do arquivo
            //ocorrendo a perca de dados
            //o adicinar irá literalemente adicionar o novo conteudo
            //ao final do arquivo, sem ocorrer perca de dados

            //Seguimos o mesmo padrão de uso do try e sua rotinas
            try
            {
                string dirCompleto =
                    Path.Combine(txtDiretorio.Text, 
                                 txtNomeArquivo.Text + ".txt");

                if(!File.Exists(dirCompleto))
                {
                    MessageBox.Show("Arquivo não encontrado.");
                    return;
                }

                //Agora a principal diferença é
                //Utilizar o AppendAllText no Lugar do WriteAllText
                //OBS: O Appdend irá adicionar o conteudo em sequencia
                //na mesma linha do ultimo dado inserido
                //portanto é nescessario adicionar uma quebra de linha
                //antes da adição do novo conteudo
                File.AppendAllText(
                    dirCompleto, Environment.NewLine + txtTexto.Text);
                
                MessageBox.Show(
                    "Dados adicionados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocorreu um erro ao adicionar os dados no arquivo."+
                    Environment.NewLine + 
                    "Erro original: " + ex.Message);
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            //Rotina para carregar o conteudo do arquivo
            //Seguiremos um padrão parecido com o adicionar e o gravar
            //Apenas trocando a gravação por leitura
            try
            {
                string dirCompleto =
                    Path.Combine(txtDiretorio.Text,
                                 txtNomeArquivo.Text + ".txt");

                if(!File.Exists(dirCompleto))
                {
                    MessageBox.Show("Arquivo não encontrado.");
                    return;
                }

                //Agora sim podemos realizar a leitura
                //ReadAllText método que realiza a leitura
                //de todo conteudo do arquivo
                string conteudo = File.ReadAllText(dirCompleto);
                txtTextoArquivo.Text = conteudo;

                MessageBox.Show("Arquivo carregado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocorreu um erro ao carregar o arquivo." +
                    Environment.NewLine +
                    "Erro original: " + ex.Message);
            }
        }
    }
}
