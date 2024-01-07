using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CoreFirstWebUI.Domain;

public partial class Animal
{
    [Key]
    public int Id { get; set; }

    [StringLength(1)]
    public string Sex { get; set; } = null!;

    [Column("DOB")]
    public DateTime? Dob { get; set; }

    public float Height { get; set; }

    public float Weight { get; set; }

    public string? EyeColor { get; set; }

    public string? HairColor { get; set; }

    public string Description { get; set; } = null!;

    public string Name { get; set; } = null!;
}
