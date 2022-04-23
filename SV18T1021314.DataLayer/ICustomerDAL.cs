using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SV18T1021314.DomainModel;

namespace SV18T1021314.DataLayer
{
    /// <summary>
    /// định nghĩa các phép xử lý dữ liệu liên quan đến khách hàng
    /// </summary>
    public interface ICustomerDAL
    {
        /// <summary>
        /// tìm kiếm và lấy danh sách khách hàng dưới dạng phân trang
        /// </summary>
        /// <param name="page"> trang cần xem </param>
        /// <param name="pageSize"> số dòng hiển thị trên mỗi trang </param>
        /// <param name="searchValue"> tên địa chỉ cần tìm (tương đối). Nếu là chuỗi rỗng thì lấy toàn bộ dữ liệu </param>
        /// <returns></returns>
        IList<Customer> List(int page, int pageSize, string searchValue);

        /// <summary>
        /// đếm số lượng khách hàng thỏa điều kiện tìm kiếm
        /// </summary>
        /// <param name="SearchValue">
        /// tên hoặc địa chỉ cần tìm (tương đối)
        /// nếu là chuỗi eroongx thì lấy toàn bộ dữ liệu
        /// </param>
        /// <returns></returns>
        int Count(string SearchValue);

        /// <summary>
        /// Lấy thông tin của khahcs hàng thoe mã khách hàng
        /// </summary>
        /// <param name="CustomerID"></param>
        /// <returns></returns>
        Customer Get(int CustomerID);

        /// <summary>
        /// bổ sung một khách hàng. hàm trả về mã của khách hàng được bổ sung
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int Add(Customer data);

        /// <summary>
        /// cập nhật thông tin khahcs hàng
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        bool Update(Customer data);

        /// <summary>
        /// xóa thông tin khách hàng
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        bool Delete(int customerID);

        /// <summary>
        /// kiểm tra thông tin khách hàng
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        bool InUsed(int customerID);
    }
}
