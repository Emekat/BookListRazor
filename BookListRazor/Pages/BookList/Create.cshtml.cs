using BookListRazor.Data.Context;
using BookListRazor.Data.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BookListRazor.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private readonly ILogger<CreateModel> _logger;
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db, ILogger<CreateModel> logger)
        {
            _logger = logger;
            _db = db;
        }

        public Book Book { get; set; }
        public void OnGet()
        {
        }
    }
}
