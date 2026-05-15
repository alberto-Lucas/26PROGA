using System;
using System.IO;
using System.Windows.Forms;

namespace AppCadastro
{
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        //Criar métodos para padronizar a exibição de mensagens
        void MsgAtencao(string Msg)
        {
            //Montar um MessageBox com Icone Amarelo de Warning
            MessageBox.Show(Msg, "Atenção", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //Ex: de Uso
            //MsgAtencao("Texto a ser exibido");
        }

        void MsgInfo(string Msg)
        {
            //Montar um MessageBox com Icone Azul de Information
            MessageBox.Show(Msg, "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Ex: de Uso
            //MsgAtencao("Texto a ser exibido");
        }

        //Função de Manipulação de Arquivo .txt
        //Função para validar a existencia do arquivo
        bool ArquivoExiste(string caminho)
        {
            //Validar se o arquivo ja existe
            //No caso usaremos o CPF como nome do arquivo
            //pode ser um identificado unico para cada cadastro
            //Desta forma se o arquivo ja existir, quer dizer
            //que ja possui um cadastro para este CPF
            //Utilizar o componente File e o Método Exists
            //Se File apresentar erro
            //basta importar a biblioteca no começo do arquivo
            //using System.IO;
            return File.Exists(caminho);
        }

        //Método de Gravar o Arquivo
        void GravarArquivo(string Caminho, string Conteudo)
        {
            //Iremos para a rotina de gravação do arquivo
            //Caso for o primeiro arquivo a ser cadasrado
            //o diretorio não existira
            //Esta diretorio será um pasta para o tipo de cadastro
            //que será criada no mesmo local onde o programa
            //está sendo executado

            //OBS: Nao utiizaremos o Try Catch neste momento
            //Pois estara no método principal

            //Validar a existencia do diferetorio
            //se não existir eu crio
            //Recuperar o diretorio do parametro usando 
            //GetDirectoryName
            string pasta = Path.GetDirectoryName(Caminho);
            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            //Gravar o conteudo
            File.WriteAllText(Caminho, Conteudo);
        }

        //Função que retorna o caminho do arquivo completo
        string GetDirArquivo(string TipoCadastro, string NomeArquivo)
        {
            //O caminho será montado:
            //Diretorio Raiz do executavel
            //Tipo do Cadastro: Cliente
            //Nome Arquivo: CPF
            //Ex: C:/Programas/AppCadastros/Cliente/00000000000.txt

            //Diretorio Raiz
            //AppDomain = O Executavel em si
            //CurrentDomain = O processo em execução (gerenciador de tarefas)
            //BaseDirectory = local da onde o .exe está sendo executado
            string raiz = AppDomain.CurrentDomain.BaseDirectory;

            //Montar o diretorio
            return Path.Combine(
                raiz, TipoCadastro, NomeArquivo + ".txt");

            //OBS: A extensão é opicional como tambem o uso 
            //de arquivo de texto, pois o sistema ira ler o arquivo 
            //bruto, a extensão não tem impacto
            //mudar ou não usar extensão dificulta o uso de 
            //engenharia reversa para roubo de dados
        }

        //Funação de montagem do conteudo do arquivo
        string GetCadastro()
        {
            //Iremos concatenar a informação da tela
            //em uma unica string
            //ja no formato de cadastro
            //assim salvando tudo no arquivo
            //Cada linha do arquivo será um campo

            string cadastro =
                "CPF=" + txtCPF.Text +
                Environment.NewLine + //Quebra de Linha
                "NOME=" + txtNome.Text +
                Environment.NewLine +
                "DTNASC=" + dtpDtNascimento.Value +
                Environment.NewLine +
                "RG=" + txtRG.Text;

            return cadastro;
        }

        //Método Principal
        //Salvar o cadastro, reuni todos os demais método e funções
        void Salvar()
        {
            //Primeiro precisamos montar/recuperar
            //o diretorio do arquivo

            string diretorio = GetDirArquivo("Cliente", txtCPF.Text);

            //Validar a existencia do arquivo
            //se ja existir quer dizer que possui um cadasrto
            try
            {
                //Validacao
                if(ArquivoExiste(diretorio))
                {
                    MsgAtencao("Já existe um cadastro com este CPF.");
                    return; //abortar
                }
            }
            catch (Exception ex)
            {
                MsgAtencao("Falha ao validar o arquivo." + Environment.NewLine +
                     "Erro oringinal: " + ex.Message);
                return; //Abortar a rotina
            }

            //Parte de gravação do arquivo
            try
            {
                //Gravar o cadastro
                GravarArquivo(diretorio, GetCadastro());

                //Notificar o usuario
                MsgInfo("Cadastro realizado com sucesso!");

                //Apenas para caracter de TESTE
                //iremos exibir uma mensagem informando onde o arquivo 
                //foi salvo
                //Esta mensagem não deve ir na versão final do sistema
                MsgInfo("Salvo em:" + diretorio);
            }
            catch(Exception ex)
            {
                MsgAtencao("Falha ao salvar o cadastro." + Environment.NewLine +
                    "Erro original: " + ex.Message);
                //Não precisa do return para abortar por ser o final da rotina
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();

            //Limpar os campos
            txtCPF.Clear();
            txtNome.Clear();
            txtRG.Clear();

            //Unico diferente é o campo de data
            //pois iremos resetar a data, usando a data atual
            //DateTime componente de Data e Hora
            //Now retorna a data e hora atual do computador
            dtpDtNascimento.Value = DateTime.Now;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Validação se realmente deseja cancelar
            bool resultado =
                MessageBox.Show("Deseja realmente cancelar?", 
                                "Confirmação",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question)
                                //Validando se foi clicado no botão sim
                                == DialogResult.Yes;
            if (resultado)
                this.Close(); //fechamos a tela

            //Se clicar em não, não realizamos nenhuma ação
        }
    }
}
