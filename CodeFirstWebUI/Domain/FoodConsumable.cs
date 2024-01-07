using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CoreFirstWebUI.Domain;

public partial class FoodConsumable
{
    [Key]
    public int FoodId { get; set; }

    public int ConsumerTypeId { get; set; }

    public string ConsumableBy { get; set; } = null!;
}
