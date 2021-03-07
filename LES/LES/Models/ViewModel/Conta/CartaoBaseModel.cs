﻿using LES.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LES.Models.ViewModel.Conta
{
    public class CartaoBaseModel
    {
        //[Required]
        [Display(Name = "Nome Impresso no Cartão")]
        public string Nome { get; set; }
        //[Required]
        [Display(Name = "Código")]
        public string Codigo { get; set; }
        //[Required]
        [Display(Name = "CVV")]
        public string Cvv { get; set; }
        //[Required]
        [Display(Name = "Data de Vencimento")]
        public DateTime Vencimento { get; set; }
        //[Required]
        [Display(Name = "Bandeira do cartão")]
        public BandeiraCartaoCredito Bandeira { get; set; }
    }
}