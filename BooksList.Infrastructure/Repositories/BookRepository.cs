using BooksList.Models;
using Couchbase.Lite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksList.Infrastructure.Repositories
{
    class BookRepository : IBookRepository
    {
        private readonly Database _database;
        public DatabaseManager databasemanager { get; set; }=new DatabaseManager(); 
        public BookRepository()
        {
            _database = databasemanager.GetDatabase();
        }
        public void Add(Book book)
        {
            try
            {
                if(book != null)
                {
                    string bookId = Guid.NewGuid().ToString();
                    book.CreatedAt = DateTime.Now;
                    MutableDocument mutabledocument = new MutableDocument(bookId);
                    mutabledocument.SetString("Id", bookId);
                    mutabledocument.SetString("Title", book.Title);
                    mutabledocument.SetString("ShortDescription", book.ShortDescription);
                    mutabledocument.SetString("LongDescription", book.LongDescription);
                    mutabledocument.SetString("CreatedAt", book.CreatedAt.ToString("g"));
                    mutabledocument.SetString("Type", "book");
                    _database.Save(mutabledocument);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine($"exception:{e.Message}");
            }
        }

        public IEnumerable<Book> GetBooks()
        {
            throw new NotImplementedException();
        }
    }
}
