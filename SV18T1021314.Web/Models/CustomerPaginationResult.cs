using SV18T1021314.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SV18T1021314.Web.Models
{
    /// <summary>
    /// kết quả tìm kiếm, phân trang cho khách hàng
    /// </summary>
    public class CustomerPaginationResult :BasePaginationResult
    {
        /// <summary>
        /// danh sách khách hàng
        /// </summary>
      public  List<Customer> Data { get; set; }
    }
}