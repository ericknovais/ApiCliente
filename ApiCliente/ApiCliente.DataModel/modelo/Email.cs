using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCliente.DataModel.modelo
{
    [Table("Emails")]
    public class Email : EntidadeBase
    {
        public Cliente Cliente { get; set; } = new Cliente();
        public int ClienteID { get; set; }

        [DisplayName("Email")]
        public string Descricao { get; set; } = string.Empty;

        public bool Principal { get; set; } = false;

        private string _msgErroEmail = "E-mail em um formato invalido";

        public override void Validar()
        {
            ValidaEmail();
            base.Validar();
        }

        private void ValidaEmail() 
        {
            if (!Descricao.Contains("@") || !Descricao.Contains(".com"))
                _msgErro.Append($"{_msgErroEmail} {Environment.NewLine}");
        }
    }
}
