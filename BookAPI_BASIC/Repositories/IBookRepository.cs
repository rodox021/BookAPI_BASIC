using BookAPI_BASIC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI_BASIC.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> Get();
        Task<Book> Get(int Id);
        Task<Book> Create(Book Book);
        Task Update(Book Book);
        Task Delete(int Id);

    }
}
