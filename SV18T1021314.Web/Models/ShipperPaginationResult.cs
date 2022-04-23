using SV18T1021314.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SV18T1021314.Web.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ShipperPaginationResult :BasePaginationResult
    {
        /// <summary>
        /// danh sách người giap hàng
        /// </summary>
        public List<Shipper> Data { get; set; }
    }
}