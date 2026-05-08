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
    }
}
