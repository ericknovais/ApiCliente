using ApiCliente.DataModel.modelo;

namespace ApiCliente.DataModel.repositorio
{
    public interface IEmailRepositorio : IRepositorioBase<Email>
    {
        List<Email> ObterEmailPorCLienteID(int clienteID);
    }
}
