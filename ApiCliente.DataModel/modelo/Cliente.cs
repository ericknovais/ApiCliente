﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCliente.DataModel.modelo
{
    public class Cliente : EntidadeBase
    {
        public string NomeCompleto { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public override void Validar()
        {
            base.Validar();
        }
    }
}