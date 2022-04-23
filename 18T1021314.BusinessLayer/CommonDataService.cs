using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using SV18T1021314.DataLayer;
using SV18T1021314.DomainModel;

namespace SV18T1021314.BusinessLayer
{
    /// <summary>
    /// cung cấp các chức năng xử lý dữ liệu chung
    /// </summary>
    /// <summary>
    /// cung cấp các chức năng xử lý dữ liệu chung
    /// </summary>
    public static class CommonDataService
    {
        private static readonly ICategoryDAL categoryDB;
        private static readonly ICustomerDAL customerDB;
        private static readonly ISupplierDAL supplierDB;
        private static readonly IShipperDAL  shipperDB;
        private static readonly IEmployeeDAL employeeDB;
        private static readonly ICountryDAL CountryDB;
        /// <summary>
        /// ctor
        /// </summary>
        static CommonDataService()
        {
            string provider = ConfigurationManager.ConnectionStrings["DB"].ProviderName;
            string connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            if (provider == "SQLServer")
            {
                categoryDB = new DataLayer.SQLServer.CategoryDAL(connectionString);
                customerDB = new DataLayer.SQLServer.CustomerDAL(connectionString);
                supplierDB = new DataLayer.SQLServer.SupplierDAL(connectionString);
                shipperDB = new DataLayer.SQLServer.ShipperDAL(connectionString);
                employeeDB = new DataLayer.SQLServer.EmployeeDAL(connectionString);
                CountryDB = new DataLayer.SQLServer.CountryDAL(connectionString);
            }
            else
            {
                categoryDB = new DataLayer.FakeDB.CategoryDAL();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Category> ListOfCategory(int page, int pageSize, string searchValue, out int rowCount)
        {
            rowCount = categoryDB.Count(searchValue);
            return categoryDB.List(page, pageSize, searchValue).ToList();
        }

        /// <summary>
        /// tìm kiếm và lấy danh sách khách hàng dưới dạng phân trang
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="searchValue"></param>
        /// <param name="rowCount"></param>
        /// <returns></returns>
        public static List<Customer> ListOfCustomer(int page, int pageSize, string searchValue, out int rowCount)
        {
            rowCount = customerDB.Count(searchValue);
            return customerDB.List(page, pageSize, searchValue).ToList();
        }

        public static List<Supplier> ListOfSuppliers(int page, int pageSize, string searchValue, out int rowCount)
        {
            rowCount = supplierDB.Count(searchValue);
            return supplierDB.List(page, pageSize, searchValue).ToList();
        }
        public static List<Shipper> ListOfShipper(int page, int pageSize, string searchValue, out int rowCount)
        {
            rowCount = shipperDB.Count(searchValue);
            return shipperDB.List(page, pageSize, searchValue).ToList();
        }
        public static List<Employee> ListOfEmployee(int page, int pageSize, string searchValue, out int rowCount)
        {
            rowCount = employeeDB.Count(searchValue);
            return employeeDB.List(page, pageSize, searchValue).ToList();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Country> ListOfCountry()
        {
            return CountryDB.List().ToList();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public static Customer GetCustomer (int customerID)
        {
            return customerDB.Get(customerID);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int AddCustomer (Customer data)
        {
            return customerDB.Add(data);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool UpdataCustomer (Customer data)
        {
            return customerDB.Update(data);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public static bool DeleteCustomer(int customerID)
        {
            if (customerDB.InUsed(customerID))
                return false;

            return customerDB.Delete(customerID);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public static bool InUsedCustomer(int customerID)
        {
            return customerDB.InUsed(customerID);
        }


        /// <summary>
        /// /
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public static Employee GetEmployee(int employeeID)
        {
            return employeeDB.Get(employeeID);
        }
        /// <summary>
        /// Thêm mới 1 NV
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int AddEmployee(Employee data)
        {
            return employeeDB.Add(data);
        }
        /// <summary>
        /// Cập nhật 1 NV thông qua mã NV
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool UpdateEmployee(Employee data)
        {
            return employeeDB.Update(data);
        }
        /// <summary>
        /// Xóa 1 NV thông qua mã NV
        /// </summary>
        /// <param name="employeeID"></param>
        /// <returns></returns>
        public static bool DeleteEmployee(int employeeID)
        {
            if (employeeDB.InUsed(employeeID))
                return false;
            return employeeDB.Delete(employeeID);
        }
        /// <summary>
        /// Kiểm tra xem 1 NV hiện có dl liên quan hay ko?
        /// </summary>
        /// <param name="employeeID"></param>
        /// <returns></returns>
        public static bool InUsedEmployee(int employeeID)
        {
            return employeeDB.InUsed(employeeID);
        }

        public static Supplier GetSupplier(int SupplierID)
        {
            return supplierDB.Get(SupplierID);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int AddSupplier(Supplier data)
        {
            return supplierDB.Add(data);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool UpdataSupplier(Supplier data)
        {
            return supplierDB.Update(data);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public static bool DeleteSupplier(int SupplierID)
        {
            if (supplierDB.InUsed(SupplierID))
                return false;

            return supplierDB.Delete(SupplierID);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public static bool InUsedSupplier(int SupplierID)
        {
            return supplierDB.InUsed(SupplierID);
        }


        public static Shipper GetShipper(int ShipperID)
        {
            return shipperDB.Get(ShipperID);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int AddShipper(Shipper data)
        {
            return shipperDB.Add(data);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool UpdataShipper(Shipper data)
        {
            return shipperDB.Update(data);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public static bool DeleteShipper(int ShipperID)
        {
            if (shipperDB.InUsed(ShipperID))
                return false;

            return shipperDB.Delete(ShipperID);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public static bool InUsedShipper(int ShipperID)
        {
            return shipperDB.InUsed(ShipperID);
        }


          public static Category GetCategory(int CategoryID)
        {
            return categoryDB.Get(CategoryID);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int AddCategory(Category data)
        {
            return categoryDB.Add(data);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool UpdataCategory(Category data)
        {
            return categoryDB.Update(data);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public static bool DeleteCategory(int CategoryID)
        {
            if (categoryDB.InUsed(CategoryID))
                return false;

            return categoryDB.Delete(CategoryID);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public static bool InUsedCategory(int CategoryID)
        {
            return categoryDB.InUsed(CategoryID);
        }
    }
}

