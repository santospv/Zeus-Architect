using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G.Alb
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void criarEquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente cad = new frmCadastroCliente();
            cad.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor cad = new frmCadastroFornecedor();
            cad.Show();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario cad = new frmCadastroFuncionario();
            cad.Show();
        }

        private void clienteXProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteProjeto cliente = new frmClienteProjeto();
            cliente.Show();
        }

        private void tipoProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroTipoProjeto cad = new frmCadastroTipoProjeto();
            cad.Show();
        }

        private void acompanhamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcompanhamentoProjeto acamp = new frmAcompanhamentoProjeto();
            acamp.Show();
        }

        private void parcelaXClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParcelasCliente parcelas = new frmParcelasCliente();
            parcelas.Show();
        }

    }
}
