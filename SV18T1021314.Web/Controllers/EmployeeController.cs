using SV18T1021314.BusinessLayer;
using SV18T1021314.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SV18T1021314.Web.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Authorize]
    [RoutePrefix("employee")]
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(int page = 1, string searchValue = "")
        {
            int pageSize = 10;
            int rowCount = 0;
            var data = CommonDataService.ListOfEmployee(page, pageSize, searchValue, out rowCount);
            Models.BasePaginationResult model = new Models.EmployeePaginationResult()
            {
                Page = page,
                PageSize = pageSize,
                RowCount = rowCount,
                SearchValue = searchValue,
                Data = data
            };
            return View(model);


        }
        public ActionResult Create()
        {

            ViewBag.Title = "Thêm mới nhân viên";
            Employee model = new Employee()
            {
                EmployeeID = 0
            };
            return View(model);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="employeeID"></param>
        /// <returns></returns>
        [Route("edit/{employeeID}")]
        public ActionResult Edit(int employeeID)
        {
            ViewBag.Title = "Sửa thông tin nhân viên";
            var model = CommonDataService.GetEmployee(employeeID);
            if (model == null)
                return RedirectToAction("Index");
            return View("Create", model);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Save([Bind(Include = "EmployeeID,LastName,FirstName,BirthDate,Notes,Email,Password")] Employee model, HttpPostedFileBase photo)
        {

            string filename = System.IO.Path.GetFileName(photo.FileName);
            string urlImage = Server.MapPath("~/images/" + filename);
            photo.SaveAs(urlImage);
            model.Photo = "images/" + filename;

            if (model.EmployeeID == 0)
            {
                CommonDataService.AddEmployee(model);
                return RedirectToAction("Index");
            }
            else
            {
                CommonDataService.UpdateEmployee(model);
                return RedirectToAction("Index");
            }
        }

        [Route("delete/{employeeID}")]
        public ActionResult Delete(int employeeID)
        {
            if (Request.HttpMethod == "POST")
            {
                CommonDataService.DeleteEmployee(employeeID);
                return RedirectToAction("Index");
            }

            var model = CommonDataService.GetEmployee(employeeID);
            if (model == null)
                return RedirectToAction("Index");
            return View(model);
        }
    }
}