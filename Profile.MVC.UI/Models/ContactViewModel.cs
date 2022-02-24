using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //brought in to support email
using Profile.MVC.UI;

namespace Profile.MVC.UI.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "* Your name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "* Your E-mail is required")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "* A subject heading is required")]
        public string Subject { get; set; }

        [UIHint("MultiLineText")]
        [Required(ErrorMessage = "* A message is required")]
        public string Message { get; set; }
    }
}