﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCliente.DataModel.modelo
{
    [Table("Enderecos")]
    public class Endereco : EntidadeBase
    {
        public Cliente Cliente { get; set; }
        public int ClienteID { get; set; }
        public string CPF { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}