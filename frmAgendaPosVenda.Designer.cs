namespace agendaPosVenda
{
    partial class frmAgendaPosVenda
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtTalao = new System.Windows.Forms.TextBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.pnlEntidades = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataTalao = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.txtDtPosVenda = new System.Windows.Forms.MaskedTextBox();
            this.txtDtEntregue = new System.Windows.Forms.MaskedTextBox();
            this.txtDtAberto = new System.Windows.Forms.MaskedTextBox();
            this.ckbPosVenda = new System.Windows.Forms.CheckBox();
            this.ckbEntregur = new System.Windows.Forms.CheckBox();
            this.ckbAberto = new System.Windows.Forms.CheckBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.pnlComandos = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gridRegistros = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Talao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAberta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataPosVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.gridExemplo = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDataHoje = new System.Windows.Forms.Label();
            this.pnlEntidades.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlControles.SuspendLayout();
            this.pnlComandos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExemplo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(82, 7);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(78, 28);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Adicionar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(101, 84);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(282, 23);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // txtTalao
            // 
            this.txtTalao.Location = new System.Drawing.Point(7, 25);
            this.txtTalao.Name = "txtTalao";
            this.txtTalao.Size = new System.Drawing.Size(76, 23);
            this.txtTalao.TabIndex = 2;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(7, 84);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(76, 23);
            this.txtCodCliente.TabIndex = 3;
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Items.AddRange(new object[] {
            "Jonatas Leoncio",
            "Leandro Leoncio",
            "Leonardo",
            "Rodrigo"});
            this.cmbFuncionario.Location = new System.Drawing.Point(101, 25);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(230, 23);
            this.cmbFuncionario.TabIndex = 5;
            // 
            // pnlEntidades
            // 
            this.pnlEntidades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEntidades.Controls.Add(this.label11);
            this.pnlEntidades.Controls.Add(this.txtValor);
            this.pnlEntidades.Controls.Add(this.label8);
            this.pnlEntidades.Controls.Add(this.cmbStatus);
            this.pnlEntidades.Controls.Add(this.txtTel);
            this.pnlEntidades.Controls.Add(this.label6);
            this.pnlEntidades.Controls.Add(this.label5);
            this.pnlEntidades.Controls.Add(this.label4);
            this.pnlEntidades.Controls.Add(this.label2);
            this.pnlEntidades.Controls.Add(this.label1);
            this.pnlEntidades.Controls.Add(this.cmbFuncionario);
            this.pnlEntidades.Controls.Add(this.txtNomeCliente);
            this.pnlEntidades.Controls.Add(this.txtTalao);
            this.pnlEntidades.Controls.Add(this.txtCodCliente);
            this.pnlEntidades.Location = new System.Drawing.Point(12, 26);
            this.pnlEntidades.Name = "pnlEntidades";
            this.pnlEntidades.Size = new System.Drawing.Size(570, 120);
            this.pnlEntidades.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(337, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(337, 25);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(99, 23);
            this.txtValor.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(442, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Aberto",
            "Entregue",
            "Pós Venda Feito"});
            this.cmbStatus.Location = new System.Drawing.Point(442, 25);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(123, 23);
            this.cmbStatus.TabIndex = 19;
            this.cmbStatus.Text = "Aberto";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(398, 84);
            this.txtTel.Mask = "(99) 00000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(131, 23);
            this.txtTel.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(398, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(101, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(101, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Funcionário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Talão";
            // 
            // txtDataTalao
            // 
            this.txtDataTalao.Location = new System.Drawing.Point(2, 611);
            this.txtDataTalao.Mask = "00/00/0000";
            this.txtDataTalao.Name = "txtDataTalao";
            this.txtDataTalao.Size = new System.Drawing.Size(146, 23);
            this.txtDataTalao.TabIndex = 14;
            this.txtDataTalao.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(2, 591);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data";
            // 
            // pnlStatus
            // 
            this.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatus.Controls.Add(this.txtDtPosVenda);
            this.pnlStatus.Controls.Add(this.txtDtEntregue);
            this.pnlStatus.Controls.Add(this.txtDtAberto);
            this.pnlStatus.Controls.Add(this.ckbPosVenda);
            this.pnlStatus.Controls.Add(this.ckbEntregur);
            this.pnlStatus.Controls.Add(this.ckbAberto);
            this.pnlStatus.Location = new System.Drawing.Point(599, 26);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(258, 120);
            this.pnlStatus.TabIndex = 9;
            this.pnlStatus.TabStop = true;
            this.pnlStatus.Tag = "";
            // 
            // txtDtPosVenda
            // 
            this.txtDtPosVenda.Location = new System.Drawing.Point(105, 74);
            this.txtDtPosVenda.Mask = "00/00/0000";
            this.txtDtPosVenda.Name = "txtDtPosVenda";
            this.txtDtPosVenda.Size = new System.Drawing.Size(131, 23);
            this.txtDtPosVenda.TabIndex = 17;
            this.txtDtPosVenda.ValidatingType = typeof(System.DateTime);
            // 
            // txtDtEntregue
            // 
            this.txtDtEntregue.Location = new System.Drawing.Point(105, 42);
            this.txtDtEntregue.Mask = "00/00/0000";
            this.txtDtEntregue.Name = "txtDtEntregue";
            this.txtDtEntregue.Size = new System.Drawing.Size(131, 23);
            this.txtDtEntregue.TabIndex = 16;
            this.txtDtEntregue.ValidatingType = typeof(System.DateTime);
            // 
            // txtDtAberto
            // 
            this.txtDtAberto.Location = new System.Drawing.Point(106, 13);
            this.txtDtAberto.Mask = "00/00/0000";
            this.txtDtAberto.Name = "txtDtAberto";
            this.txtDtAberto.Size = new System.Drawing.Size(130, 23);
            this.txtDtAberto.TabIndex = 15;
            this.txtDtAberto.ValidatingType = typeof(System.DateTime);
            // 
            // ckbPosVenda
            // 
            this.ckbPosVenda.AutoSize = true;
            this.ckbPosVenda.Location = new System.Drawing.Point(3, 76);
            this.ckbPosVenda.Name = "ckbPosVenda";
            this.ckbPosVenda.Size = new System.Drawing.Size(103, 19);
            this.ckbPosVenda.TabIndex = 10;
            this.ckbPosVenda.Text = "Pós Venda Em:";
            this.ckbPosVenda.UseVisualStyleBackColor = true;
            // 
            // ckbEntregur
            // 
            this.ckbEntregur.AutoSize = true;
            this.ckbEntregur.Location = new System.Drawing.Point(3, 47);
            this.ckbEntregur.Name = "ckbEntregur";
            this.ckbEntregur.Size = new System.Drawing.Size(96, 19);
            this.ckbEntregur.TabIndex = 9;
            this.ckbEntregur.Text = "Entregue Em:";
            this.ckbEntregur.UseVisualStyleBackColor = true;
            // 
            // ckbAberto
            // 
            this.ckbAberto.AutoSize = true;
            this.ckbAberto.Checked = true;
            this.ckbAberto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAberto.Enabled = false;
            this.ckbAberto.Location = new System.Drawing.Point(3, 17);
            this.ckbAberto.Name = "ckbAberto";
            this.ckbAberto.Size = new System.Drawing.Size(85, 19);
            this.ckbAberto.TabIndex = 8;
            this.ckbAberto.Text = "Aberto Em:";
            this.ckbAberto.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterar.Location = new System.Drawing.Point(168, 7);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(71, 28);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Atualizar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.Location = new System.Drawing.Point(245, 7);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(65, 28);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // pnlControles
            // 
            this.pnlControles.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlControles.Controls.Add(this.pnlComandos);
            this.pnlControles.Location = new System.Drawing.Point(14, 152);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(843, 53);
            this.pnlControles.TabIndex = 12;
            // 
            // pnlComandos
            // 
            this.pnlComandos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlComandos.Controls.Add(this.btnNovo);
            this.pnlComandos.Controls.Add(this.btnSalvar);
            this.pnlComandos.Controls.Add(this.btnAlterar);
            this.pnlComandos.Controls.Add(this.btnExcluir);
            this.pnlComandos.Location = new System.Drawing.Point(518, 3);
            this.pnlComandos.Name = "pnlComandos";
            this.pnlComandos.Size = new System.Drawing.Size(318, 43);
            this.pnlComandos.TabIndex = 13;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNovo.Location = new System.Drawing.Point(11, 7);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(65, 28);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(5, 26);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(184, 140);
            this.txtObservacao.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(14, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total de Registros:";
            // 
            // gridRegistros
            // 
            this.gridRegistros.AllowUserToAddRows = false;
            this.gridRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Talao,
            this.Funcionario,
            this.CodCliente,
            this.cliente,
            this.Telefone,
            this.Status,
            this.DataAberta,
            this.DataEntrega,
            this.DataPosVenda,
            this.Observacao});
            this.gridRegistros.Location = new System.Drawing.Point(12, 211);
            this.gridRegistros.Name = "gridRegistros";
            this.gridRegistros.RowTemplate.Height = 25;
            this.gridRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRegistros.Size = new System.Drawing.Size(1045, 195);
            this.gridRegistros.TabIndex = 16;
            // 
            // Id
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Talao
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Talao.DefaultCellStyle = dataGridViewCellStyle2;
            this.Talao.HeaderText = "Talao";
            this.Talao.Name = "Talao";
            // 
            // Funcionario
            // 
            this.Funcionario.HeaderText = "Funcionario";
            this.Funcionario.Name = "Funcionario";
            // 
            // CodCliente
            // 
            this.CodCliente.HeaderText = "Cod Cliente";
            this.CodCliente.Name = "CodCliente";
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // DataAberta
            // 
            this.DataAberta.HeaderText = "Data Aberta";
            this.DataAberta.Name = "DataAberta";
            // 
            // DataEntrega
            // 
            this.DataEntrega.HeaderText = "Data Entrega";
            this.DataEntrega.Name = "DataEntrega";
            // 
            // DataPosVenda
            // 
            this.DataPosVenda.HeaderText = "Data Pós Venda";
            this.DataPosVenda.Name = "DataPosVenda";
            // 
            // Observacao
            // 
            this.Observacao.HeaderText = "Observacao";
            this.Observacao.Name = "Observacao";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Obs:";
            // 
            // gridExemplo
            // 
            this.gridExemplo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridExemplo.Location = new System.Drawing.Point(12, 462);
            this.gridExemplo.Name = "gridExemplo";
            this.gridExemplo.RowTemplate.Height = 25;
            this.gridExemplo.Size = new System.Drawing.Size(1045, 109);
            this.gridExemplo.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(259, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Data Hoje: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtObservacao);
            this.panel1.Location = new System.Drawing.Point(863, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 179);
            this.panel1.TabIndex = 20;
            // 
            // lblDataHoje
            // 
            this.lblDataHoje.AutoSize = true;
            this.lblDataHoje.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataHoje.Location = new System.Drawing.Point(334, 6);
            this.lblDataHoje.Name = "lblDataHoje";
            this.lblDataHoje.Size = new System.Drawing.Size(41, 17);
            this.lblDataHoje.TabIndex = 21;
            this.lblDataHoje.Text = "Atual";
            // 
            // frmAgendaPosVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 596);
            this.Controls.Add(this.lblDataHoje);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gridExemplo);
            this.Controls.Add(this.gridRegistros);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDataTalao);
            this.Controls.Add(this.pnlControles);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlEntidades);
            this.Name = "frmAgendaPosVenda";
            this.Text = "Agenda controle";
            this.Load += new System.EventHandler(this.frmAgendaPosVenda_Load);
            this.pnlEntidades.ResumeLayout(false);
            this.pnlEntidades.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.pnlControles.ResumeLayout(false);
            this.pnlComandos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExemplo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSalvar;
        private TextBox txtNomeCliente;
        private TextBox txtTalao;
        private TextBox txtCodCliente;
        private ComboBox cmbFuncionario;
        private Panel pnlEntidades;
        private Panel pnlStatus;
        private CheckBox ckbPosVenda;
        private CheckBox ckbEntregur;
        private CheckBox ckbAberto;
        private Button btnAlterar;
        private Button btnExcluir;
        private Panel pnlControles;
        private Button btnNovo;
        private TextBox txtObservacao;
        private Panel pnlComandos;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox txtDataTalao;
        private MaskedTextBox txtTel;
        private MaskedTextBox txtDtPosVenda;
        private MaskedTextBox txtDtEntregue;
        private MaskedTextBox txtDtAberto;
        private Label label7;
        private Label label8;
        private ComboBox cmbStatus;
        private DataGridView gridRegistros;
        private Label label9;
        private DataGridView gridExemplo;
        private Label label10;
        private Panel panel1;
        private Label lblDataHoje;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Talao;
        private DataGridViewTextBoxColumn Funcionario;
        private DataGridViewTextBoxColumn CodCliente;
        private DataGridViewTextBoxColumn cliente;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn DataAberta;
        private DataGridViewTextBoxColumn DataEntrega;
        private DataGridViewTextBoxColumn DataPosVenda;
        private DataGridViewTextBoxColumn Observacao;
        private Label label11;
        private TextBox txtValor;
    }
}