using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV18T1021314.DomainModel
{
    /// <summary>
    /// 
    /// </summary>
   public class Employee
    {
        /// <summary>
        /// 
        /// </summary>
        public int EmployeeID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Photo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String Notes { get; set; }
        /// <summary>
        /// MO
        /// </summary>
        public String Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String Password { get; set; }
    }
}
