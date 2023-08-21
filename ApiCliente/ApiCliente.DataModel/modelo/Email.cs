using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCliente.DataModel.modelo
{
    [Table("Emails")]
    public class Email : EntidadeBase
    {
        public Cliente Cliente { get; set; }
        public int ClienteID { get; set; }
        
        [DisplayName("Email")]
        public string Descricao { get; set; }

        public bool Principal { get; set; }

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
