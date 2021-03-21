using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC.Models
{
    public class QuantitativosAlunosAnos
    {
        public Guid Id { get; set; }

        [Required]
        public string Ano { get; set; }

        [Required]
        public string Turno { get; set; }

        [Required]
        public int Quantidade { get; set; }


        public QuantitativosAlunosAnos()
        {
            Id = Guid.NewGuid();
        }

    }

}
