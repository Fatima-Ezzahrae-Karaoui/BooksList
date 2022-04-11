using BooksList.Models;

namespace BooksList.Infrastructure.Repositories
{
    public interface IBookRepository
    {
        public void Add(Book book);
        public IEnumerable<Book> GetBooks();
    }
}
