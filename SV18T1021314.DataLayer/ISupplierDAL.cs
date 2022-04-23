using SV18T1021314.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV18T1021314.DataLayer
{
    public interface ISupplierDAL
    {
        /// <summary>
        /// tìm kiếm và lấy danh sách khách hàng dưới dạng phân trang
        /// </summary>
        /// <param name="page"> trang cần xem </param>
        /// <param name="pageSize"> số dòng hiển thị trên mỗi trang </param>
        /// <param name="searchValue"> tên địa chỉ cần tìm (tương đối). Nếu là chuỗi rỗng thì lấy toàn bộ dữ liệu </param>
        /// <returns></returns>
        IList<Supplier> List(int page, int pageSize, string searchValue);

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
        /// <param name="SupplierID"></param>
        /// <returns></returns>
        Supplier Get(int SupplierID);

        /// <summary>
        /// bổ sung một khách hàng. hàm trả về mã của khách hàng được bổ sung
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int Add(Supplier data);

        /// <summary>
        /// cập nhật thông tin khahcs hàng
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        bool Update(Supplier data);

        /// <summary>
        /// xóa thông tin khách hàng
        /// </summary>
        /// <param name="SupplierID"></param>
        /// <returns></returns>
        bool Delete(int SupplierID);

        /// <summary>
        /// kiểm tra thông tin khách hàng
        /// </summary>
        /// <param name="SupplierID"></param>
        /// <returns></returns>
        bool InUsed(int SupplierID);
    }
}
