using agendaPosVenda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agendaPosVenda.Banco
{
    
    static public class Banco
    {
        static int num = 1;

        static  List<Registro> registros = new List<Registro>();

       static public List<Registro> Salvar(Registro registro)
        {
            registro.Id=num++;
            registros.Add(registro);

           ///////aaaaaaaa
            return registros;
        }
    }
}
