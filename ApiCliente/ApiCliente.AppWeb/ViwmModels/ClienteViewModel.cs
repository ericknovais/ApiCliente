using ApiCliente.DataModel.modelo;

namespace ApiCliente.AppWeb.ViwmModels
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {
            NomeCompleto = string.Empty;
            Telefone = string.Empty;
            Emails = new List<Email>() { new Email() };
            Enderecos = new List<Endereco>() { new Endereco() };
        }

        public string NomeCompleto { get; set; }
        public string Telefone { get; set; }
        public List<Email> Emails { get; set; }
        public List<Endereco> Enderecos { get; set; }

    }
}
