using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProASP_Chapter2.Models
{
    public class ResponseModel
    {
        [Required(ErrorMessage ="Name please")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Mail?")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Valid Mail Please")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Going?")]
        public bool? WillYou { get; set; }

    }
}