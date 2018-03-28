using SayGood.Concrete;
using SayGood.Abstract;
using SayGood.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SayGood.Controllers
{
    public class AdminController : Controller
    {
        private IAccountRepo reposity;
        public AdminController(IAccountRepo repo)
        {
            reposity = repo;
        }
        // GET: Admin
        //private EFDbContext db = new EFDbContext();
        //--对应Team页面
        public PartialViewResult Admin()
        {
            return PartialView(reposity.Accounts);

        }
        //仅管理员可见
        public PartialViewResult UserList()
        {
            return PartialView(reposity.Accounts);
        }
        //弹窗显示用户列表，可以直接删除，新增用户
        [HttpPost]
        public ActionResult AddUser(Account account)
        {
            if (ModelState.IsValid)
            {
                reposity.SaveAccount(account);
                //add完之后清空表单，刷新下方removeUser List
            }

            return RedirectToAction("UserList");
        }
        [HttpPost]
        public ActionResult RemoveUser(string alias)
        {
            Account deletedUser =reposity.DeleteUser(alias);
            return RedirectToAction("UserList");
        }
        //public ActionResult UserControl()
        //{

        //    return View();
        //}
    }
}
