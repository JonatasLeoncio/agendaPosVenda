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
                string sql = "insert into registros (Talao, Funcionario, codCliente, NomeCliente, Telefone, Status, Data, DataAberta, DataEntrega, DataPosVenda, Observacao)values(@Talao,@Funcionario,@CodCliente,@NomeCliente,@Telefone,@Status,@Data,@DataAberta,@DataEntrega,@DataPosVenda,@Observacao);";
                // string sql = "insert into registros (Talao, Funcionario, CodCliente, NomeCliente, Telefone, Status, Data, DataAbertura, DataEntrega, DataPosVenda, Observacao)values(123,'jojo',222,'kkkko',3215544,'aberto','1984/10/02','02-10-1984','02-10-1984','02-10-1984','ooop');";
                int linhasAfetadas = conexao.Execute(sql, registro);
                return Banco.Banco.Salvar(registro);
            }




        }
        public List<Registro> ListarGegistros()
        {
            using (var conexao = new SQLiteConnection("Data Source=C:/Users/Micro/Desktop/Agenda_pos_vendas/agendaPosVenda/Banco/BdCV.db"))
            {
                string sql = "select * from registros";
                var resp = conexao.Query<Registro>(sql).ToList();
                return resp ;
            }
        }
    }
}         
        
   
