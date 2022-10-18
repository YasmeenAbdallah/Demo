using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo.BL.Models
{
   public class DepartmentVM
    {
        /// <summary>
        /// the department id
        /// </summary>
        
        public int Id { get; set; }

        /// <summary>
        /// the department name
        /// </summary>
        [Required(ErrorMessage ="name required")]
        [StringLength(50,ErrorMessage ="the max length is 50")]
        [MinLength(2,ErrorMessage ="the min length 2")]
        public string Name { get; set; }

        /// <summary>
        /// the department code
        /// </summary>
        [Required(ErrorMessage ="code is required")]
        public string Code { get; set; }
    }
}
