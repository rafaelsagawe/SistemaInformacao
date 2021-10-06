using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Ramal
    {
        [Key]
        public int idRamal { get; set; }

        public string MACAddress { get; set; }

        public int IP { get; set; }

        public string localizacao { get; set; }

        public int IdLinha { get; set; }

        public ICollection<Linha> Linhas { get; set; }

    }

    public class Linha
    {
        [Key]
        public int IdLinha { get; set; }

        public int NumeroLinha { get; set; }

        public int Tronco { get; set; }

        public int Slot { get; set; }
    }
}
