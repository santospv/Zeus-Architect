namespace G.Alb
{
    partial class frmCadastroFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroFuncionario));
            this.txtSalarioFunc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboCargoFunc = new System.Windows.Forms.ComboBox();
            this.cboSetorFunc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBairroFunc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCodigoFunc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefoneFunc = new System.Windows.Forms.MaskedTextBox();
            this.txtCelularFunc = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRuaFunc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmailFunc = new System.Windows.Forms.TextBox();
            this.cboStatusFunc = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboComplementoFunc = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSobrenomeFunc = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cboCidadeFunc = new System.Windows.Forms.ComboBox();
            this.txtCEPFunc = new System.Windows.Forms.MaskedTextBox();
            this.txtCPFFunc = new System.Windows.Forms.MaskedTextBox();
            this.cboEstadoFunc = new System.Windows.Forms.ComboBox();
            this.txtNumeroFunc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditarFunc = new System.Windows.Forms.Button();
            this.btnNovoFunc = new System.Windows.Forms.Button();
            this.btnLimparFunc = new System.Windows.Forms.Button();
            this.btnIncluirFunc = new System.Windows.Forms.Button();
            this.btnAtualizarFunc = new System.Windows.Forms.Button();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.rbNomeFunc = new System.Windows.Forms.RadioButton();
            this.rbCPFFunc = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPesquisaFunc = new System.Windows.Forms.TextBox();
            this.btnListarFunc = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSalarioFunc
            // 
            this.txtSalarioFunc.Location = new System.Drawing.Point(79, 139);
            this.txtSalarioFunc.Name = "txtSalarioFunc";
            this.txtSalarioFunc.Size = new System.Drawing.Size(140, 20);
            this.txtSalarioFunc.TabIndex = 15;
            this.txtSalarioFunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 146);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 111;
            this.label15.Text = "SALÁRIO:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 110;
            this.label9.Text = "CARGO:";
            // 
            // cboCargoFunc
            // 
            this.cboCargoFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCargoFunc.FormattingEnabled = true;
            this.cboCargoFunc.Location = new System.Drawing.Point(79, 114);
            this.cboCargoFunc.Name = "cboCargoFunc";
            this.cboCargoFunc.Size = new System.Drawing.Size(228, 21);
            this.cboCargoFunc.TabIndex = 14;
            this.cboCargoFunc.Click += new System.EventHandler(this.cboCargoFunc_Click);
            // 
            // cboSetorFunc
            // 
            this.cboSetorFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSetorFunc.FormattingEnabled = true;
            this.cboSetorFunc.Location = new System.Drawing.Point(79, 85);
            this.cboSetorFunc.Name = "cboSetorFunc";
            this.cboSetorFunc.Size = new System.Drawing.Size(228, 21);
            this.cboSetorFunc.TabIndex = 13;
            this.cboSetorFunc.Click += new System.EventHandler(this.cboSetorFunc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 106;
            this.label4.Text = "SETOR:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 100;
            this.label13.Text = "CEP:";
            // 
            // txtBairroFunc
            // 
            this.txtBairroFunc.Location = new System.Drawing.Point(93, 158);
            this.txtBairroFunc.Name = "txtBairroFunc";
            this.txtBairroFunc.Size = new System.Drawing.Size(138, 20);
            this.txtBairroFunc.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 97;
            this.label12.Text = "BAIRRO:";
            // 
            // txtCodigoFunc
            // 
            this.txtCodigoFunc.Enabled = false;
            this.txtCodigoFunc.Location = new System.Drawing.Point(93, 13);
            this.txtCodigoFunc.Name = "txtCodigoFunc";
            this.txtCodigoFunc.ReadOnly = true;
            this.txtCodigoFunc.Size = new System.Drawing.Size(36, 20);
            this.txtCodigoFunc.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 93;
            this.label10.Text = "COD.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 91;
            this.label8.Text = "CPF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "EMAIL:";
            // 
            // txtTelefoneFunc
            // 
            this.txtTelefoneFunc.Location = new System.Drawing.Point(79, 8);
            this.txtTelefoneFunc.Mask = "(00) 0000-0000";
            this.txtTelefoneFunc.Name = "txtTelefoneFunc";
            this.txtTelefoneFunc.Size = new System.Drawing.Size(159, 20);
            this.txtTelefoneFunc.TabIndex = 10;
            // 
            // txtCelularFunc
            // 
            this.txtCelularFunc.Location = new System.Drawing.Point(79, 59);
            this.txtCelularFunc.Mask = "(00) 0000-0000";
            this.txtCelularFunc.Name = "txtCelularFunc";
            this.txtCelularFunc.Size = new System.Drawing.Size(140, 20);
            this.txtCelularFunc.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 86;
            this.label6.Text = "CELULAR:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "TELEFONE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "ESTADO:";
            // 
            // txtRuaFunc
            // 
            this.txtRuaFunc.Location = new System.Drawing.Point(93, 109);
            this.txtRuaFunc.Name = "txtRuaFunc";
            this.txtRuaFunc.Size = new System.Drawing.Size(229, 20);
            this.txtRuaFunc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "ENDEREÇO:";
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(93, 38);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(229, 20);
            this.txtNomeFunc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "NOME:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmailFunc);
            this.groupBox1.Controls.Add(this.cboStatusFunc);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtTelefoneFunc);
            this.groupBox1.Controls.Add(this.txtSalarioFunc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCelularFunc);
            this.groupBox1.Controls.Add(this.cboCargoFunc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboSetorFunc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(438, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtEmailFunc
            // 
            this.txtEmailFunc.Location = new System.Drawing.Point(79, 34);
            this.txtEmailFunc.Name = "txtEmailFunc";
            this.txtEmailFunc.Size = new System.Drawing.Size(228, 20);
            this.txtEmailFunc.TabIndex = 11;
            // 
            // cboStatusFunc
            // 
            this.cboStatusFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatusFunc.FormattingEnabled = true;
            this.cboStatusFunc.Location = new System.Drawing.Point(79, 162);
            this.cboStatusFunc.Name = "cboStatusFunc";
            this.cboStatusFunc.Size = new System.Drawing.Size(159, 21);
            this.cboStatusFunc.TabIndex = 16;
            this.cboStatusFunc.Click += new System.EventHandler(this.cboStatusFunc_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 168);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 113;
            this.label17.Text = "STATUS:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboComplementoFunc);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtSobrenomeFunc);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.cboCidadeFunc);
            this.groupBox2.Controls.Add(this.txtCEPFunc);
            this.groupBox2.Controls.Add(this.txtCPFFunc);
            this.groupBox2.Controls.Add(this.cboEstadoFunc);
            this.groupBox2.Controls.Add(this.txtNumeroFunc);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNomeFunc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtRuaFunc);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtBairroFunc);
            this.groupBox2.Controls.Add(this.txtCodigoFunc);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(5, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 241);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // cboComplementoFunc
            // 
            this.cboComplementoFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComplementoFunc.FormattingEnabled = true;
            this.cboComplementoFunc.Items.AddRange(new object[] {
            "CASA",
            "APARTAMENTO"});
            this.cboComplementoFunc.Location = new System.Drawing.Point(112, 208);
            this.cboComplementoFunc.Name = "cboComplementoFunc";
            this.cboComplementoFunc.Size = new System.Drawing.Size(175, 21);
            this.cboComplementoFunc.TabIndex = 129;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 128;
            this.label14.Text = "SOBRENOME:";
            // 
            // txtSobrenomeFunc
            // 
            this.txtSobrenomeFunc.Location = new System.Drawing.Point(93, 61);
            this.txtSobrenomeFunc.Name = "txtSobrenomeFunc";
            this.txtSobrenomeFunc.Size = new System.Drawing.Size(229, 20);
            this.txtSobrenomeFunc.TabIndex = 127;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(181, 136);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 126;
            this.label18.Text = "CIDADE:";
            // 
            // cboCidadeFunc
            // 
            this.cboCidadeFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCidadeFunc.FormattingEnabled = true;
            this.cboCidadeFunc.Items.AddRange(new object[] {
            ""});
            this.cboCidadeFunc.Location = new System.Drawing.Point(231, 134);
            this.cboCidadeFunc.Name = "cboCidadeFunc";
            this.cboCidadeFunc.Size = new System.Drawing.Size(175, 21);
            this.cboCidadeFunc.TabIndex = 124;
            // 
            // txtCEPFunc
            // 
            this.txtCEPFunc.Location = new System.Drawing.Point(93, 183);
            this.txtCEPFunc.Mask = "00000-000";
            this.txtCEPFunc.Name = "txtCEPFunc";
            this.txtCEPFunc.Size = new System.Drawing.Size(65, 20);
            this.txtCEPFunc.TabIndex = 7;
            // 
            // txtCPFFunc
            // 
            this.txtCPFFunc.Location = new System.Drawing.Point(93, 84);
            this.txtCPFFunc.Mask = "000,000,000-00";
            this.txtCPFFunc.Name = "txtCPFFunc";
            this.txtCPFFunc.Size = new System.Drawing.Size(89, 20);
            this.txtCPFFunc.TabIndex = 2;
            this.txtCPFFunc.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cboEstadoFunc
            // 
            this.cboEstadoFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoFunc.FormattingEnabled = true;
            this.cboEstadoFunc.Location = new System.Drawing.Point(93, 133);
            this.cboEstadoFunc.Name = "cboEstadoFunc";
            this.cboEstadoFunc.Size = new System.Drawing.Size(50, 21);
            this.cboEstadoFunc.TabIndex = 125;
            this.cboEstadoFunc.SelectedIndexChanged += new System.EventHandler(this.cboEstadoFunc_SelectedIndexChanged);
            this.cboEstadoFunc.Click += new System.EventHandler(this.cboEstadoFunc_Click);
            // 
            // txtNumeroFunc
            // 
            this.txtNumeroFunc.Location = new System.Drawing.Point(354, 106);
            this.txtNumeroFunc.Name = "txtNumeroFunc";
            this.txtNumeroFunc.Size = new System.Drawing.Size(51, 20);
            this.txtNumeroFunc.TabIndex = 4;
            this.txtNumeroFunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(326, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 13);
            this.label16.TabIndex = 108;
            this.label16.Text = "Nº:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 95;
            this.label11.Text = "COMPLEMENTO:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnEditarFunc);
            this.panel1.Controls.Add(this.btnNovoFunc);
            this.panel1.Controls.Add(this.btnLimparFunc);
            this.panel1.Controls.Add(this.btnIncluirFunc);
            this.panel1.Controls.Add(this.btnAtualizarFunc);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 35);
            this.panel1.TabIndex = 0;
            // 
            // btnEditarFunc
            // 
            this.btnEditarFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarFunc.Image")));
            this.btnEditarFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarFunc.Location = new System.Drawing.Point(132, 2);
            this.btnEditarFunc.Name = "btnEditarFunc";
            this.btnEditarFunc.Size = new System.Drawing.Size(70, 32);
            this.btnEditarFunc.TabIndex = 1;
            this.btnEditarFunc.Text = "Editar";
            this.btnEditarFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarFunc.UseVisualStyleBackColor = true;
            this.btnEditarFunc.Click += new System.EventHandler(this.btnEditarFunc_Click);
            // 
            // btnNovoFunc
            // 
            this.btnNovoFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoFunc.Image")));
            this.btnNovoFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoFunc.Location = new System.Drawing.Point(3, 2);
            this.btnNovoFunc.Name = "btnNovoFunc";
            this.btnNovoFunc.Size = new System.Drawing.Size(56, 32);
            this.btnNovoFunc.TabIndex = 0;
            this.btnNovoFunc.Text = "Novo";
            this.btnNovoFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoFunc.UseVisualStyleBackColor = true;
            this.btnNovoFunc.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnLimparFunc
            // 
            this.btnLimparFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparFunc.Image")));
            this.btnLimparFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparFunc.Location = new System.Drawing.Point(296, 2);
            this.btnLimparFunc.Name = "btnLimparFunc";
            this.btnLimparFunc.Size = new System.Drawing.Size(77, 32);
            this.btnLimparFunc.TabIndex = 0;
            this.btnLimparFunc.Text = "Cancelar";
            this.btnLimparFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparFunc.UseVisualStyleBackColor = true;
            this.btnLimparFunc.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnIncluirFunc
            // 
            this.btnIncluirFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluirFunc.Image")));
            this.btnIncluirFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluirFunc.Location = new System.Drawing.Point(64, 2);
            this.btnIncluirFunc.Name = "btnIncluirFunc";
            this.btnIncluirFunc.Size = new System.Drawing.Size(62, 32);
            this.btnIncluirFunc.TabIndex = 0;
            this.btnIncluirFunc.Text = "Incluir";
            this.btnIncluirFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluirFunc.UseVisualStyleBackColor = true;
            this.btnIncluirFunc.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAtualizarFunc
            // 
            this.btnAtualizarFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizarFunc.Image")));
            this.btnAtualizarFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizarFunc.Location = new System.Drawing.Point(211, 2);
            this.btnAtualizarFunc.Name = "btnAtualizarFunc";
            this.btnAtualizarFunc.Size = new System.Drawing.Size(79, 32);
            this.btnAtualizarFunc.TabIndex = 0;
            this.btnAtualizarFunc.Text = "Confirmar";
            this.btnAtualizarFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizarFunc.UseVisualStyleBackColor = true;
            this.btnAtualizarFunc.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Location = new System.Drawing.Point(-1, 18);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.Size = new System.Drawing.Size(817, 216);
            this.dgvFuncionario.TabIndex = 0;
            this.dgvFuncionario.SelectionChanged += new System.EventHandler(this.dgvFuncionario_SelectionChanged);
            // 
            // rbNomeFunc
            // 
            this.rbNomeFunc.AutoSize = true;
            this.rbNomeFunc.Location = new System.Drawing.Point(2, 16);
            this.rbNomeFunc.Name = "rbNomeFunc";
            this.rbNomeFunc.Size = new System.Drawing.Size(58, 19);
            this.rbNomeFunc.TabIndex = 17;
            this.rbNomeFunc.TabStop = true;
            this.rbNomeFunc.Text = "NOME";
            this.rbNomeFunc.UseVisualStyleBackColor = true;
            this.rbNomeFunc.CheckedChanged += new System.EventHandler(this.rbNome_CheckedChanged);
            // 
            // rbCPFFunc
            // 
            this.rbCPFFunc.AutoSize = true;
            this.rbCPFFunc.Location = new System.Drawing.Point(88, 15);
            this.rbCPFFunc.Name = "rbCPFFunc";
            this.rbCPFFunc.Size = new System.Drawing.Size(45, 19);
            this.rbCPFFunc.TabIndex = 18;
            this.rbCPFFunc.TabStop = true;
            this.rbCPFFunc.Text = "CPF";
            this.rbCPFFunc.UseVisualStyleBackColor = true;
            this.rbCPFFunc.CheckedChanged += new System.EventHandler(this.rbCPF_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPesquisaFunc);
            this.groupBox3.Controls.Add(this.rbCPFFunc);
            this.groupBox3.Controls.Add(this.rbNomeFunc);
            this.groupBox3.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(438, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 44);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisa por:";
            // 
            // txtPesquisaFunc
            // 
            this.txtPesquisaFunc.Location = new System.Drawing.Point(140, 15);
            this.txtPesquisaFunc.Name = "txtPesquisaFunc";
            this.txtPesquisaFunc.Size = new System.Drawing.Size(167, 22);
            this.txtPesquisaFunc.TabIndex = 19;
            this.txtPesquisaFunc.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // btnListarFunc
            // 
            this.btnListarFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnListarFunc.Image")));
            this.btnListarFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarFunc.Location = new System.Drawing.Point(755, 297);
            this.btnListarFunc.Name = "btnListarFunc";
            this.btnListarFunc.Size = new System.Drawing.Size(75, 23);
            this.btnListarFunc.TabIndex = 20;
            this.btnListarFunc.Text = "Listar";
            this.btnListarFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListarFunc.UseVisualStyleBackColor = true;
            this.btnListarFunc.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvFuncionario);
            this.groupBox4.Location = new System.Drawing.Point(5, 319);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(829, 240);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Funcionarios Cadastrados";
            // 
            // frmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 566);
            this.Controls.Add(this.btnListarFunc);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCadastroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionario";
            this.Load += new System.EventHandler(this.frmCadastroFuncionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalarioFunc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboCargoFunc;
        private System.Windows.Forms.ComboBox cboSetorFunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBairroFunc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCodigoFunc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtTelefoneFunc;
        private System.Windows.Forms.MaskedTextBox txtCelularFunc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRuaFunc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.RadioButton rbNomeFunc;
        private System.Windows.Forms.RadioButton rbCPFFunc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLimparFunc;
        private System.Windows.Forms.Button btnIncluirFunc;
        private System.Windows.Forms.Button btnAtualizarFunc;
        private System.Windows.Forms.TextBox txtNumeroFunc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboStatusFunc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEmailFunc;
        private System.Windows.Forms.MaskedTextBox txtCEPFunc;
        private System.Windows.Forms.MaskedTextBox txtCPFFunc;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnNovoFunc;
        private System.Windows.Forms.TextBox txtPesquisaFunc;
        private System.Windows.Forms.Button btnListarFunc;
        private System.Windows.Forms.Button btnEditarFunc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSobrenomeFunc;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cboCidadeFunc;
        private System.Windows.Forms.ComboBox cboEstadoFunc;
        private System.Windows.Forms.ComboBox cboComplementoFunc;
        private System.Windows.Forms.Label label11;

    }
}