﻿using Dapper.Contrib.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria01._03_Entidades
{
    [Table("Clientes")]
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Contato { get; set; }
        public string Endereco { get; set; }

    }
}
