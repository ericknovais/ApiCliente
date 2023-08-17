using ApiCliente.DataModel.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCliente.DataModel.repositorio
{
    public interface IRepositorioBase<T> where T : EntidadeBase
    {
        void Salvar(T entidade);
        void Excluir(T entidade);
        T ObterPorID();
        IList<T> ObterTodo();
    }
}
