using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CoreFirstWebUI.Domain;

public partial class Human
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    [StringLength(1)]
    public string Sex { get; set; } = null!;

    [Column("DOB")]
    public DateTime Dob { get; set; }

    public float Height { get; set; }

    public float Weight { get; set; }

    public string Complexion { get; set; } = null!;

    public string EyeColor { get; set; } = null!;

    public string HairColor { get; set; } = null!;
}
