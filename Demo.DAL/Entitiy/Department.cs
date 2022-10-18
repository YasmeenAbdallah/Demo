using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.DAL.Entitiy
{
    [Table("Department")]
    public class Department
    {
       /// <summary>
       /// the department id
       /// </summary>
        public int Id { get; set; }
       
        /// <summary>
        /// the department name
        /// </summary>
        [Required]
        [StringLength(50)]
       
        public string Name { get; set; }

        /// <summary>
        /// the department code
        /// </summary>
        [Required]
        public string Code { get; set; }
        /// <summary>
        /// the list of departments employees
        /// </summary>
        public ICollection<Employee> Employee { get; set; }
    }
}
