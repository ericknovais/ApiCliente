using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCliente.DataModel.modelo
{
    [Table("Enderecos")]
    public class Endereco : EntidadeBase
    {
        public Cliente Cliente { get; set; } = new Cliente();
        public int ClienteID { get; set; }
        public string CEP { get; set; } = string.Empty;
        public string Logradouro { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Complemento { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public bool Principal { get; set; } = false;

        public override void Validar()
        {
            ValidaCampoTexto(CEP, "CEP");
            ValidaCampoTexto(Logradouro, "Logradouro");
            ValidaCampoTexto(Numero, "Número");
            ValidaCampoTexto(Bairro, "Bairro");
            ValidaCampoTexto(Cidade, "Cidade");
            ValidaCampoTexto(Estado, "Estado");
            base.Validar();
        }
    }
}
