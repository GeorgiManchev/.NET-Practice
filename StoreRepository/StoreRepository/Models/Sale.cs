﻿using System;
using System.ComponentModel.DataAnnotations;

namespace StoreRepository.Models
{
    public class Sale
    {
        [Key]
        public DateTime Date { get; set; }

        [Required]
        public string Offers { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }
    }
}
