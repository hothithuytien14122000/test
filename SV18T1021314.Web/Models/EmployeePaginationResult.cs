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
    public class EmployeePaginationResult:BasePaginationResult
    {
        /// <summary>
        /// 
        /// </summary>
        public List<Employee> Data { get; set; }
    }
}