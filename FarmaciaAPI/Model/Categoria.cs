﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using FarmaciaAPI.Model;

namespace FarmaciaAPI.Model
{
    public class Categoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(255)]
        public string Tipo { get; set; } = string.Empty;

        [InverseProperty("Categoria")]
        public virtual ICollection<Produto>? Produto { get; set; }
    }
}