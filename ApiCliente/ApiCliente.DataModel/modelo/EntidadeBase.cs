using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCliente.DataModel.modelo
{
    public abstract class EntidadeBase
    {
        public int ID { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }

        protected StringBuilder _msgErro = new StringBuilder();

        public virtual void Validar() 
        {
            if (_msgErro.Length > 0)
                throw new Exception(_msgErro.ToString());
        }

        public virtual void ValidaCampoTexto(string campo, string nomeCampo)
        {
            if (string.IsNullOrEmpty(campo))
                _msgErro.Append($"O campo {nomeCampo} é obrigatório {Environment.NewLine}"); 
        }
    }
}
