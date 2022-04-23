using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SV18T1021314.BusinessLayer;
using SV18T1021314.DomainModel;

namespace SV18T1021314.Web
{
    /// <summary>
    /// cung cấp một số tiện ích các hàm liên quan đến danh sách chọn trong Seclect
    /// </summary>
    public static class SelectListHelper
    {
        /// <summary>
        /// hiển thị danh sách quốc gia
        /// </summary>
        /// <returns></returns>
        public static List<SelectListItem> Countries()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem() { Value = "", Text = "--Chọn quốc gia--" });
            foreach (var c in CommonDataService.ListOfCountries())
            {
                list.Add(new SelectListItem()
                {
                    Value = c.CountryName,
                    Text = c.CountryName

                });
            }
            return list;
        }
    }
}