﻿using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using System.Web;
using System;
using System.Collections.Generic;
using SayGood.Abstract;
using SayGood.Concrete;
using SayGood.Models;

namespace SayGood.Controllers
{
    public class HomeController : Controller
    {
        //获取当前登录用户
        string user = System.Environment.UserName;

        //加载StartPage页面
        public ViewResult StartPage()
        {
            return View();
        }
        private IAccountRepo reposity;

        public HomeController(IAccountRepo repo)
        {
            reposity = repo;
        }
        // GET: Admin
        //private EFDbContext db = new EFDbContext();
        //--对应Team页面
        
        public ActionResult Admin(Account account)
        {
           
            return PartialView(account);



        }
        //仅管理员可见
        public PartialViewResult UserList()
        {
            return PartialView(reposity.Accounts);
        }
        //弹窗显示用户列表，可以直接删除，新增用户
        [HttpPost]
        public ActionResult AddUser(string alias,string name,string role)
        {
            Account account = reposity.Accounts.FirstOrDefault(p => p.Alias == alias);
            if(account==null)
            reposity.SaveAccount(account);
            //else提示用户已存在
            return RedirectToAction("RemovdUser");
                //add完之后清空表单，刷新下方removeUser List
            

            
        }
        [HttpPost]
        public ActionResult RemoveUser(string alias)
        {
            Account deletedUser = reposity.DeleteUser(alias);
            return RedirectToAction("UserList");
        }
        private EFDbContext db = new EFDbContext();


        public PartialViewResult DetailList()
        {
            var query = from b in db.Details
                            //orderby b.UpdateDate
                        select b;

            return PartialView(query);
        }

        
        //显示本月排行
        public PartialViewResult TopPraise()
        {
            
            int month = DateTime.Now.Month;
            IEnumerable<string> member = from b in db.Accounts
                            select b.Name;
            string[] people = member.ToArray();
            //创建一个数组用来存储本月的用户名及Got数量
            string[][] rank = new string[people.Length][];
            for (int i=0;i< people.Length;i++)
            {
                rank[i][0] = people[i];
                rank[i][1] = (from b in db.Details
                              
                              where b.Name == people[i]
                              select b).Count().ToString();
            }
            //对rank数组进行由大到小冒泡排序
            for (int i=0;i<people.Length;i++)
                for(int j=i+1;j<people.Length;j++)
                {
                    if (int.Parse(rank[i][1]) < int.Parse(rank[j][1]))
                    {
                        var temp = rank[i][1];
                        rank[i][1] = rank[j][1];
                        rank[j][1] = temp;
                    }
                    else
                        continue;
                }
            
            return PartialView(ViewBag.rank);
        }

        ////显示当前用户信息
        public PartialViewResult PerInfo()
        {
            //得到赞总数
            //发出赞总数
            //当前用户角色 都要被显示
            var info = from b in db.Accounts
                       where b.Alias == user
                       select b;
            return PartialView(info);
        }

        //查询用户

        //Make Praise
        public PartialViewResult Praise()
        {
            var member = from b in db.Accounts
                                         select b;
           
            return PartialView(member);
        }

        

    }
}