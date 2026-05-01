using System.Drawing;
using System.Windows.Forms;

namespace AppCadastro
{
    public partial class frmMovimentacao : Form
    {
        //Para alterar o modo de abertura da tela
        //é preciso receber um parametro durante a chamada

        //Quando receber zero (0) será modo Orçamento
        //Quando receber um (1) será modo Venda
        //Para basta adicionar um parametro no construtor da tela
        //Método abaixo que possui o mesmo nome da tela
        //Ex: public frmMovimentacao()

        //Tambem é preciso criar uma variavel global
        //para salvar o método que a tela foi aberta
        //para determinar o curso das rotinas

        //Variaveis globais criamos fora dos métodos e funções
        //Ou seja aqui abaixo
        //Por padrão abrirá no modo orçamento
        int modoTela = 0;

        //Este é o construtor
        public frmMovimentacao(int ParametroModoTela)
        {
            InitializeComponent();

            //Salvar o modo da tela
            modoTela = ParametroModoTela;     
            
            if(ParametroModoTela == 0)
            {
                lblModoTela.Text = "ORÇAMENTO";
                pnlModoTela.BackColor = Color.Blue;
            }
            else if (ParametroModoTela == 1)
            {
                lblModoTela.Text = "VENDA";
                pnlModoTela.BackColor = Color.Red;
            }

            //Mudar o titulo da tela
            //this se refere a propria tela
            this.Text = lblModoTela.Text;
        }
    }
}
