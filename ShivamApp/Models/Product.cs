﻿using System.ComponentModel.DataAnnotations;

namespace ShivamApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } 
        public int Price { get; set; }
        public DateTime createDate { get; set; }

        

    }
}
