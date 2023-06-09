﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_web.Models.Dtos
{
    public class VillaNumberUpdateDTO
    {
        [Required]
        public int VillaNo { get; set; }
        [Required]
        public string SpecialDetails { get; set; }
        [Required]
        public int VillaId { get; set; }
    }
}
