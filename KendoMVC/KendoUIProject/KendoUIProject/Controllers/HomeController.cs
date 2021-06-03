using KendoUIProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;


namespace KendoUIProject.Controllers
{
    public class HomeController : Controller
    {
        private TaskProjectEntities db = new TaskProjectEntities();

        public ActionResult ColumnSettings()
        {
            var columns = new[]
            {
                new GridColumnSettings
                {
                    Member = "isadi",
                    Title="İşin Adı"
                },
                new GridColumnSettings
                {
                    Member = "issahibi",
                    Title="İş Sahibi"
                },
                new GridColumnSettings
                {
                    Member = "talepno",
                    Title="Talep No"

                },
                new GridColumnSettings
                {
                    Member = "bildirimtarih",
                    Format = "{0:d}",
                    Title="Bildirim Tarihi"

                },
                new GridColumnSettings
                {
                    Member = "cozumtarih",
                    Format = "{0:d}",
                    Title="Çözüm Tarihi"

                },

                new GridCommandColumnSettings
                {
                    Commands =
                    {
                        new GridEditActionCommand(),
                        new GridDestroyActionCommand()
                    },
                    Width = "250px",
                    Title = ""
                }
            };
            ViewData["Columns"] = columns;

            return View();
        }
        public ActionResult Index()
        {
            ColumnSettings();
             sumofTask st = new sumofTask();
            st.acilislerCount = db.task.Where(m => m.durum == 3).Count();
            st.bekleyenCount = db.task.Where(m => m.durum == 4).Count();
            st.completedCount = db.task.Where(m => m.durum == 5).Count();
            return View(st);
        }

        public ActionResult getMenuList()
        {
            try
            {
                List<MenuModel> mi = db.menus
            .Select(m => new MenuModel
            {
                id = m.id,
                title = m.title,
                parentid = m.parentid,
                link = m.link,
            }).ToList();



            return View("Menu", mi);
            }
            catch (Exception ex)
            {
                var error = ex.Message.ToString();
                return Content("Error");
            }
        }
        public ActionResult gotoGrid(int id = 0)
        {
            ColumnSettings();
            List<MenuModel> mi = db.menus
           .Where(m => m.link == id.ToString())
           .Select(m => new KendoUIProject.Models.MenuModel
           {
               id = m.id,
               title = m.title,
               parentid = m.parentid,
               link = m.link

           }).ToList();

            return View(mi);
        }
    }


}