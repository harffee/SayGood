using SayGood.Abstract;
using System.Linq;
using SayGood.Models;
using System.Web.Mvc;

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

        public void SaveAccount(Account account)
        {
            if (account.Alias == null)
                context.Accounts.Add(account);
            else
            {
                //TempData["message"] = string.Format("Alias existed!");
            }
            context.SaveChanges();
        }

        public Account DeleteUser (string alias)
        {
            Account dbEntry = context.Accounts.Find(alias);
            if(dbEntry!=null)
            {
                context.Accounts.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
    
}