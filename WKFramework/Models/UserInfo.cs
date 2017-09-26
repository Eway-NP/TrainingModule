using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WKFramework.Models
{
    public class UserInfo
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}