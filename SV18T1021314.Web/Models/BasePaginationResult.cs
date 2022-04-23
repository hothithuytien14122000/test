using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SV18T1021314.Web.Models
{
    /// <summary>
    /// lớp cơ sở của các lớp dùng để chứa dữ liệu truy vấn dưới dạng phân trang tìm kiếm
    /// </summary>
    public abstract class BasePaginationResult
    {
        /// <summary>
        /// trang hiện tại(trang đang xem)
        /// </summary>
        public int Page { get; set; }
        /// <summary>
        /// số dòng trên mỗi trang
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// tổng số dòng
        /// </summary>
        public int RowCount { get; set; }
        /// <summary>
        /// tổng số trang
        /// </summary>
        public int PageCount
        {
            get
            {
                int p = RowCount / PageSize;
                if (RowCount % PageSize > 0)
                    p += 1;
                return p;
            } 
        }
        /// <summary>
        /// giá trị tìm kiếm
        /// </summary>
        public string SearchValue { get; set; }

        
    }
}