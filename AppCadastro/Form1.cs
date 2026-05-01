using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void versãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "AppCadastro" + Environment.NewLine + 
                Environment.NewLine +
                "Versão 1.0.0.0" + Environment.NewLine +
                "Desenvolvido por: Lucas Alberto");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro de Cliente");
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            //Quando o mouse sai do componente
            pictureBox2.BackColor = panel1.BackColor;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            //Quando mouse está sobre o componente
            pictureBox2.BackColor = Color.LightGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PerformClick(); aplicar click em outro botão
            //Botão clicando em outro Botão
            versãoToolStripMenuItem.PerformClick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DateTime.Now Data e Hora atual da maquina
            //ToLongTimeString(); apresenta somente a hora com os segundos
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //O intervalo é em milisegundos
            //ou seja 1 segundo é 1000 milisegundos
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToShortDateString();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Iremos chamar a tela de cadastro de cliente
            //Para isso é preciso instanciar a tela na memoria
            //Ou seja carregar a tela na memoria RAM

            //Para realizar uma instancia, é preciso
            //Chamar o tipo de dados
            //definir uma variavel
            //usar a palavra reservada new
            //o chamar o método construtor do Dado
            //ou seja o mesmo nome do tipo de dados com o parenteses 
            //no final ex: Cliente cliente = new Cliente();

            frmCadCliente frm = new frmCadCliente();
            //Agora posso chamar a abertura da tela
            //Irei abrir a tela separa do formanterior
            //frm.Show();

            //Irei abrir a tela trava a tela anterior
            //Geralmente utilizada em telas de cadastro
            frm.ShowDialog();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Chamar a tela de movimentação no modo venda
            //para isso basta adicionar o parametro no momento
            //da instancia da tela
            //0 - Orçamento
            //1 - Venda

            frmMovimentacao movimentacao = new frmMovimentacao(1);
            movimentacao.ShowDialog();
        }

        private void orçamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Chamar a tela de movimentação no modo orçamento
            //para isso basta adicionar o parametro no momento
            //da instancia da tela
            //0 - Orçamento
            //1 - Venda

            frmMovimentacao movimentacao = new frmMovimentacao(0);
            movimentacao.ShowDialog();
        }
    }
}
