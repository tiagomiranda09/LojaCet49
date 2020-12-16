using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaCet49.Dados.Entidades
{
    public class Cliente
    {

        public int Id { get; set; }


        public string Nome { get; set; }

        public string Email { get; set; }

        public int Telefone { get; set; }

        public int Nif { get; set; }


        [Display(Name = "Imagem")]
        public string UrlDaImagem { get; set; }


    }
}
