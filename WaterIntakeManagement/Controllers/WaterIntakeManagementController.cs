using WaterIntakeManagement.DAL.Interface;
using WaterIntakeManagement.DAL.Repository;
using WaterIntakeManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WaterIntakeManagement.Controllers
{
    public class WaterIntakeManagementController : Controller
    {
        private readonly IWaterIntakeManagementInterface _Repository;
        public WaterIntakeManagementController(IWaterIntakeManagementInterface service)
        {
            _Repository = service;
        }
        public WaterIntakeManagementController()
        {
            // Constructor logic, if needed
        }
        // GET: WaterIntakeManagement
        public ActionResult Index()
        {
            var workouts = from work in _Repository.GetWaterIntakes()
                        select work;
            return View(workouts);
        }

        public ViewResult Details(int id)
        {
            WaterIntake workout =   _Repository.GetWaterIntakeByID(id);
            return View(workout);
        }

        public ActionResult Create()
        {
            return View(new WaterIntake());
        }

        [HttpPost]
        public ActionResult Create(WaterIntake workout)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _Repository.InsertWaterIntake(workout);
                    _Repository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(workout);
        }

        public ActionResult EditAsync(int id)
        {
            WaterIntake workout =  _Repository.GetWaterIntakeByID(id);
            return View(workout);
        }
        [HttpPost]
        public ActionResult Edit(WaterIntake workout)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _Repository.UpdateWaterIntake(workout);
                    _Repository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(workout);
        }

        public ActionResult Delete(int id, bool? saveChangesError)
        {
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Unable to save changes. Try again, and if the problem persists see your system administrator.";
            }
            WaterIntake workout =  _Repository.GetWaterIntakeByID(id);
            return View(workout);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                WaterIntake workout =  _Repository.GetWaterIntakeByID(id);
                _Repository.DeleteWaterIntake(id);
                _Repository.Save();
            }
            catch (DataException)
            {
                return RedirectToAction("Delete",
                   new System.Web.Routing.RouteValueDictionary {
        { "id", id },
        { "saveChangesError", true } });
            }
            return RedirectToAction("Index");
        }
    }
}