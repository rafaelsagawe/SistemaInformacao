using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Web.Models.Enum
{
        public enum Equipamento
        {
            [Display(Name = "Impressora")] Impressora,
            [Display(Name = "Notebook")] Notebook,
            [Display(Name = "Computador")] Computador
        }
    }

