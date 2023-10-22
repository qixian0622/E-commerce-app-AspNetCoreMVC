﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ecommerce.Models
{
    public class Category
    {
        [Key]
        public int  Id { get; set; }

        [Required]

        [DisplayName("Category Name")]
        public string Name { get; set; } = string.Empty;


        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="Display order must be between 1-100")]
        public int DisplayOrder { get; set; }

    }
}
