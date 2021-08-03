using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

/* Itens
Nome do sistema 
Nome da Plataforma
Descrição
Acesso
Código Fonte
    Linguagens
    Banco de dados
    Documentação
Hospedagem -> possivel referencia as ativos/Servidor
Cliente
    Estado
    Criticidade
Desenvolvedor
    Versão da aplicação
    Licença
Imagem
*/

namespace ControleAtivosTI.Models
{
    public class Portifolios
    {
        [Key]
        public int IdPortefolio { get; set; }

        [Display(Name ="Nome do sistema")]
        public string NomeSistema {get; set;}

        public enum Criticidade
        {
            Alta, Media, Baixa
        }
    }
}