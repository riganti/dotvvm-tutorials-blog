using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotvvmBlog.DTO
{
    public class RegisterDTO
    {

        [Required]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Compare(nameof(Password))]
        public string Password2 { get; set; }

        public string BlogDescription { get; set; }

        public int BlogCategoryId { get; set; }

        public string ThemeName { get; set; } = "Dark";

        public bool AgreeWithConditions { get; set; }

    }
}
