﻿using System.ComponentModel.DataAnnotations;

namespace QuickMusic.Admin.Models
{
    public class Rol
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string Nombre { get; set; }
    }
}

