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

        [Display(Name ="Descrição")]
        public string EquipDescricao { get; set; }

        [Display(Name ="Numero de Serie")]
        public string EquipNuSerie { get; set; }

        [Display(Name ="Numero de patrimonio")]
        public string EquipNuControle { get; set; }

        // Setor ou escola onde esta instalado


        // Tipo Impressora, notebook, computador
        [Display(Name ="Tipo")]
        public string EquipTipo { get; set; }

        //Alugado ou proprio
        public string EquipOrigem { get; set; }

        [Display(Name = "Valor do equipamento")]
        public int EquipValor { get; set; }

        [Display(Name ="Unidade de locação")]
        public int IdUE { get; set; }

        //public string EquipLocalizacao { get; set; }
        public ICollection<Unidades> Unidades { get; set; }
    }

    public class Camera
    {
        [Key]
        public int IdCamera { get; set; }

        public string MAC { get; set; }

        public string IP { get; set; }
        public string Modelo { get; set; }
        public string Local { get; set; }
        public string NumeroSerie { get; set; }

    }
}
