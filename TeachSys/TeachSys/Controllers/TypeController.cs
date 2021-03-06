﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeachSys.Controllers
{
    public class TypeController : Controller
    {
        //
        // GET: /Type/
        Models.TeachDBEntities1 tdb = new Models.TeachDBEntities1();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EditIndex(int id)
        {
            Models.Type type = tdb.Type.First(t => t.ID == id);
            return View(type);
        }
        public ActionResult GetType()
        {
            var type = from t in tdb.Type
                       select new { t.Name, t.TypeId };
            return Json(type, JsonRequestBehavior.AllowGet);
        }
        public ActionResult AddType(Models.Type  t)
        {
            try
            {
                tdb.Type.Add(t);
                tdb.SaveChanges();
                return Content("ok");
            }
            catch
            {
                return Content("error");
            }
        }
        public ActionResult EditType(int id,string name,int typeid)
        {
            try
            {
                var type = tdb.Type.First(t => t.ID == id);
                type.Name=name;
                type.TypeId = typeid;
                tdb.SaveChanges();
                return Content("ok");
            }
            catch
            {
                return Content("error");
            }
        }
        public ActionResult DeleteType(int id)
        {
            try
            {
                var type = tdb.Type.First(t => t.ID == id);
                tdb.Type.Remove(type);
                tdb.SaveChanges();
                return Content("ok");
            }
            catch
            {
                return Content("error");
            }
        }

    }
}
