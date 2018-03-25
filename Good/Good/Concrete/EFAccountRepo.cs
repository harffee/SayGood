using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Praise2017.Abstract;
using Praise2017.Models;

namespace Praise2017.Concrete
{
    public class EFAccountRepo:IAccountRepo
    {
        //context用于接收数据库的数据
        private EFDbContext context = new EFDbContext();
        public IQueryable<Detail> Details
        {
            get { return context.Details; }
        }
        public IQueryable<AccountInfo> Accounts
        {
            get { return context.Accounts; }
        }

        
    }
    
}