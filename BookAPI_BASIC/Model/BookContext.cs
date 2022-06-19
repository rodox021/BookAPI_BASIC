using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace BookAPI_BASIC.Model
{
    public class BookContext : DbContext
    {
        public BookContext( DbContextOptions<BookContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        /*
         *Mapeamento da Tabela
            - para cada entidade criada (classe) será feito o mapeamento para gerar as tabelas
              no banco de dados.
         */
        public DbSet<Book> Books { get; set; }


    }
}
