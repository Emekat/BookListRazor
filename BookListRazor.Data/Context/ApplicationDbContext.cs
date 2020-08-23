using System;
using System.Collections.Generic;
using System.Text;
using BookListRazor.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookListRazor.Data.Context
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Book> Book { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
