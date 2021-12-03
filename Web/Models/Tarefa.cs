﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Web.Models
{
    public class Tarefa

    {
        [Key]
        public int id { get; set; }

        [DisplayName("Título")]
        [Required(ErrorMessage ="Campo obrigatório")]
        public string titulo { get; set; }

        [DisplayName("Status")]
        public bool concluido { get; set; }

        [DisplayName("Usuário da Tarefa")]
        public string usuario { get; set; }

        [DisplayName("Data da Criação")]
        public DateTime dataCriacao { get; set; } = DateTime.Now;

        [DisplayName("ultima Alteração")]
        public DateTime dataAlteracao { get; set; } = DateTime.Now;

    }
}