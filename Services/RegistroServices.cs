using agendaPosVenda.Model;
using agendaPosVenda.Repositories;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agendaPosVenda.Services
{
    public class RegistroServices
    {
            RegistroRepositories registroRepositories=new RegistroRepositories();
        public List<Registro> SalvarRegistro(Registro registro)
        {
            return registroRepositories.SalvarRegistro(registro);
        }
        public List<Registro> ListarRegistros(string funcionario = null, string status = null, int talao = 0,DateTime? dataIncialFilt=null,DateTime? dataFinalFilt=null,string? columData = null)
        {
            return registroRepositories.ListarGegistros(funcionario,status,talao, dataIncialFilt, dataFinalFilt,columData);
        }

        public bool ExcluirRegistro(int id)
        {
           return registroRepositories.ExcluirRegstro(id);
        }

        public List<Registro> AlterarRegistro(Registro novoRegistro)
        {
            return registroRepositories.AlterarRegistro(novoRegistro);
        }
    }
}
