using Praise2017.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Praise2017.Controllers
{
    public class TestController : Controller

    {


        private SqlDB _db = new SqlDB();

        //

        // GET: /Test/

        public ActionResult Index()

        {

            bool r = _db.OpenConnection();

            if (r)

            {

                return Content("连接成功");

            }

            else

            {

                return Content("连接失败");

            }

        }

    }


}