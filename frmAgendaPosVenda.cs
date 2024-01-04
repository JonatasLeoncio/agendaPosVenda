using agendaPosVenda.Controller;
using agendaPosVenda.Model;
using agendaPosVenda.Services;
using Microsoft.Win32;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Windows.Forms;

namespace agendaPosVenda
{
    public partial class frmAgendaPosVenda : Form
    {
        RegistroControler registroControler = new RegistroControler();
        public frmAgendaPosVenda()
        {
            InitializeComponent();
            lblDataHoje.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtDtAberto.Text = DateTime.Now.ToString("dd/MM/yyyy");
            gridExemplo.DataSource = registroControler.ListarRegistros();


            txtAlertaHoje.Multiline = true;
            txtAlertaHoje.WordWrap = false;
            txtAlertaHoje.ScrollBars = ScrollBars.Both;
            txtAlertaHoje.ReadOnly = true;
            //txtAlertaHoje.Enabled = false;
            txtAlertaHoje.BackColor= Color.White;

            txtAlertaAmanha.Multiline = true;
            txtAlertaAmanha.WordWrap = false;
            txtAlertaAmanha.ScrollBars = ScrollBars.Both;
            txtAlertaAmanha.ReadOnly = true;
            //txtAlertaAmanha.Enabled=false;
            txtAlertaAmanha.BackColor = Color.White;

            txtAlertaAtrazada.Multiline = true;
            txtAlertaAtrazada.WordWrap = false;
            txtAlertaAtrazada.ScrollBars = ScrollBars.Both;
            txtAlertaAtrazada.ReadOnly= true;
            //txtAlertaAtrazada.Enabled=false;
            txtAlertaAtrazada.BackColor = Color.White;

            btnNovo.Enabled= true;
            btnSalvar.Enabled= false;
            btnAlterar.Enabled= false;
            btnExcluir.Enabled= false;

            InabilitaCampos();

            cmbFuncLogin.SelectedIndex = 0;

            Program.FuncionarioLogin = cmbFuncLogin.Text;


            ListarGridRegistros(Program.FuncionarioLogin);
            gridExemplo.CellFormatting += gridExemplo_CellFormatting;

        }
        private void frmAgendaPosVenda_Load(object sender, EventArgs e)
        {



            //registroControler.ListarRegistros();
            //gridRegistros.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            //gridRegistros.DefaultCellStyle.SelectionForeColor = Color.Black;
            // gridRegistros.Columns[0].Width = 00;
            //gridRegistros.Columns[0].Visible = false;




            gridRegistros.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            gridRegistros.CurrentCell = null;

            gridRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


              gridRegistros.RowHeadersVisible = false;

        }
        //funcoes
        private void InabilitaCampos()
        {
            //ReadOnly é o contrario de Enabled porem mantem a cor da escrita forte
            lblId.Enabled = true;
            txtTalao.ReadOnly = true;
            cmbFuncionario.Enabled = false;           
            txtNomeCliente.ReadOnly = true;
            txtDataPrevEntrega.ReadOnly = true;
            cmbStatus.SelectedIndex = 0;
            cmbStatus.Enabled = false;
            txtCodCliente.ReadOnly = true;
            txtTel.ReadOnly = true;
            txtValor.ReadOnly = true;
            txtDtAberto.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtDtAberto.ReadOnly = true;
            txtDtEntregue.ReadOnly = true;
            txtDtPosVenda.ReadOnly = true;
            txtObservacao.ReadOnly = true;
            
        }
        private void HabilitaCampos()
        {
            //ReadOnly é o contrario de Enabled porem mantem a cor da escrita forte e permite a captura do control+C 
            txtTalao.ReadOnly = false;
            lblId.Enabled = true;
            txtNomeCliente.ReadOnly = false;
            cmbFuncionario.Enabled = true;
            txtDataPrevEntrega.ReadOnly = false;
            cmbStatus.SelectedIndex = 0;
            cmbStatus.Enabled = true;
            txtCodCliente.ReadOnly = false;
            txtTel.ReadOnly = false;
            txtValor.ReadOnly = false;
            txtDtAberto.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtDtAberto.ReadOnly = false;
            txtDtEntregue.ReadOnly = false;
            txtDtPosVenda.ReadOnly = false;
            txtObservacao.ReadOnly = false;
           
        }
        private void Limpar_Campos()
        {
            txtTalao.Text = string.Empty;
            lblId.Text = string.Empty;
            txtNomeCliente.Text = string.Empty;

            txtDataPrevEntrega.Text = string.Empty;
            cmbStatus.SelectedIndex = 0;
            txtCodCliente.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtValor.Text = string.Empty;
            txtDtAberto.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtDtEntregue.Text = string.Empty;
            txtDtPosVenda.Text = string.Empty;
            txtObservacao.Text = string.Empty;
            txtObservacao.BackColor = Color.White;
        }
        private void CarregaCamposComGrid()
        {
            if (gridRegistros.CurrentCell == null)//caso clicar na parte vazia da DatagridView
                return;

            // Faça o que você precisa fazer quando a tecla Enter é pressionada
            // ...
            lblId.Text = gridRegistros.CurrentRow.Cells[0].Value.ToString();
            txtTalao.Text = gridRegistros.CurrentRow.Cells[1].Value.ToString();
            cmbFuncionario.Text = gridRegistros.CurrentRow.Cells[2].Value.ToString();
            txtCodCliente.Text = gridRegistros.CurrentRow.Cells[3].Value.ToString();
            txtNomeCliente.Text = gridRegistros.CurrentRow.Cells[4].Value.ToString();
            txtTel.Text = gridRegistros.CurrentRow.Cells[5].Value.ToString();
            cmbStatus.Text = gridRegistros.CurrentRow.Cells[6].Value.ToString();

            txtDtAberto.Text = gridRegistros.CurrentRow.Cells[7].Value.ToString();
            txtDataPrevEntrega.Text = gridRegistros.CurrentRow.Cells[8].Value.ToString();
            txtDtEntregue.Text = gridRegistros.CurrentRow.Cells[9].Value.ToString();
            txtDtPosVenda.Text = gridRegistros.CurrentRow.Cells[10].Value.ToString();
            txtValor.Text = gridRegistros.CurrentRow.Cells[11].Value.ToString();

            txtObservacao.Text = gridRegistros.CurrentRow.Cells[12].Value.ToString();

            if (gridRegistros.CurrentRow.Cells[12].Value.ToString() != "".Trim())
            {
                txtObservacao.BackColor
                    = Color.LightBlue;
            }
            else
            {
                txtObservacao.BackColor
                    = Color.White;
            }

            

            // Impede a mudança para a próxima linha
            //e.SuppressKeyPress = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Registro novoRegistro = new Registro();
            //novoRegistro.Id = 1;
            novoRegistro.Talao = Convert.ToInt32(txtTalao.Text);
            novoRegistro.Funcionario = cmbFuncionario.Text;
            novoRegistro.CodCliente = Convert.ToInt32(txtCodCliente.Text);
            novoRegistro.NomeCliente = txtNomeCliente.Text;
            novoRegistro.Telefone = txtTel.Text;
            novoRegistro.Status = cmbStatus.Text;
            novoRegistro.Data = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            novoRegistro.DataPrevEntrega = (txtDataPrevEntrega.Text == "  /  /") ? null : Convert.ToDateTime(txtDataPrevEntrega.Text);
            novoRegistro.DataAberta = (txtDtAberto.Text == "  /  /") ? null : Convert.ToDateTime(txtDtAberto.Text);
            novoRegistro.DataEntrega = (txtDtEntregue.Text == "  /  /") ? null : Convert.ToDateTime(txtDtEntregue.Text);
            novoRegistro.DataPosVenda = (txtDtPosVenda.Text == "  /  /") ? null : Convert.ToDateTime(txtDtPosVenda.Text);
            novoRegistro.Observacao = txtObservacao.Text;
            novoRegistro.Valor = (txtValor.Text == "".Trim()) ? 0 : Convert.ToDecimal(txtValor.Text);
            novoRegistro.Observacao = txtObservacao.Text;


            List<Registro> resp = new List<Registro>();
            resp.AddRange(registroControler.SalvarRegistro(novoRegistro));
            // return null;

            /* foreach (var item in resp)
             {
                 MessageBox.Show($"Id: {item.Id}\nTalao: {item.Talao}\nFuncionatrio: {item.Funcionario}\nid Cliente: {item.CodCliente}\ncliente: {item.NomeCliente}\nTelefone: {item.Telefone}\nStatus: {item.Status}\nData: {item.Data}\nData Aberta: {item.DataAberta}\nData Entrega: {item.DataEntrega}\nData Pos Venda: {item.DataPosVenda}\nObs: {item.Observacao}");
             }*/

            ListarGridRegistros();
            MessageBox.Show("Salvo com Sucesso.");
            Limpar_Campos();
            InabilitaCampos();
            gridExemplo.DataSource = resp;



            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;








        }

        private void ListarGridRegistros(string funcionario = null)
        {
            // gridRegistros.CellFormatting += gridRegistros_CellFormatting;
            //if (txtLogin.Text != "".Trim())
            //{
            //    Program.FuncionarioLogin = txtLogin.Text;
            //    funcionario = Program.FuncionarioLogin;
            //}
            if (cmbFuncLogin.Text == "Admin".Trim())
            {
                Program.FuncionarioLogin = null;
                funcionario = Program.FuncionarioLogin;
            }
            else
            {
                Program.FuncionarioLogin = cmbFuncLogin.Text;
                funcionario = Program.FuncionarioLogin;
            }

            var resp = registroControler.ListarRegistros(funcionario);
            gridRegistros.Rows.Clear();
            double total = 0;
            for (int i = 0; i < resp.Count; i++)
            {
                int rowIndex = gridRegistros.Rows.Add();

                gridRegistros.Rows[i].Cells["Id"].Value = resp[i].Id;
                gridRegistros.Rows[i].Cells["Talao"].Value = resp[i].Talao;
                gridRegistros.Rows[i].Cells["Funcionario"].Value = resp[i].Funcionario;
                gridRegistros.Rows[i].Cells["CodCliente"].Value = resp[i].CodCliente;
                gridRegistros.Rows[i].Cells["Cliente"].Value = resp[i].NomeCliente;
                gridRegistros.Rows[i].Cells["Telefone"].Value = resp[i].Telefone;
                gridRegistros.Rows[i].Cells["Status"].Value = resp[i].Status;


                // gridRegistros.Rows[i].Cells["DataPrevEntrega"].Value = resp[i].DataPrevEntrega;
                // Formata a data para excluir a parte da hora e minutos
                // Verifica se DataPrevEntrega não é nulo antes de formatar
                if (resp[i].DataAberta != null)
                {
                    // Formata a data para excluir a parte da hora e minutos
                    gridRegistros.Rows[i].Cells["DataAberta"].Value = ((DateTime)resp[i].DataAberta).ToString("dd/MM/yyyy");
                }
                else
                {
                    // Se a data for nula, você pode manipular de acordo com sua lógica de tratamento
                    gridRegistros.Rows[i].Cells["DataPrevEntrega"].Value = "";
                }

                if (resp[i].DataPrevEntrega != null)
                {
                    // Formata a data para excluir a parte da hora e minutos
                    gridRegistros.Rows[i].Cells["DataPrevEntrega"].Value = ((DateTime)resp[i].DataPrevEntrega).ToString("dd/MM/yyyy");
                }
                else
                {
                    // Se a data for nula, você pode manipular de acordo com sua lógica de tratamento
                    gridRegistros.Rows[i].Cells["DataPrevEntrega"].Value = "";
                }

                //               

                if (resp[i].DataEntrega != null)
                {
                    gridRegistros.Rows[i].Cells["DataEntrega"].Value = ((DateTime)resp[i].DataEntrega).ToString("dd/MM/yyyy");
                }
                else
                {
                    gridRegistros.Rows[i].Cells["DataEntrega"].Value = "";
                }
                if (resp[i].DataPosVenda != null)
                {
                    gridRegistros.Rows[i].Cells["DataPosVenda"].Value = ((DateTime)resp[i].DataPosVenda).ToString("dd/MM/yyyy");
                }
                else
                {
                    gridRegistros.Rows[i].Cells["DataPosVenda"].Value = "";
                }

                gridRegistros.Rows[i].Cells["Observacao"].Value = resp[i].Observacao;




                // Altera a cor do texto na célula com base em alguma condição
                if (resp[i].Status == "Aberto")
                {
                    gridRegistros.Rows[i].Cells["Status"].Style.BackColor = Color.Yellow;
                    gridRegistros.Rows[i].Cells["Status"].Style.ForeColor = Color.Red; // Cor padrão
                }
                else if (resp[i].Status == "Entregue")
                {
                    gridRegistros.Rows[i].Cells["Status"].Style.ForeColor = Color.White; // Cor padrão
                    gridRegistros.Rows[i].Cells["Status"].Style.BackColor = Color.Green;
                }
                else
                {
                    gridRegistros.Rows[i].Cells["Status"].Style.ForeColor = Color.White; // Cor padrão
                    gridRegistros.Rows[i].Cells["Status"].Style.BackColor = Color.Blue;
                }
                double valor = (double)resp[i].Valor;
                gridRegistros.Rows[i].Cells["Valor"].Value = valor.ToString("N2");
                total += valor;
            }

            // gridRegistros.Columns[0].Visible = false;





            gridRegistros.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            gridRegistros.CurrentCell = null;

            gridRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblTotRegistrosGrid.Text = gridRegistros.RowCount.ToString();
            lblSomaTotal.Text = total.ToString("C2");

            StatusAlerta();
        }

        

        private void btnNovo_Click(object sender, EventArgs e)
        {


            Limpar_Campos();

            if (cmbFuncLogin.Text.Trim() == "")
            {
                MessageBox.Show("vc precisa logar");
                cmbFuncLogin.Focus();
                return;
            }


            HabilitaCampos();
            gridRegistros.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            gridRegistros.CurrentCell = null;
            gridRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            btnNovo.Enabled = true;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (lblId.Text == "".Trim())
            {
                MessageBox.Show("Selecione algum registro na grade para alteração");
                return;
            }

            Registro novoRegistro = new Registro();
            novoRegistro.Id = Convert.ToInt32(lblId.Text);
            novoRegistro.Talao = Convert.ToInt32(txtTalao.Text);
            novoRegistro.Funcionario = cmbFuncionario.Text;
            novoRegistro.CodCliente = Convert.ToInt32(txtCodCliente.Text);
            novoRegistro.NomeCliente = txtNomeCliente.Text;
            novoRegistro.Telefone = txtTel.Text;
            if (txtDtAberto.Text != "  /  /" && txtDtEntregue.Text == "  /  /" && txtDtPosVenda.Text == "  /  /")
            {
                cmbStatus.Text = "Aberto";
            }
            if (txtDtAberto.Text != "  /  /" && txtDtEntregue.Text != "  /  /" && txtDtPosVenda.Text == "  /  /")
            {
                cmbStatus.Text = "Entregue";
            }
            if (txtDtAberto.Text != "  /  /" && txtDtEntregue.Text != "  /  /" && txtDtPosVenda.Text != "  /  /")
            {
                cmbStatus.Text = "Pós Venda Feito";
            }


            novoRegistro.Status = cmbStatus.Text;
            //novoRegistro.Data = Convert.ToDateTime(lblDataHoje.Text);
            novoRegistro.DataAberta = (txtDtAberto.Text == "  /  /") ? null : Convert.ToDateTime(txtDtAberto.Text);
            novoRegistro.DataPrevEntrega = (txtDataPrevEntrega.Text == "  /  /") ? null : Convert.ToDateTime(txtDataPrevEntrega.Text);
            novoRegistro.DataEntrega = (txtDtEntregue.Text == "  /  /") ? null : Convert.ToDateTime(txtDtEntregue.Text);
            novoRegistro.DataPosVenda = (txtDtPosVenda.Text == "  /  /") ? null : Convert.ToDateTime(txtDtPosVenda.Text);
            novoRegistro.Observacao = txtObservacao.Text;
            novoRegistro.Valor = (txtValor.Text == "".Trim()) ? 0 : Convert.ToDecimal(txtValor.Text);

            novoRegistro.Observacao = txtObservacao.Text;


            List<Registro> resp = new List<Registro>();
            resp.AddRange(registroControler.AlterarRegistro(novoRegistro));


            ListarGridRegistros();
            MessageBox.Show("Atualizado com Sucesso.");
            // Limpar_Campos();
            InabilitaCampos();
            gridExemplo.DataSource = resp;

            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                if (lblId.Text != "")
                {
                    id = Convert.ToInt32(lblId.Text);
                }
                else
                {
                    MessageBox.Show("Selecione um registro");
                    return;
                }


                // Exibe uma MessageBox com opção Sim/Não
                DialogResult resultado = MessageBox.Show("Gostaria realmente de Excluir esse Registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verifica a escolha do usuário
                if (resultado == DialogResult.Yes)
                {
                    // Código a ser executado se o usuário escolheu "Sim"
                    if (registroControler.ExcluirRegistro(id))
                    {
                        MessageBox.Show("Registro Excluído com sucesso");
                        Limpar_Campos();
                        id = 0;
                        ListarGridRegistros();
                        InabilitaCampos();

                        btnNovo.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = false;
                        btnExcluir.Enabled = false;
                    }
                }
                else
                {
                    // Código a ser executado se o usuário escolheu "Não"
                    // MessageBox.Show("Você escolheu Não!");
                    return;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void gridRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //lblId.Text = gridRegistros.CurrentRow.Cells[0].Value.ToString();
            //gridRegistros.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 128, 128);//coloca cor argb


            /*gridRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridRegistros.CurrentCell = null;
            lblId.Text = "";*/
            gridRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridRegistros.CurrentCell = null;
            lblId.Text = "";

            Limpar_Campos();
            InabilitaCampos();


            //gridRegistros.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;

            //gridRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void gridRegistros_Click(object sender, EventArgs e)
        {
            //gridRegistros.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            //gridRegistros.DefaultCellStyle.SelectionForeColor = Color.Black;           
            // Color corPadrao = SystemColors.Highlight;

            /*gridRegistros.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;

            gridRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;*/

            //gridRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //gridRegistros.CurrentCell = null;
            //lblId.Text = "";
            if (cmbFuncLogin.Text.Trim() == "")
            {
                MessageBox.Show("vc precisa logar");
                cmbFuncLogin.Focus();
                return;
            }


            gridRegistros.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;

            gridRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Limpar_Campos();
            CarregaCamposComGrid();
            InabilitaCampos();
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        private void gridRegistros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (gridRegistros.CurrentCell == null)
                {
                    // MessageBox.Show("Selecione algum registro");
                    gridRegistros.CurrentCell = null;
                    e.SuppressKeyPress = true;
                    return;
                }
                gridRegistros.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 128, 128);//coloca cor argb

                CarregaCamposComGrid();
                HabilitaCampos();
                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;

                e.SuppressKeyPress = true;
            }
        }

        private void gridRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridRegistros_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {

                InabilitaCampos();
               // CarregaCamposComGrid();
               Limpar_Campos();
                gridRegistros.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;


            }
        }

        private void txtDtAberto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void gridExemplo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridExemplo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == gridExemplo.Columns["Status"].Index && e.Value != null)
            {
                // Obtém o valor da célula
                string valorCelula = e.Value.ToString();

                // Condição para determinar a cor com base no conteúdo
                if (valorCelula == "Aberto")
                {
                    // Define a cor desejada
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White; // Cor do texto
                }
                // Adicione mais condições conforme necessário

                // Importante: Define a propriedade FormattingApplied como true para indicar que a formatação foi aplicada
                e.FormattingApplied = true;
            }
        }

        private void btnAlerta_Click(object sender, EventArgs e)
        {
            //StatusAlerta();
            // string caminho = Path.GetFullPath(@"Banco\BdCV.db");
            //MessageBox.Show("KKK = " + System.IO.Directory.GetCurrentDirectory());

            // string diretorioAtual = Directory.GetCurrentDirectory();

            //double num = 1582.401233;
            //MessageBox.Show(num.ToString("C2"));

            ListarGridRegistros();





            //MessageBox.Show("Res = "+ caminhoDestino);

        }

        private void StatusAlerta()
        {
            var dados = registroControler.ListarRegistros();

            int totHoje = 0;
            int totAmanha = 0;
            int totAtrazada = 0;

            txtAlertaHoje.Clear();
            txtAlertaAmanha.Clear();
            txtAlertaAtrazada.Clear();

            string dataHoje = DateTime.Now.ToString("dd/MM/yyyy");

            foreach (var item in dados)
            {
                string dataPrevEntrega = ((DateTime)item.DataPrevEntrega).ToString("dd/MM/yyyy");
                // Converta as strings para objetos DateTime usando o formato desejado
                DateTime data2 = DateTime.ParseExact(dataPrevEntrega, "dd/MM/yyyy", null);
                DateTime data1 = DateTime.ParseExact(dataHoje, "dd/MM/yyyy", null);
                // Subtraia as datas e obtenha a diferença em dias
                TimeSpan diferenca = data2 - data1;
                int diferencaEmDias = diferenca.Days;

                if (diferencaEmDias == 0 && item.Status == "Aberto")
                {
                    //listaEntregasHoje.Add(item);
                    txtAlertaHoje.Text += $"Talao: {item.Talao}  - Func: {item.Funcionario}         IdDoc: {item.Id}\r\n\r\n";
                    txtAlertaHoje.ForeColor = Color.Blue;
                    totHoje++;
                }
                if (diferencaEmDias == 1 && item.Status == "Aberto")
                {
                    //listaEntregasAmanha.Add(item);
                    txtAlertaAmanha.Text += $"Talao: {item.Talao}  - Func: {item.Funcionario}         IdDoc: {item.Id}\r\n\r\n";
                    txtAlertaAmanha.ForeColor = Color.Green;
                    totAmanha++;
                }
                if (diferencaEmDias < 0 && item.Status == "Aberto")
                {
                    //listaEntregasAtrazadas.Add(item);
                    //lblAtrazado.Text = "\r\n";
                    txtAlertaAtrazada.Text += $"Talao: {item.Talao} - Func: {item.Funcionario} - IdDoc: {item.Id}       está atrazado à ({diferencaEmDias * (-1)}) dias\r\n\r\n";
                    txtAlertaAtrazada.ForeColor = Color.Red;
                    totAtrazada++;
                }

            }
            lblTotHoje.Text = totHoje.ToString();
            lblTotAmanha.Text = totAmanha.ToString();
            lblTotAtrazada.Text = totAtrazada.ToString();
        }

        private void rbHoje_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHoje.Checked)
            {
                txtAlertaHoje.Visible = true;
                txtAlertaAtrazada.Visible = false;
                txtAlertaAmanha.Visible = false;
            }
        }

        private void rbAmanha_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAmanha.Checked)
            {
                txtAlertaAmanha.Visible = true;
                txtAlertaAtrazada.Visible = false;
                txtAlertaHoje.Visible = false;
            }
        }

        private void rbAtrazada_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAtrazada.Checked)
            {
                txtAlertaAtrazada.Visible = true;
                txtAlertaHoje.Visible = false;
                txtAlertaAmanha.Visible = false;
            }
        }

        private void pnlControles_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlStatus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlEntidades_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbFuncLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarGridRegistros();
            cmbFuncionario.Text = "";
            Limpar_Campos();
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }
    }
}