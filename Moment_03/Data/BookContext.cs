using Moment_03.Models;
using Microsoft.EntityFrameworkCore;

namespace Moment_03.data
{
public class BookContext : DbContext
{
public BookContext(DbContextOptions<BookContext> options) : base(options){

}

public DbSet<Book> Books {get; set;}
public DbSet<Author> Authors {get; set;}

}
}