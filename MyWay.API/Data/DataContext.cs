using Microsoft.EntityFrameworkCore;
using MyWay.API.Models;

namespace MyWay.API.Data

{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}
        public DbSet<User> Users { get; set; }
    }
}