﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LES.Models.Entity
{
    public class TipoTelefone : MetadadoBase
    {

        public virtual IList<Telefone> Telefones { get; set; }
    }
}
