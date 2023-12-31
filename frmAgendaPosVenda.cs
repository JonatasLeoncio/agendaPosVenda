using agendaPosVenda.Controller;
using agendaPosVenda.Model;
using agendaPosVenda.Services;
using Microsoft.Win32;
using System.Data;
using System.Data.Common;
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

            ListarGridRegistros();
            gridExemplo.CellFormatting += gridExemplo_CellFormatting;
           
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
            novoRegistro.DataPrevEntrega = (txtDataPrevEntrega.Text == "  /  /")?null:Convert.ToDateTime(txtDataPrevEntrega.Text);
            novoRegistro.DataAberta = (txtDtAberto.Text == "  /  /") ? null : Convert.ToDateTime(txtDtAberto.Text);
            novoRegistro.DataEntrega = (txtDtEntregue.Text == "  /  /") ? null : Convert.ToDateTime(txtDtEntregue.Text);
            novoRegistro.DataPosVenda = (txtDtPosVenda.Text == "  /  /") ? null : Convert.ToDateTime(txtDtPosVenda.Text);
            novoRegistro.Observacao = txtObservacao.Text;
            novoRegistro.Valor = (txtValor.Text == "".Trim()) ? 0 : Convert.ToDecimal(txtValor.Text);


            List<Registro> resp = new List<Registro>();
            resp.AddRange(registroControler.SalvarRegistro(novoRegistro));
            // return null;

            /* foreach (var item in resp)
             {
                 MessageBox.Show($"Id: {item.Id}\nTalao: {item.Talao}\nFuncionatrio: {item.Funcionario}\nid Cliente: {item.CodCliente}\ncliente: {item.NomeCliente}\nTelefone: {item.Telefone}\nStatus: {item.Status}\nData: {item.Data}\nData Aberta: {item.DataAberta}\nData Entrega: {item.DataEntrega}\nData Pos Venda: {item.DataPosVenda}\nObs: {item.Observacao}");
             }*/

            ListarGridRegistros();
            gridExemplo.DataSource = resp;












        }

        private void ListarGridRegistros()
        {
            // gridRegistros.CellFormatting += gridRegistros_CellFormatting;
            var resp = registroControler.ListarRegistros();
            gridRegistros.Rows.Clear();
            foreach (var item in resp)
            {
                // Adicione uma nova linha ao DataGridView
                int rowIndex = gridRegistros.Rows.Add();
               
            }
            for (int i = 0; i < resp.Count; i++)
            {
                gridRegistros.Rows[i].Cells["Id"].Value = resp[i].Id;
                gridRegistros.Rows[i].Cells["Talao"].Value = resp[i].Talao;
                gridRegistros.Rows[i].Cells["Funcionario"].Value = resp[i].Funcionario;
                gridRegistros.Rows[i].Cells["CodCliente"].Value = resp[i].CodCliente;
                gridRegistros.Rows[i].Cells["Cliente"].Value = resp[i].NomeCliente;
                gridRegistros.Rows[i].Cells["Telefone"].Value = resp[i].Telefone;
                gridRegistros.Rows[i].Cells["Status"].Value = resp[i].Status;


                // gridRegistros.Rows[i].Cells["DataPrevEntrega"].Value = resp[i].DataPrevEntrega;
                // Formata a data para excluir a parte da hora e minutos
                // Verifica se DataPrevEntrega n�o � nulo antes de formatar
                if (resp[i].DataAberta != null)
                {
                    // Formata a data para excluir a parte da hora e minutos
                    gridRegistros.Rows[i].Cells["DataAberta"].Value = ((DateTime)resp[i].DataAberta).ToString("dd/MM/yyyy");
                }
                else
                {
                    // Se a data for nula, voc� pode manipular de acordo com sua l�gica de tratamento
                    gridRegistros.Rows[i].Cells["DataPrevEntrega"].Value = "";
                }

                if (resp[i].DataPrevEntrega != null)
                {
                    // Formata a data para excluir a parte da hora e minutos
                    gridRegistros.Rows[i].Cells["DataPrevEntrega"].Value = ((DateTime)resp[i].DataPrevEntrega).ToString("dd/MM/yyyy");
                }
                else
                {
                    // Se a data for nula, voc� pode manipular de acordo com sua l�gica de tratamento
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




                // Altera a cor do texto na c�lula com base em alguma condi��o
                if (resp[i].Status == "Aberto")
                {
                    gridRegistros.Rows[i].Cells["Status"].Style.BackColor = Color.Yellow;
                    gridRegistros.Rows[i].Cells["Status"].Style.ForeColor = Color.Red; // Cor padr�o
                }
                else if (resp[i].Status == "Entregue")
                {
                    gridRegistros.Rows[i].Cells["Status"].Style.ForeColor = Color.White; // Cor padr�o
                    gridRegistros.Rows[i].Cells["Status"].Style.BackColor = Color.Green;
                }
                else
                {
                    gridRegistros.Rows[i].Cells["Status"].Style.ForeColor = Color.White; // Cor padr�o
                    gridRegistros.Rows[i].Cells["Status"].Style.BackColor = Color.Blue;
                }
            }

           // gridRegistros.Columns[0].Visible = false;




            gridRegistros.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            gridRegistros.CurrentCell = null;

            gridRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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


            //  gridRegistros.RowHeadersVisible = false;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //gridRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            /*string testSemMascara = new String(txtDtEntregue.Text.Where(Char.IsDigit).ToArray());
            MessageBox.Show(testSemMascara);*/
            if(txtDtEntregue.Text=="  /  /")
            {
                MessageBox.Show("vazio");
            }
            else
            {
                MessageBox.Show(txtDtEntregue.Text);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (lblId.Text == "".Trim())
            {
                MessageBox.Show("Selecione algum registro na grade para altera��o");
                return;
            }

            Registro novoRegistro = new Registro();
            novoRegistro.Id = Convert.ToInt32(lblId.Text);
            novoRegistro.Talao = Convert.ToInt32(txtTalao.Text);
            novoRegistro.Funcionario = cmbFuncionario.Text;
            novoRegistro.CodCliente = Convert.ToInt32(txtCodCliente.Text);
            novoRegistro.NomeCliente = txtNomeCliente.Text;
            novoRegistro.Telefone = txtTel.Text;
            novoRegistro.Status = cmbStatus.Text;
            //novoRegistro.Data = Convert.ToDateTime(lblDataHoje.Text);
            novoRegistro.DataPrevEntrega = (txtDataPrevEntrega.Text == "  /  /") ? null : Convert.ToDateTime(txtDataPrevEntrega.Text);
            novoRegistro.DataAberta = (txtDtAberto.Text == "  /  /") ? null : Convert.ToDateTime(txtDtAberto.Text);
            novoRegistro.DataEntrega = (txtDtEntregue.Text == "  /  /") ? null : Convert.ToDateTime(txtDtEntregue.Text);
            novoRegistro.DataPosVenda = (txtDtPosVenda.Text == "  /  /") ? null : Convert.ToDateTime(txtDtPosVenda.Text);
            novoRegistro.Observacao = txtObservacao.Text;
            novoRegistro.Valor = (txtValor.Text=="".Trim())?0:Convert.ToDecimal(txtValor.Text);


            List<Registro> resp = new List<Registro>();
            resp.AddRange(registroControler.AlterarRegistro(novoRegistro));


            ListarGridRegistros();
            gridExemplo.DataSource = resp;

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

                if (registroControler.ExcluirRegistro(id))
                {
                    MessageBox.Show("Registro Exclu�do com sucesso");
                    id = 0;
                    lblId.Text = "";
                    ListarGridRegistros();
                }
                else
                {
                    MessageBox.Show("N�o foi possivel excluir o registro");
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

            gridRegistros.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;

            gridRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void gridRegistros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (gridRegistros.CurrentCell == null){
                   // MessageBox.Show("Selecione algum registro");
                    gridRegistros.CurrentCell = null;
                    e.SuppressKeyPress = true;
                    return;
                }
                
                // Fa�a o que voc� precisa fazer quando a tecla Enter � pressionada
                // ...
                lblId.Text = gridRegistros.CurrentRow.Cells[0].Value.ToString();
               txtTalao.Text = gridRegistros.CurrentRow.Cells[1].Value.ToString();
               cmbFuncionario.Text = gridRegistros.CurrentRow.Cells[2].Value.ToString();
               txtCodCliente.Text = gridRegistros.CurrentRow.Cells[3].Value.ToString();
               txtNomeCliente.Text = gridRegistros.CurrentRow.Cells[4].Value.ToString();
               txtTel.Text = gridRegistros.CurrentRow.Cells[5].Value.ToString();
               cmbStatus.Text = gridRegistros.CurrentRow.Cells[6].Value.ToString();
               // txtDataPrevEntrega.Text = gridExemplo.CurrentRow.Cells[9].Value.ToString();
              // txtDtAberto.Text = gridRegistros.CurrentRow.Cells[7].Value.ToString();
              // txtDtEntregue.Text = gridRegistros.CurrentRow.Cells[8].Value.ToString();
               //txtDtPosVenda.Text = gridRegistros.CurrentRow.Cells[9].Value.ToString();
                //txtObservacao.Text = gridRegistros.CurrentRow.Cells[10].Value.ToString();

                gridRegistros.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 128, 128);//coloca cor argb

                // Impede a mudan�a para a pr�xima linha
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
                // Obt�m o valor da c�lula
                string valorCelula = e.Value.ToString();

                // Condi��o para determinar a cor com base no conte�do
                if (valorCelula == "Aberto")
                {
                    // Define a cor desejada
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White; // Cor do texto
                }
                // Adicione mais condi��es conforme necess�rio

                // Importante: Define a propriedade FormattingApplied como true para indicar que a formata��o foi aplicada
                e.FormattingApplied = true;
            }
        }
    }
}