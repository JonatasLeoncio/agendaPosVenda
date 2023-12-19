using agendaPosVenda.Controller;
using agendaPosVenda.Model;
using agendaPosVenda.Services;
using Microsoft.Win32;
using System.Windows.Forms;

namespace agendaPosVenda
{
    public partial class frmAgendaPosVenda : Form
    {
        public frmAgendaPosVenda()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Registro novoRegistro = new Registro();
            novoRegistro.Id = 1;
            novoRegistro.Talao = Convert.ToInt32(txtTalao.Text);
            novoRegistro.Funcionario = cmbFuncionario.Text;
            novoRegistro.CodCliente = Convert.ToInt32(txtCodCliente.Text);
            novoRegistro.NomeCliente = txtNomeCliente.Text;
            novoRegistro.Status = "Aberto";
            novoRegistro.Observacao = "blablabla";

            RegistroControler registroControler = new RegistroControler();
            List<Registro> resp = new List<Registro>();
             resp.AddRange(registroControler.SalvarRegistro(novoRegistro));
            // return null;

            foreach (var item in resp)
            {
                MessageBox.Show($"Id: {item.Id}\nTalao: {item.Talao}\nFuncionatrio: {item.Funcionario}\nid Cliente: {item.CodCliente}\ncliente: {item.NomeCliente}\nTelefone: {item.Telefone}\nStatus: {item.Status}\nData: {item.Data}\nData Aberta: {item.DataAberta}\nData Entrega: {item.DataEntrega}\nData Pos Venda: {item.DataPosVenda}\nObs: {item.Observacao}");
            }

            gridRegistros.Rows.Clear();
            foreach (var item in resp)
            {
                // Adicione uma nova linha ao DataGridView
                 int rowIndex = gridRegistros.Rows.Add();

                // Preencha os valores das células para a nova linha
               // gridRegistros.Rows[rowIndex].Cells["Id"].Value = item.Id ;
                gridRegistros.Rows[rowIndex].Cells["Talao"].Value = item.Talao;
                gridRegistros.Rows[rowIndex].Cells["Funcionario"].Value = item.Funcionario;
                gridRegistros.Rows[rowIndex].Cells["CodCliente"].Value = item.CodCliente;
                gridRegistros.Rows[rowIndex].Cells["Cliente"].Value =item.NomeCliente;
                //gridRegistros.Rows[rowIndex].Cells["Telefone"].Value = item.Telefone;
                //gridRegistros.Rows[rowIndex].Cells["Status"].Value = item.Status;
               // gridRegistros.Rows[rowIndex].Cells["Observacao"].Value = item.Observacao;
                // Adicione mais linhas conforme necessário
            }











        }

        private void frmAgendaPosVenda_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

       
    }
}