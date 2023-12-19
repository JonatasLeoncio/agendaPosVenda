using agendaPosVenda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agendaPosVenda.Repositories
{
    public class RegistroRepositories
    {
        public List<Registro> SalvarRegistro(Registro registro)
        {
          return Banco.Banco.Salvar(registro);
          
        }
    }
}
