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
            lblDataHoje.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            txtDtAberto.Text = DateTime.Now.ToString("dd/MM/yyyy");
            gridExemplo.DataSource = registroControler.ListarRegistros();

            ListarGridRegistros();
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
            novoRegistro.Data = Convert.ToDateTime(lblDataHoje.Text);
            novoRegistro.DataAberta = Convert.ToDateTime(txtDtAberto.Text);
            novoRegistro.DataEntrega = Convert.ToDateTime(txtDtEntregue.Text);
            novoRegistro.DataPosVenda = Convert.ToDateTime(txtDtPosVenda.Text);
            novoRegistro.Observacao = txtObservacao.Text;
            novoRegistro.Valor = Convert.ToDecimal(txtValor.Text);


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
            var resp = registroControler.ListarRegistros();
            gridRegistros.Rows.Clear();
            foreach (var item in resp)
            {
                // Adicione uma nova linha ao DataGridView
                int rowIndex = gridRegistros.Rows.Add();

                // Preencha os valores das células para a nova linha
                gridRegistros.Rows[rowIndex].Cells["Id"].Value = item.Id;
                gridRegistros.Rows[rowIndex].Cells["Talao"].Value = item.Talao;
                gridRegistros.Rows[rowIndex].Cells["Funcionario"].Value = item.Funcionario;
                gridRegistros.Rows[rowIndex].Cells["CodCliente"].Value = item.CodCliente;
                gridRegistros.Rows[rowIndex].Cells["Cliente"].Value = item.NomeCliente;
                gridRegistros.Rows[rowIndex].Cells["Telefone"].Value = item.Telefone;
                gridRegistros.Rows[rowIndex].Cells["Status"].Value = item.Status;
                // gridRegistros.Rows[rowIndex].Cells["Observacao"].Value = item.Observacao;
                // Adicione mais linhas conforme necessário

                gridRegistros.DefaultCellStyle.SelectionBackColor = Color.White;
                gridRegistros.DefaultCellStyle.SelectionForeColor = Color.Black;
            }
        }

        private void frmAgendaPosVenda_Load(object sender, EventArgs e)
        {
            //registroControler.ListarRegistros();
            gridRegistros.DefaultCellStyle.SelectionBackColor = Color.White;
            gridRegistros.DefaultCellStyle.SelectionForeColor = Color.Black;
           // gridRegistros.Columns[0].Width = 00;
            gridRegistros.Columns[0].Visible=false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var resp = registroControler.ListarRegistros();


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                if (lblId.Text!="")
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
                    MessageBox.Show("Registro Excluído com sucesso");
                    id = 0;
                    lblId.Text = "";
                    ListarGridRegistros();
                }
                else
                {
                    MessageBox.Show("Não foi possivel excluir o registro");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void gridRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = gridRegistros.CurrentRow.Cells[0].Value.ToString();
            gridRegistros.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 128, 128);//coloca cor argb
        }

        private void gridRegistros_Click(object sender, EventArgs e)
        {
            gridRegistros.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            gridRegistros.DefaultCellStyle.SelectionForeColor = Color.Black;

            lblId.Text = "";
        }

        private void gridRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}