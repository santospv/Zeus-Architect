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
    public partial class frmCadastroFornecedor : Form
    {
        String campo = "nome_fantasia";
        Boolean condicao;


        public frmCadastroFornecedor()
        {
            InitializeComponent();
        }


        //Métodos--------------------------------------------------------

        public string conectaBD()
        {
            return @"Data Source=PC-PV;Initial Catalog=Galb;Integrated Security=True";
        }

        private void limparCamposFornecedor()
        {
            dgvFornecedor.DataSource = null;
            txtCodigoFor.Clear();
            txtNomeFantasia.Clear();
            txtCNPJ.Clear();
            txtRazaoSocial.Clear();
            txtEnderecoFor.Clear();
            txtNumeroFor.Clear();
            txtCidadeFor.Clear();
            txtBairroFor.Clear();
            cboEstadoFor.SelectedIndex = 0;
            txtCEPFor.Clear();
            txtTelefoneFor.Clear();
            txtEmailFor.Clear();
            txtCelularFor.Clear();
            txtSite.Clear();
            rbCNPJ.Checked = false;
            rbNomeFantasia.Checked = false;

        }

        private void habilitaCamposFornecedor()
        {
            txtCodigoFor.Enabled = true;
            txtNomeFantasia.Enabled = true;
            txtCNPJ.Enabled = true;
            txtRazaoSocial.Enabled = true;
            txtEnderecoFor.Enabled = true;
            txtNumeroFor.Enabled = true;
            txtCidadeFor.Enabled = true;
            txtBairroFor.Enabled = true;
            txtCEPFor.Enabled = true;
            txtTelefoneFor.Enabled = true;
            txtEmailFor.Enabled = true;
            txtCelularFor.Enabled = true;
            txtSite.Enabled = true;
            txtPesquisaFor.Enabled = true;
            txtPesquisaFor.Clear();

            cboEstadoFor.SelectedIndex = 0;
            cboEstadoFor.Enabled = true;
            rbCNPJ.Checked = false;
            rbCNPJ.Enabled = true;
            rbNomeFantasia.Checked = false;
            rbNomeFantasia.Enabled = true;

            btnAtualizarFor.Enabled = true;
            btnLimparFor.Enabled = true;
            btnListarFor.Enabled = true;
            btnAtualizarFor.Enabled = true;
            btnIncluirFor.Enabled = true;
        }

        private void desabilitaCamposFornecedor()
        {

            txtCodigoFor.Enabled = false;
            txtNomeFantasia.Enabled = false;
            txtCNPJ.Enabled = false;
            txtRazaoSocial.Enabled = false;
            txtEnderecoFor.Enabled = false;
            txtNumeroFor.Enabled = false;
            txtCidadeFor.Enabled = false;
            txtBairroFor.Enabled = false;
            txtCEPFor.Enabled = false;
            txtTelefoneFor.Enabled = false;
            txtEmailFor.Enabled = false;
            txtCelularFor.Enabled = false;
            txtPesquisaFor.Enabled = false;
            txtSite.Enabled = false;

            cboEstadoFor.SelectedIndex = 0;
            cboEstadoFor.Enabled = false;
            
            rbCNPJ.Checked = false;
            rbCNPJ.Enabled = false;
            rbNomeFantasia.Checked = false;
            rbNomeFantasia.Enabled = false;

            //btnAtualizar.Enabled = false;
            //btnLimpar.Enabled = false;
            btnIncluirFor.Enabled = false;
            //btnListar.Enabled = false;
        }

        private void validaCamposFornecedor()
        {

            if (txtNomeFantasia.Text == "")
            {
                MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeFantasia.Focus();
            }
            else
            {
                if (txtCNPJ.Text == "")
                {
                    MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCNPJ.Focus();
                }
                else
                {
                    if (txtEnderecoFor.Text == "")
                    {
                        MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtEnderecoFor.Focus();
                    }
                    else
                    {
                        if (txtNumeroFor.Text == "")
                        {
                            MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNumeroFor.Focus();
                        }
                        else
                        {
                            if (txtCidadeFor.Text == "")
                            {
                                MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtCidadeFor.Focus();
                            }
                            else
                            {
                                if (txtBairroFor.Text == "")
                                {
                                    MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtBairroFor.Focus();
                                }
                                else
                                {
                                    if (txtCEPFor.Text == "")
                                    {
                                        MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txtCEPFor.Focus();
                                    }
                                    else
                                    {
                                        if (cboEstadoFor.Text == "")
                                        {
                                            MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            cboEstadoFor.Focus();
                                        }
                                        else
                                        {
                                            if (txtTelefoneFor.Text == "")
                                            {
                                                MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                txtTelefoneFor.Focus();
                                            }
                                            else
                                            {
                                                if (txtEmailFor.Text == "")
                                                {
                                                    MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    txtEmailFor.Focus();
                                                }
                                                else
                                                {
                                                    if (txtCelularFor.Text == "")
                                                    {
                                                        MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        txtCelularFor.Focus();
                                                    }
                                                    else
                                                    {

                                                        if (txtRazaoSocial.Text == "")
                                                        {
                                                            MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            txtRazaoSocial.Focus();
                                                        }
                                                        else
                                                        {
                                                            if (txtSite.Text == "")
                                                            {
                                                                MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                txtSite.Focus();
                                                            }
                                                            else
                                                            {
                                                                if (condicao == true)
                                                                {
                                                                    incluiFornecedor();
                                                                }
                                                                else
                                                                {
                                                                    atualizaFornecedor();
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

        private void incluiFornecedor()
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

            cmd = new SqlCommand("INSERT INTO Fornecedor values('" + txtNomeFantasia.Text + "','" + txtCNPJ.Text + "','" + txtRazaoSocial.Text + "','" + txtCidadeFor.Text + 
            "','" + txtEnderecoFor.Text + "','" + txtNumeroFor.Text + "','" + txtBairroFor.Text + "','" + cboEstadoFor.SelectedItem.ToString() +  
            "','" + txtCEPFor.Text + "','" + txtTelefoneFor.Text + "','" + txtCelularFor.Text + "','" + txtEmailFor.Text + "','" + txtSite.Text + "')", cnx);

            try
            {
                int linhasAfetadas = cmd.ExecuteNonQuery(); //Quantidade de registros incluidos

                if (linhasAfetadas == 1)
                {
                    cnx.Close();
                    MessageBox.Show("Fornecedor incluido com sucesso!", "Sucesso" + MessageBoxButtons.OK);
                    btnIncluirFor.Enabled = false;
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

            atualizaDataGridViewFornecedor("Select * from Fornecedor order by nome_fantasia");

        }

        private void atualizaFornecedor()
        {

            SqlConnection conexao = new SqlConnection(conectaBD());
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;

            cmd.CommandText = "UPDATE Fornecedor SET nome_fantasia= @nome, cnpj= @cnpj, , razao_social= @razaosocial, cidade= @cidade, endereco= @endereco, numero= @numero, bairro= @bairro, estado= @estado, cep= @cep, telefone= @telefone, celular= @celular, email= @email, site= @site WHERE id_fornecedor= @codigo";


            cmd.Parameters.AddWithValue("@codigo", Convert.ToInt32(this.txtCodigoFor.Text));
            cmd.Parameters.AddWithValue("@nome", this.txtNomeFantasia.Text);
            cmd.Parameters.AddWithValue("@cnpj", this.txtCNPJ.Text);
            cmd.Parameters.AddWithValue("@razaosocial", this.txtRazaoSocial.Text);
            cmd.Parameters.AddWithValue("@cidade", this.txtCidadeFor.Text);
            cmd.Parameters.AddWithValue("@endereco", this.txtEnderecoFor.Text);
            cmd.Parameters.AddWithValue("@numero", Convert.ToInt32(this.txtNumeroFor.Text));
            cmd.Parameters.AddWithValue("@bairro", this.txtBairroFor.Text);
            cmd.Parameters.AddWithValue("@estado", this.cboEstadoFor.SelectedItem);
            cmd.Parameters.AddWithValue("@cep", this.txtCEPFor.Text);
            cmd.Parameters.AddWithValue("@telefone", this.txtTelefoneFor.Text);
            cmd.Parameters.AddWithValue("@email", this.txtEmailFor.Text);
            cmd.Parameters.AddWithValue("@celular", this.txtCelularFor.Text);
            cmd.Parameters.AddWithValue("@site", this.txtSite.Text);
            
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

            atualizaDataGridViewFornecedor("Select * from Fornecedor order by nome_fantasia");

        }

        public void atualizaDataGridViewFornecedor(String comandoSQL)
        {
            SqlConnection conexao = new SqlConnection(conectaBD());

            try
            {
                conexao.Open();
                SqlCommand sql = new SqlCommand(comandoSQL, conexao);
                SqlDataAdapter da = new SqlDataAdapter(sql);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvFornecedor.DataSource = ds;
                dgvFornecedor.DataMember = ds.Tables[0].TableName;
                dgvFornecedor.AllowUserToAddRows = false;
                configuraDatagridViewFornecedor();


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

        private void configuraDatagridViewFornecedor()
        {

            //Renomeia as Colunas do DataGrid
            dgvFornecedor.Columns[0].HeaderText = "Código";
            dgvFornecedor.Columns[1].HeaderText = "Nome Fantasia";
            dgvFornecedor.Columns[2].HeaderText = "CNPJ";
            dgvFornecedor.Columns[3].HeaderText = "Razão Social";
            dgvFornecedor.Columns[4].HeaderText = "Cidade";
            dgvFornecedor.Columns[5].HeaderText = "Endereço";
            dgvFornecedor.Columns[6].HeaderText = "Numero";
            dgvFornecedor.Columns[7].HeaderText = "Bairro";
            dgvFornecedor.Columns[8].HeaderText = "Estado";
            dgvFornecedor.Columns[9].HeaderText = "CEP";
            dgvFornecedor.Columns[10].HeaderText = "Telefone";
            dgvFornecedor.Columns[11].HeaderText = "Email";
            dgvFornecedor.Columns[12].HeaderText = "Celular";
            dgvFornecedor.Columns[13].HeaderText = "Site";

            //Desabilidade Colunas do DataGridView
            dgvFornecedor.Columns["id_fornecedor"].Visible = true;
            dgvFornecedor.Columns["nome_fantasia"].Visible = true;
            dgvFornecedor.Columns["cnpj"].Visible = true;
            dgvFornecedor.Columns["razao_social"].Visible = true;
            dgvFornecedor.Columns["cidade"].Visible = false;
            dgvFornecedor.Columns["endereco"].Visible = false;
            dgvFornecedor.Columns["numero"].Visible = false;
            dgvFornecedor.Columns["bairro"].Visible = false;
            dgvFornecedor.Columns["estado"].Visible = false;
            dgvFornecedor.Columns["cep"].Visible = false;
            dgvFornecedor.Columns["telefone"].Visible = true;
            dgvFornecedor.Columns["email"].Visible = false;
            dgvFornecedor.Columns["celular"].Visible = false;
            dgvFornecedor.Columns["site"].Visible = false;

            //Configura o Tamanho da coluna
            dgvFornecedor.Columns[0].Width = 50;
            dgvFornecedor.Columns[1].Width = 220;
            dgvFornecedor.Columns[2].Width = 150;
            dgvFornecedor.Columns[3].Width = 150;
            dgvFornecedor.Columns[4].Width = 390;
            dgvFornecedor.Columns[5].Width = 50;
            dgvFornecedor.Columns[6].Width = 150;
            dgvFornecedor.Columns[7].Width = 30;
            dgvFornecedor.Columns[8].Width = 20;
            dgvFornecedor.Columns[9].Width = 20;
            dgvFornecedor.Columns[10].Width = 203;
            dgvFornecedor.Columns[11].Width = 120;
            dgvFornecedor.Columns[12].Width = 20;
            dgvFornecedor.Columns[13].Width = 203;


        }

        //Configuração dos botões------------------------------------------


        private void Cadastro_de_Fornecedor_Load(object sender, EventArgs e)
        {
            desabilitaCamposFornecedor();
        }

        private void btnListarFor_Click(object sender, EventArgs e)
        {
            atualizaDataGridViewFornecedor("Select * from Fornecedor Where " + campo + " LIKE '" + txtPesquisaFor.Text + "%'");
            //limparCampos();
        }

        private void btnIncluirFor_Click(object sender, EventArgs e)
        {
            condicao = true;
            validaCamposFornecedor();
            //limparCampos();
        }

        private void rbNomeFantasia_CheckedChanged(object sender, EventArgs e)
        {
            campo = "nome_fantasia";
            txtPesquisaFor.Text = "";
        }

        private void rbCNPJ_CheckedChanged(object sender, EventArgs e)
        {

            campo = "cnpj";
            txtPesquisaFor.Text = "";
        }

        private void btnLimparFor_Click(object sender, EventArgs e)
        {
            limparCamposFornecedor();
            desabilitaCamposFornecedor();
        }

        private void btnNovoFor_Click(object sender, EventArgs e)
        {
            limparCamposFornecedor();
            habilitaCamposFornecedor();
            txtNomeFantasia.Focus();
        }

        private void txtPesquisaFor_TextChanged(object sender, EventArgs e)
        {
            dgvFornecedor.Enabled = false;
            btnIncluirFor.Enabled = false;
            btnAtualizarFor.Enabled = true;

            if (txtPesquisaFor.Text != "")
            {
                dgvFornecedor.Enabled = true;
                atualizaDataGridViewFornecedor("Select * from Fornecedor Where " + campo + " LIKE '" + txtPesquisaFor.Text + "%'");
            }
            else
            {
                txtPesquisaFor.Text = "";
                limparCamposFornecedor();
                txtPesquisaFor.Focus();
            }
        }

        private void btnAtualizarFor_Click(object sender, EventArgs e)
        {
            condicao = false;
            validaCamposFornecedor();
            limparCamposFornecedor();
        }

        //Capturando Somente Numeros no TextBox
        private void txtNumeroFor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void dgvFornecedor_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtCodigoFor.Text = dgvFornecedor.CurrentRow.Cells[0].Value.ToString();
                txtNomeFantasia.Text = dgvFornecedor.CurrentRow.Cells[1].Value.ToString();
                txtCNPJ.Text = dgvFornecedor.CurrentRow.Cells[2].Value.ToString();
                txtRazaoSocial.Text = dgvFornecedor.CurrentRow.Cells[3].Value.ToString();
                txtCidadeFor.Text = dgvFornecedor.CurrentRow.Cells[4].Value.ToString();
                txtEnderecoFor.Text = dgvFornecedor.CurrentRow.Cells[5].Value.ToString();
                txtNumeroFor.Text = dgvFornecedor.CurrentRow.Cells[6].Value.ToString();
                txtBairroFor.Text = dgvFornecedor.CurrentRow.Cells[7].Value.ToString();
                cboEstadoFor.Text = dgvFornecedor.CurrentRow.Cells[8].Value.ToString();
                txtCEPFor.Text = dgvFornecedor.CurrentRow.Cells[9].Value.ToString();
                txtTelefoneFor.Text = dgvFornecedor.CurrentRow.Cells[10].Value.ToString();
                txtCelularFor.Text = dgvFornecedor.CurrentRow.Cells[11].Value.ToString();
                txtEmailFor.Text = dgvFornecedor.CurrentRow.Cells[12].Value.ToString();
                txtSite.Text = dgvFornecedor.CurrentRow.Cells[13].Value.ToString();

            }
            catch (Exception erro)
            {

            }
        }
     }
 }

