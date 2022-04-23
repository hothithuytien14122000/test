using SV18T1021314.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV18T1021314.DataLayer
{
    public interface IShipperDAL
    {
        IList<Shipper> List(int page, int pageSize, string searchValue);

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
        /// <param name="ShipperID"></param>
        /// <returns></returns>
        Shipper Get(int ShipperID);

        /// <summary>
        /// bổ sung một khách hàng. hàm trả về mã của khách hàng được bổ sung
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int Add(Shipper data);

        /// <summary>
        /// cập nhật thông tin khahcs hàng
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        bool Update(Shipper data);

        /// <summary>
        /// xóa thông tin khách hàng
        /// </summary>
        /// <param name="ShipperID"></param>
        /// <returns></returns>
        bool Delete(int ShipperID);

        /// <summary>
        /// kiểm tra thông tin khách hàng
        /// </summary>
        /// <param name="ShipperID"></param>
        /// <returns></returns>
        bool InUsed(int ShipperID);
    }
}
