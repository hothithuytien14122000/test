using SV18T1021314.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SV18T1021314.Web.Models
{
    public class CategoryPaginationResult :BasePaginationResult
    {
        /// <summary>
        /// danh sách người giap hàng
        /// </summary>
        public List<Category> Data { get; set; }
    }
}