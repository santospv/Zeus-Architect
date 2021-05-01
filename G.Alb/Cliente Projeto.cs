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
    public partial class frmClienteProjeto : Form
    {

        Boolean condicao;

        public frmClienteProjeto()
        {
            InitializeComponent();
        }

        public string conectaBD()
        {
            return @"Data Source=PC-PV;Initial Catalog=Galb;Integrated Security=True";
        }

        private void validaCamposProjeto()
        {

            if (cboClienteProj.Text == "")
            {
                MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboClienteProj.Focus();
            }
            else
            {
                if (cboResponsavelProj.Text == "")
                {
                    MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboResponsavelProj.Focus();
                }
                else
                {
                    if (cboTipoProj.Text == "")
                    {
                        MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cboTipoProj.Focus();
                    }
                    else
                    {
                        if (txtNomeObra.Text == "")
                        {
                            MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNomeObra.Focus();
                        }
                        else
                        {
                            if (txtEnderecoProj.Text == "")
                            {
                                MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtEnderecoProj.Focus();
                            }
                            else
                            {
                                if (txtBairroProj.Text == "")
                                {
                                    MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtBairroProj.Focus();
                                }
                                else
                                {
                                    if (txtCidadeProj.Text == "")
                                    {
                                        MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txtCidadeProj.Focus();
                                    }
                                    else
                                    {
                                        if (cboEstadoProj.Text == "")
                                        {
                                            MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            cboEstadoProj.Focus();
                                        }
                                        else
                                        {
                                            if (txtNumeroProj.Text == "")
                                            {
                                                MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                txtNumeroProj.Focus();
                                            }
                                            else
                                            {
                                                if (txtQuadraProj.Text == "")
                                                {
                                                    MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    txtQuadraProj.Focus();
                                                }
                                                else
                                                {
                                                    if (txtLoteProj.Text == "")
                                                    {
                                                        MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        txtLoteProj.Focus();
                                                    }
                                                    else
                                                    {
                                                        if (txtAreaProj.Text == "")
                                                        {
                                                            MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            txtAreaProj.Focus();
                                                        }
                                                        else
                                                        {
                                                            if (txtDataFechamento.Text == "")
                                                            {
                                                                MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                txtDataFechamento.Focus();
                                                            }
                                                            else
                                                            {
                                                                if (txtDataPreliminar.Text == "")
                                                                {
                                                                    MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                    txtDataPreliminar.Focus();
                                                                }
                                                                else
                                                                {
                                                                    if (txtDataAnteProjeto.Text == "")
                                                                    {
                                                                        MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                        txtDataAnteProjeto.Focus();
                                                                    }
                                                                    else
                                                                    {
                                                                        if (txtDataProjetoExec.Text == "")
                                                                        {
                                                                            MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                            txtDataProjetoExec.Focus();
                                                                        }
                                                                        else
                                                                        {
                                                                            if (rtObservacaoProj.Text == "")
                                                                            {
                                                                                MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                                rtObservacaoProj.Focus();
                                                                            }
                                                                            else
                                                                            {
                                                                                if (txtStatusProj.Text == "")
                                                                                {
                                                                                    MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                                    txtStatusProj.Focus();
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (condicao == true)
                                                                                    {
                                                                                        incluiProjeto();
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        //atualizaProjeto();
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void incluiProjeto()
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

            cmd = new SqlCommand("INSERT INTO Projeto values('" + txtDataFechamento.Text + "','" + txtDataPreliminar.Text + "','" + txtDataAnteProjeto.Text + "','" + txtDataProjetoExec.Text +
            "','" + txtNomeObra.Text + "','" + rtObservacaoProj.Text + "','" + txtAreaProj.Text + "','" + txtCidadeProj.Text + "','" + cboEstadoProj.Text + "','" + txtEnderecoProj.Text +
            "','" + txtNumeroProj.Text + "','" + txtQuadraProj.Text + "','" + txtLoteProj.Text + "','" + txtBairroProj.Text + "','" + cboClienteProj.SelectedValue + "','" + cboResponsavelProj.SelectedValue +
            "','" + cboTipoProj.SelectedValue + "','" + txtStatusProj.Text + "')", cnx);

            try
            {
                int linhasAfetadas = cmd.ExecuteNonQuery(); //Quantidade de registros incluidos

                if (linhasAfetadas == 1)
                {
                    cnx.Close();
                    MessageBox.Show("Projeto incluido com sucesso!", "Sucesso" + MessageBoxButtons.OK);
                    btnIncluirProj.Enabled = false;
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

            atualizaDataGridViewProjeto("Select * from Projeto order by id_projeto");

        }

        public void atualizaDataGridViewProjeto(String comandoSQL)
        {
            SqlConnection conexao = new SqlConnection(conectaBD());

            try
            {
                conexao.Open();
                SqlCommand sql = new SqlCommand(comandoSQL, conexao);
                SqlDataAdapter da = new SqlDataAdapter(sql);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvProjeto.DataSource = ds;
                dgvProjeto.DataMember = ds.Tables[0].TableName;
                dgvProjeto.AllowUserToAddRows = false;
                //configuraDatagridViewCliente();


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

        public void PopulaCboCliente()
        {
            SqlConnection conexao = new SqlConnection(conectaBD());
            conexao.Open();    
                       
            try
            {
                SqlCommand Command = new SqlCommand("SELECT id_cliente, nome FROM Cliente ORDER BY nome", conexao);
                SqlDataReader reader = Command.ExecuteReader();
                DataTable Cliente = new DataTable("Cliente");
                Cliente.Load(reader);

                DataRow linha = Cliente.NewRow();
                linha["nome"] = "";
                Cliente.Rows.InsertAt(linha, 0);

                this.cboClienteProj.DataSource = Cliente;
                this.cboClienteProj.ValueMember = "id_cliente";
                this.cboClienteProj.DisplayMember = "nome";

                reader.Close();
                reader.Dispose();


            }
            catch
            {

            }
            finally
            {
                conexao.Close();
            }

        }

        public void PopulaCboResponsavel()
        {
            SqlConnection conexao = new SqlConnection(conectaBD());
            conexao.Open();

            try
            {
                SqlCommand Command = new SqlCommand("SELECT id_funcionario, nome FROM Funcionario ORDER BY nome", conexao);
                SqlDataReader reader = Command.ExecuteReader();
                DataTable Funcionario = new DataTable("Funcionario");
                Funcionario.Load(reader);

                DataRow linha = Funcionario.NewRow();
                linha["nome"] = "";
                Funcionario.Rows.InsertAt(linha, 0);

                this.cboResponsavelProj.DataSource = Funcionario;
                this.cboResponsavelProj.ValueMember = "id_funcionario";
                this.cboResponsavelProj.DisplayMember = "nome";

                reader.Close();
                reader.Dispose();

            }
            catch
            {

            }
            finally
            {
                conexao.Close();
            }

        }

        public void PopulaCboTipoProjeto()
        {
            SqlConnection conexao = new SqlConnection(conectaBD());
            conexao.Open();

            try
            {
                SqlCommand Command = new SqlCommand("SELECT id_tipoProjeto, nome_tipoProjeto FROM TipoProjeto ORDER BY nome_tipoProjeto", conexao);
                SqlDataReader reader = Command.ExecuteReader();
                DataTable TipoProjeto = new DataTable("TipoProjeto");
                TipoProjeto.Load(reader);

                DataRow linha = TipoProjeto.NewRow();
                linha["nome_tipoProjeto"] = "";
                TipoProjeto.Rows.InsertAt(linha, 0);

                this.cboTipoProj.DataSource = TipoProjeto;
                this.cboTipoProj.ValueMember = "id_tipoProjeto";
                this.cboTipoProj.DisplayMember = "nome_tipoProjeto";

                reader.Close();
                reader.Dispose();

            }
            catch
            {

            }
            finally
            {
                conexao.Close();
            }

        }

        private void frmClienteProjeto_Load(object sender, EventArgs e)
        {
            

        }

        private void cboClienteProj_Click(object sender, EventArgs e)
        {
            PopulaCboCliente();
        }

        private void cboResponsavelProj_Click(object sender, EventArgs e)
        {
            PopulaCboResponsavel();
        }

        private void cboTipoProj_Click(object sender, EventArgs e)
        {
            PopulaCboTipoProjeto();
        }

        private void btnIncluirProj_Click(object sender, EventArgs e)
        {
            condicao = true;
            validaCamposProjeto();
            //limparCampos();
        }

    }
}
