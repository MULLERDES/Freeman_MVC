using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WARSVP.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please entes your email adress")]
        [RegularExpression(".+\\@.+\\..+")]
        public string Email { get; set; }
        
        [Required(ErrorMessage ="Please enter your phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify whether you`ll attent")]
        public bool? WillAttend { get; set; }
    }
}