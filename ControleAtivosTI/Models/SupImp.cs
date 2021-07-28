using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{

    //model para os suprimentos das impressoras
    public class SupImp
    {
        [Key]
        public int IdSupImp { get; set; }

        [Display(Name = "Modelo do toner")]
        public string ModeloToner { get; set; }

        [Display(Name ="Qtd impressoras compatives")]
        public int QtdImpressoas { get; set; }

        [Display(Name ="Qtd de toner")]
        public int QtdToner { get; set; }

        [Display(Name ="Estoque")]
        public int Estoque
        {
            get
            {
                return QtdToner - QtdImpressoas;
            }
        }


    }
}
