using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace G.Alb
{
    public partial class frmCadastroTipoProjeto : Form
    {
        
        //String campo = "nome_tipoProjeto";
        Boolean condicao;

        public frmCadastroTipoProjeto()
        {
            InitializeComponent();
        }


        //Métodos--------------------------------------------------------

        public string conectaBD()
        {
            return @"Data Source=PC-PV;Initial Catalog=Galb;Integrated Security=True";
        }

        private void limparCamposTipoProjeto()
        {
            dgvTipoProjeto.DataSource = null;
            txtCodTipoProj.Clear();
            txtNomeTipoProj.Clear();
            rtDescTipoProj.Clear();
            

        }

        private void habilitaCamposTipoProjeto()
        {
            txtCodTipoProj.Enabled = true;
            txtNomeTipoProj.Enabled = true;
            rtDescTipoProj.Enabled = true;
            
            btnAtualizarTipoProj.Enabled = true;
            btnLimparTipoProj.Enabled = true;
            btnNovoTipoProj.Enabled = true;
            btnIncluirTipoProj.Enabled = true;
        }

        private void desabilitaTipoProjeto()
        {

            txtCodTipoProj.Enabled = false;
            txtNomeTipoProj.Enabled = false;
            rtDescTipoProj.Enabled = false;

            btnAtualizarTipoProj.Enabled = true;
            btnLimparTipoProj.Enabled = true;
            btnNovoTipoProj.Enabled = true;
            btnIncluirTipoProj.Enabled = false;
        }

        private void validaCamposTipoProjeto()
        {

            if (txtNomeTipoProj.Text == "")
            {
                MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeTipoProj.Focus();
            }
            else
            {
                if (rtDescTipoProj.Text == "")
                {
                    MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rtDescTipoProj.Focus();
                }
                else
                {
                    if (condicao == true)
                    {
                        incluiTipoProjeto();
                    }
                    else
                    {
                        atualizaTipoProjeto();
                    }
                }
            }
        }                                          
                                     

        private void incluiTipoProjeto()
        {
            SqlConnection cnx = new SqlConnection(conectaBD());
            SqlCommand cmd;

            try
            {
                cnx.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha no acesso ao banco de dados" + erro + "Erro" + MessageBoxButtons.OK);
                return;
            }

            cmd = new SqlCommand("INSERT INTO TipoProjeto values('" + txtNomeTipoProj.Text + "','" + rtDescTipoProj.Text + "')", cnx);

            try
            {
                int linhasAfetadas = cmd.ExecuteNonQuery(); //Quantidade de registros incluidos

                if (linhasAfetadas == 1)
                {
                    cnx.Close();
                    MessageBox.Show("Tipo de Projeto incluido com sucesso!", "Sucesso" + MessageBoxButtons.OK);
                    btnIncluirTipoProj.Enabled = false;
                    //limpaCampos();
                    //btnAtualizar.Enabled = true;
                    //btnExcluir.Enabled = true;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha na inclusão ao banco de dados" + erro + "Erro" + MessageBoxButtons.OK);
                return;
            }
            finally
            {
                cnx.Close();
            }

            atualizaDataGridViewTipoProjeto("Select * from TipoProjeto order by nome_tipoProjeto");

        }

        private void atualizaTipoProjeto()
        {

            SqlConnection conexao = new SqlConnection(conectaBD());
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;

            cmd.CommandText = "UPDATE TipoProjeto SET nome_tipoProjeto= @nome, descricao= @descricao WHERE id_tipoProjeto = @codigo";


            cmd.Parameters.AddWithValue("@codigo", Convert.ToInt32(this.txtCodTipoProj.Text));
            cmd.Parameters.AddWithValue("@nome", this.txtNomeTipoProj.Text);
            cmd.Parameters.AddWithValue("@descricao", this.rtDescTipoProj.Text);

            try
            {
                int linhasAfetadas = cmd.ExecuteNonQuery(); //Quantidade de registros incluidos

                if (linhasAfetadas == 1)
                {
                    conexao.Close();
                    MessageBox.Show("Cadastro atualizado com sucesso!", "Sucesso" + MessageBoxButtons.OK);
                    //limpaCampos();
                    //btnAtualizar.Enabled = true;
                    //btnExcluir.Enabled = true;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha na atualização ao banco de dados" + erro + "Erro" + MessageBoxButtons.OK);
                return;
            }
            finally
            {
                conexao.Close();
            }

            atualizaDataGridViewTipoProjeto("Select * from TipoProjeto order by nome_tipoProjeto");

        }

        public void atualizaDataGridViewTipoProjeto(String comandoSQL)
        {
            SqlConnection conexao = new SqlConnection(conectaBD());

            try
            {
                conexao.Open();
                SqlCommand sql = new SqlCommand(comandoSQL, conexao);
                SqlDataAdapter da = new SqlDataAdapter(sql);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvTipoProjeto.DataSource = ds;
                dgvTipoProjeto.DataMember = ds.Tables[0].TableName;
                dgvTipoProjeto.AllowUserToAddRows = false;
                configuraDatagridViewTipoProjeto();


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao obter dados" + erro + "Erro" + MessageBoxButtons.OK);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void configuraDatagridViewTipoProjeto()
        {

            //Renomeia as Colunas do DataGrid
            dgvTipoProjeto.Columns[0].HeaderText = "Código";
            dgvTipoProjeto.Columns[1].HeaderText = "Nome";
            dgvTipoProjeto.Columns[2].HeaderText = "Observação";

            //Desabilidade Colunas do DataGridView
            dgvTipoProjeto.Columns["id_tipoProjeto"].Visible = true;
            dgvTipoProjeto.Columns["nome_tipoProjeto"].Visible = true;
            dgvTipoProjeto.Columns["descricao"].Visible = true;
            

            //Configura o Tamanho da coluna
            dgvTipoProjeto.Columns[0].Width = 50;
            dgvTipoProjeto.Columns[1].Width = 200;
            dgvTipoProjeto.Columns[2].Width = 235;
 
        }

        private void btnNovoTipoProj_Click(object sender, EventArgs e)
        {
            limparCamposTipoProjeto();
            habilitaCamposTipoProjeto();
            txtNomeTipoProj.Focus();
        }

        private void btnIncluirTipoProj_Click(object sender, EventArgs e)
        {
            condicao = true;
            validaCamposTipoProjeto();
            //limparCampos();
        }

        private void btnAtualizarTipoProj_Click(object sender, EventArgs e)
        {
            condicao = false;
            validaCamposTipoProjeto();
            limparCamposTipoProjeto();
        }

        private void btnLimparTipoProj_Click(object sender, EventArgs e)
        {
            limparCamposTipoProjeto();
            desabilitaTipoProjeto();
        }

        private void dgvTipoProjeto_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtCodTipoProj.Text = dgvTipoProjeto.CurrentRow.Cells[0].Value.ToString();
                txtNomeTipoProj.Text = dgvTipoProjeto.CurrentRow.Cells[1].Value.ToString();
                rtDescTipoProj.Text = dgvTipoProjeto.CurrentRow.Cells[2].Value.ToString();

            }
            catch (Exception erro)
            {

            }
        }

        private void frmCadastroTipoProjeto_Load(object sender, EventArgs e)
        {
            desabilitaTipoProjeto();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            atualizaDataGridViewTipoProjeto("Select * from TipoProjeto order by nome_tipoProjeto");
        }

    }
}
