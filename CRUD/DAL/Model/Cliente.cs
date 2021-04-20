using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Cliente
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string sexo { get; set; }
        public int cod_tipo_cliente { get; set; }
        public string tipo_cliente { get; set; }
        public int cod_situacao_cliente { get; set; }
        public string situacao_cliente { get; set; }
    }
}
