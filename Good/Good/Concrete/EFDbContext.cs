using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Praise2017.Models;

namespace Praise2017.Concrete
{
    public class EFDbContext : DbContext
    {
       
        //两个表名 Accounts,Details
        public DbSet<AccountInfo> Accounts { get; set; }
        public DbSet<Detail> Details { get; set; }
    }
}