﻿using agendaPosVenda.Model;
using agendaPosVenda.Repositories;
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
    }
}
