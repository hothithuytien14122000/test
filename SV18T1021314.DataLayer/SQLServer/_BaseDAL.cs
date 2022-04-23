using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV18T1021314.DataLayer.SQLServer
{
    /// <summary>
    /// lớp cơ sở cho các lớp xử ly dữ liệu trên SQL Server
    /// </summary>
   public abstract class _BaseDAL
    {
        /// <summary>
        /// chuỗi tham số kết nối
        /// </summary>
        protected string _connectionString;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="connectionString"></param>
        public _BaseDAL(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// tạo và kết nối đến CSDL
        /// </summary>
        /// <returns></returns>
        public SqlConnection OpenConnection()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = _connectionString;
            cn.Open();
            return cn;
        }
    }
}
