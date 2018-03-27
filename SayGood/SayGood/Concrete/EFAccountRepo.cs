using SayGood.Abstract;
using System.Linq;
using SayGood.Models;

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