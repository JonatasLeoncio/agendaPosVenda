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
    }

        
}
