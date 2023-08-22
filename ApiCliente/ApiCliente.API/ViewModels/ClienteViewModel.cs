using ApiCliente.DataModel.modelo;

namespace ApiCliente.AppWeb.ViwmModels
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {
            Emails = new EmailViewModel();
            Enderecos = new EnderecoViewModel();
        }

        public int ID { get; set; }
        public string NomeCompleto { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public EmailViewModel Emails { get; set; }
        public EnderecoViewModel Enderecos { get; set; }
    }

    public class EmailViewModel
    {
        public int ID { get; set; }
        public string Email { get; set; } = string.Empty;
        public bool Principal { get; set; } = false;
    }

    public class EnderecoViewModel
    {
        public int ID { get; set; }
        public string CEP { get; set; } = string.Empty;
        public string Logradouro { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Complemento { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public bool Principal { get; set; } = false;
    }
}
