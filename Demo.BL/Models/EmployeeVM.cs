using Demo.DAL.Entitiy;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo.BL.Models
{
    public class EmployeeVM
    {
        public EmployeeVM()
        {
            CreationDate = DateTime.Now;
        }
        /// <summary>
        /// the employee id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// the employee name
        /// </summary>
        [Required(ErrorMessage = "name required")]
        [StringLength(50, ErrorMessage = "the max length is 50")]
        [MinLength(2, ErrorMessage = "the min length 2")]
        public string Name { get; set; }

        /// <summary>
        /// the department code
        /// </summary>
        [Required(ErrorMessage = "Salary is required")]
        [Range(2000, 10000, ErrorMessage = "Range Btw 2000 : 10000")]
        public string Salary { get; set; }

        /// <summary>
        /// the hire date
        /// </summary>
        public DateTime HireDate { get; set; }
        /// <summary>
        /// the Creation date
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// is the account is active
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// notes
        /// </summary>
        public string Notes { get; set; }
        /// <summary>
        /// Address
        /// </summary>
        [RegularExpression("[0-9]{2,5}-[A-Za-z]{2,5}-[A-Za-z]{2,5}-[A-Za-z]{2,5}",ErrorMessage ="like : 12- st-Cairo-Epypt")]
        public string Address { get; set; }
        /// <summary>
        /// the email address
        /// </summary>
        [EmailAddress(ErrorMessage ="email not vaild")]
        public string Email { get; set; }
        /// <summary>
        /// the department that this employee works at
        /// </summary>
        [Required(ErrorMessage = "Choose Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
