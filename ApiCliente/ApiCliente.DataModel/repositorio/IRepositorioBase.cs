using ApiCliente.DataModel.modelo;

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
