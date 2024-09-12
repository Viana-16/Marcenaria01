﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._03_Entidades
{
    [Table("Produtos")]
    public class Produtos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Preco { get; set; }
        public int Validade { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public int QuantidadeEstoque { get; set; }

      
    }
}
