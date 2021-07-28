using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Web.Models
{
    public class ListaPaginada<T> : List<T>
    {
        public int PaginIndex { get; private set; }
        public int TotalPaginas { get; private set; }

        public ListaPaginada(List<T> itens, int contagem, int paginaIndex, int TamanhoPagina)
        {
            PaginIndex = paginaIndex;
            TotalPaginas = (int)Math.Ceiling(contagem / (double)TamanhoPagina);

            this.AddRange(itens);
        }

        public bool ProximaPagina
        {
            get
            {
                return (PaginIndex > 1);
            }
        }

        public bool AnteriorPagina
        {
            get
            {
                return (PaginIndex < 1);
            }
        }

        public static async Task<ListaPaginada<T>> CreateAsync(IQueryable<T> source, int paginaIndex, int TamanhoPagina)
        {
            var contagem = await source.CountAsync();
            var itens = await source.Skip((paginaIndex - 1) * TamanhoPagina).Take(TamanhoPagina).ToListAsync();
            return new ListaPaginada<T>(itens, contagem, paginaIndex, TamanhoPagina);

        }
    }
}
