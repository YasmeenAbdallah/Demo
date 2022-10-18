using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.DAL.Entitiy
{
    [Table("Employee")]
    public class Employee
    {
        /// <summary>
        /// the employee id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// the employee name
        /// </summary>
        [Required]
        [StringLength(50)]

        public string Name { get; set; }

        /// <summary>
        /// the employee Salary
        /// </summary>
        [Required]
        public double Salary { get; set; }
        /// <summary>
        /// the hire date
        /// </summary>
        public DateTime HireDate { get; set; }
        /// <summary>
        /// is the account is active
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// notes
        /// </summary>
        public string Notes { get; set; }
        /// <summary>
        /// the email address
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// the department that this employee works at
        /// </summary>
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
