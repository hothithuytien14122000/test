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
    [RoutePrefix("supplier")]
    public class SupplierController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // GET: Supplier
        public ActionResult Index(int page = 1, string searchValue = "")
        {
            int pageSize = 10;
            int rowCount = 0;
            var data = CommonDataService.ListOfSuppliers(page, pageSize, searchValue, out rowCount);
            Models.BasePaginationResult model = new Models.SupplierPaginationResult()
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
            {
                ViewBag.Title = "Bổ sung nhà cung cấp";
                Supplier model = new Supplier()
                {
                    SupplierID = 0
                };
                return View(model);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="supplierID"></param>
        /// <returns></returns>
        [Route("edit/{supplierID}")]
        public ActionResult Edit(int supplierID)
        {

            {
                ViewBag.Title = "Cập nhật thông tin nahf cung cấp";
                Supplier model = CommonDataService.GetSupplier(supplierID);
                if (model == null)
                {
                    RedirectToAction("Index");
                }
                return View("Create", model);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Save(Supplier model)
        {
            if (string.IsNullOrWhiteSpace(model.SupplierName))
            {
                ModelState.AddModelError("SupplierName", "Tên không nhà cung cấp được để trống");
            }
            if (string.IsNullOrWhiteSpace(model.ContactName))
            {
                ModelState.AddModelError("ContactName", "Tên giao dịch không được để trống");
            }

            if (!ModelState.IsValid)
            {
                ViewBag.Title = "nahf cung cấp";
                return View("Create", model);
            }

            if (model.SupplierID == 0)
            {
                CommonDataService.AddSupplier(model);
                return RedirectToAction("Index");
            }
            else
            {
                CommonDataService.AddSupplier(model);
                return RedirectToAction("Index");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="supplierID"></param>
        /// <returns></returns>
        [Route("delete/{supplierID}")]
        public ActionResult Delete(int supplierID)
        {
            if (Request.HttpMethod == "POST")
            {
                CommonDataService.DeleteSupplier(supplierID);
                return RedirectToAction("Index");
            }
            var model = CommonDataService.GetSupplier(supplierID);
            if (model == null)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}