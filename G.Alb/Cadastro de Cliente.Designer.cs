namespace G.Alb
{
    partial class frmCadastroCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.btnNovoCli = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDocCli = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbotipocli = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtEmailCli = new System.Windows.Forms.TextBox();
            this.txtTelefoneCli = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSnCli = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCelularCli = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodigoCli = new System.Windows.Forms.TextBox();
            this.btnConfirmarCli = new System.Windows.Forms.Button();
            this.btnIncluirCli = new System.Windows.Forms.Button();
            this.btnLimparCli = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditarCli = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbNomeCli = new System.Windows.Forms.RadioButton();
            this.rbDocCli = new System.Windows.Forms.RadioButton();
            this.txtPesquisaCli = new System.Windows.Forms.TextBox();
            this.btnListarCli = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBairroCli = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRuaCli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNumeroCli = new System.Windows.Forms.TextBox();
            this.txtCEPCli = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCidadeCli = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cboEstadoCli = new System.Windows.Forms.ComboBox();
            this.txtLoteCli = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtQuadraCli = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.cboComplementoCli = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "NOME:";
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Location = new System.Drawing.Point(97, 102);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(229, 20);
            this.txtNomeCli.TabIndex = 1;
            // 
            // btnNovoCli
            // 
            this.btnNovoCli.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoCli.Image")));
            this.btnNovoCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoCli.Location = new System.Drawing.Point(3, 1);
            this.btnNovoCli.Name = "btnNovoCli";
            this.btnNovoCli.Size = new System.Drawing.Size(56, 32);
            this.btnNovoCli.TabIndex = 1;
            this.btnNovoCli.Text = "Novo";
            this.btnNovoCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoCli.UseVisualStyleBackColor = true;
            this.btnNovoCli.Click += new System.EventHandler(this.btnNovoCli_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDocCli);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbotipocli);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtEmailCli);
            this.groupBox2.Controls.Add(this.txtTelefoneCli);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSnCli);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCelularCli);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNomeCli);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtCodigoCli);
            this.groupBox2.Location = new System.Drawing.Point(3, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 245);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Gerais";
            // 
            // txtDocCli
            // 
            this.txtDocCli.Location = new System.Drawing.Point(97, 77);
            this.txtDocCli.Mask = "00,000,000/0000-00";
            this.txtDocCli.Name = "txtDocCli";
            this.txtDocCli.Size = new System.Drawing.Size(229, 20);
            this.txtDocCli.TabIndex = 126;
            this.txtDocCli.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 125;
            this.label8.Text = "DOCUMENTO:";
            // 
            // cbotipocli
            // 
            this.cbotipocli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipocli.FormattingEnabled = true;
            this.cbotipocli.Items.AddRange(new object[] {
            ""});
            this.cbotipocli.Location = new System.Drawing.Point(97, 50);
            this.cbotipocli.Name = "cbotipocli";
            this.cbotipocli.Size = new System.Drawing.Size(107, 21);
            this.cbotipocli.TabIndex = 124;
            this.cbotipocli.SelectedIndexChanged += new System.EventHandler(this.cbotipocli_SelectedIndexChanged);
            this.cbotipocli.Click += new System.EventHandler(this.cbotipocli_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 123;
            this.label19.Text = "TIPO:";
            // 
            // txtEmailCli
            // 
            this.txtEmailCli.Location = new System.Drawing.Point(98, 180);
            this.txtEmailCli.Name = "txtEmailCli";
            this.txtEmailCli.Size = new System.Drawing.Size(228, 20);
            this.txtEmailCli.TabIndex = 95;
            // 
            // txtTelefoneCli
            // 
            this.txtTelefoneCli.Location = new System.Drawing.Point(98, 154);
            this.txtTelefoneCli.Mask = "(00) 0000-0000";
            this.txtTelefoneCli.Name = "txtTelefoneCli";
            this.txtTelefoneCli.Size = new System.Drawing.Size(228, 20);
            this.txtTelefoneCli.TabIndex = 94;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 81;
            this.label11.Text = "SOBRENOME:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 97;
            this.label5.Text = "TELEFONE:";
            // 
            // txtSnCli
            // 
            this.txtSnCli.Location = new System.Drawing.Point(97, 128);
            this.txtSnCli.Name = "txtSnCli";
            this.txtSnCli.Size = new System.Drawing.Size(230, 20);
            this.txtSnCli.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 98;
            this.label6.Text = "CELULAR:";
            // 
            // txtCelularCli
            // 
            this.txtCelularCli.Location = new System.Drawing.Point(98, 205);
            this.txtCelularCli.Mask = "(00) 0000-0000";
            this.txtCelularCli.Name = "txtCelularCli";
            this.txtCelularCli.Size = new System.Drawing.Size(228, 20);
            this.txtCelularCli.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 99;
            this.label7.Text = "EMAIL:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 93;
            this.label10.Text = "COD.";
            // 
            // txtCodigoCli
            // 
            this.txtCodigoCli.Enabled = false;
            this.txtCodigoCli.Location = new System.Drawing.Point(98, 25);
            this.txtCodigoCli.Name = "txtCodigoCli";
            this.txtCodigoCli.ReadOnly = true;
            this.txtCodigoCli.Size = new System.Drawing.Size(36, 20);
            this.txtCodigoCli.TabIndex = 0;
            // 
            // btnConfirmarCli
            // 
            this.btnConfirmarCli.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmarCli.Image")));
            this.btnConfirmarCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmarCli.Location = new System.Drawing.Point(284, 1);
            this.btnConfirmarCli.Name = "btnConfirmarCli";
            this.btnConfirmarCli.Size = new System.Drawing.Size(80, 32);
            this.btnConfirmarCli.TabIndex = 5;
            this.btnConfirmarCli.Text = "Confirmar";
            this.btnConfirmarCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmarCli.UseVisualStyleBackColor = true;
            this.btnConfirmarCli.Click += new System.EventHandler(this.btnAtualizarCli_Click);
            // 
            // btnIncluirCli
            // 
            this.btnIncluirCli.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluirCli.Image")));
            this.btnIncluirCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluirCli.Location = new System.Drawing.Point(65, 1);
            this.btnIncluirCli.Name = "btnIncluirCli";
            this.btnIncluirCli.Size = new System.Drawing.Size(62, 32);
            this.btnIncluirCli.TabIndex = 6;
            this.btnIncluirCli.Text = "Incluir";
            this.btnIncluirCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluirCli.UseVisualStyleBackColor = true;
            this.btnIncluirCli.Click += new System.EventHandler(this.btnIncluirCli_Click);
            // 
            // btnLimparCli
            // 
            this.btnLimparCli.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparCli.Image")));
            this.btnLimparCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparCli.Location = new System.Drawing.Point(203, 1);
            this.btnLimparCli.Name = "btnLimparCli";
            this.btnLimparCli.Size = new System.Drawing.Size(75, 32);
            this.btnLimparCli.TabIndex = 7;
            this.btnLimparCli.Text = "Cancelar";
            this.btnLimparCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparCli.UseVisualStyleBackColor = true;
            this.btnLimparCli.Click += new System.EventHandler(this.btnLimparCli_Click);
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCliente.Location = new System.Drawing.Point(6, 19);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(831, 467);
            this.dgvCliente.TabIndex = 0;
            this.dgvCliente.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCliente_CellFormatting);
            this.dgvCliente.SelectionChanged += new System.EventHandler(this.dgvCliente_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnEditarCli);
            this.panel1.Controls.Add(this.btnNovoCli);
            this.panel1.Controls.Add(this.btnLimparCli);
            this.panel1.Controls.Add(this.btnIncluirCli);
            this.panel1.Controls.Add(this.btnConfirmarCli);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 35);
            this.panel1.TabIndex = 8;
            // 
            // btnEditarCli
            // 
            this.btnEditarCli.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarCli.Image")));
            this.btnEditarCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCli.Location = new System.Drawing.Point(132, 1);
            this.btnEditarCli.Name = "btnEditarCli";
            this.btnEditarCli.Size = new System.Drawing.Size(65, 32);
            this.btnEditarCli.TabIndex = 8;
            this.btnEditarCli.Text = "Editar";
            this.btnEditarCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarCli.UseVisualStyleBackColor = true;
            this.btnEditarCli.Click += new System.EventHandler(this.btnEditarCli_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvCliente);
            this.groupBox4.Location = new System.Drawing.Point(360, 98);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(844, 486);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Clientes Cadastrados";
            // 
            // rbNomeCli
            // 
            this.rbNomeCli.AutoSize = true;
            this.rbNomeCli.Location = new System.Drawing.Point(9, 16);
            this.rbNomeCli.Name = "rbNomeCli";
            this.rbNomeCli.Size = new System.Drawing.Size(58, 19);
            this.rbNomeCli.TabIndex = 17;
            this.rbNomeCli.TabStop = true;
            this.rbNomeCli.Text = "NOME";
            this.rbNomeCli.UseVisualStyleBackColor = true;
            this.rbNomeCli.CheckedChanged += new System.EventHandler(this.rbNomeCli_CheckedChanged);
            // 
            // rbDocCli
            // 
            this.rbDocCli.AutoSize = true;
            this.rbDocCli.Location = new System.Drawing.Point(95, 15);
            this.rbDocCli.Name = "rbDocCli";
            this.rbDocCli.Size = new System.Drawing.Size(45, 19);
            this.rbDocCli.TabIndex = 18;
            this.rbDocCli.TabStop = true;
            this.rbDocCli.Text = "CPF";
            this.rbDocCli.UseVisualStyleBackColor = true;
            this.rbDocCli.CheckedChanged += new System.EventHandler(this.rbCPFCli_CheckedChanged);
            // 
            // txtPesquisaCli
            // 
            this.txtPesquisaCli.Location = new System.Drawing.Point(147, 15);
            this.txtPesquisaCli.Name = "txtPesquisaCli";
            this.txtPesquisaCli.Size = new System.Drawing.Size(167, 22);
            this.txtPesquisaCli.TabIndex = 19;
            this.txtPesquisaCli.TextChanged += new System.EventHandler(this.txtPesquisaCli_TextChanged);
            // 
            // btnListarCli
            // 
            this.btnListarCli.Image = ((System.Drawing.Image)(resources.GetObject("btnListarCli.Image")));
            this.btnListarCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarCli.Location = new System.Drawing.Point(318, 14);
            this.btnListarCli.Name = "btnListarCli";
            this.btnListarCli.Size = new System.Drawing.Size(75, 23);
            this.btnListarCli.TabIndex = 20;
            this.btnListarCli.Text = "Listar";
            this.btnListarCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListarCli.UseVisualStyleBackColor = true;
            this.btnListarCli.Click += new System.EventHandler(this.btnListarCli_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnListarCli);
            this.groupBox3.Controls.Add(this.txtPesquisaCli);
            this.groupBox3.Controls.Add(this.rbDocCli);
            this.groupBox3.Controls.Add(this.rbNomeCli);
            this.groupBox3.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(360, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 44);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisa por:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 124;
            this.label12.Text = "BAIRRO:";
            // 
            // txtBairroCli
            // 
            this.txtBairroCli.Location = new System.Drawing.Point(90, 81);
            this.txtBairroCli.Name = "txtBairroCli";
            this.txtBairroCli.Size = new System.Drawing.Size(229, 20);
            this.txtBairroCli.TabIndex = 117;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 125;
            this.label14.Text = "ESTADO:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 126;
            this.label13.Text = "CEP:";
            // 
            // txtRuaCli
            // 
            this.txtRuaCli.Location = new System.Drawing.Point(90, 110);
            this.txtRuaCli.Name = "txtRuaCli";
            this.txtRuaCli.Size = new System.Drawing.Size(229, 20);
            this.txtRuaCli.TabIndex = 114;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 121;
            this.label2.Text = "RUA:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 13);
            this.label16.TabIndex = 127;
            this.label16.Text = "Nº:";
            // 
            // txtNumeroCli
            // 
            this.txtNumeroCli.Location = new System.Drawing.Point(90, 136);
            this.txtNumeroCli.Name = "txtNumeroCli";
            this.txtNumeroCli.Size = new System.Drawing.Size(60, 20);
            this.txtNumeroCli.TabIndex = 115;
            this.txtNumeroCli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroCli_KeyPress);
            // 
            // txtCEPCli
            // 
            this.txtCEPCli.Location = new System.Drawing.Point(90, 162);
            this.txtCEPCli.Mask = "00000-000";
            this.txtCEPCli.Name = "txtCEPCli";
            this.txtCEPCli.Size = new System.Drawing.Size(60, 20);
            this.txtCEPCli.TabIndex = 118;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboComplementoCli);
            this.groupBox1.Controls.Add(this.cboCidadeCli);
            this.groupBox1.Controls.Add(this.txtCEPCli);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cboEstadoCli);
            this.groupBox1.Controls.Add(this.txtNumeroCli);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtLoteCli);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtRuaCli);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtQuadraCli);
            this.groupBox1.Controls.Add(this.txtBairroCli);
            this.groupBox1.Controls.Add(this.lblComplemento);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(9, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 285);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // cboCidadeCli
            // 
            this.cboCidadeCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCidadeCli.FormattingEnabled = true;
            this.cboCidadeCli.Items.AddRange(new object[] {
            ""});
            this.cboCidadeCli.Location = new System.Drawing.Point(90, 49);
            this.cboCidadeCli.Name = "cboCidadeCli";
            this.cboCidadeCli.Size = new System.Drawing.Size(229, 21);
            this.cboCidadeCli.TabIndex = 122;
            this.cboCidadeCli.Click += new System.EventHandler(this.cboCidadeCli_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 57);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 121;
            this.label18.Text = "CIDADE:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 250);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 87;
            this.label17.Text = "LOTE:";
            // 
            // cboEstadoCli
            // 
            this.cboEstadoCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCli.FormattingEnabled = true;
            this.cboEstadoCli.Location = new System.Drawing.Point(90, 22);
            this.cboEstadoCli.Name = "cboEstadoCli";
            this.cboEstadoCli.Size = new System.Drawing.Size(228, 21);
            this.cboEstadoCli.TabIndex = 123;
            this.cboEstadoCli.SelectedIndexChanged += new System.EventHandler(this.cboEstadoCli_SelectedIndexChanged);
            this.cboEstadoCli.Click += new System.EventHandler(this.cboEstadoCli_Click);
            // 
            // txtLoteCli
            // 
            this.txtLoteCli.Location = new System.Drawing.Point(90, 245);
            this.txtLoteCli.Name = "txtLoteCli";
            this.txtLoteCli.Size = new System.Drawing.Size(60, 20);
            this.txtLoteCli.TabIndex = 86;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 85;
            this.label15.Text = "QUADRA:";
            // 
            // txtQuadraCli
            // 
            this.txtQuadraCli.Location = new System.Drawing.Point(90, 216);
            this.txtQuadraCli.Name = "txtQuadraCli";
            this.txtQuadraCli.Size = new System.Drawing.Size(60, 20);
            this.txtQuadraCli.TabIndex = 84;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(1, 195);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(57, 13);
            this.lblComplemento.TabIndex = 83;
            this.lblComplemento.Text = "COMPLE.:";
            // 
            // cboComplementoCli
            // 
            this.cboComplementoCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComplementoCli.FormattingEnabled = true;
            this.cboComplementoCli.Items.AddRange(new object[] {
            "CASA",
            "APARTAMENTO"});
            this.cboComplementoCli.Location = new System.Drawing.Point(90, 187);
            this.cboComplementoCli.Name = "cboComplementoCli";
            this.cboComplementoCli.Size = new System.Drawing.Size(108, 21);
            this.cboComplementoCli.TabIndex = 130;
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 590);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Name = "frmCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.Button btnNovoCli;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodigoCli;
        private System.Windows.Forms.Button btnConfirmarCli;
        private System.Windows.Forms.Button btnIncluirCli;
        private System.Windows.Forms.Button btnLimparCli;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbNomeCli;
        private System.Windows.Forms.RadioButton rbDocCli;
        private System.Windows.Forms.TextBox txtPesquisaCli;
        private System.Windows.Forms.Button btnListarCli;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtEmailCli;
        private System.Windows.Forms.MaskedTextBox txtTelefoneCli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtCelularCli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBairroCli;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRuaCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNumeroCli;
        private System.Windows.Forms.MaskedTextBox txtCEPCli;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSnCli;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtQuadraCli;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtLoteCli;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cboCidadeCli;
        private System.Windows.Forms.ComboBox cboEstadoCli;
        private System.Windows.Forms.ComboBox cbotipocli;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox txtDocCli;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEditarCli;
        private System.Windows.Forms.ComboBox cboComplementoCli;

    }
}