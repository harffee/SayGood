using SayGood.Models;
using System.Data.Entity;

namespace SayGood.Concrete
{
    public class EFDbContext : DbContext
    {
       
        //两个表名 Accounts,Details
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Detail> Details { get; set; }
    }
}