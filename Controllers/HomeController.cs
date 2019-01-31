using DutyPlan.Common.DB;
using DutyPlan.Common.Photo;
using DutyPlan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using DutyPlan.Common.Extend;
using DutyPlan.Common;

namespace DutyPlan.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Cache.SetCache();
            //Extention.GetLogonUserIdentity();
            //var now = DateTime.Now;
            //if (now.IsLastDayOfMonth())
            //{
            //    Report.GenarateReport(OperationDb.GetAllLeavers().ToList());
            //}
            //Extention.GetLogonUserIdentity();
            Response.Cookies.Add(new HttpCookie("user", Extention.GetLogonUserIdentity()));
            return View();
        }
        public ActionResult DmsTestLine()
        {
            return PartialView();
        }
        public ActionResult DmsTestLine2()
        {
            return PartialView();
        }
        public ActionResult Tco()
        {
            return PartialView();
        }
        public ActionResult SystemAssembly()
        {
            return PartialView();
        }
        public ActionResult DmsModel()
        {
            return PartialView();
        }
        public ActionResult OutOffice()
        {
            return PartialView();
        }
        public ActionResult SysTest()
        {
            return PartialView();
        }
        public ActionResult SysTest2()
        {
            return PartialView();
        }
        public ActionResult SlipringAsm()
        {
            return PartialView();
        }
        public ActionResult TeamLeader()
        {
            return PartialView();
        }
        public ActionResult F1()
        {
            return PartialView();
        }
        public ActionResult Customization()
        {
            return PartialView();
        }
        public ActionResult IPQC()
        {
            return PartialView();
        }
        public ActionResult Test()
        {
            return View();
        }
        
    }
}