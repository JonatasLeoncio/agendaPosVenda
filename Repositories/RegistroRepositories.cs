﻿using agendaPosVenda.Model;
using Dapper;

using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace agendaPosVenda.Repositories
{

    public class RegistroRepositories
    {
       readonly string diretorioAtual = AppDomain.CurrentDomain.BaseDirectory;
       readonly string caminhoDestino;

        // Obtenha o diretório base do executável
        //string diretorioAtual = AppDomain.CurrentDomain.BaseDirectory;
        public RegistroRepositories()
        {
            // Navegue tres vezes para a pasta pai
            DirectoryInfo diretorioPai = Directory.GetParent(diretorioAtual)?.Parent?.Parent?.Parent;
            // MessageBox.Show("2= " + diretorioPai);

            string caminhoDestino = System.IO.Path.Combine(diretorioPai.FullName, "Banco\\BdCV.db");
            this.caminhoDestino = caminhoDestino;
        }



        public List<Registro> SalvarRegistro(Registro registro)
        {
            // return Banco.Banco.Salvar(registro);
           


            using (var conexao = new SQLiteConnection("Data Source="+ caminhoDestino))
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
            using (var conexao = new SQLiteConnection("Data Source=" + caminhoDestino))
            {
                string sql = "UPDATE registros SET Talao = @Talao,Funcionario = @Funcionario,CodCliente = @CodCliente,NomeCliente = @NomeCliente,Telefone = @Telefone,Status = @Status,DataAberta = @DataAberta,DataPrevEntrega=@DataPrevEntrega,DataEntrega = @DataEntrega,DataPosVenda = @DataPosVenda,Observacao = @Observacao,Valor = @Valor WHERE Id = @Id";
                int linhasAfetadas = conexao.Execute(sql, registro);
                // Banco.Banco.Salvar(registro);
                return ListarGegistros();
            }
        }
        public List<Registro> ListarGegistros(string? funcionario = null, string? status = null, int talao = 0,DateTime? dataInicio = null, DateTime? dataFinal = null,string? colunaDatas = null)
        {            
            using (var conexao = new SQLiteConnection("Data Source=" + caminhoDestino))
            {
                //var parametros = new DynamicParameters();
                //var parametros = new { Funcionario = funcionario, Status = status };

                string sql = "SELECT * FROM registros WHERE 1 = 1 ";

                if (!string.IsNullOrEmpty(funcionario))
                {
                    sql += "AND LOWER(Funcionario) = LOWER(@Funcionario) ";
                    //parametros.Add("@Funcionario", funcionario);
                }

                if (!string.IsNullOrEmpty(status))
                {
                    sql += "AND Status = @Status ";
                    //parametros.Add("@Status", status);
                }



                if (talao > 0)
                {
                    sql += "AND Talao = @Talao ";
                    //parametros.Add("@Status", status);
                }


                //string colunaData = "DataAberta";

                if (!string.IsNullOrEmpty(colunaDatas)){
                    if (colunaDatas == "Aberta")
                    {
                        colunaDatas = "DataAberta";
                    }

                    if (colunaDatas == "Entrega")
                    {
                        colunaDatas = "DataEntrega";
                    }
                    if (colunaDatas == "Pós Venda Feito")
                    {
                        colunaDatas = "DataPosVenda";
                    }
                    if (colunaDatas == "Previsão de Entrega")
                    {
                        colunaDatas = "DataPrevEntrega";
                    }




                }


                    if (dataInicio != null)
                    {
                        sql += $"AND {colunaDatas} >= @DataInicio ";
                    }
                    if (dataFinal != null)
                    {
                        sql += $"AND {colunaDatas} <= @DataFinal ";
                    }
                

                



               


               // string orderby = (Program.OrderListDesc)?"":"";

                 sql += (Program.OrderListDesc) ? "ORDER BY Id DESC" : "ORDER BY Id ASC"; 
               // MessageBox.Show(sql);

                var registros = conexao.Query<Registro>(sql, new { Funcionario = funcionario, Status = status, Talao = talao, DataInicio = dataInicio,DataFinal = dataFinal }).ToList();

                return registros;
            }
        }

        
        //Excluir
        public bool ExcluirRegstro(int Id)
        {

            using (var conexao = new SQLiteConnection("Data Source=" + caminhoDestino))
            {
                string sql = $"DELETE FROM registros WHERE Id = @Id";
                var linhasAfetadas = conexao.Execute(sql, new { Id });
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


