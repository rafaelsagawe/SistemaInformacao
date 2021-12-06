using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Models.Enum
{

        public enum CriticidadeTipo
        {
        
            [Display(Name = "Alta")]
            Alta,

            [Display(Name = "Media")]
            Media,

            [Display(Name = "Baixa")]
            Baixa



    }


}

