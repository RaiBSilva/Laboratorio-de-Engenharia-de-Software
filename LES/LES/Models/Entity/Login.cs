﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LES.Models.Entity
{
    public class Login : EntidadeDominio
    {

        public string Email { get; set; }

        public string Senha { get; set; }

        public Login(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }
    }
}
