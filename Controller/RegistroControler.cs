using agendaPosVenda.Model;
using agendaPosVenda.Services;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agendaPosVenda.Controller
{
    public class RegistroControler
    {
        RegistroServices servico = new RegistroServices();

        public List<Registro> SalvarRegistro(Registro novoRegistro)
        {
           return servico.SalvarRegistro(novoRegistro);
        }

        public List<Registro> ListarRegistros(string funcionario = null, string status = null, int talao = 0,DateTime? dataIncialFilt = null, DateTime? dataFinalFilt = null, string? columData = null)
        {
            return servico.ListarRegistros(funcionario,status,talao, dataIncialFilt, dataFinalFilt,columData);
        }

        public bool ExcluirRegistro(int Id)
        {
           return  servico.ExcluirRegistro(Id);
        }

        public List<Registro> AlterarRegistro(Registro novoRegistro)
        {
            return servico.AlterarRegistro(novoRegistro);
        }
    }

        
}
