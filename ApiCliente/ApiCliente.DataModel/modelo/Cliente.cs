using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCliente.DataModel.modelo
{
    [Table("Clientes")]
    public class Cliente : EntidadeBase
    {
        public string NomeCompleto { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;

        public override void Validar()
        {
            ValidaCampoTexto(NomeCompleto, "Nome Completo");
            ValidaCampoTexto(Telefone, "Telefone");

            base.Validar();
        }
    }
}
