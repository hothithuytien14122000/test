using SV18T1021314.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SV18T1021314.Web.Models
{
    public class SupplierPaginationResult :BasePaginationResult
    {
        /// <summary>
        /// lấy danh sách nhà cung cấp
        /// </summary>
        public List<Supplier> Data { get; set; }
    }
}