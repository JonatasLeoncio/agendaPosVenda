using agendaPosVenda.Model;
using Dapper;

using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agendaPosVenda.Repositories
{
    public class RegistroRepositories
    {
        public List<Registro> SalvarRegistro(Registro registro)
        {
            // return Banco.Banco.Salvar(registro);


            using (var conexao = new SQLiteConnection("Data Source=C:/Users/Micro/Desktop/Agenda_pos_vendas/agendaPosVenda/Banco/BdCV.db"))
            {
                string sql = "insert into registros (Talao, Funcionario, codCliente, NomeCliente, Telefone, Status, Data, DataAberta,DataPrevEntrega, DataEntrega, DataPosVenda, Observacao,Valor)values(@Talao,@Funcionario,@CodCliente,@NomeCliente,@Telefone,@Status,@Data,@DataAberta,@DataPrevEntrega,@DataEntrega,@DataPosVenda,@Observacao,@Valor);";
                // string sql = "insert into registros (Talao, Funcionario, CodCliente, NomeCliente, Telefone, Status, Data, DataAberta, DataEntrega, DataPosVenda, Observacao)values(123,'jojo',222,'kkkko',3215544,'aberto','1984/10/02','02-10-1984','02-10-1984','02-10-1984','ooop');";
                int linhasAfetadas = conexao.Execute(sql, registro);
                return  ListarGegistros();//Banco.Banco.Salvar(registro);
            }

        }

        //Alterar
        public List<Registro> AlterarRegistro(Registro registro)
        {
            using (var conexao = new SQLiteConnection("Data Source=C:/Users/Micro/Desktop/Agenda_pos_vendas/agendaPosVenda/Banco/BdCV.db"))
            {
                string sql = "UPDATE registros SET Talao = @Talao,Funcionario = @Funcionario,CodCliente = @CodCliente,NomeCliente = @NomeCliente,Telefone = @Telefone,Status = @Status,DataAberta = @DataAberta,DataPrevEntrega=@DataPrevEntrega,DataEntrega = @DataEntrega,DataPosVenda = @DataPosVenda,Observacao = @Observacao,Valor = @Valor WHERE Id = @Id";
                int linhasAfetadas = conexao.Execute(sql, registro);
                // Banco.Banco.Salvar(registro);
                return ListarGegistros();
            }
        }
        public List<Registro> ListarGegistros()
        {
            using (var conexao = new SQLiteConnection("Data Source=C:/Users/Micro/Desktop/Agenda_pos_vendas/agendaPosVenda/Banco/BdCV.db"))
            {
                string sql = "select * from registros Order By Id Desc";
                var resp = conexao.Query<Registro>(sql).ToList();
                return resp;
            }
        }

        
        //Excluir
        public bool ExcluirRegstro(int Id)
        {

            using (var conexao = new SQLiteConnection("Data Source=C:/Users/Micro/Desktop/Agenda_pos_vendas/agendaPosVenda/Banco/BdCV.db"))
            {
                string sql = $"DELETE FROM registros WHERE Id = {Id}";
                var linhasAfetadas = conexao.Execute(sql, Id);
                if (linhasAfetadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

        }

        //Buscar

    }
}


