using SayGood.Concrete;
using SayGood.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SayGood.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        private EFDbContext db = new EFDbContext();
        
        public PartialViewResult Admin()
        {

            //取出Name和头像
            var member = from b in db.Accounts

                         select b;

            // IEnumerable people = member.ToArray();
            // IEnumerable people = new IEnumerable(member);
            return PartialView(member);

        }

        //弹窗显示用户列表，可以直接删除，新增用户
        public PartialViewResult AddUser(Account account)
        {
            if(ModelState.IsValid)
            {

            }

           return PartialView();
        }
        
        public PartialViewResult RemoveUser()
        {

        }
        //public ActionResult UserControl()
        //{

        //    return View();
        //}
    }
}
