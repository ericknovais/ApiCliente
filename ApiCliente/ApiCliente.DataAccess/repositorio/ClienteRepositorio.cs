﻿using ApiCliente.DataAccess.db;
using ApiCliente.DataModel.modelo;
using ApiCliente.DataModel.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCliente.DataAccess.repositorio
{
    class ClienteRepositorio : AbstractGeneric<Cliente>, IClienteRepositorio
    {
        ContextoDB ctx;
        public ClienteRepositorio(ContextoDB contextoDB) : base(contextoDB)
        {
            ctx = contextoDB;
        }
    }
}
