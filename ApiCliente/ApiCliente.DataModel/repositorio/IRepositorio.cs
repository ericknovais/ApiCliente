namespace ApiCliente.DataModel.repositorio
{
    public interface IRepositorio
    {
        void SaveChanges();
        IClienteRepositorio Cliente { get; }
        IEnderecoRepositorio Endereco { get; }
        IEmailRepositorio Email { get; }
    }
}
