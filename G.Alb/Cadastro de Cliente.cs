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
    public partial class frmCadastroCliente : Form
    {
        
        String campo = "nome";
        Boolean condicao;
        int valorbtn = 5;
        
        public frmCadastroCliente()
        {
            InitializeComponent();
        }


        //Métodos--------------------------------------------------------

        public string conectaBD()
        {
            return @"Data Source=PC-PV;Initial Catalog=Galb;Integrated Security=True";
        }

        private void habilitaCamposCliente()
        {
            txtCodigoCli.Enabled = true;
            txtNomeCli.Enabled = true;
            txtDocCli.Enabled = true;
            txtDocCli.Enabled = true;
            txtSnCli.Enabled = true;
            cboComplementoCli.Enabled = true;
            txtQuadraCli.Enabled = true;
            txtLoteCli.Enabled = true;
            txtRuaCli.Enabled = true;
            txtNumeroCli.Enabled = true;
            txtBairroCli.Enabled = true;
            txtCEPCli.Enabled = true;
            txtTelefoneCli.Enabled = true;
            txtEmailCli.Enabled = true;
            txtCelularCli.Enabled = true;
            txtPesquisaCli.Enabled = true;
            cbotipocli.Enabled = true;
            cboEstadoCli.Enabled = true;
            cboCidadeCli.Enabled = true;
            rbDocCli.Checked = true;
            rbDocCli.Enabled = true;
            rbNomeCli.Checked = true;
            rbNomeCli.Enabled = true;

        }

        private void desabilitaCamposCliente()
        {

            txtCodigoCli.Enabled = false;
            txtNomeCli.Enabled = false;
            txtDocCli.Enabled = false;
            txtDocCli.Enabled = false;
            txtSnCli.Enabled = false;
            cboComplementoCli.Enabled = false;
            txtQuadraCli.Enabled = false;
            txtLoteCli.Enabled = false;
            txtRuaCli.Enabled = false;
            txtNumeroCli.Enabled = false;
            txtBairroCli.Enabled = false;
            txtCEPCli.Enabled = false;
            txtTelefoneCli.Enabled = false;
            txtEmailCli.Enabled = false;
            txtCelularCli.Enabled = false;
            txtPesquisaCli.Enabled = false;
            rbDocCli.Checked = false;
            rbDocCli.Enabled = false;
            rbNomeCli.Checked = false;
            rbNomeCli.Enabled = false;

        }

        private void limparCamposCliente()
        {
            dgvCliente.DataSource = null;
            txtCodigoCli.Clear();
            txtNomeCli.Clear();
            txtDocCli.Clear();
            cbotipocli.SelectedIndex = 0;
            txtNomeCli.Clear();
            txtSnCli.Clear();
            txtEmailCli.Clear();
            txtCelularCli.Clear();
            txtNumeroCli.Clear();
            txtTelefoneCli.Clear();
            txtBairroCli.Clear();
            txtRuaCli.Clear();
            cboEstadoCli.SelectedIndex = 0;
            cboCidadeCli.SelectedItem = null;
            txtCEPCli.Clear();
            txtTelefoneCli.Clear();
            txtQuadraCli.Clear();
            cboComplementoCli.SelectedItem = null;
            txtLoteCli.Clear();
            //rbCPFCli.Checked = false;
            //rbNomeCli.Checked = false;

        }

        private void validaCamposCliente()
        {

            if (txtNomeCli.Text == "")
            {
                MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeCli.Focus();
            }

            else
            {
                if (txtRuaCli.Text == "")
                {
                    MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRuaCli.Focus();
                }
                else
                {
                    if (txtNomeCli.Text == "")
                    {
                        MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNomeCli.Focus();
                    }
                    else
                        if (txtSnCli.Text == "")
                        {
                            MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSnCli.Focus();
                        }

                        else
                        {
                            if (txtNumeroCli.Text == "")
                            {
                                MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtNumeroCli.Focus();
                            }
                            else
                            {
                                if (cbotipocli.Text == "")
                                {
                                    MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    cbotipocli.Focus();
                                }
                                else
                                {
                                    if (cboCidadeCli.Text == "")
                                    {
                                        MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cboCidadeCli.Focus();
                                    }

                                    else
                                    {
                                        if (txtBairroCli.Text == "")
                                        {
                                            MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            txtBairroCli.Focus();
                                        }
                                        else
                                        {
                                            if (txtCEPCli.Text == "")
                                            {
                                                MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                txtCEPCli.Focus();
                                            }
                                            else
                                            {
                                                if (cboEstadoCli.Text == "")
                                                {
                                                    MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    cboEstadoCli.Focus();
                                                }
                                                else
                                                {
                                                    if (txtTelefoneCli.Text == "")
                                                    {
                                                        MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        txtTelefoneCli.Focus();
                                                    }
                                                    else
                                                    {
                                                        if (txtEmailCli.Text == "")
                                                        {
                                                            MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            txtEmailCli.Focus();
                                                        }
                                                        else
                                                        {
                                                            if (txtCelularCli.Text == "")
                                                            {
                                                                MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                txtCelularCli.Focus();
                                                            }
                                                            else
                                                            {
                                                                if (txtBairroCli.Text == "")
                                                                {
                                                                    MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                    txtBairroCli.Focus();
                                                                }
                                                                else
                                                                {
                                                                    if (cboComplementoCli.Text == "")
                                                                    {
                                                                        MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                        cboComplementoCli.Focus();
                                                                    }
                                                                    else
                                                                    {
                                                                        if (txtQuadraCli.Text == "")
                                                                        {
                                                                            MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                            txtQuadraCli.Focus();
                                                                        }
                                                                        else
                                                                        {
                                                                            if (txtLoteCli.Text == "")
                                                                            {
                                                                                MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                                txtLoteCli.Focus();
                                                                            }
                                                                            else
                                                                            {
                                                                                if(txtDocCli.Text == "")
                                                                                {
                                                                                    MessageBox.Show("Campo não preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                                    txtDocCli.Focus();
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (condicao == true)
                                                                                    {
                                                                                        incluiCliente();
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        atualizaCliente();
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
               
        private void incluiCliente()
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

            /*cmd = new SqlCommand("INSERT INTO Cliente values('" + txtNomeCli.Text + "','" + txtRGCli.Text + "','" + txtCPFCli.Text + "','" + txtEnderecoCli.Text +
            "','" + txtNumeroCli.Text + "','" + txtBairroCli.Text + "','" + txtCidadeCli.Text + "','" + cboEstadoCli.SelectedItem.ToString() + "','" + txtCEPCli.Text +
            "','" + txtTelefoneCli.Text + "','" + txtCelularCli.Text + "','" + txtEmailCli.Text + "','" + rtObsCli.Text + "')", cnx);*/

                  cmd = new SqlCommand("[dbo].[SP_MANTERCLI]", cnx);
                  cmd.CommandType = CommandType.StoredProcedure;
                  cmd.Parameters.Add(new SqlParameter("@ACAO", SqlDbType.Int)).Value = valorbtn;
                  cmd.Parameters.Add(new SqlParameter("@IDTIPOCLI", SqlDbType.Int)).Value = Convert.ToInt32(cbotipocli.SelectedValue);
                  cmd.Parameters.Add(new SqlParameter("@IDTIPODOC", SqlDbType.Int)).Value = Convert.ToInt32(cbotipocli.SelectedIndex);
                  cmd.Parameters.Add(new SqlParameter("@NOMECLI", SqlDbType.VarChar)).Value = txtNomeCli.Text;
                  cmd.Parameters.Add(new SqlParameter("@SNCLI", SqlDbType.VarChar)).Value = txtSnCli.Text;
                  cmd.Parameters.Add(new SqlParameter("@DOCCLI", SqlDbType.VarChar)).Value = txtDocCli.Text;
                  cmd.Parameters.Add(new SqlParameter("@TELCLI", SqlDbType.VarChar)).Value = txtTelefoneCli.Text;
                  cmd.Parameters.Add(new SqlParameter("@CELCLI", SqlDbType.VarChar)).Value = txtCelularCli.Text;
                  cmd.Parameters.Add(new SqlParameter("@EMAILCLI", SqlDbType.VarChar)).Value = txtEmailCli.Text;
                  cmd.Parameters.Add(new SqlParameter("@CODSTATUSCLI", SqlDbType.Int)).Value = 1;
                  cmd.Parameters.Add(new SqlParameter("@CIDADEID", SqlDbType.Int)).Value = Convert.ToInt32(cboCidadeCli.SelectedValue);
                  cmd.Parameters.Add(new SqlParameter("@CIDADE", SqlDbType.VarChar)).Value = null;
                  cmd.Parameters.Add(new SqlParameter("@RUA", SqlDbType.VarChar)).Value = txtRuaCli.Text;
                  cmd.Parameters.Add(new SqlParameter("@NUMERO", SqlDbType.Int)).Value = txtNumeroCli.Text;
                  cmd.Parameters.Add(new SqlParameter("@CEP", SqlDbType.VarChar)).Value = txtCEPCli.Text;
                  cmd.Parameters.Add(new SqlParameter("BAIRRO", SqlDbType.VarChar)).Value = txtBairroCli.Text;
                  cmd.Parameters.Add(new SqlParameter("@COMPLEMENTO", SqlDbType.VarChar)).Value = cboComplementoCli.SelectedValue;
                  cmd.Parameters.Add(new SqlParameter("@QUADRA", SqlDbType.VarChar)).Value = txtQuadraCli.Text;
                  cmd.Parameters.Add(new SqlParameter("@LOTE", SqlDbType.VarChar)).Value = txtLoteCli.Text;
                  cmd.Parameters.Add(new SqlParameter("@IDCLI", SqlDbType.Int)).Value = null;
                  //cnx.Open();
                  //cmd.ExecuteNonQuery();

                 //var returnValue = cmd.ExecuteReader(); //Retorna a linha que foi executada


            try
            {
                int linhasAfetadas = cmd.ExecuteNonQuery(); //Quantidade de registros incluidos

                if (linhasAfetadas > 1)
                {
                    cnx.Close();
                    MessageBox.Show("Cliente incluido com sucesso!", "Sucesso" + MessageBoxButtons.OK);
                    btnIncluirCli.Enabled = false;
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

            //atualizaDataGridViewCliente("Select * from Cliente order by nome");

        }

        private void atualizaCliente()
        {

            SqlConnection cnx = new SqlConnection(conectaBD());
            cnx.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;

            //cmd.CommandText = "UPDATE Cliente SET nome= @nome, rg= @rg, cpf= @cpf, endereco= @endereco, numero= @numero, bairro= @bairro, cidade= @cidade, estado= @estado, cep= @cep, telefone= @telefone, celular= @celular, email= @email, observacao= @observacao WHERE id_cliente= @codigo";

           // cmd.Parameters.AddWithValue("@codigo", Convert.ToInt32(this.txtCodigoCli.Text));
           // cmd.Parameters.AddWithValue("@nome", this.txtNomeCli.Text);
           //// cmd.Parameters.AddWithValue("@rg", this.txtRGCli.Text);
           // cmd.Parameters.AddWithValue("@cpf", this.txtDocCli.Text);
           // cmd.Parameters.AddWithValue("@endereco", this.txtRuaCli.Text);
           //  cmd.Parameters.AddWithValue("@numero", Convert.ToInt32(this.txtNumeroCli.Text));
           // cmd.Parameters.AddWithValue("@bairro", this.txtBairroCli.Text);
           // //cmd.Parameters.AddWithValue("@cidade", this.txtCidadeCli.Text);
           // cmd.Parameters.AddWithValue("@estado", this.cboEstadoCli.SelectedItem);
           // cmd.Parameters.AddWithValue("@cep", this.txtCEPCli.Text);
           // cmd.Parameters.AddWithValue("@telefone", this.txtTelefoneCli.Text);
           // cmd.Parameters.AddWithValue("@email", this.txtEmailCli.Text);
           // cmd.Parameters.AddWithValue("@celular", this.txtCelularCli.Text);
           // //cmd.Parameters.AddWithValue("@observacao", this.rtObsCli.Text);


            cmd = new SqlCommand("[dbo].[SP_MANTERCLI]", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ACAO", SqlDbType.Int)).Value = Convert.ToInt32(valorbtn);
            cmd.Parameters.Add(new SqlParameter("@IDTIPOCLI", SqlDbType.Int)).Value = Convert.ToInt32(cbotipocli.SelectedIndex);
            cmd.Parameters.Add(new SqlParameter("@IDTIPODOC", SqlDbType.Int)).Value = Convert.ToInt32(cbotipocli.SelectedIndex);
            cmd.Parameters.AddWithValue("@NOMECLI", this.txtNomeCli.Text);
            cmd.Parameters.AddWithValue("@SNCLI", this.txtSnCli.Text);
            cmd.Parameters.AddWithValue("@DOCCLI", this.txtDocCli.Text);
            cmd.Parameters.AddWithValue("@TELCLI", this.txtTelefoneCli.Text);
            cmd.Parameters.AddWithValue("@CELCLI", this.txtCelularCli.Text);
            cmd.Parameters.AddWithValue("@EMAILCLI", this.txtEmailCli.Text);
            //cmd.Parameters.AddWithValue("@CODSTATUSCLI", SqlDbType.Int)).Value = 1;
            cmd.Parameters.AddWithValue("@CIDADEID", this.cboCidadeCli.SelectedValue);
            //cmd.Parameters.AddWithValue("@CIDADE", SqlDbType.VarChar)).Value = null;
            cmd.Parameters.AddWithValue("@RUA", this.txtRuaCli.Text);
            cmd.Parameters.AddWithValue("@NUMERO", this.txtNumeroCli.Text);
            cmd.Parameters.AddWithValue("@CEP", this.txtCEPCli.Text);
            cmd.Parameters.AddWithValue("BAIRRO", this.txtBairroCli.Text);
            cmd.Parameters.AddWithValue("@COMPLEMENTO", this.cboComplementoCli.Text);
            cmd.Parameters.AddWithValue("@QUADRA", this.txtQuadraCli.Text);
            cmd.Parameters.AddWithValue("@LOTE", this.txtLoteCli.Text);
            cmd.Parameters.AddWithValue("@IDCLI", SqlDbType.Int).Value = Convert.ToInt32(txtCodigoCli.Text);

            try
            {
                int linhasAfetadas = cmd.ExecuteNonQuery(); //Quantidade de registros incluidos

                if (linhasAfetadas == 1)
                {
                    cnx.Close();
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
                cnx.Close();
            }

            //atualizaDataGridViewCliente("Select * from Cliente order by nome");

        }

        public void atualizaDataGridViewCliente(String comandoSQL)
        {
            SqlConnection conexao = new SqlConnection(conectaBD());

            try
            {
                conexao.Open();
                SqlCommand sql = new SqlCommand(comandoSQL, conexao);
                SqlDataAdapter da = new SqlDataAdapter(sql);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvCliente.DataSource = ds;
                dgvCliente.DataMember = ds.Tables[0].TableName;
                dgvCliente.AllowUserToAddRows = false;
                configuraDatagridViewCliente();


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

        private void configuraDatagridViewCliente()
        {

            //Renomeia as Colunas do DataGrid
            dgvCliente.Columns[0].HeaderText = "Codigo";
            dgvCliente.Columns[1].HeaderText = "Tipo";
            dgvCliente.Columns[2].HeaderText = "Documento";
            dgvCliente.Columns[3].HeaderText = "Nome";
            dgvCliente.Columns[4].HeaderText = "Sobrenome";
            dgvCliente.Columns[5].HeaderText = "Telefone";
            dgvCliente.Columns[6].HeaderText = "Email";
            dgvCliente.Columns[7].HeaderText = "Celular";
            dgvCliente.Columns[8].HeaderText = "Estado";
            dgvCliente.Columns[9].HeaderText = "Cidade";
            dgvCliente.Columns[10].HeaderText = "Bairro";
            dgvCliente.Columns[11].HeaderText = "Rua";
            dgvCliente.Columns[12].HeaderText = "Numero";
            dgvCliente.Columns[13].HeaderText = "CEP";
            dgvCliente.Columns[14].HeaderText = "Complemento";
            dgvCliente.Columns[15].HeaderText = "Quadra";
            dgvCliente.Columns[16].HeaderText = "Lote";





            //Desabilita Colunas do DataGridView
            dgvCliente.Columns["idcli"].Visible = true;
            dgvCliente.Columns["descricao"].Visible = true;
            dgvCliente.Columns["doccli"].Visible = true;
            dgvCliente.Columns["nomecli"].Visible = true;
            dgvCliente.Columns["sncli"].Visible = true;
            dgvCliente.Columns["telcli"].Visible = true;
            dgvCliente.Columns["emailcli"].Visible = true;
            dgvCliente.Columns["celcli"].Visible = true;
            dgvCliente.Columns["sigla"].Visible = false;
            dgvCliente.Columns["nome"].Visible = true;
            dgvCliente.Columns["bairro"].Visible = false;
            dgvCliente.Columns["rua"].Visible = false;
            dgvCliente.Columns["numero"].Visible = false;
            dgvCliente.Columns["cep"].Visible = false;
            dgvCliente.Columns["complemento"].Visible = false;
            dgvCliente.Columns["quadra"].Visible = false;
            dgvCliente.Columns["lote"].Visible = false;


            //Configura o Tamanho da coluna
            dgvCliente.Columns[0].Width = 30;
            dgvCliente.Columns[1].Width = 60;
            dgvCliente.Columns[2].Width = 100;
            dgvCliente.Columns[3].Width = 100;
            dgvCliente.Columns[4].Width = 140;
            dgvCliente.Columns[5].Width = 100;
            dgvCliente.Columns[6].Width = 100;
            dgvCliente.Columns[7].Width = 100;
            dgvCliente.Columns[8].Width = 60;
            dgvCliente.Columns[9].Width = 150;
            dgvCliente.Columns[10].Width = 30;
            dgvCliente.Columns[11].Width = 150;
            dgvCliente.Columns[12].Width = 150;
            dgvCliente.Columns[13].Width = 100;
            dgvCliente.Columns[14].Width = 140;
            dgvCliente.Columns[15].Width = 30;
            dgvCliente.Columns[16].Width = 100;
       

        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            btnIncluirCli.Enabled = false;
            btnConfirmarCli.Enabled = false;
            btnLimparCli.Enabled = false;
            btnEditarCli.Enabled = false;
            desabilitaCamposCliente();
            PegarCidadeCli();
            PegarEstadoCli();
            PegarTipoDoc();
        }

        private void btnListarCli_Click(object sender, EventArgs e)
        {
            btnEditarCli.Enabled = true;
            rbDocCli.Enabled = true;
            rbNomeCli.Enabled = true;
            txtPesquisaCli.Enabled = true;
            //btnNovoCli.Enabled = false;
            btnIncluirCli.Enabled = false;
            atualizaDataGridViewCliente("select  c.idcli,tc.descricao,c.doccli,c.nomecli,c.sncli,c.telcli,c.emailcli,c.celcli,e.Sigla,cd.nome,ec.bairro,ec.rua,ec.numero,ec.cep,ec.complemento,ec.quadra,ec.lote from tbcliente c left join tbEndCli ec on c.idcli = ec.idcli left join Cidade cd on ec.cidadeid = cd.cidadeid left join Estado e on cd.EstadoId = e.EstadoId left join tbTipoCliente tc on c.idtipocli = tc.idtipocli Where c.nomecli LIKE '" + txtPesquisaCli.Text + "%'");
            //limparCampos();
        }

        private void btnIncluirCli_Click(object sender, EventArgs e)
        {
            btnNovoCli.Enabled = true;
            valorbtn = 1;
            condicao = true;
            validaCamposCliente();
            //limparCampos();
        }

        private void rbNomeCli_CheckedChanged(object sender, EventArgs e)
        {
            campo = "nomecli";
            txtPesquisaCli.Text = "";
        }

        private void rbCPFCli_CheckedChanged(object sender, EventArgs e)
        {
            campo = "doccli";
            txtPesquisaCli.Text = "";
        }

        private void btnLimparCli_Click(object sender, EventArgs e)
        {
            limparCamposCliente();
            desabilitaCamposCliente();
            btnEditarCli.Enabled = false;
            btnConfirmarCli.Enabled = false;
            btnLimparCli.Enabled = false;
            btnNovoCli.Enabled = true;
        }

        private void btnNovoCli_Click(object sender, EventArgs e)
        {
            btnNovoCli.Enabled = false;
            btnEditarCli.Enabled = false;
            btnIncluirCli.Enabled = true;
            limparCamposCliente();
            btnLimparCli.Enabled = true;
            habilitaCamposCliente();
            txtNomeCli.Focus();
        }

        private void txtPesquisaCli_TextChanged(object sender, EventArgs e)
        {
            //dgvCliente.Enabled = false;
            //btnIncluirCli.Enabled = false;
            btnConfirmarCli.Enabled = true;

            if (txtPesquisaCli.Text != "")
            {
                dgvCliente.Enabled = true;
                atualizaDataGridViewCliente("select  c.idcli,tc.descricao,c.doccli,c.nomecli,c.sncli,c.telcli,c.emailcli,c.celcli,e.Sigla,cd.nome,ec.bairro,ec.rua,ec.numero,ec.cep,ec.complemento,ec.quadra,ec.lote from tbcliente c left join tbEndCli ec on c.idcli = ec.idcli left join Cidade cd on ec.cidadeid = cd.cidadeid left join Estado e on cd.EstadoId = e.EstadoId left join tbTipoCliente tc on c.idtipocli = tc.idtipocli Where "+ campo +" LIKE '" + txtPesquisaCli.Text + "%'");
            }
            else
            {
                txtPesquisaCli.Text = "";
                limparCamposCliente();
                txtPesquisaCli.Focus();
            }
        }

        private void btnAtualizarCli_Click(object sender, EventArgs e)
        {
            valorbtn = 2;
            condicao = false;
            validaCamposCliente();
            atualizaDataGridViewCliente("select  c.idcli,tc.descricao,c.doccli,c.nomecli,c.sncli,c.telcli,c.emailcli,c.celcli,e.Sigla,cd.nome,ec.bairro,ec.rua,ec.numero,ec.cep,ec.complemento,ec.quadra,ec.lote from tbcliente c left join tbEndCli ec on c.idcli = ec.idcli left join Cidade cd on ec.cidadeid = cd.cidadeid left join Estado e on cd.EstadoId = e.EstadoId left join tbTipoCliente tc on c.idtipocli = tc.idtipocli Where " + campo + " LIKE '" + txtPesquisaCli.Text + "%'");
            desabilitaCamposCliente();
            btnConfirmarCli.Enabled = false;
        }

        private void txtNumeroCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void dgvCliente_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtCodigoCli.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();
                cbotipocli.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
                txtDocCli.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
                txtNomeCli.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
                txtSnCli.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
                txtTelefoneCli.Text = dgvCliente.CurrentRow.Cells[5].Value.ToString();
                txtEmailCli.Text = dgvCliente.CurrentRow.Cells[6].Value.ToString();
                txtCelularCli.Text = dgvCliente.CurrentRow.Cells[7].Value.ToString();
                cboEstadoCli.Text = dgvCliente.CurrentRow.Cells[8].Value.ToString();
                cboCidadeCli.Text = dgvCliente.CurrentRow.Cells[9].Value.ToString();
                txtBairroCli.Text = dgvCliente.CurrentRow.Cells[10].Value.ToString();
                txtRuaCli.Text = dgvCliente.CurrentRow.Cells[11].Value.ToString();
                txtNumeroCli.Text = dgvCliente.CurrentRow.Cells[12].Value.ToString();
                txtCEPCli.Text = dgvCliente.CurrentRow.Cells[13].Value.ToString();
                cboComplementoCli.Text = dgvCliente.CurrentRow.Cells[14].Value.ToString();
                txtQuadraCli.Text = dgvCliente.CurrentRow.Cells[15].Value.ToString();
                txtLoteCli.Text = dgvCliente.CurrentRow.Cells[16].Value.ToString();

                //rtObsCli.Text = dgvCliente.CurrentRow.Cells[13].Value.ToString();

            }
            catch (Exception erro)
            {

            }
        }

        public void PegarEstadoCli()
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
                linha["estadoid"] = Convert.ToInt32(cboEstadoCli.SelectedValue);
                linha["Sigla"] = "";
                Estado.Rows.InsertAt(linha, 0);

                this.cboEstadoCli.DataSource = Estado;
                this.cboEstadoCli.ValueMember = "estadoid";
                this.cboEstadoCli.DisplayMember = "Sigla";

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

        public void PegarCidadeCli()
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
                linha["cidadeid"] = Convert.ToInt32(cboEstadoCli.SelectedValue);
                linha["nome"] = "";
                Cidade.Rows.InsertAt(linha, 0);

                this.cboCidadeCli.DataSource = Cidade;
                this.cboCidadeCli.ValueMember = "cidadeid";

                this.cboCidadeCli.DisplayMember = "nome";

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

        public void PegarTipoDoc()
        {
            SqlConnection conexao = new SqlConnection(conectaBD());
            conexao.Open();

            try
            {
                SqlCommand Command = new SqlCommand("SELECT  idtipocli,descricao FROM tbTipoCliente ORDER BY descricao", conexao);
                SqlDataReader reader = Command.ExecuteReader();
                DataTable Estado = new DataTable("tbTipoCliente");
                Estado.Load(reader);

                DataRow linha = Estado.NewRow();
                linha["idtipocli"] = Convert.ToInt32(cbotipocli.SelectedValue);
                linha["descricao"] = "";
                Estado.Rows.InsertAt(linha, 0);

                this.cbotipocli.DataSource = Estado;
                this.cbotipocli.ValueMember = "idtipocli";
                this.cbotipocli.DisplayMember = "descricao";

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

        private void cboCidadeCli_Click(object sender, EventArgs e)
        {
            //PegarCidadeCli();
        }

        private void cboEstadoCli_Click(object sender, EventArgs e)
        {
            PegarEstadoCli();
        }

        private void cboEstadoCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conectaBD());
            conexao.Open();

            try
            {
                SqlCommand Command = new SqlCommand("SELECT  cidadeid,nome FROM Cidade where Estadoid=" + cboEstadoCli.SelectedIndex.ToString() + " ORDER BY nome", conexao);
                SqlDataReader reader = Command.ExecuteReader();
                DataTable Cidade = new DataTable("Cidade");
                Cidade.Load(reader);

                DataRow linha = Cidade.NewRow();
                linha["cidadeid"] = Convert.ToInt32(cboCidadeCli.SelectedValue);
                linha["Nome"] = Convert.ToString(cboCidadeCli.Text);
                Cidade.Rows.InsertAt(linha, 0);

                this.cboCidadeCli.DataSource = Cidade;
                this.cboCidadeCli.ValueMember = "cidadeid";
                this.cboCidadeCli.DisplayMember = "Nome";

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

        private void cbotipocli_Click(object sender, EventArgs e)
        {
            PegarTipoDoc();
        }

        private void cbotipocli_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbotipocli.SelectedIndex == 2)
            {

                txtDocCli.Mask = "00,000,000/0000-00"; //Mascara para CPF

            }
            else
            {
                if (cbotipocli.SelectedIndex == 1)
                {
                    txtDocCli.Mask = "000,000,000-00"; //Mascara para CPF
                }

            }
        }

        private void btnEditarCli_Click(object sender, EventArgs e)
        {
            habilitaCamposCliente();
            btnLimparCli.Enabled = true;
            btnConfirmarCli.Enabled = true;
        }

        private void dgvCliente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

foreach (DataGridViewRow row in dgvCliente.Rows)
{
     if (Convert.ToInt32(row.Cells[0].Value) %2 == 0 ) 
     {
         // Se for negativo, fica vermelho
         row.DefaultCellStyle.BackColor = Color.Azure; 
     }
}

        }
    }
}
