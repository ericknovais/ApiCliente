using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCliente.DataModel.modelo
{
    [Table("Clientes")]
    public class Cliente : EntidadeBase
    {
        public Cliente()
        {
            NomeCompleto = string.Empty;
            Telefone = string.Empty;
            //Email = string.Empty;
        }

        public string NomeCompleto { get; set; }
        public string Telefone { get; set; }

        public override void Validar()
        {
            ValidaCampoTexto(NomeCompleto, "Nome Completo");
            ValidaCampoTexto(Telefone, "Telefone");

            base.Validar();
        }
    }
}
