using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTrial_CodeFirst.Domain
{
    public class FoodConsumable
    {
        [Key]
        public int FoodId { get; set; }
        
        public int ConsumerTypeId { get; set; }
        public string ConsumableBy { get; set; }
    }
}
