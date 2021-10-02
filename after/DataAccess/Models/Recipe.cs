using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "The title is too long, try a shorter one (500 characters limit)")]
        public string Title { get; set; }

        [Required]
        [StringLength(8000, ErrorMessage = "The description is too long, try a shorter one (8000 characters limit)")]
        public string Description { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }
    }
}
