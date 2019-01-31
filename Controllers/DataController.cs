using DutyPlan.Common.DB;
using DutyPlan.Common.Extend;
using DutyPlan.Common.Photo;
using DutyPlan.Entities;
using DutyPlan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace DutyPlan.Controllers
{

    public class DataController : Controller
    {
        [HttpPost]
        public ActionResult Service(string query)
        {
            System.Collections.ArrayList list = new System.Collections.ArrayList();
            try
            {
                if (query.Length > 4)
                {
                    var employees = OperationDb.GetallEmployee();
                    Config.log.Info("this is 27");
                    Regex pattern = new Regex(@query.ToUpper());
                    foreach (var employee in employees)
                    {
                        if (pattern.IsMatch(@employee.DisplayName.ToUpper()))
                        {
                            list.Add(employee.DisplayName);
                        }
                    }
                    return Json(list);
                }
            }
            catch (Exception e)
            {
                Config.log.Error(e);
            }
            return Json(list);
        }

        [HttpPost]
        public string PhotoChange(LocationSave obj)
        {
            var user = Request.Cookies["user"].Value;
            if (true/*OperationDb.GetALLAdmin().ToList().Exists(o => o.UserName.Equals(user))*/)
            {
                if (!string.IsNullOrEmpty(obj.DisName))
                {
                    Regex pattern = new Regex(@obj.DisName.ToUpper());
                    var employees = OperationDb.GetallEmployee();
                    foreach (var employee in employees)
                    {
                        if (pattern.IsMatch(@employee.DisplayName.ToUpper()) || employee.DisplayName.ToUpper().Equals(@obj.DisName.ToUpper()))
                        {
                            var uid = employee.UID;
                            //var location = @"/cms/photo/" + uid + ".jpg";// @"../Content/img/employee/" //@"/cms/photo/"+uid+".jpg"
                            var location = ReadPhoto.Getlocation(uid);
                            if (!string.IsNullOrEmpty(location))
                            {
                                //var states = OperationDb.GetAllTable().Where(p => p.Location == location).FirstOrDefault();
                                //if (states == null)
                                //{
                                var objLocation = new LocationSave
                                {
                                    Id = obj.Id,
                                    Location = location,
                                    DisName = employee.DisplayName
                                };
                                OperationDb.UpdataTableState(objLocation);

                                //var isoutoffice = OperationDb.GetAllTable().Where(p => p.ID == obj.Id).FirstOrDefault()
                                //    .Category == "OutOffice";
                                //if (isoutoffice)
                                //{
                                //    OperationDb.InsertLeaver(new LeaverSave
                                //    {
                                //        uid = employee.UID,
                                //        displayName = employee.DisplayName,
                                //        startTime = DateTime.Now
                                //    });
                                //}
                                return "Success";
                                //}
                                //var cato = states.Category;
                                //TempData["category"] = cato;
                                //return "Already";
                            }
                            else { return "Error2"; }
                        }
                    }
                }
                return "Error";
            }
            return "Error3";
        }
        [HttpPost]
        public string Delete(string id)
        {
            var user = Request.Cookies["user"].Value;
            if (OperationDb.GetALLAdmin().ToList().Exists(o => o.UserName.Equals(user)))
            {
                OperationDb.DeleteTableState(id);
                return "Success";
            }
            return "Error3";
            
        }
    }
}