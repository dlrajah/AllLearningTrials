using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTrial_CodeFirst.Domain
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public char Sex { get; set; }
        public DateTime? DOB { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public string? EyeColor { get; set; }
        public string? HairColor { get; set; }
    }
}
