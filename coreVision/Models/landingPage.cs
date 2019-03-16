//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace coreVision.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class LandingPage
    {
        public long id { get; set; }

        [DisplayName("First Name")]
        [DataType(DataType.Text)]
        [Required( ErrorMessage = "This field is required")]
        public string first_name { get; set; }

        [DisplayName("Last Name")]
        [DataType(DataType.Text)]
        [Required( ErrorMessage = "This field is required")]
        public string last_name { get; set; }

        [DataType(DataType.PhoneNumber)]
        [DisplayName("Phone Number")]
        [Required( ErrorMessage = "This field is required")]
        public string phone { get; set; }

        [DataType(DataType.EmailAddress)]
        [DisplayName("Email address")]
        [Required( ErrorMessage = "This field is required")]
        public string email { get; set; }

        [DisplayName("Your message")]
        [DataType(DataType.MultilineText)]
        [Required( ErrorMessage = "This field is required")]
        public string message { get; set; }
    }
}