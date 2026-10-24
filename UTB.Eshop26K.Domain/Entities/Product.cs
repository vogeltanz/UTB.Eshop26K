using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UTB.Eshop26K.Domain.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(70)]
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
