using Microsoft.AspNetCore.Mvc;
using BooksApi.Models;

namespace BooksApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private static List<Book> books = new List<Book>
        {
            new Book
            {
                Id = 1,
                Title = "Абай жолы",
                Author = "Мұхтар Әуезов",
                Year = 1942
            },
            new Book
            {
                Id = 2,
                Title = "Менің атым Қожа",
                Author = "Бердібек Соқпақбаев",
                Year = 1957
            }
        };

        [HttpGet]
        public ActionResult<List<Book>> GetBooks()
        {
            return Ok(books);
        }

        [HttpPost]
        public ActionResult<Book> AddBook(Book book)
        {
            book.Id = books.Count + 1;
            books.Add(book);

            return Ok(book);
        }
    }
}
