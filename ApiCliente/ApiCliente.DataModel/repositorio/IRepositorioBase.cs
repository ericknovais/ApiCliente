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
        void Salvar(T Entidade);
        void Excluir(T Entidade);
        T ObterPorID(int Id);
        IList<T> ObterTodos();
    }
}
