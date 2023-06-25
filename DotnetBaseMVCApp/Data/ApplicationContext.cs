using Microsoft.EntityFrameworkCore;
using DotnetBaseMVCApp.Models;

namespace DotnetBaseMVCApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Account> Accounts { get; set; } = default!;
    }
}
