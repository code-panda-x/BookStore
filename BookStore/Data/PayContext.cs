using Microsoft.EntityFrameworkCore;
using BookStore.Models;

namespace BookStore.Data
{
    public class PayContext : DbContext
    {
        public PayContext(DbContextOptions<PayContext> options)
            : base(options)
        {
        }

        public DbSet<Pay> Pay { get; set; }
    }
}