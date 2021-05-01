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
using System.Data.Sql;

namespace G.Alb
{
    public partial class frmCadastroFuncionario : Form
    {

        String campo = "nome";
        Boolean condicao;
        int valorbtn = 5;

        public frmCadastroFuncionario()
        {
            InitializeComponent();
        }

        //Métodos

        public string conectaBD()
        {
            return  @"Data Source=PC-PV;Initial Catalog=Galb;Integrated Security=True";
        }

        private void habilitaCamposFunc()
        {
            txtCodigoFunc.Enabled = true;
            txtNomeFunc.Enabled = true;
            txtSobrenomeFunc.Enabled = true;
            txtCPFFunc.Enabled = true;
            txtRuaFunc.Enabled = true;
            txtNumeroFunc.Enabled = true;
            cboEstadoFunc.Enabled = true;
            cboCidadeFunc.Enabled = true;
            txtCEPFunc.Enabled = true;
            txtBairroFunc.Enabled = true;
            cboComplementoFunc.Enabled = true;
            txtTelefoneFunc.Enabled = true;
            txtEmailFunc.Enabled = true;
            txtCelularFunc.Enabled = true;
            cboSetorFunc.Enabled = true;
            cboCargoFunc.Enabled = true;
            txtSalarioFunc.Enabled = true;
            cboStatusFunc.Enabled = true;
            txtPesquisaFunc.Enabled = true;
            txtPesquisaFunc.Clear();
            rbCPFFunc.Checked = false;
            rbCPFFunc.Enabled = true;
            rbNomeFunc.Checked = false;
            rbNomeFunc.Enabled = true;

        }

        private void desabilitaCamposFunc()
        {

            txtCodigoFunc.Enabled = false;
            txtNomeFunc.Enabled = false;
            txtSobrenomeFunc.Enabled = false;
            txtCPFFunc.Enabled = false;
            txtRuaFunc.Enabled = false;
            txtNumeroFunc.Enabled = false;
            //txtCidadeF.Enabled = false;
            txtBairroFunc.Enabled = false;
            //txtComplemento.Enabled = false;
            txtTelefoneFunc.Enabled = false;
            txtEmailFunc.Enabled = false;
            txtCelularFunc.Enabled = false;
            txtSalarioFunc.Enabled = false;
            txtCEPFunc.Enabled = false;
            txtPesquisaFunc.Enabled = false;

            //cboEstado.SelectedIndex = 0;
            //cboEstado.Enabled = false;
            //cboSetorFunc.SelectedIndex = 0;
            cboSetorFunc.Enabled = false;
            //cboCargoFunc.SelectedIndex = 0;
            cboCargoFunc.Enabled = false;
            //cboStatusFunc.SelectedIndex = 0;
            cboStatusFunc.Enabled = false;

            rbCPFFunc.Checked = false;
            rbCPFFunc.Enabled = false;
            rbNomeFunc.Checked = false;
            rbNomeFunc.Enabled = false;

            //btnAtualizar.Enabled = false;
            //btnLimpar.Enabled = false;
            btnIncluirFunc.Enabled = false;
            //btnListar.Enabled = false;
        }

        private void limparCamposFunc()
        {
            dgvFuncionario.DataSource = null;
            txtCodigoFunc.Clear();
            txtNomeFunc.Clear();
            txtSobrenomeFunc.Clear();
            txtCPFFunc.Clear();
            txtRuaFunc.Clear();
            txtNumeroFunc.Clear();
            txtBairroFunc.Clear();
            txtCEPFunc.Clear();
            cboEstadoFunc.SelectedIndex = 0;
            cboCidadeFunc.SelectedItem = null;
            cboComplementoFunc.SelectedItem = null;
            txtTelefoneFunc.Clear();
            txtEmailFunc.Clear();
            txtCelularFunc.Clear();
            cboSetorFunc.SelectedIndex = 0;
            cboCargoFunc.SelectedIndex = 0;
            txtSalarioFunc.Clear();
            cboStatusFunc.SelectedIndex = 0;

            rbCPFFunc.Checked = false;
            rbNomeFunc.Checked = false;



        }

        private void validaCamposFunc()
        {

            if (txtNomeFunc.Text == "")
            {
                MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeFunc.Focus();
            }
            else
            {
                if (txtCPFFunc.Text == "")
                {
                    MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCPFFunc.Focus();
                }
                else
                {
                    if (txtRuaFunc.Text == "")
                    {
                        MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtRuaFunc.Focus();
                    }
                    else
                    {
                        if (txtNumeroFunc.Text == "")
                        {
                            MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNumeroFunc.Focus();
                        }
                        else
                        {
                            if (cboCidadeFunc.Text == "")
                            {
                                MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cboCidadeFunc.Focus();
                            }
                            else
                            {
                                if (txtBairroFunc.Text == "")
                                {
                                    MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtBairroFunc.Focus();
                                }
                                else
                                {
                                    if (txtCEPFunc.Text == "")
                                    {
                                        MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txtCEPFunc.Focus();
                                    }
                                    else
                                    {
                                        if (cboEstadoFunc.Text == "")
                                        {
                                            MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            cboEstadoFunc.Focus();
                                        }
                                        else
                                        {
                                            if (cboComplementoFunc.Text == "")
                                            {
                                                MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                cboComplementoFunc.Focus();
                                            }
                                            else
                                            {
                                                if (txtTelefoneFunc.Text == "")
                                                {
                                                    MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    txtTelefoneFunc.Focus();
                                                }
                                                else
                                                {
                                                    if (txtEmailFunc.Text == "")
                                                    {
                                                        MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        txtEmailFunc.Focus();
                                                    }
                                                    else
                                                    {
                                                        if (txtCelularFunc.Text == "")
                                                        {
                                                            MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            txtCelularFunc.Focus();
                                                        }
                                                        else
                                                        {
                                                            if (cboSetorFunc.Text == "")
                                                            {
                                                                MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                cboSetorFunc.Focus();
                                                            }
                                                            else
                                                            {
                                                                if (cboCargoFunc.Text == "")
                                                                {
                                                                    MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                    cboCargoFunc.Focus();
                                                                }
                                                                else
                                                                {
                                                                    if (txtSalarioFunc.Text == "")
                                                                    {
                                                                        MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                        txtSalarioFunc.Focus();
                                                                    }
                                                                    else
                                                                    {
                                                                        if (cboStatusFunc.Text == "")
                                                                        {
                                                                            MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                            cboStatusFunc.Focus();
                                                                        }
                                                                        else
                                                                        {
                                                                            if (condicao == true)
                                                                            {
                                                                                incluiFuncionario();
                                                                            }
                                                                            else
                                                                            {
                                                                                atualizaFuncionario();
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

        private void incluiFuncionario()
        {
            SqlConnection cnx = new SqlConnection(conectaBD());
            SqlCommand cmd;
       
            try
            {
                    cnx.Open();
                }
                catch(Exception erro)
                {
                    MessageBox.Show("Falha no acesso ao banco de dados" + erro + "Erro"+ MessageBoxButtons.OK);
                    return;
            }

             //cmd = new SqlCommand ("INSERT INTO Funcionario values('" + txtNomeFunc.Text + "','" + txtCPFFunc.Text + "','" +txtCidadeF.Text + "','" + txtRuaFunc.Text + "','" + txtNumeroFunc.Text + "','" + txtBairro.Text + "','" + cboEstado.SelectedItem.ToString() + 
             //"','" + txtCEPFunc.Text + "','" + txtComplemento.Text + "','" + txtTelefoneFunc.Text + "','" + txtEmailFunc.Text + "','" + txtCelularFunc.Text + "','" + cboSetorFunc.SelectedItem.ToString() + "','" + cboCargoFunc.SelectedItem.ToString() + "','" + sal.ToString() + "','" + cboStatusFunc.SelectedItem.ToString() + "')", cnx);
                
                cmd = new SqlCommand("[dbo].[SP_MANTERFUNC]", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ACAO", SqlDbType.Int)).Value = valorbtn;
                cmd.Parameters.Add(new SqlParameter("@NOME", SqlDbType.VarChar)).Value = txtNomeFunc.Text;
                cmd.Parameters.Add(new SqlParameter("@SOBRENOME", SqlDbType.VarChar)).Value = txtSobrenomeFunc.Text;
                cmd.Parameters.Add(new SqlParameter("@IDCARGO", SqlDbType.Int)).Value = Convert.ToInt32(cboCargoFunc.SelectedValue);
                cmd.Parameters.Add(new SqlParameter("@IDSETOR", SqlDbType.Int)).Value = Convert.ToInt32(cboSetorFunc.SelectedValue);
                cmd.Parameters.Add(new SqlParameter("@CPF", SqlDbType.VarChar)).Value = txtCPFFunc.Text;
                cmd.Parameters.Add(new SqlParameter("@TELEFONE", SqlDbType.VarChar)).Value = txtTelefoneFunc.Text;
                cmd.Parameters.Add(new SqlParameter("@CELULAR", SqlDbType.VarChar)).Value = txtCelularFunc.Text;
                cmd.Parameters.Add(new SqlParameter("@SALARIO", SqlDbType.Float)).Value = Convert.ToDouble(txtSalarioFunc.Text);
                cmd.Parameters.Add(new SqlParameter("@CODSTATUSFUNC", SqlDbType.Int)).Value = Convert.ToInt32(cboStatusFunc.SelectedValue);
                cmd.Parameters.Add(new SqlParameter("@DATAADIMISSAO", SqlDbType.DateTime)).Value = DateTime.Now;
                cmd.Parameters.Add(new SqlParameter("@DATADEMISSAO", SqlDbType.DateTime)).Value = DateTime.Now;
                cmd.Parameters.Add(new SqlParameter("@CIDADEID", SqlDbType.Int)).Value = Convert.ToInt32(cboCidadeFunc.SelectedValue);
                cmd.Parameters.Add(new SqlParameter("@RUA", SqlDbType.VarChar)).Value = txtRuaFunc.Text;
                cmd.Parameters.Add(new SqlParameter("@NUMERO", SqlDbType.Int)).Value = txtNumeroFunc.Text;
                cmd.Parameters.Add(new SqlParameter("@CEP", SqlDbType.VarChar)).Value = txtCEPFunc.Text;
                cmd.Parameters.Add(new SqlParameter("@BAIRRO", SqlDbType.VarChar)).Value = txtBairroFunc.Text;
                cmd.Parameters.Add(new SqlParameter("@EMAIL", SqlDbType.VarChar)).Value = txtEmailFunc.Text;
                cmd.Parameters.Add(new SqlParameter("@COMPLEMENTO", SqlDbType.VarChar)).Value = cboComplementoFunc.Text;
                cmd.Parameters.Add(new SqlParameter("@IDFUNC", SqlDbType.Int)).Value = null;
                cmd.Parameters.Add(new SqlParameter("@CIDADE", SqlDbType.VarChar)).Value = null;


            try
            {
                int linhasAfetadas = cmd.ExecuteNonQuery(); //Quantidade de registros incluidos

                if (linhasAfetadas > 1)
                {
                    cnx.Close();
                    MessageBox.Show("Funcionario incluido com sucesso!", "Sucesso" + MessageBoxButtons.OK );
                    btnIncluirFunc.Enabled = false;
                    //limpaCampos();
                    //btnAtualizar.Enabled = true;
                    //btnExcluir.Enabled = true;
                }

            }
            catch(Exception erro)
            {
                MessageBox.Show("Falha na inclusão ao banco de dados" + erro + "Erro"+ MessageBoxButtons.OK);
                return;
            }
            finally
            {
                cnx.Close();
            }

            //atualizaDataGridViewFuncionario("Select * from Funcionario order by nome");

        }

        private void atualizaFuncionario()
        {

            SqlConnection conexao = new SqlConnection(conectaBD());
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;

            //cmd.CommandText = "UPDATE Funcionario SET nome= @nome, cpf= @cpf, cidade= @cidade, endereco= @endereco, numero= @numero, bairro= @bairro, estado= @estado, cep= @cep, complemento= @complemento, telefone= @telefone, email= @email, celular= @celular, setor= @setor, cargo= @cargo, salario= @salario, status= @status WHERE id_funcionario= @codigo";


            //cmd.Parameters.AddWithValue("@codigo", Convert.ToInt32(this.txtCodigoFunc.Text));
            //cmd.Parameters.AddWithValue("@nome", this.txtNomeFunc.Text);
            //cmd.Parameters.AddWithValue("@cpf", this.txtCPFFunc.Text);
            //cmd.Parameters.AddWithValue("@cidade", this.txtCidadeF.Text);
            //cmd.Parameters.AddWithValue("@endereco", this.txtRuaFunc.Text);
            //cmd.Parameters.AddWithValue("@numero", Convert.ToInt32(this.txtNumeroFunc.Text));
            //cmd.Parameters.AddWithValue("@bairro", this.txtBairroFunc.Text);
            //cmd.Parameters.AddWithValue("@estado", this.cboEstado.SelectedItem);
            //cmd.Parameters.AddWithValue("@cep", this.txtCEPFunc.Text);
            //cmd.Parameters.AddWithValue("@complemento", this.txtComplemento.Text);
            //cmd.Parameters.AddWithValue("@telefone", this.txtTelefoneFunc.Text);
            //cmd.Parameters.AddWithValue("@email", this.txtEmailFunc.Text);
            //cmd.Parameters.AddWithValue("@celular", this.txtCelularFunc.Text);
            //cmd.Parameters.AddWithValue("@setor", this.cboSetorFunc.SelectedItem);
            //cmd.Parameters.AddWithValue("@cargo", this.cboCargoFunc.SelectedItem);
            //cmd.Parameters.AddWithValue("@salario", float.Parse(this.txtSalarioFunc.Text));
            //cmd.Parameters.AddWithValue("@status", this.cboStatusFunc.SelectedItem);

            cmd = new SqlCommand("[dbo].[SP_MANTERFUNC]", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ACAO", SqlDbType.Int)).Value = Convert.ToInt32(valorbtn);
            cmd.Parameters.Add(new SqlParameter("@IDCARGO", SqlDbType.Int)).Value = Convert.ToInt32(cboCargoFunc.SelectedIndex);
            cmd.Parameters.Add(new SqlParameter("@IDSETOR", SqlDbType.Int)).Value = Convert.ToInt32(cboSetorFunc.SelectedIndex);
            cmd.Parameters.AddWithValue("@NOMECLI", this.txtNomeFunc.Text);
            cmd.Parameters.AddWithValue("@SNCLI", this.txtSobrenomeFunc.Text);
            cmd.Parameters.AddWithValue("@CPFFUNC", this.txtCPFFunc.Text);
            cmd.Parameters.AddWithValue("@TELCLI", this.txtTelefoneFunc.Text);
            cmd.Parameters.AddWithValue("@CELCLI", this.txtCelularFunc.Text);
            cmd.Parameters.AddWithValue("@EMAILCLI", this.txtEmailFunc.Text);
            cmd.Parameters.Add(new SqlParameter("@CODSTATUSFUNC", SqlDbType.Int)).Value = Convert.ToInt32(cboStatusFunc.SelectedIndex); 
            cmd.Parameters.AddWithValue("@CIDADEID", this.cboCidadeFunc.SelectedValue);
            //cmd.Parameters.AddWithValue("@CIDADE", SqlDbType.VarChar)).Value = null;
            cmd.Parameters.AddWithValue("@RUA", this.txtRuaFunc.Text);
            cmd.Parameters.AddWithValue("@NUMERO", this.txtNumeroFunc.Text);
            cmd.Parameters.AddWithValue("@CEP", this.txtCEPFunc.Text);
            cmd.Parameters.AddWithValue("BAIRRO", this.txtBairroFunc.Text);
            cmd.Parameters.AddWithValue("@COMPLEMENTO", this.cboComplementoFunc.Text);
            cmd.Parameters.AddWithValue("@IDFUNC", SqlDbType.Int).Value = Convert.ToInt32(txtCodigoFunc.Text);
     

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

            atualizaDataGridViewFuncionario("Select * from Funcionario order by nome");
    
        }

        public void atualizaDataGridViewFuncionario(String comandoSQL)
        {
            SqlConnection conexao = new SqlConnection(conectaBD());

            try
            {
                conexao.Open();
                SqlCommand sql = new SqlCommand(comandoSQL, conexao);
                SqlDataAdapter da = new SqlDataAdapter(sql);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvFuncionario.DataSource = ds;
                dgvFuncionario.DataMember = ds.Tables[0].TableName;
                dgvFuncionario.AllowUserToAddRows = false;
                configuraDatagridViewFunc();


            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao obter dados" + erro + "Erro"+ MessageBoxButtons.OK);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void configuraDatagridViewFunc()
        {

            //Renomeia as Colunas do DataGrid
            dgvFuncionario.Columns[0].HeaderText = "Codigo";
            dgvFuncionario.Columns[1].HeaderText = "Nome";
            dgvFuncionario.Columns[2].HeaderText = "Sobrenome";
            dgvFuncionario.Columns[3].HeaderText = "CPF";
            dgvFuncionario.Columns[4].HeaderText = "Endereco";
            dgvFuncionario.Columns[5].HeaderText = "Numero";
            dgvFuncionario.Columns[6].HeaderText = "Estado";
            dgvFuncionario.Columns[7].HeaderText = "Cidade";
            dgvFuncionario.Columns[8].HeaderText = "Bairro";
            dgvFuncionario.Columns[9].HeaderText = "CEP";
            dgvFuncionario.Columns[10].HeaderText = "Complemento";
            dgvFuncionario.Columns[11].HeaderText = "Telefone";
            dgvFuncionario.Columns[12].HeaderText = "Email";
            dgvFuncionario.Columns[13].HeaderText = "Celular";
            dgvFuncionario.Columns[14].HeaderText = "Setor";
            dgvFuncionario.Columns[15].HeaderText = "Cargo";
            dgvFuncionario.Columns[16].HeaderText = "Salario";
            dgvFuncionario.Columns[17].HeaderText = "Status";

            //Desabilidade Colunas do DataGridView
            dgvFuncionario.Columns["idfunc"].Visible = true;
            dgvFuncionario.Columns["nomefunc"].Visible = true;
            dgvFuncionario.Columns["sobrenomefunc"].Visible = true;
            dgvFuncionario.Columns["cpf"].Visible = false;
            dgvFuncionario.Columns["rua"].Visible = false;
            dgvFuncionario.Columns["numero"].Visible = false;
            dgvFuncionario.Columns["sigla"].Visible = false;
            dgvFuncionario.Columns["nome"].Visible = false;
            dgvFuncionario.Columns["bairro"].Visible = false;
            dgvFuncionario.Columns["cep"].Visible = false;
            dgvFuncionario.Columns["complemento"].Visible = false;
            dgvFuncionario.Columns["telefone"].Visible = false;
            dgvFuncionario.Columns["email"].Visible = false;
            dgvFuncionario.Columns["celular"].Visible = false;
            dgvFuncionario.Columns["nomesetor"].Visible = true;
            dgvFuncionario.Columns["nomecargo"].Visible = true;
            dgvFuncionario.Columns["salario"].Visible = false;
            dgvFuncionario.Columns["nomestatus"].Visible = true;

           


            //Configura o Tamanho da coluna
            dgvFuncionario.Columns[0].Width = 50;
            dgvFuncionario.Columns[1].Width = 200;
            dgvFuncionario.Columns[2].Width = 198;
            dgvFuncionario.Columns[3].Width = 110;
            dgvFuncionario.Columns[4].Width = 124;
            dgvFuncionario.Columns[5].Width = 90;
            dgvFuncionario.Columns[6].Width = 50;
            dgvFuncionario.Columns[7].Width = 200;
            dgvFuncionario.Columns[8].Width = 200;
            dgvFuncionario.Columns[9].Width = 110;
            dgvFuncionario.Columns[10].Width = 124;
            dgvFuncionario.Columns[11].Width = 90;
            dgvFuncionario.Columns[12].Width = 50;
            dgvFuncionario.Columns[13].Width = 200;
            dgvFuncionario.Columns[14].Width = 120;
            dgvFuncionario.Columns[15].Width = 118;
            dgvFuncionario.Columns[16].Width = 110;
            dgvFuncionario.Columns[17].Width = 88;

        }

        //Configuração dos componentes do formulario

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            btnNovoFunc.Enabled = true;
            valorbtn = 1;
            condicao = true;
            validaCamposFunc();
            //limparCampos();
        }

        private void dgvFuncionario_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtCodigoFunc.Text = dgvFuncionario.CurrentRow.Cells[0].Value.ToString();
                txtNomeFunc.Text = dgvFuncionario.CurrentRow.Cells[1].Value.ToString();
                txtSobrenomeFunc.Text = dgvFuncionario.CurrentRow.Cells[2].Value.ToString();
                txtCPFFunc.Text = dgvFuncionario.CurrentRow.Cells[3].Value.ToString();
                txtRuaFunc.Text = dgvFuncionario.CurrentRow.Cells[4].Value.ToString();
                txtNumeroFunc.Text = dgvFuncionario.CurrentRow.Cells[5].Value.ToString();
                cboEstadoFunc.Text = dgvFuncionario.CurrentRow.Cells[6].Value.ToString();
                cboCidadeFunc.Text = dgvFuncionario.CurrentRow.Cells[7].Value.ToString();
                txtBairroFunc.Text = dgvFuncionario.CurrentRow.Cells[8].Value.ToString();
                txtCEPFunc.Text = dgvFuncionario.CurrentRow.Cells[9].Value.ToString();
                cboComplementoFunc.Text = dgvFuncionario.CurrentRow.Cells[10].Value.ToString();
                txtTelefoneFunc.Text = dgvFuncionario.CurrentRow.Cells[11].Value.ToString();
                txtEmailFunc.Text = dgvFuncionario.CurrentRow.Cells[12].Value.ToString();
                txtCelularFunc.Text = dgvFuncionario.CurrentRow.Cells[13].Value.ToString();
                cboSetorFunc.Text = dgvFuncionario.CurrentRow.Cells[14].Value.ToString();
                cboCargoFunc.Text = dgvFuncionario.CurrentRow.Cells[15].Value.ToString();
                txtSalarioFunc.Text = dgvFuncionario.CurrentRow.Cells[16].Value.ToString();
                cboStatusFunc.Text = dgvFuncionario.CurrentRow.Cells[17].Value.ToString();

                //rtObsCli.Text = dgvCliente.CurrentRow.Cells[13].Value.ToString();

            }
            catch (Exception erro)
            {

            }
        }
          
        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            btnIncluirFunc.Enabled = false;
            btnAtualizarFunc.Enabled = false;
            btnLimparFunc.Enabled = false;
            btnEditarFunc.Enabled = false;
            desabilitaCamposFunc();
            PegarCidadeFunc();
            PegarEstadoFunc();
            PegarSetorFunc();
            PegarCargoFunc();
            PegarStatusFunc();


        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            campo = "nome";
            txtPesquisaFunc.Text = "";
        }

        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {

            campo = "cpf";
            txtPesquisaFunc.Text = "";
                
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCamposFunc();
            desabilitaCamposFunc();
            btnEditarFunc.Enabled = false;
            btnAtualizarFunc.Enabled = false;
            btnLimparFunc.Enabled = false;
            btnNovoFunc.Enabled = true;
        }
        
        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnNovoFunc.Enabled = false;
            btnEditarFunc.Enabled = false;
            btnIncluirFunc.Enabled = true;
            limparCamposFunc();
            btnLimparFunc.Enabled = false;
            habilitaCamposFunc();
            txtNomeFunc.Focus();

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dgvFuncionario.Enabled = false;
            btnIncluirFunc.Enabled = false;
            btnAtualizarFunc.Enabled = true;

            if (txtPesquisaFunc.Text != "")
            {
                dgvFuncionario.Enabled = true;
                atualizaDataGridViewFuncionario("Select * from Funcionario Where " + campo + " LIKE '" + txtPesquisaFunc.Text + "%'");
            }
            else
            {
                txtPesquisaFunc.Text = "";
                limparCamposFunc();
                txtPesquisaFunc.Focus();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            btnEditarFunc.Enabled = true;
            txtPesquisaFunc.Enabled = true;
            //btnNovoCli.Enabled = false;
            btnIncluirFunc.Enabled = false;
            atualizaDataGridViewFuncionario("select  f.idfunc, f.nomefunc, f.sobrenomefunc, f.cpf, ef.rua, ef.numero, e.Sigla, cd.nome, ef.bairro, ef.cep, ef.complemento, f.telefone, f.email, f.celular, s.nomesetor, cg.nomecargo, f.salario, sf.nomestatus from tbFuncionario f left join tbEndFunc ef on f.idfunc = ef.idfunc left join tbStatusFuncionario sf on f.codstatusfunc = sf.codstatusfunc left join Cidade cd on ef.cidadeid = cd.cidadeid left join Estado e on cd.EstadoId = e.EstadoId left join tbSetor s on f.idsetor = s.idsetor left join tbCargo cg on f.idcargo = cg.idcargo Where f.nomefunc LIKE '" + txtPesquisaFunc.Text + "%'");
            //limparCampos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            condicao = false;
            validaCamposFunc();
            limparCamposFunc();
        }
        //Capturando Somente Numeros no TextBox
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
        }
        //Capturando Somente Numeros no TextBox
        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void btnEditarFunc_Click(object sender, EventArgs e)
        {
            habilitaCamposFunc();
            btnLimparFunc.Enabled = true;
            btnAtualizarFunc.Enabled = true;
        }

        private void cboEstadoFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conectaBD());
            conexao.Open();

            try
            {
                SqlCommand Command = new SqlCommand("SELECT  cidadeid,nome FROM Cidade where Estadoid=" + cboEstadoFunc.SelectedIndex.ToString() + " ORDER BY nome", conexao);
                SqlDataReader reader = Command.ExecuteReader();
                DataTable Cidade = new DataTable("Cidade");
                Cidade.Load(reader);

                DataRow linha = Cidade.NewRow();
                linha["cidadeid"] = Convert.ToInt32(cboCidadeFunc.SelectedValue);
                linha["Nome"] = Convert.ToString(cboCidadeFunc.Text);
                Cidade.Rows.InsertAt(linha, 0);

                this.cboCidadeFunc.DataSource = Cidade;
                this.cboCidadeFunc.ValueMember = "cidadeid";
                this.cboCidadeFunc.DisplayMember = "Nome";

                reader.Close();
                reader.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex, "erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conexao.Close();
            }
        }
        
        public void PegarEstadoFunc()
        {
            SqlConnection conexao = new SqlConnection(conectaBD());
            conexao.Open();

            try
            {
                SqlCommand Command = new SqlCommand("SELECT  estadoid,sigla FROM Estado ORDER BY SIGLA", conexao);
                SqlDataReader reader = Command.ExecuteReader();
                DataTable Estado = new DataTable("Estado");
                Estado.Load(reader);

                DataRow linha = Estado.NewRow();
                linha["estadoid"] = Convert.ToInt32(cboEstadoFunc.SelectedValue);
                linha["Sigla"] = "";
                Estado.Rows.InsertAt(linha, 0);

                this.cboEstadoFunc.DataSource = Estado;
                this.cboEstadoFunc.ValueMember = "estadoid";
                this.cboEstadoFunc.DisplayMember = "Sigla";

                reader.Close();
                reader.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex, "erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conexao.Close();
            }

        }

        public void PegarCidadeFunc()
        {
            SqlConnection conexao = new SqlConnection(conectaBD());
            conexao.Open();

            try
            {
                SqlCommand Command = new SqlCommand("SELECT cidadeid,nome FROM Cidade ORDER BY nome ", conexao);
                SqlDataReader reader = Command.ExecuteReader();
                DataTable Cidade = new DataTable("Cidade");
                Cidade.Load(reader);

                DataRow linha = Cidade.NewRow();
                linha["cidadeid"] = Convert.ToInt32(cboEstadoFunc.SelectedValue);
                linha["nome"] = "";
                Cidade.Rows.InsertAt(linha, 0);

                this.cboCidadeFunc.DataSource = Cidade;
                this.cboCidadeFunc.ValueMember = "cidadeid";

                this.cboCidadeFunc.DisplayMember = "nome";

                reader.Close();
                reader.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex, "erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conexao.Close();
            }

        }

        public void PegarSetorFunc()
        {
            SqlConnection conexao = new SqlConnection(conectaBD());
            conexao.Open();

            try
            {
                SqlCommand Command = new SqlCommand("SELECT  idsetor,nomesetor FROM tbSetor ORDER BY nomesetor", conexao);
                SqlDataReader reader = Command.ExecuteReader();
                DataTable Setor = new DataTable("tbSetor");
                Setor.Load(reader);

                DataRow linha = Setor.NewRow();
                linha["idsetor"] = Convert.ToInt32(cboSetorFunc.SelectedValue);
                linha["nomesetor"] = "";
                Setor.Rows.InsertAt(linha, 0);

                this.cboSetorFunc.DataSource = Setor;
                this.cboSetorFunc.ValueMember = "idsetor";
                this.cboSetorFunc.DisplayMember = "nomesetor";

                reader.Close();
                reader.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex, "erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conexao.Close();
            }

        }

        public void PegarCargoFunc()
        {
            SqlConnection conexao = new SqlConnection(conectaBD());
            conexao.Open();

            try
            {
                SqlCommand Command = new SqlCommand("SELECT  idcargo,nomecargo FROM tbCargo ORDER BY nomecargo", conexao);
                SqlDataReader reader = Command.ExecuteReader();
                DataTable Cargo = new DataTable("tbCargo");
                Cargo.Load(reader);

                DataRow linha = Cargo.NewRow();
                linha["idcargo"] = Convert.ToInt32(cboCargoFunc.SelectedValue);
                linha["nomecargo"] = "";
                Cargo.Rows.InsertAt(linha, 0);

                this.cboCargoFunc.DataSource = Cargo;
                this.cboCargoFunc.ValueMember = "idcargo";
                this.cboCargoFunc.DisplayMember = "nomecargo";

                reader.Close();
                reader.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex, "erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conexao.Close();
            }

        }

        public void PegarStatusFunc()
        {
            SqlConnection conexao = new SqlConnection(conectaBD());
            conexao.Open();

            try
            {
                SqlCommand Command = new SqlCommand("SELECT  codstatusFunc,nomestatus FROM tbStatusFuncionario ORDER BY nomestatus", conexao);
                SqlDataReader reader = Command.ExecuteReader();
                DataTable Status = new DataTable("tbStatusFuncionario");
                Status.Load(reader);

                DataRow linha = Status.NewRow();
                linha["codStatusfunc"] = Convert.ToInt32(cboStatusFunc.SelectedValue);
                linha["nomestatus"] = "";
                Status.Rows.InsertAt(linha, 0);

                this.cboStatusFunc.DataSource = Status;
                this.cboStatusFunc.ValueMember = "codstatusfunc";
                this.cboStatusFunc.DisplayMember = "nomestatus";

                reader.Close();
                reader.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex, "erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conexao.Close();
            }

        }

        private void cboEstadoFunc_Click(object sender, EventArgs e)
        {
            PegarEstadoFunc();
        }

        private void cboSetorFunc_Click(object sender, EventArgs e)
        {
            PegarSetorFunc();
        }

        private void cboCargoFunc_Click(object sender, EventArgs e)
        {
            PegarCargoFunc();
        }

        private void cboStatusFunc_Click(object sender, EventArgs e)
        {
            PegarStatusFunc();
        }

    }
}
