using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Equipamentos
    {
        [Key]
        public int IdEquipamento { get; set; }

        public string EquipDescricao { get; set; }

        public string EquipNuSerie { get; set; }

        public string EquipNuControle { get; set; }

        // Setor ou escola onde esta instalado


        // Tipo Impressora, notebook, computador
        public string EquipTipo { get; set; }

        //Alugado ou proprio
        public string EquipOrigem { get; set; }

        public int EquipValor { get; set; }

        public int IdUE { get; set; }

        //public string EquipLocalizacao { get; set; }
        public ICollection<Unidades> Unidades { get; set; }
    }
}
