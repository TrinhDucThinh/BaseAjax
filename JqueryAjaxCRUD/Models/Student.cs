using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JqueryAjaxCRUD.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [MaxLength(256)]
        public string Password { get; set; }

        public bool? Status { get; set; }

        public DateTime? DateOfBirth { get; set; }

    }
}