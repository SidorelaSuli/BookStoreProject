using System.Data.Entity;

namespace BookStore.Models
{
    public class BookStoreEntities : DbContext
    {
        public DbSet<Book> Book { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Authors { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}