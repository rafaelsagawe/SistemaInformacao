using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Unidades
    {
        [Key]
        public int IdUE { get; set; }

        [Display(Name = "Unidade Escolar")]
        public string NomeUE { get; set; }

        [Display(Name ="Codigo do INEP")]
        public int INEP { get; set; }

        [Display(Name = "Codigo de CNPJ")]
        public int CNPJ { get; set; }

        [Display(Name = "Codigo de Protocolo Interno")]
        public int NProtocolo { get; set; }

        // Endereçamento da Unidade

        [Display(Name = "URG")]
        public string URG { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Display(Name = "Codigo Postal")]
        public int CEP { get; set; }

        // Telefone da Unidade
        [Display(Name = "Telefone")]
        [DataType(DataType.PhoneNumber)]
        public int UETel { get; set; }

    }
}
