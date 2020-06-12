﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ReservaSala.App.Models
{
    public class Aluno
    {
        public Aluno()
        {
           DataCadastro = DateTime.Now;
        }
        public int AlunoId { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string RA { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataCadastro { get; set; } 

    }
}
 