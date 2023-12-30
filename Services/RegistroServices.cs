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
        public List<Registro> ListarRegistros()
        {
            return registroRepositories.ListarGegistros();
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
