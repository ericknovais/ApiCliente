using ApiCliente.DataAccess.db;
using ApiCliente.DataModel.modelo;
using ApiCliente.DataModel.repositorio;

namespace ApiCliente.DataAccess
{
    abstract class AbstractGeneric<T> : IRepositorioBase<T> where T : EntidadeBase
    {
        ContextoDB ctx;

        public AbstractGeneric(ContextoDB contextoDB)
        {
            ctx = contextoDB;
        }

        public void Excluir(T Entidade)
        {
            ctx.Set<T>().Remove(Entidade);
        }

        public T ObterPorID(int Id)
        {
            return ctx.Set<T>().FirstOrDefault(x => x.ID.Equals(Id));
        }

        public IList<T> ObterTodos()
        {
            return ctx.Set<T>().ToList();
        }

        public void Salvar(T Entidade)
        {
            if (Entidade.ID.Equals(0))
                ctx.Set<T>().Add(Entidade);
        }
    }
}
