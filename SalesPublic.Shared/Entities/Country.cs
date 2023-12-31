﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPublic.Shared.Entities
{
    public class Country
    {
        public int Id { get; set; }
        [Display(Name="Pais")]
        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        [MaxLength(100,ErrorMessage ="El campo {} no debe ser mayor {1} caractéres")]
        public string Name { get; set; } = null!;
    }
}
