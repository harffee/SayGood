using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SayGood.Abstract;
using SayGood.Controllers;

namespace SayGood.Concrete
{
    public class EFAccountRepo:IAccountRepo
    {
        //context用于接收数据库的数据
        private EFDbContext context = new EFDbContext();
        public IQueryable<Detail> Details
        {
            get { return context.Details; }
        }
        public IQueryable<Account> Accounts
        {
            get { return context.Accounts; }
        }

        
    }
    
}