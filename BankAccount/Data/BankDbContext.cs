using BankAccount.Models;
using Microsoft.EntityFrameworkCore;

namespace BankAccount.Data
{
    public class BankDbContext : DbContext
    {
        public BankDbContext(DbContextOptions<BankDbContext> options) : base(options)
        {
        }

        public DbSet<BankAccountModel> BankAccounts { get; set; }

    }
}
