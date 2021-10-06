using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Setor
    {
        [Key]
        public int IdSetor { get; set; }

        public string NomeSetor { get; set; }
    }
}
