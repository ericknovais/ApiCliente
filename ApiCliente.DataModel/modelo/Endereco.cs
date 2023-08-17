using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCliente.DataModel.modelo
{
    public class Endereco : EntidadeBase
    {
        public Cliente Cliente { get; set; }
        public int ClienteID { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public override void Validar()
        {
            base.Validar();
        }
    }
}
