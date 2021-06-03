using System;
﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using KendoUIProject.Models;

namespace KendoUIProject.Controllers
{
	public partial class GridController : Controller
	{
		private TaskProjectEntities db = new TaskProjectEntities();

		 
		public List<task> TaskRead(int drm = 0)
		{
			return db.task.Where(m => m.durum == drm)
				//.Select(m => new task
				//{
				//    id = m.id,
				//    talepno = m.talepno,
				//    isadi = m.isadi,
				//    issahibi = m.issahibi,
				//    durum = m.durum

				//})
				.ToList();
		}

		public ActionResult Read([DataSourceRequest] DataSourceRequest request, byte drm = 0)
		{
			return Json(TaskRead(drm).ToDataSourceResult(request));
		}

		[AcceptVerbs(HttpVerbs.Post)]
		public ActionResult Create([DataSourceRequest] DataSourceRequest request, task tsk,byte drm = 0)
		{
			if (tsk != null && ModelState.IsValid)
			{
				var entity = new task();
				entity.talepno = tsk.talepno;
				entity.isadi = tsk.isadi;
				entity.issahibi = tsk.issahibi;
				entity.bildirimtarih = tsk.bildirimtarih;
				entity.cozumtarih = tsk.cozumtarih;
				entity.durum = drm;
				db.task.Add(entity);
				db.SaveChanges();
				tsk.id = entity.id;

			}
			return Json(new[] { tsk }.ToDataSourceResult(request, ModelState));
		}
		[AcceptVerbs(HttpVerbs.Post)]
		public ActionResult Update([DataSourceRequest] DataSourceRequest request, task tsk, byte drm = 0)
		{
			if (tsk != null && ModelState.IsValid)
			{
				var entity = db.task.Find(tsk.id);

				entity.talepno = tsk.talepno;
				entity.isadi = tsk.isadi;
				entity.issahibi = tsk.issahibi;
				entity.bildirimtarih = tsk.bildirimtarih;
				entity.cozumtarih = tsk.cozumtarih;
				entity.durum = drm;
				db.task.Attach(entity);
				db.Entry(entity).State = EntityState.Modified;
				db.SaveChanges();
			}

			return Json(new[] { tsk }.ToDataSourceResult(request, ModelState));
		}


		[AcceptVerbs(HttpVerbs.Post)]
		public ActionResult Destroy([DataSourceRequest] DataSourceRequest request, task tsk)
		{
			if (tsk != null && ModelState.IsValid)
			{
				var entity = new task();
				entity.id = tsk.id;
				db.task.Attach(entity);
				db.task.Remove(entity);
				db.SaveChanges();
			}

			return Json(new[] { tsk }.ToDataSourceResult(request, ModelState));
		}
	}
}